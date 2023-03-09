public class Solution {
    /*
    * @title: Return number of 1 bit in unisigned integer n.
    * @precondition: Input must be an unsigned integer.
    * @postcondition: Return number of 1 bits in the unsigned integer.
    * @description:
    *             Check n(unsigned integer) is 0 or not. If 0, return 0.
    *             Declare count to store number of 1 bits.
    *             Run while loop until n is not equal to 1.
    *               Calculate remainder of n divided by 2.
    *               If the remainder is 1, increase the count by 1.
    *               Update n with dividing by 2.
    *             Increase the count by 1 since last n is always 1.
    *             Return the count.
    * @param:
    *         n: uint
    * @return:
    *         int
    * @time complexity:
    *         O(n): since running a while loop with n.
    * @space complexity:
    *         O(1): since there are only constant variable.
    */    
    public int HammingWeight(uint n) {
        if(n == 0)
        {
            return 0;
        }
        int count = 0;
        while(n != 1)
        {
            uint remainder = n % 2;
            if(remainder == 1)
            {
                count++;
            }
            n = n / 2;
        }
        count++;
        return count;
    }
}