/**
    locat each c in s, find the longest palindrmic substring based on current char.
    if the current char is equal to the char next to it, need to also check if this char and next char are the center of 
    palindrmic

    Time complexity : O(n*n)
*/


public class Solution {
    public string LongestPalindrome(string s) {
        string res = string.Empty;
        if(s.Length <= 1) return s;
        for(int i=0; i<s.Length-1; i++){
            string temp = findLongestLength(i, s);
            res = temp.Length > res.Length? temp : res;
        }
        return res;
    }
    
    private string findLongestLength(int pos, string s){
        int start = pos;
        int end = pos;
        while(start >= 0 && end < s.Length && s[start] == s[end]){
            start--;
            end++;
        }
        Console.WriteLine(start+":"+end);
        string ans = s.Substring(start+1, end-start-1);
        
        if(s[pos] == s[pos+1]){
            start = pos;
            end = pos + 1;
            while(start >= 0 && end < s.Length && s[start] == s[end]){
                start--;
                end++;
            }
        }
        if(end-start-1 > ans.Length){
            ans = s.Substring(start+1, end-start-1);
        }
        
        return ans;
        
    }
}


/**
    famous Manacher's Algorithm

    Time complexity: O(n)!!!!!!

*/