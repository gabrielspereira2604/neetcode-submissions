public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        if(!temperatures.Any()) return new int[0];

        var stack = new Stack<int>();
        var results = new int[temperatures.Count()];
        int i = 0;
        foreach(var t in temperatures){
            while (stack.Count > 0 && temperatures[stack.Peek()] < t){
                var index = stack.Pop();
                results[index] = i - index;
            }

            stack.Push(i);
            i++;
        }

        return results;
    }
}
