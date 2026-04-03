public class Pair {
    public int Key;
    public int Value;
    public Pair(int key, int value) {
        Key = key;
        Value = value;
    }
}
public class MyHashMap {
    private Pair[] map;
    private int size;
    private int capacity;
    public MyHashMap() {
        map = new Pair[2];
        size = 0;
        capacity = 2;
    }
    
    public void Put(int key, int value) {
        int index = key % capacity;
        while (true) {
            if (map[index] == null || map[index].Key == -1) {
                map[index] = new Pair(key, value);
                size++;
                if (size >= capacity) {
                    Rehash();
                }
                return;
            }
            else if (map[index].Key == key) {
                map[index].Value = value;
                return;
            }
            index++;
            index = index % capacity;
        }
    }
    
    public int Get(int key) {
        int index = key % capacity;
        while (map[index] != null) {
            if (map[index].Key == key) {
                return map[index].Value;
            }
            index++;
            index = index % capacity;
        }
        return -1;
    }
    
    public void Remove(int key) {
        int index = key % capacity;
        while (map[index] != null) {
            if (map[index].Key == key) {
                map[index].Key = -1;
                map[index].Value = -1;
                size--;
                return;
            }
            index++;
            index = index % capacity;
        }
    }

    public void Rehash() {
        capacity = capacity * 2;
        Pair[] newMap = new Pair[capacity];
        Pair[] oldMap = map;
        map = newMap;
        size = 0;
        foreach (Pair pair in oldMap) {
            if (pair != null && pair.Key != -1) {
                Put(pair.Key, pair.Value);          
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */