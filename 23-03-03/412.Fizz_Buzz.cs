public class Solution {
    /*
    * @title: Return list of string which contains "FizzBuzz", "Fizz", "Buzz" and integers.
    * @precondition: Input must be an integer.
    * @postcondition: String array.
    * @description:
    *             Declare results(string array) to store strings.
    *             Run for loop with index from 1 to n(integer input) + 1
    * @param:
    *         n: int
    * @return:
    *         List<string>
    * @time complexity:
    *         O(n): since running a for loop with size of n.
    * @space complexity:
    *         O(n): since size of input is 1 and size of declared results is n.
    */  
    public IList<string> FizzBuzz(int n) {
        IList<string> results = new List<string>();
        for(int i = 1; i < n+1; i++)
        {
            if((i % 3 == 0) && (i % 5 == 0))
            {
                results.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                results.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                results.Add("Buzz");
            }
            else
            {
                results.Add(i.ToString());
            }
        }
        return results;
    }
}