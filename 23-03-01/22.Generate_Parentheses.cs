public class Solution {
    /*
    * @title: Return all possible parenthesis sets from a given integer
    * @precondition: Input must be an integer.
    * @postcondition: List of all possible parenthesis sets.
    * @description:
    *             Declare results to store all possible parenthesis sets.
    *               Call a recursive function with current(StringBuilder to store current set) to store a current parenthesis set.
    *               Check size of current set and n(number of pairs)*2. If they are same, add current set to results.
    *                 If not,
    *                   Compare left(number of left parenthesis) and n.
    *                   If left < n,
    *                     Add left parenthesis to current.
    *                     Call the method itself.
    *                     Remove the last element from the current.
    *                   Compare right(number of right parenthesis) and left.
    *                   If right < left,
    *                     Add right parenthesis to current.
    *                     Call the method itself.
    *                     Remove the last element from the current.    
    *             Return all sets.
    * @param:
    *         n: int
    * @return:
    *         IList<string>
    * @time complexity:
    *         O(2^n): 2^n(backtracking 2^n sets by recursive)
    * @space complexity:
    *         O(n): 1(input) + n(maintaining creating current).
    */    
    IList<string> results = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        GenerateParenthesis(new StringBuilder(), 0, 0, n);
        return results;
    }

    public void GenerateParenthesis(StringBuilder current, int left, int right,  int n) {
        if(current.Length == n*2)
        {
            results.Add(current.ToString());
            return;
        }

        if(left < n)
        {
            current.Append("(");
            GenerateParenthesis(current, left+1, right, n);
            current.Remove(current.Length-1, 1);
        }

        if(right < left)
        {
            current.Append(")");
            GenerateParenthesis(current, left, right+1, n);
            current.Remove(current.Length-1, 1);
        }        
    }
}