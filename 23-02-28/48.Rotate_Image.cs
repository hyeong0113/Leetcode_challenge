public class Solution {
    /*
    * @title: Return a rotated 2D integer array by 90 degrees.
    * @precondition: Input must be a 2D integer array.
    * @postcondition: Rotated 2D integer array mut be returned.
    * @description:
    *             Run for loop from the first element to the last element of the row.
    *               Run for loop from the first element to the index from the first for loop.
    *                 Transpose the matrix.
    *             Run for loop from the first element to the last element of the row.
    *               Run for loop from the first element to the middle element of the row.
    *                 Reverse the matrix.
    * @param:
    *         matrix: int[][]
    * @return:
    *         void
    * @time complexity:
    *         O(n^2): since iterating n times from the first for loop and n*n/2 times from the second for loop.
    * @space complexity:
    *         O(n^2): since the given input is the 2D integer array.
    */ 
    public void Rotate(int[][] matrix) {
        // Transpose
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < i; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }      

        // Reverse
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix.Length/2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix.Length - j - 1];
                matrix[i][matrix.Length - j - 1] = temp;
            }
        }
    }
}