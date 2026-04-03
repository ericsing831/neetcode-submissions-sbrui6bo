public class FreqStack {
    private Dictionary<int, Stack<int>> _freqGroup;
    private int maxFreq;
    private Dictionary<int, int> _stackCount;

    public FreqStack() {
        _freqGroup = new Dictionary<int, Stack<int>>();
        _stackCount = new Dictionary<int, int>();
        maxFreq = 0;
    }
    
    public void Push(int val) {
        _stackCount[val] = _stackCount.GetValueOrDefault(val, 0) + 1;
        int valCount = _stackCount[val];
        if (valCount > maxFreq) {
            maxFreq = valCount;
            _freqGroup[valCount] = new Stack<int>();
        }
        _freqGroup[valCount].Push(val);
    }
    
    public int Pop() {
        int popVal = _freqGroup[maxFreq].Pop();
        _stackCount[popVal]--;
        if (_freqGroup[maxFreq].Count == 0) {
            maxFreq--;
        }
        return popVal;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */