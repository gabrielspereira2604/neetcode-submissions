public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var letrasS = s.ToCharArray();
        var letrasT = t.ToCharArray();

        Array.Sort(letrasS);
        Array.Sort(letrasT);

        return letrasS.SequenceEqual(letrasT);    }
}
