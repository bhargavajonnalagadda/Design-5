public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        
        if(paragraph==null || paragraph.Length==0) return String.Empty;
        ISet<string> bannedSet = banned.ToHashSet();
        
        Dictionary<string,int> dict = new Dictionary<string,int>();
        List<char> list = new List<char>();
        list.Add('.');
        list.Add('?');
        list.Add('!');
        list.Add(',');
        list.Add('"');
        list.Add(';');
        list.Add('\'');
        
        
        int n = paragraph.Length;
                 
        StringBuilder sb = new StringBuilder(n);
                 
                foreach(char c in paragraph)
                 {
                     if(!list.Contains(c))
                     {
                         sb.Append(c);
                     }
                     else
                     {
                         sb.Append(' ');
                     }
                 }
                 
                 paragraph = sb.ToString();
                 var words = paragraph.ToLower().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        foreach(string s in words)
        {
            if(banned.Contains(s))
            {
                continue;
            }
            else
            {   
                if(!dict.ContainsKey(s))
                {
                    dict.Add(s,0);
                }
                dict[s]+=1;
                
            }
        }
                 
        int minvalue = Int32.MinValue;
                 string result = string.Empty;
                 
                 foreach(KeyValuePair<string,int> kvp in dict)
                 {
                     if(kvp.Value > minvalue)
                     {
                         minvalue = kvp.Value;
                         result=kvp.Key;
                     }
                 }
        
        
        
        return result;
    }
}