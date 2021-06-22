public class Solution {
    public static Dictionary<string,int> dict = new Dictionary<string,int>()
    {
        {"I",1},
        {"V",5},
        {"X",10},
        {"L",50},
        {"C",100},
        {"D",500},
        {"M",1000},
        {"IV",4},
        {"IX",9},
    {"XL",40},
    {"XC",90},
    {"CD",400},
    {"CM",900}
    };
    public int RomanToInt(string s) {
        int n = s.Length;
        if(s==null || s.Length==0) return 0;
        int result =0;
        int i=0;
        while(i<n)
        {
            if(i<n-1)
            {
                string ds = s.Substring(i,2);
                Console.WriteLine(ds);
                if(dict.ContainsKey(ds))
                {
                    result = result + dict[ds];
                    i=i+2;
                    continue;
                }
            }
            string ss = s.Substring(i,1);
            Console.WriteLine(ss);
            result = result + dict[ss];
            i=i+1;
        }
        
        return result;
    }
}