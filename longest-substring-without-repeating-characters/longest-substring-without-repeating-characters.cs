public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0) return 0;
       
    int ans =0;
        int slow =0;
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int fast =0;fast<s.Length;fast++)
        {
            if(dict.ContainsKey(s[fast]))
            {
                slow = Math.Max(slow,dict[s[fast]]);
            }
            ans = Math.Max(ans,fast-slow+1);
            dict[s[fast]]= fast+1;
        }
        return ans;
       
        
    }
}