public class MyCircularQueue {
    public int space;
    public ListNode left;
    public ListNode right;

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode prev;
        public ListNode(int val, ListNode next, ListNode prev) {
            this.val = val;
            this.next = next;
            this.prev = prev;
        }
    }

    public MyCircularQueue(int k) {
        this.space = k;
        this.left = new ListNode(0, null, null);
        this.right = new ListNode(0, null, this.left);
        this.left.next = this.right;
    }

    public bool EnQueue(int value) {
        if (IsFull()) return false;
        var curr = new ListNode(value, right, right.prev);
        right.prev.next = curr;
        right.prev = curr;
        space--;
        return true;
    }
    
    public bool DeQueue() {
        if (IsEmpty()) return false;
        var curr = left.next.next;
        left.next = curr;
        left.next.prev = left;
        space++;
        return true;
    }
    
    public int Front() {
        if (IsEmpty()) {
            return -1;
        }
        else {
            return this.left.next.val;
        }
    }
    
    public int Rear() {
        if (IsEmpty()) {
            return -1;
        }
        else {
            return right.prev.val;
        }
    }
    
    public bool IsEmpty() {
        return this.left.next == this.right;
    }
    
    public bool IsFull() {
        return this.space == 0;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */