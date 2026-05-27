public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int i = 0; i <= haystack.Length - needle.Length; i++){
            var word = haystack.Substring(i, needle.Length);
            if(word == needle){
                return i;
            }
        }

        return -1;
    }
}