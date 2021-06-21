public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int>  dict= new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            var temp = target - nums[i];
            if(dict.ContainsKey(temp))
            {
                return new int[] {dict[temp],i};
            }
            dict.Add(nums[i],i);
        }
        
        throw new Exception("no solution");
        
       
        
    }
}