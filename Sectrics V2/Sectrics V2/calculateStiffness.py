import sys
from itertools import groupby
import numpy as np
from numpy.linalg import norm
from scipy.linalg import eigh

def setup():
	# define the coordinate system
	x_axis = np.array([1,0])
	y_axis = np.array([0,1])
	sectricsInput = sys.argv

	# define the model
	name, nodeX, nodeY, dofsX, dofsY, toMember, fromMember, restrainedDOFS, forceX, forceY, youngModulus, a, ndof = (list(g) for k,g in groupby(sectricsInput, key=lambda x: x != '/') if k)

	print(name)
	# define the model
	nodes               = list(zip(list(map(float, nodeX)), list(map(float, nodeY))))
	degrees_of_freedom  = list(map(list, zip(map(int, dofsX),map(int, dofsY))))
	elementsTo          = list(map(int, toMember))
	elementsFrom        = list(map(int, fromMember))
	restrained_dofs     = list(map(int, restrainedDOFS))
	forces = [None]*(len(forceX)+len(forceY))
	forces[::2] = forceX
	forces[1::2] = forceY
	forces = list(map(int, forces))

	# material properties - AISI 1095 Carbon Steel (Spring Steel)
	stiffnesses = list(map(float, youngModulus))
	# geometric properties
	areas = list(map(float, a))

	ndofs = int(ndof[0])

	return {  'x_axis':x_axis, 'y_axis':y_axis, 'nodes':nodes, 'degrees_of_freedom':degrees_of_freedom,   \
	      	  'elementsTo':elementsTo, 'elementsFrom':elementsFrom, 'restrained_dofs':restrained_dofs, 'forces':forces, 'ndofs':ndofs,     \
	      	  'stiffnesses':stiffnesses, 'areas':areas }


def points(element, properties):
	elementsTo = properties['elementsTo']
	elementsFrom = properties['elementsFrom']
	nodes = properties['nodes']
	degrees_of_freedom = properties['degrees_of_freedom']

	# find the nodes that the lements connects
	fromNode = elementsTo[element]
	toNode = elementsFrom[element]

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
	elementsTo = properties['elementsTo']
	elementsFrom = properties['elementsFrom']
	forces   = properties['forces']
	areas    = properties['areas']
	x_axis   = properties['x_axis']
	y_axis   = properties['y_axis']

	K = np.zeros((ndofs,ndofs))

	for element in range(0, len(elementsTo)):
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
	F = forces


	# remove the restrained dofs
	remove_indices = np.array(properties['restrained_dofs']) - 1
	for i in [0,1]:
		K = np.delete(K, remove_indices, axis=i)

	F = np.delete(F, remove_indices)

	return K, F

def get_stresses(properties, X):
	x_axis   = properties['x_axis']
	y_axis   = properties['y_axis']
	elementsTo = properties['elementsTo']
	E 		 = properties['stiffnesses']

	# find the stresses in each member
	stresses = []
	for element in range(0, len(elementsTo)):
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
