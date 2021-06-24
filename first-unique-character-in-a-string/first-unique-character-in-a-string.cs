public class Solution {
    public int FirstUniqChar(string s) {
        
        if(s==null || s.Length==0) return -1;
        
        
        Dictionary<char,int> dict = new Dictionary<char,int>();
        
        for(int i=0;i<s.Length;i++)
        {
            if(!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i],1);
                
               // Console.WriteLine(count[i]);
            }
            else
            {
                dict[s[i]]+=1;
                
            }
            
           //Console.WriteLine(count[i]);
        }
        for(int j=0;j<s.Length;j++)
        {
            if(dict[s[j]]==1)
            {
                return j;
            }
        }
        
      
        
        return -1;
    }
}