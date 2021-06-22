public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        IList<IList<string>> list = new List<IList<string>>();
        
        if(strs==null || strs.Length==0) return list;
         Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();
        
        foreach(string s in strs)
        {
           
            
            char[] chararray = s.ToCharArray();
            Array.Sort(chararray);
            //int score = ComputeAsciivalue(s);
            string sorted = new string(chararray);
            
            if(!dict.ContainsKey(sorted))
            {
                dict.Add(sorted,new List<string>(){s});
              
            }
            else
            {
                  dict[sorted].Add(s);
            }
        }
        
        foreach(var pair in dict.Values)
        {
            list.Add(pair);
        }
        
        return list;
        
    }
    
    public int ComputeAsciivalue(string s)
    {
        int number=0;
        for(int i=0;i<s.Length;i++)
        {
            number += (int)s[i];
        }
        
        return number;
    }
}