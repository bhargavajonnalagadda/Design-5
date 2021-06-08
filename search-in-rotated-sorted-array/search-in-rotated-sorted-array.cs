public class Solution {
    public int Search(int[] nums, int target) {
        if(nums==null) return -1;
        
        int low=0;
        int high =nums.Length-1;
        int mid;
        
        while(low<=high)
        {
            mid = low+(high-low)/2;
            if(nums[mid]==target)
            {
                return mid;
            }
            else if (nums[mid] >= nums[low])
            {
               if(target >= nums[low] && target < nums[mid])
               {
                    high = mid-1;
               }
            
                else
                {
                    low = mid+1;
                }
            }
            else
            {
                if(target >nums[mid] && target <= nums[high])
                {
                    low = mid+1;
                }
                else
                {
                    high = mid-1;
                }
            }
        }
        
        return -1;
        
    }
}