/*
    Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
*/

public class Solution {
    public string RemoveVowels(string s) {
        char[] letters = s.ToCharArray();
        char[] vowels = {
            'a', 'e', 'i', 'o', 'u'
        };
        
        var new_s = new StringBuilder();
        
        
        foreach(char c in s) {
            if (vowels.Contains(c) == false) {
                new_s.Append(c);
            }     
        }
        
        return new_s.ToString();
    }
}