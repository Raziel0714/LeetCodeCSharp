/**
	Very straight forward, use a stack to push every thing's partner into stack.
	eg if its '(' , then push ')';
	   if its ')', then pop to see if they are same, if not false;
	   if the stack is empty. then true.

*/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i< s.Length; i++){
            if(s[i] == '('){
                stack.Push(')');
            }else if(s[i] == '['){
                stack.Push(']');
            }else if(s[i] == '{'){
                stack.Push('}');
            }else{
                if(stack.Count() == 0 || stack.Pop() != s[i]){
                    return false;
                }
            }
        }
        if(stack.Count() == 0) return true;
        return false;
    }
}