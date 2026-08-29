public class StockSpanner {
    public Stack<(int span, int price)> stack;
    public StockSpanner() {
        stack = new Stack<(int span, int price)>();
    }
    
    public int Next(int price) {
        (int span, int price) dummy = (1, price);
        while (stack.Count != 0 && dummy.price >= stack.Peek().price) {
            dummy.span += stack.Pop().span;
        }
        stack.Push(dummy);
        return stack.Peek().span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */