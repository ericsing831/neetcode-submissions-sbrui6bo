public class ListNode {
    public int Key;
    public ListNode Next;
    public ListNode (int key){
        Key = key;
        Next = null;
    }
}

public class MyHashSet {
    private ListNode[] set;

    public MyHashSet() {
        set = new ListNode[1000001];
        for (int i = 0; i < set.Length; i++) {
            set[i] = new ListNode(0);
        }
    }
    
    public void Add(int key) {
        int index = key % set.Length; 
        ListNode cur = set[index];
        while (cur.Next != null) {
            if (cur.Next.Key == key) return;
            cur = cur.Next;
        }
        cur.Next = new ListNode(key);
    }
    
    public void Remove(int key) {
        int index = key % set.Length; 
        ListNode cur = set[index];
        while (cur.Next != null) {
            if (cur.Next.Key == key) {
                cur.Next = cur.Next.Next;
                return;
            }
            cur = cur.Next;
        }
    }
    
    public bool Contains(int key) {
        int index = key % set.Length; 
        ListNode cur = set[index];
        while (cur.Next != null) {
            if (cur.Next.Key == key) {
                return true;
            }
            cur = cur.Next;
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