namespace LeetCode.HashMap;
public static class HappyNum{
    public static bool IsHappy(int n) {
        int x = n;
        HashSet<int> used = new HashSet<int>();
    //while  not happy & not in a loop
        while (x != 1 && !used.Contains(x)){
        // add num to set  
            used.Add(x);
            
            int total = 0;
            while (x > 0){
            // isolate digit
                int d = x % 10;
                total += d*d;
            // remove the digit from x
                x /= 10;
                
            } 
            //update x
            x=total;
        }
        if (x == 1){
            return true;
        }
        return false;
    }
}