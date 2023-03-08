public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> collection = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!collection.ContainsKey(nums[i]))
            {
                collection.Add(nums[i], 1);
            }
            else
            {
                collection[nums[i]] = collection[nums[i]] + 1;
            }
        }

        int result = 0;
        int currentCount = 0;
        foreach(var elem in collection)
        {
            if(currentCount < elem.Value)
            {
                currentCount = elem.Value;
                result = elem.Key;
            }
        }
        return result;
    }
}

//Alternative:
class Solution {
    public int majorityElement(int[] nums) {
        int count = 0;
        Integer candidate = null;

        foreach(int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}