public class Solution {
    public string ReverseVowels(string s) {
        char[] word = s.ToCharArray();
        HashSet<char> vowels = new HashSet<char>(){
            'a',
            'e',
            'i',
            'o',
            'u'
        };

        int l = 0;
        int r = s.Length - 1;

        while (l < r) {
            if (!vowels.Contains(char.ToLowerInvariant(word[l]))) {
                l++;
                continue;
            }

            if (!vowels.Contains(char.ToLowerInvariant(word[r]))) {
                r--;
                continue;
            }

            char temp = word[l];
            word[l] = word[r];
            word[r] = temp;

            l++;
            r--;
        }

        return new string(word);
    }
}