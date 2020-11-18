using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    class Recursion
    {
        //https://www.w3resource.com/csharp-exercises/recursion/index.php


        #region //Print the first n natural numbers
        public int PrintNNatural(int startValue, int n)
        {
            if (n < 1)
            {
                Console.WriteLine("\r\n");
                return startValue;
            }

            Console.Write(startValue + " ");
            n--;
            return PrintNNatural(startValue + 1, n);
        }
        #endregion

        #region //Print numbers from n to 1
        public int PrintNNaturalBackwards(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("\r\n");
                return n;
            }

            Console.Write(n + " ");
            return PrintNNaturalBackwards(n - 1);
        }
        #endregion

        #region Sides on an Island (2x2 int[] map/grid)
        //You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.
        //Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
        //The island doesn't have "lakes" (water inside that isn't connected to the water around the island). One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. 
        //Determine the perimeter of the island.
        public int SidesOnIsland(int[,] grid)
        {
            int rows = grid.GetLength(0); //Length of dimension 1
            int cols = grid.GetLength(1); //Length of dimension 2

            int result = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r, c] == 1)
                    {
                        result += 4;

                        if (r > 0 && grid[r - 1, c] == 1)
                        {
                            result -= 2;
                        }

                        if (c > 0 && grid[r, c - 1] == 1)
                        {
                            result -= 2;
                        }
                    }
                }
            }

            return result;
        }
        #endregion

        #region Number of paths from 1st coord in grid to last coord
        public int numberOfPaths(int m, int n)
        {
            //numberOfPaths(3, 3)
            //https://www.geeksforgeeks.org/count-possible-paths-top-left-bottom-right-nxm-matrix/
            //Input: m = 2, n = 3; //2 Rows, 3 Cols
            //Output: 3
            //There are three paths
            //(0, 0) -> (0, 1)-> (0, 2)-> (1, 2)
            //(0, 0)-> (0, 1)-> (1, 1)-> (1, 2)
            //(0, 0)-> (1, 0)-> (1, 1)-> (1, 2)

            // If either given row number is first or given column number is first 
            if (m == 1 || n == 1)
            {
                return 1;
            }

            // If diagonal movements are allowed then the last addition is required. 
            return numberOfPaths(m - 1, n) + numberOfPaths(m, n - 1);
            // + numberOfPaths(m-1, n-1); 
        }
        #endregion

        #region Fibonacci

        #endregion

        #region Factorial

        #endregion


        #region asdf

        #endregion

        #region asdf

        #endregion

        #region asdf

        #endregion


    }
}
