/**
* This question is required to find the longest substring without repeating. Two pointers come to my mind directly, use one pointer to locate the start point of the string, and move end pointer when the substring doesn't contain repeat character. if we find a repeat character, move start to avoid.
* how to check the substring, and move the substring is a question.
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


/**
* Need a better way to save the substring
* we can use a HashTable and Sliding windows
* initiated a 128 length int array, 128 is because keyboard can only represent 128 characters.
* ASCII has 256 chars.
*
*/

public class Solution{
	public int LengthOfLongestSubstring(string s){
        int[] flags = new int[128];
		for(int i = 0; i<flags.Length; i++){
			flags[i] = -1;
		}

		int start = 0;
		int res = 0;

		for(int i = 0; i<s.Length; i++){
			if(flags[s[i]] != -1){
				start = Math.Max(start, flags[s[i]] + 1);
			}
			flags[s[i]] = i;
			res = Math.Max(res, i - start + 1);
		}

		return res;
	}
}