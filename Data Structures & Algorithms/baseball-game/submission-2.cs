public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scores = new Stack<int>();
        foreach (string i in operations) {
            if (!"+CD".Contains(i)) {
                scores.Push(int.Parse(i.ToString()));
            }
            else {
                switch (i) 
                {
                    case "C":
                    scores.Pop();
                    break;
                    case "+":
                        int last = scores.Pop();
                        int sum = last + scores.Peek();
                        scores.Push(last);
                        scores.Push(sum);
                        break;
                    case "D":
                        scores.Push(scores.Peek()*2);
                        break;
                }
            }
        }
        int totalScores = 0;
        foreach (int score in scores) {
            totalScores += score;
        }
        return totalScores;
    }
}