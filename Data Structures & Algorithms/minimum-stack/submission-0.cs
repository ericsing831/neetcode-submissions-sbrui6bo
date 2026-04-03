public class MinStack {

    private List<int> _stack; 
    public MinStack() {
        _stack = new List<int>();
    }
    
    public void Push(int val) {
        _stack.Add(val);
    }
    
    public void Pop() {
        int last = _stack.Count - 1;
        int x = _stack[last];
        _stack.RemoveAt(last);
    }
    
    public int Top() {
        return _stack[_stack.Count -1];
    }
    
    public int GetMin() {
        int min = int.MaxValue;
        foreach (int x in _stack) {
            min = Math.Min(x, min);
        }
        return min;
    }
}
