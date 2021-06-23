public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int n = nums.Length;
        int[] ans = new int[n];
        
        ans[0] =1;
        
        for(int i=1;i<n;i++)
        {
            ans[i] = nums[i-1] * ans[i-1];
            Console.WriteLine(ans[i]);
        }
        
        int r=1;
        
        for(int j=n-1;j>=0;j--)
        {
            ans[j] = ans[j] *r;
            r= r* nums[j];
            Console.WriteLine(ans[j]);
        }
        
        return ans;
        
    }
}