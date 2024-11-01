using System;

class SudokuChecker
{
    static void Main()
    {
        // Example of a completed (solved) Sudoku grid
        int[,] sudokuGrid = {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };

        if (IsValidSudoku(sudokuGrid))
        {
            Console.WriteLine("Sudoku solution is correct!");
        }
        else
        {
            Console.WriteLine("Sudoku solution is incorrect.");
        }
    }

    // Function to check if the Sudoku grid is valid
    static bool IsValidSudoku(int[,] grid)
    {
        // Check rows
        for (int i = 0; i < 9; i++)
        {
            if (!IsUniqueSet(GetRow(grid, i)))
                return false;
        }

        // Check columns
        for (int j = 0; j < 9; j++)
        {
            if (!IsUniqueSet(GetColumn(grid, j)))
                return false;
        }

        // Check 3x3 sub-grids
        for (int row = 0; row < 9; row += 3)
        {
            for (int col = 0; col < 9; col += 3)
            {
                if (!IsUniqueSet(GetSubGrid(grid, row, col)))
                    return false;
            }
        }

        return true;
    }

    // Function to get a row as an array
    static int[] GetRow(int[,] grid, int row)
    {
        int[] result = new int[9];
        for (int i = 0; i < 9; i++)
        {
            result[i] = grid[row, i];
        }
        return result;
    }

    // Function to get a column as an array
    static int[] GetColumn(int[,] grid, int col)
    {
        int[] result = new int[9];
        for (int i = 0; i < 9; i++)
        {
            result[i] = grid[i, col];
        }
        return result;
    }

    // Function to get a 3x3 sub-grid as an array
    static int[] GetSubGrid(int[,] grid, int startRow, int startCol)
    {
        int[] result = new int[9];
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[index++] = grid[startRow + i, startCol + j];
            }
        }
        return result;
    }

    // Function to check if an array contains unique numbers from 1-9
    static bool IsUniqueSet(int[] numbers)
    {
        bool[] seen = new bool[9]; // Track numbers 1-9 (index 0-8)

        foreach (int number in numbers)
        {
            if (number < 1 || number > 9)
                return false; // Numbers must be between 1 and 9

            if (seen[number - 1])
                return false; // Duplicate number found

            seen[number - 1] = true;
        }

        return true;
    }
}