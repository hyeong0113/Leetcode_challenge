public class Solution {
    /*
    * @title: Return the Pascal's triangle with a given number of row.
    * @precondition: Input must be an integer.
    * @postcondition: Pascal's triangle which is 2d list.
    * @description:
    *             Declare results to store the result.
    *             Run a nested for loop to initialize 2D array with 1 on the side of triangle.
    *             Run a nested for loop to fill elements inside the triangle.
    *             Run a nested for loop to convert 2D array to 2D list.
    * @param:
    *         numRows: int
    * @return:
    *         IList<IList<int>>
    * @time complexity:
    *         O(n^2): since using the nested for loop.
    * @space complexity:
    *         O(n^2): since creating 2d array and 2d list.
    */     
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> results = new List<IList<int>>();
        int[,] array = new int[numRows, numRows];
        for(int i = 0; i < numRows; i++)
        {
            for(int j = 0; j < i+1; j++)
            {
                if(i == j)
                {
                    array[i,j] = 1;
                    continue;
                }
                array[i,0] = 1;
            }
        }

        for(int i = 2; i < numRows; i++)
        {
            for(int j = 1; j < numRows; j++)
            {
                if(array[i,j] == 1)
                {
                    continue;
                }
                array[i,j] = array[i-1,j-1] + array[i-1,j];
            }
        }

        for(int i = 0; i < numRows; i++)
        {
            List<int> current = new List<int>();
            for(int j = 0; j < i+1; j++)
            {
                current.Add(array[i,j]);
            }
            results.Add(new List<int>(current));
        }

        return results;
    }
}