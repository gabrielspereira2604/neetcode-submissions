using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

        if(s.Length > 0){
            int l = 0;
            int r = s.Length - 1;
            while(l < r){
                if(s[l] != s[r]){
                    return false;
                }

                l++;
                r--;
            }
        }

        return true;
    }
}