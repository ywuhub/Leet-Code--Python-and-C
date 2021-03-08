/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/

public class Solution {
    public int Reverse(int x) {
        bool negative = false;

        if (x < 0) {
            negative = true;
            x = x * -1;
        }

        if ((x >= int.MaxValue) || (x <= int.MinValue)) { 
            return 0;
        }

        string x_str = new string(x.ToString().Reverse().ToArray());
        
        if ((x > 0 && x <= int.MaxValue) && (negative == false)) {
            try {
                x = Int32.Parse(x_str);
                return x;    
            } catch {
                return 0;
            }
        } else if (negative == true) {
            try {
                x = -1 * Int32.Parse(x_str);   
            } catch {
                return 0;
            }

            if ((x > 0 && x <= int.MaxValue) || (x < 0 && x >= int.MinValue)) {
                return x;
            } else {
                return 0;
            }
        } else {
            return 0;
        }
    }
}