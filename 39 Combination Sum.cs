/**
	just wanna practice backtrack

	for avoid the duplicate, we don't need to loop the backtrack method.
	
*/

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        if(candidates.Length == 0) return res;
        helper(candidates, 0, target, new List<int>(), res);
        return res;
    }
    
    private void helper(int[] candidates, int start, int target, List<int> ans, List<IList<int>> res){
       if(target == 0){
            res.Add(new List<int>(ans));
            return;
        }
        
        for(int i = start; i<candidates.Length; i++){
            int val = candidates[i];
            if(target >= val){
                ans.Add(val);
                helper(candidates, i, target - val, ans, res);
                ans.RemoveAt(ans.Count() - 1);  
            }
        }
    }
}