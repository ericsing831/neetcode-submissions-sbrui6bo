public class FreqStack {

    private Dictionary<int, List<int>> _dict;
    int maxFreq;
    public FreqStack() {
        _dict = new Dictionary<int, List<int>>();
    }
    int topIndex;
    
    public void Push(int val) {
        if (_dict.Count == 0) {
            _dict.Add(val, new List<int>{0});
            maxFreq = val;
            topIndex = 0;
            return;
        }
        topIndex++;
        var currMax = _dict[maxFreq]; 
        if (!_dict.ContainsKey(val)) {
            _dict.Add(val, new List<int>{topIndex});
            if (_dict[val].Count >= _dict[maxFreq].Count) {
                maxFreq = val;
            }
        }
        else {
            _dict[val].Add(topIndex);
            if (_dict[val].Count >= _dict[maxFreq].Count) {
                maxFreq = val;
            }
        }
    }
    
    public int Pop() {
        int index = _dict[maxFreq].Count - 1;
        int value = maxFreq;
        _dict[maxFreq].RemoveAt(index);

        if (_dict[value].Count == 0) {
            _dict.Remove(value);
        }
        maxFreq = MaxFreq();
        return value;
    }

    private int MaxFreq() {
        int bestVal = -1;
        int bestFreq = -1;
        int bestTop = -1;

        foreach (var pair in _dict) {
            var list = pair.Value;
            if (list.Count == 0) continue;

            int freq = list.Count;
            int top = list[list.Count - 1];

            if (freq > bestFreq || (freq == bestFreq && top > bestTop)) {
                bestFreq = freq;
                bestTop = top;
                bestVal = pair.Key;
            }
        }
        return bestVal;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */