using System;

namespace Sectrics_V2
{
    class Maths
    {
        //Normal Maths Formulas

        public double distanceFormula(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
        }

        //Matrix Operations

        public double[] vectorMatrixDotProduct(double[,] mainMatrix, double[] mainVector)
        {
            double[] returnMatrix = new double[mainMatrix.GetLength(0)];
            if (mainVector.Length == mainMatrix.GetLength(0) || mainVector.Length == mainMatrix.GetLength(1))
            {
                //CALCULATE DOT PRODUCT

                for (int i = 0; i < mainMatrix.GetLength(0); i++)
                {
                    returnMatrix[i] = 0;
                    for (int j = 0; j < mainMatrix.GetLength(1); j++)
                    {
                        returnMatrix[i] += mainMatrix[i, j] * mainVector[j];
                    }
                }

                return returnMatrix;
            }
            else
            {
                Console.WriteLine("Error: Does not satisify dotproduct");
                return null;
            }
        }

        public double[] vectorVectorRemove(double[] mainVector, int[] row)
        {
            double[] returnVector = new double[(mainVector.GetLength(0) - row.Length)];
            int k = 0;
            int j = 0;

            for (int i = 0; i < mainVector.GetLength(0); i++)
            {
                if (i != row[j])
                {
                    returnVector[k] = mainVector[i];
                    k++;
                }
                else if (i == row[j])
                {
                    if (j == (row.Length - 1))
                    {
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }


            return returnVector;
        }

        public double[,] vectorMatrixRemove(double[,] mainMatrix, int[] rows, int[] columns)
        {
            int rowlen = mainMatrix.GetLength(0);
            int collen = mainMatrix.GetLength(1);
            int ni = 0, nj = 0;
            double[,] matrixReturn = new double[(mainMatrix.GetLength(0) - rows.Length), (mainMatrix.GetLength(1) - columns.Length)];
            int c = 0;
            int r = 0;

            for (int i = 0; i < rowlen; i++)
            {
                if (i != rows[c])
                {
                    for (int j = 0; j < collen; j++)
                    {
                        if (j != columns[r])
                            matrixReturn[ni, nj++] = mainMatrix[i, j];
                        if (j == columns[r])
                        {
                            if (j < columns.Length - 1)
                                r++;
                        }
                    }
                    ni++;
                    nj = 0;
                }
                if (i == rows[c])
                {
                    if (i < rows.Length - 1)
                        c++;
                }

                r = 0;
            }
            return matrixReturn;
        }

        public int[] vectorAdditionByOne(int value, int[] vector)
        {
            int[] returnVector = new int[vector.GetLength(0)];
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                returnVector[i] = vector[i] + value;
            }
            return returnVector;
        }

        public void vectorDisplay(double[] vector)
        {
            Console.Write("| ");
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                Console.Write(vector[i] + " |");
            }
        }

        public double[,] matrixAddition(double[,] MatrixOne, double[,] MatrixTwo)
        {
            double[,] returnMatrix = new double[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
            for (int i = 0; i < MatrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixOne.GetLength(1); j++)
                {
                    returnMatrix[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
                }
            }
            return returnMatrix;
        }

        public double dotProduct(double[] vec1, double[] vec2)
        {
            double returnValue = 0;
            for (int i = 0; i < vec1.GetLength(0); i++)
            {
                returnValue += vec1[i] * vec2[i];
            }
            return returnValue;
        }

        public double[,] zeroMatrix(int columns, int width)
        {
            double[,] returnMatrix = new double[columns, width];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    returnMatrix[i, j] = 0;
                }
            }
            return returnMatrix;
        }

        public double[,] oneValueMultiplyMatrix(double oneValue, double[,] mainMatrix)
        {
            double[,] returnMatrix = new double[mainMatrix.GetLength(0), mainMatrix.GetLength(1)];
            for (int i = 0; i < mainMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mainMatrix.GetLength(1); j++)
                {
                    returnMatrix[i, j] = mainMatrix[i, j] * oneValue;
                }
            }

            return returnMatrix;
        }

        public void matrixDisplay(double[,] mainMatrix)
        {
            Console.WriteLine("\n\n" + nameof(mainMatrix) + "\n\n");
            for (int rows = 0; rows < mainMatrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < mainMatrix.GetLength(1); columns++)
                {
                    Console.Write("| " + mainMatrix[rows, columns] + " | "); ;
                }
                Console.WriteLine();
            }
        }

        public double[,] inverseMatrix(double[,] mainMatrix)
        {
            int matrixLength = mainMatrix.GetLength(1);
            double determinant = determinantSolver(mainMatrix, matrixLength);
            double[,] inverseMatrix = new double[matrixLength, matrixLength];
            double inverseDeterminant;
            double[,] transposedAdjoint = transposeSolver(adjointSolver(mainMatrix));
            if (determinant == 0)
            {
                Console.WriteLine("This is no inverse matrix");
            }
            else
            {
                inverseDeterminant = 1 / determinant;
                inverseMatrix = oneValueMultiplyMatrix(inverseDeterminant, transposedAdjoint);
            }
            return inverseMatrix;
        }

        public double[,] matrixMultiplication(double[,] matrix1, double[,] matrix2)
        {
            double[,] returnMatrix = zeroMatrix(matrix1.GetLength(0), matrix2.GetLength(1));
            for (int i = 0; i < returnMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < returnMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        returnMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return returnMatrix;
        }

        public double[,] transposeSolver(double[,] mainMatrix)
        {
            double[,] transposeMatrix = new double[mainMatrix.GetLength(1), mainMatrix.GetLength(0)];
            for (int i = 0; i < mainMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mainMatrix.GetLength(1); j++)
                {
                    transposeMatrix[j, i] = mainMatrix[i, j];
                }
            }
            return transposeMatrix;
        }

        public double[,] adjointSolver(double[,] mainMatrix)
        {
            //Matrix of coefficents
            int lengthOfMatrix = mainMatrix.GetLength(0);
            double[,] miniMatrix = new double[lengthOfMatrix, lengthOfMatrix];
            double[,] returnMatrix = new double[lengthOfMatrix, lengthOfMatrix];

            for (int rows = 0; rows < lengthOfMatrix; rows++)
            {
                for (int columns = 0; columns < lengthOfMatrix; columns++)
                {
                    miniMatrix = rowColumnRemover(mainMatrix, rows, columns);
                    returnMatrix[rows, columns] = determinantSolver(miniMatrix, miniMatrix.GetLength(0)) * (Math.Pow((-1), (rows + 1 + columns + 1)));

                }
            }



            return returnMatrix;
        }

        public double[,] rowColumnRemover(double[,] mainMatrix, int row, int column)
        {
            double[,] matrixReturn = new double[(mainMatrix.GetLength(1) - 1), (mainMatrix.GetLength(1) - 1)];
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;

            for (int i = 0; i < mainMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < mainMatrix.GetLength(1); j++)
                {

                    if (i != row && j != column)
                    {
                        matrixReturn[m, n] = mainMatrix[i, j];
                        m++;
                        if (m == (mainMatrix.GetLength(0) - 1))
                        {
                            m = 0;
                            n++;
                        }
                    }
                    if (k < (mainMatrix.GetLength(1) - 1))
                    {
                        k++;
                    }
                    else
                    {
                        k = 0;
                        l++;
                    }

                }

            }

            //Insert Row removing vars & columns

            return matrixReturn;
        }

        public double determinantSolver(double[,] mainMatrix, int lengthOfMatricies)
        {
            //Determinate Solver Variables
            double determinate = 0;
            int objectOfMatriciesDeterminantToCalculate;
            int evenOrOddSwitch = 1;
            double[,] miniArray = new double[lengthOfMatricies, lengthOfMatricies];
            int rows;
            int columns;
            int miniMatrixRows;
            int miniMatrixColumns;

            //Exits Loop if matricies is 1*1
            if (lengthOfMatricies == 1)
            {
                return mainMatrix[0, 0];
            }
            else
            {
                determinate = 0;
                for (objectOfMatriciesDeterminantToCalculate = 0; objectOfMatriciesDeterminantToCalculate < lengthOfMatricies; objectOfMatriciesDeterminantToCalculate++)
                {
                    miniMatrixRows = 0;
                    miniMatrixColumns = 0;

                    //Row column remover
                    //Replace with function
                    for (rows = 0; rows < lengthOfMatricies; rows++)
                    {
                        for (columns = 0; columns < lengthOfMatricies; columns++)
                        {
                            miniArray[rows, columns] = 0;
                            if (rows != 0 && columns != objectOfMatriciesDeterminantToCalculate)
                            {

                                miniArray[miniMatrixRows, miniMatrixColumns] = mainMatrix[rows, columns];
                                if (miniMatrixColumns < (lengthOfMatricies - 2))
                                {
                                    miniMatrixColumns++;
                                }
                                else
                                {
                                    miniMatrixColumns = 0;
                                    miniMatrixRows++;
                                }
                            }
                        }
                    }

                    //Endfunction

                    //Sums of determinate of each matricies and then inverts even or odd switch to equate
                    determinate = determinate + evenOrOddSwitch * (mainMatrix[0, objectOfMatriciesDeterminantToCalculate] * determinantSolver(miniArray, lengthOfMatricies - 1));
                    evenOrOddSwitch = evenOrOddSwitch * -1;
                }
            }
            return determinate;
        }
    }
}
