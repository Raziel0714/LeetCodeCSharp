/**
* This question is required to find the longest substring without repeating. Two pointers come to my mind directly, use one pointer to locate the start point of the string, and move end pointer when the substring doesn't contain repeat character. if we find a repeat character, move start to avoid.
* need to keep updating the substring when two pointers is moving.
*/


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null) return 0;
        if(s.Length == 1) return 1;
        int ans = 0;
        int start = 0; int end = 1;
        while(end < s.Length){
            if(s.Substring(start, end - start).Contains(s[end])){
                start++;
            }else{
                end++;
            }
            Console.WriteLine(start+":"+end);
            ans = Math.Max(ans, end-start);
        }
        return ans;
    }
}