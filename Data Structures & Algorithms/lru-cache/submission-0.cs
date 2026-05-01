public class LRUCache {
    public class ListNode {
        public int key;
        public int val;
        public ListNode next, prev;
        public ListNode(int key, int val) {
            this.key = key;
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }

    public int cap; 
    public Dictionary<int, ListNode> cache;
    public ListNode left, right;
    public LRUCache(int capacity) {
        cap = capacity;
        cache = new Dictionary<int, ListNode>();

        left = new ListNode(0, 0);
        right = new ListNode(0, 0); 
        left.next = right;
        right.prev = left;
    }
    
    public int Get(int key) {
        if (cache.ContainsKey(key)) {
            Remove(cache[key]);
            Insert(cache[key]);
            return cache[key].val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) Remove(cache[key]);
        cache[key] = new ListNode(key, value);
        Insert(cache[key]);

        if (cache.Count > cap) {
            var node = left.next;
            Remove(node);
            cache.Remove(node.key);
        }
    }

    private void Remove(ListNode node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    private void Insert(ListNode node) {
        node.next = right;
        node.prev = right.prev;
        right.prev.next = node;
        right.prev = node;
    }
}
