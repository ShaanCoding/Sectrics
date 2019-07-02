import sys
import numpy as np
from numpy.linalg import norm
from scipy.linalg import eigh

def setup():
	print('Number of arguments:', len(sys.argv), 'arguments.')
	print('Argument List:', str(sys.argv))
	# define the coordinate system
	x_axis = np.array([1,0])
	y_axis = np.array([0,1])

	# define the model
	nodes              = { 1:[0,0], 2:[40,0], 3:[40,30], 4:[0,30]}
	degrees_of_freedom = { 1:[1,2], 2:[3,4], 3:[5,6], 4:[7,8]}
	elements 		   = { 1:[1,2], 2:[2,3], 3:[1,3], 4:[3,4]}
	restrained_dofs    = [1,2,3,7,8]
	forces             = { 1:[0,0], 2:[20000,0], 3:[0,-25000], 4:[0,0]}

	# material properties - AISI 1095 Carbon Steel (Spring Steel)
	densities   = {1:0.284, 2:0.284, 3:0.284, 4:0.284}
	stiffnesses = {1:30.0e6, 2:30.0e6, 3:30.0e6, 4:30.0e6}
	# geometric properties
	areas = {1:0.284, 2:0.284, 3:0.284, 4:0.284}

	ndofs = 2 * len(nodes)

	# assertions
	assert len(densities) == len(elements) == len(stiffnesses) == len(areas)
	assert len(restrained_dofs) < ndofs
	assert len(forces) == len(nodes)

	return {  'x_axis':x_axis, 'y_axis':y_axis, 'nodes':nodes, 'degrees_of_freedom':degrees_of_freedom,   \
	      	  'elements':elements, 'restrained_dofs':restrained_dofs, 'forces':forces, 'ndofs':ndofs,     \
	      	  'densities':densities, 'stiffnesses':stiffnesses, 'areas':areas }


def points(element, properties):
	elements = properties['elements']
	nodes = properties['nodes']
	degrees_of_freedom = properties['degrees_of_freedom']

	# find the nodes that the lements connects
	fromNode = elements[element][0]
	toNode = elements[element][1]

	# the coordinates for each node
	fromPoint = np.array(nodes[fromNode])
	toPoint = np.array(nodes[toNode])

	# find the degrees of freedom for each node
	dofs = degrees_of_freedom[fromNode]
	dofs.extend(degrees_of_freedom[toNode])
	dofs = np.array(dofs)

	return fromPoint, toPoint, dofs

def direction_cosine(vec1, vec2):
	return np.dot(vec1,vec2) / (norm(vec1) * norm(vec2))

def rotation_matrix(element_vector, x_axis, y_axis):
	# find the direction cosines
	x_proj = direction_cosine(element_vector, x_axis)
	y_proj = direction_cosine(element_vector, y_axis)
	return np.array([[x_proj,y_proj,0,0],[0,0,x_proj,y_proj]])

def get_matrices(properties):
	# construct the global mass and stiffness matrices
	ndofs    = properties['ndofs']
	nodes    = properties['nodes']
	elements = properties['elements']
	forces   = properties['forces']
	areas    = properties['areas']
	x_axis   = properties['x_axis']
	y_axis   = properties['y_axis']

	K = np.zeros((ndofs,ndofs))

	for element in elements:
		# find the element geometry
		fromPoint, toPoint, dofs = points(element, properties)

		element_vector = toPoint - fromPoint

		# find element mass and stiffness matrices
		length = norm(element_vector)
		area   = properties['areas'][element]
		E      = properties['stiffnesses'][element]

		Ck = E * area / length

		k = np.array([[1,-1],[-1,1]])

		# find rotated mass and stiffness element matrices
		tau = rotation_matrix(element_vector, x_axis, y_axis)
		k_r = tau.T.dot(k).dot(tau)

		# change from element to global coordinates
		index = dofs-1
		B = np.zeros((4,ndofs))
		for i in range(4):
			B[i,index[i]] = 1.0
		K_rG = B.T.dot(k_r).dot(B)

		K += Ck * K_rG

	# construct the force vector
	F = []
	for f in forces.values():
		F.extend(f)
	F = np.array(F)


	# remove the restrained dofs
	remove_indices = np.array(properties['restrained_dofs']) - 1
	for i in [0,1]:
		K = np.delete(K, remove_indices, axis=i)

	F = np.delete(F, remove_indices)

	return K, F

def get_stresses(properties, X):
	x_axis   = properties['x_axis']
	y_axis   = properties['y_axis']
	elements = properties['elements']
	E 		 = properties['stiffnesses']

	# find the stresses in each member
	stresses = []
	for element in elements:
		# find the element geometry
		fromPoint, toPoint, dofs = points(element, properties)
		element_vector = toPoint - fromPoint

		# find rotation matrix
		tau = rotation_matrix(element_vector, x_axis, y_axis)
		global_displacements = np.array([0,0,X[0],X[1]])
		q = tau.dot(global_displacements)

		# calculate the strains and stresses
		strain = (q[1] - q[0]) / norm(element_vector)
		stress = E[element] * strain
		stresses.append(stress)

	return stresses

def show_results(X, stresses):
	print('Nodal Displacments:', X)
	print('Stresses:', stresses)
	print( 'Displacment Magnitude:', round(norm(X),5))
	print()


def main():
	# problem setup
	properties = setup()
	# determine the global matrices
	K, F = get_matrices(properties)
	# calculate the static displacement of each element
	X = np.linalg.inv(K).dot(F)
	# determine the stresses in each element
	stresses = get_stresses(properties, X)
	# output results
	show_results(X, stresses)



if __name__ == '__main__':
	main()
