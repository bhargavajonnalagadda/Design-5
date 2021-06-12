public class Solution {
    public bool IsRobotBounded(string instructions) {
        if(instructions==null || instructions.Length <=1) return false;
        int x=0;
        int y=0;
        int direction =0;
        
        foreach(var instruction in instructions)
        {
           
           switch (instruction) {
                    case 'L': direction = (direction + 1) % 4; break;
                    case 'R': direction = (direction + 3) % 4; break;
                    case 'G':
               switch (direction) {
                            case 0: y++; break;
                            case 1: x--; break;
                            case 2: y--; break;
                            case 3: x++; break;
                        } break;
            }
        }
        
        
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(direction);
        if((direction !=0) || (x==0 && y==0))
        {
            return true;
        }
        else
        {
            return false;
        }
        
        
    }
}