public class MyHashSet {
    private int[] set;
    public MyHashSet() {
        set = new int[1000001];
        for (int i = 0; i < set.Length; i++) {
            set[i] = -1;
        }
    }
    
    public void Add(int key) {
        int index = key % set.Length;
        while (set[index] != -1) {
            if (set[index] == key) return;
            index++;
            index = index % set.Length;
        }
        set[index] = key;
    }
    
    public void Remove(int key) {
        int index = key % set.Length;
        while (set[index] != -1) {
            if (set[index] == key) {
                set[index] = -1;
                return;
            }
            index++;
            index = index % set.Length;
        }
    }
    
    public bool Contains(int key) {
        int index = key % set.Length;
        while (set[index] != -1) {
            if (set[index] == key) {
                return true;
            }
            index++;
            index = index % set.Length;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */