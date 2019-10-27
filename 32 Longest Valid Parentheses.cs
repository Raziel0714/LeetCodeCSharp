/**
	Find all the valid parentheses substring in s , save their
	start point and end point

	check if there are any substring connect with each other 
	and return the longest.

	Runtime is better than 86.05%
	Memory Usage less than 25%

	because i use recursive to update the list, which cost the cousume of memory, easy to optimized.

	i figure out a way to do it, but spend around 1 hour.
	need to hurry up next time.
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<char> stack = new Stack<char>();
        List<int[]> list = new List<int[]>();
        for(int i=0; i<s.Length; i++){
            if(s[i] == '('){
                stack.Push(')');
            }else{
                if(stack.Count() != 0 && stack.Pop() == s[i]){
                    if(s[i] == s[i-1]){
                        list.Add(new int[]{list[list.Count()-1][0] - 1,i});
                        
                    }else{
                        list.Add(new int[]{i-1, i});
                    }
                    Update(list);
                }
            }
        }
        int res = 0;
        foreach(var item in list){
            res = Math.Max(res, item[1]-item[0] + 1);
        }
        return res;
    }
    public void Update(List<int[]> input){
        if(input.Count() == 1) return;
        int i = input.Count() - 1;
        if(input[i][0] <= input[i-1][1] + 1){
            input[i-1][0] = Math.Min(input[i-1][0], input[i][0]);
            input[i-1][1] =Math.Max(input[i-1][1], input[i][1]);
            input.RemoveAt(i);
            Update(input);
        }
    }
}