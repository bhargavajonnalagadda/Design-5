public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0) return 0;
        int startindex=0;
        int endindex=1;
        int length=s.Length;
        int ans=0;
       Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i=0,j=0;j<length;j++)
        {
            if(dict.ContainsKey(s[j]))
            {
                i = Math.Max(dict[s[j]],i);
            }
            ans = Math.Max(ans,j-i+1);
            dict[s[j]] = j+1;
        }
        
        return ans;
       
        
    }
}