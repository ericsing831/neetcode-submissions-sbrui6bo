public class MyStack {

    private List<int> _stack; 
    public MyStack() {
        _stack = new List<int>();
    }
    
    public void Push(int x) {
        _stack.Add(x);
    }
    
    public int Pop() {
        int returnValue = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return returnValue;        
    }
    
    public int Top() {
        return _stack[_stack.Count - 1];
    }
    
    public bool Empty() {
        return _stack.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */