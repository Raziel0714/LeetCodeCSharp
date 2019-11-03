/**
this is right, but it exceed the memory limit, we can use dp for this 
question, the combinations for n is the sum of dp[n-1] + dp[n-2]
*/

public class Solution {
    public int ClimbStairs(int n) {
        var res = new List<List<int>>();
        helper(n, new List<int>(), res);
        return res.Count;
    }
    
    private void helper(int target, List<int> ans, List<List<int>> res){
        if(target == 0){
            res.Add(new List<int>(ans));
            return;
        }
        if(target < 0) return;
        
        for(int i = 1; i <= 2; i++){
            ans.Add(i);
            helper(target - i, ans, res);
            ans.RemoveAt(ans.Count - 1);
        }
    }
}

//here is dp solution
public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1) return 1;
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 2;
        for(int i = 3; i<dp.Length; i++){
            dp[i] = dp[i-1] + dp[i-2];
        }
        return dp[n];
    }
}