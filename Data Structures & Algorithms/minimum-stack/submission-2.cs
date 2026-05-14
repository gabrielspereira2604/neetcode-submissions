public class MinStack {
    private Stack<int> minStack;
    private Stack<int> historyMinimal;

    public MinStack() {
        minStack = new Stack<int>();
        historyMinimal = new Stack<int>();
    }
    
    public void Push(int val) {
        minStack.Push(val);// -2, -2, -3

        if(historyMinimal.Count == 0){
            historyMinimal.Push(val); // -2
        }else{
            var last = historyMinimal.Peek();
            if(last >= val){
                historyMinimal.Push(val); // -3
            }
        }
        
    }
    
    public void Pop() {
        var number = minStack.Pop();

        if (number == historyMinimal.Peek()) {
            historyMinimal.Pop();
        }
    }
    
    public int Top() {
        return minStack.Peek();
    }
    
    public int GetMin() {
        return historyMinimal.Peek(); // 0
    }
}
