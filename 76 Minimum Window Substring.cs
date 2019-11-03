/**
    keep a int array to record all the chars appearance.
    moving the windows to the right
    updating the leftMin and ans during the moving.
    return result.

*/
public class Solution {
    public string MinWindow(string s, string t) {
        int left = 0;
        int leftMin = 0;
        int ans = Int32.MaxValue;
        var count = new int[58];
        int cun = 0;
        foreach(var item in t){
            count[item - 65]++;
        }
        
        for(int i = 0; i<s.Length; i++){
            //if count already has this value, which means string t has this character.
            // then cun++;
            if(count[s[i]-65] > 0) {
                cun++;
            }
            count[s[i]-65]--;
            while(cun == t.Length){
                if(ans > i - left + 1){
                    leftMin = left;
                    ans = i-leftMin + 1;
                }
                //if string t contains this value, then we add 1 to the count array, since we remove one from the window
                //if the value is bigger then 0, means , the current substring of s doesnt contain enough character, so cun--;
                if(t.Contains(s[left])){
                    count[s[left]-65]++;
                    if(count[s[left]-65] > 0)
                        cun--;
                }
                left++;
            }
        }
        return ans == Int32.MaxValue? "":s.Substring(leftMin, ans);
    }
}