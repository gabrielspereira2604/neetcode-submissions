public class Solution {
    public bool IsAnagram(string s, string t) {
        var letrasS = s.ToCharArray();
        var letrasT = t.ToCharArray();
        Array.Sort(letrasS);
        Array.Sort(letrasT);

        Console.WriteLine(letrasS);
        Console.WriteLine(letrasT);

        return letrasS.SequenceEqual(letrasT);;
    }
}
