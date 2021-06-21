public class Solution {
    
    public static string[] keys = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
    public static int[] values = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
    public string IntToRoman(int num) {
        
        if(num==null || num ==0) return String.Empty;
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<values.Length && num >0;i++)
        {
            while(values[i] <= num)
            {
                Console.WriteLine(values[i]);
                Console.WriteLine(num);
                num = num - values[i];
                 Console.WriteLine(num);
                Console.WriteLine(keys[i]);
                sb.Append(keys[i]);
            }
        }
         return sb.ToString();
        
    }
}