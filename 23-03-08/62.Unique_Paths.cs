public class Solution {
    /*
    * @title: Return a total number of paths
    * @precondition: Type of two inputs must be integer
    * @postcondition: Return a single integer which represents a total number of paths
    * @description:
    *             Initialize board with given length, m and n.
    *             During two first for loops, insert 1 to board[0,...,m-1][0] and board[0][0,...,n-1].
    *             During a nested for loop, update element by adding board[i-1][j] and board[i][j-1] from 1 to end of the board.
    *             Return board[m-1][n-1].
    * @param:
    *         m: int
    *         n: int
    * @return:
    *         int
    * @time complexity:
    *         O(mn): since traversing all elements in the board.
    * @space complexity:
    *         O(mn): since creating the board with m and n.
    */  
    public int UniquePaths(int m, int n) {
        int[,] board = new int[m,n];
        for(int i = 0; i < m; i++)
        {
            board[i,0] = 1;
        }
        for(int j = 0; j < n; j++)
        {
            board[0,j] = 1;
        }

        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                board[i,j] = board[i-1,j] + board[i,j-1];
            }
        }

        return board[m-1,n-1];
    }
}