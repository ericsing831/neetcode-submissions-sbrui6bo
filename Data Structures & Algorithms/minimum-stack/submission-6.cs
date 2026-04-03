public class MinStack {
    private long min;
    private Stack<long> _stack; 
    public MinStack() {
        _stack = new Stack<long>();
    }
    
    public void Push(int val) {
        if (_stack.Count == 0) {
            _stack.Push((long)0);
            min = (long)val;
        }
        else {
            _stack.Push(val - min);
            min = (long)Math.Min(val, min);
        }
    }
    
    public void Pop() {
        long x = _stack.Pop();
        if (x < 0) min -= x;
    }
    
    public int Top() {
        long top = _stack.Peek();
        return top > 0 ? (int)(top + min) : (int)(min);
    }
    
    public long GetMin() {
        return min;
    }
}
