public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Count() == 0) return 0;

        var result = new Stack<int>();
        foreach(var t in tokens){
            if (int.TryParse(t, out int number)){ 
                result.Push(number);
            }else{
                var b = result.Pop();
                var a = result.Pop();
                var calc = PerformCalculation(a, b, t);
                result.Push(calc);
            }
        }

        return result.Pop();
    }

    public int PerformCalculation(int a, int b, string op)
    {
        return op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 ? 0 : a / b,
            _ => throw new ArgumentException("Invalid operator")
        };
    }

}

// 1+2
// 3*3
// 9-4 
