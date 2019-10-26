/**

	use back track for this question, two variables can mark '(' ans ')'
	when ')''s number equals n, means its the end of string.

	when we call the backtrack, it will execute current str, and also keep execute next if decision.
*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> ans = new List<string>();
        backtrack(ans, "", 0, 0, n);
        return ans;
    }
    
    public void backtrack(List<string> ans, string str, int open, int close, int max){
        if(close == max){
            ans.Add(str);
            return;
        }
        if(open < max){
            backtrack(ans, str+"(", open+1, close, max);
        }
        if(close < open){
            backtrack(ans, str+")", open, close+1, max);
        }
    }
}