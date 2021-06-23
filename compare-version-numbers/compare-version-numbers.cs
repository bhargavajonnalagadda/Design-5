public class Solution {
    public int CompareVersion(string version1, string version2) {
        
        string[] firstarray = version1.Split('.');
        string[] secondarray = version2.Split('.');
        
        int n1 = firstarray.Length;
        int n2 = secondarray.Length;
        
        foreach(var a in firstarray)
        {
            Console.WriteLine(a);
        }
        
        foreach(var a in secondarray)
        {
            Console.WriteLine(a);
        }
        
        int i1=0,i2=0;
        
        for(int i=0;i<Math.Max(n1,n2);i++)
        {
            //i1 = i<n1 ? Int32.Parse(firstarray[i]) :0;
            if(i<n1)
            {
                if(Int32.TryParse(firstarray[i],out i1))
                {
                //i1 = Int32.Parse(firstarray[i]);
                Console.WriteLine(i1);
                }
            }
            else
            {
                i1=0;
            }
            
            if(i<n2 )
            {
                if(Int32.TryParse(secondarray[i],out i2))
                {
                Console.WriteLine(i2);
                }
            }
            else
            {
                i2=0;
            }
            //i2 = i<n2 ? Int32.Parse(secondarray[i]) :0;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            
            if(i1!=i2)
            {
                return i1>i2 ?1 :-1;
            }
        }
        
        return 0;
        
    }
}