public class MyHashSet {
    private int[] set;
    private int size;
    private int capacity;

    public MyHashSet() {
        size = 0;
        capacity = 2;
        set = new int[2];
        for (int i = 0; i < set.Length;i++) {
            set[i] = -1;
        }
    }
    
    public void Add(int key) {
        int index = key % set.Length;
        while (set[index] != -1 && set[index] != -2) {
            if (set[index] == key) {
                return;
            }
            index++;
            index = index % set.Length;
        }
        set[index] = key;
        size++;
        if (size >= capacity/2) {
            Rehash();
        }
    }
    
    public void Remove(int key) {
        int index = key % set.Length;
        while (set[index] != -1) {
            if (set[index] == key) {
                set[index] = -2;
                size--;
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

    public void Rehash() {
        capacity = 2 * capacity;
        int[] newSet = new int[capacity];
        for (int i = 0; i < newSet.Length; i++) {
            newSet[i] = -1;
        }
        int[] oldSet = set;
        set = newSet;
        size = 0;
        foreach (int i in oldSet) {
            if (i != -1 & i != -2) {
                Add(i);
            }
        }
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */