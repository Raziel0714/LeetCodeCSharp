/**
    use a dictionary to save all the char ans coresponding value

    then loop the s and saving the value to a stack, every time pop the stack
    to see if the order is decresing, if not, pop and minus.

    last step is just sum the value in stack.

*/


public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> flag = new Dictionary<char,int>();
        flag.Add('I', 1);
        flag.Add('V', 5);
        flag.Add('X', 10);
        flag.Add('L', 50);
        flag.Add('C', 100);
        flag.Add('D', 500);
        flag.Add('M', 1000);
        
        Stack<int> res = new Stack<int>();
        foreach(var item in s.ToCharArray()){
            if(res.Count > 0){
                int temp = res.Pop();
                if(temp >= flag[item]){
                    res.Push(temp);
                    res.Push(flag[item]);
                }else{
                    res.Push(flag[item]-temp);
                }
            }else{
                res.Push(flag[item]);
            }
        }
        
        int ans = 0;
        while(res.Count > 0){
            ans += res.Pop();
        }
        
        return ans;
    }
}