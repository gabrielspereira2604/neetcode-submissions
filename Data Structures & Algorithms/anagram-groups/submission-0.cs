public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var str in strs) {
            var sortedKey = new string(str.OrderBy(c => c).ToArray());
            if (!dict.ContainsKey(sortedKey)) {
                dict[sortedKey] = new List<string>();
            }

            dict[sortedKey].Add(str);
        }

        return dict.Values.ToList();
    }
}
