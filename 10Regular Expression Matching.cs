/**
	this is a hard question. maybe there is some very elegant solutions.
	though what come to my mind first is the solution using Recursive. 
	Time complexity : O(n)

	check when both s and p is 1 length string, return value
	or else check if p start with *, 
		if not, then both mius 1
		if yes, check if the rest string of p(without *) is equal to s or not
			if yes, return true.
			if not, see the first char of s is equal to p or not, if not return false, yes, recheck again. 
*/

public class Solution {
    public bool IsMatch(string s, string p) {
        if (String.IsNullOrEmpty(p)) return String.IsNullOrEmpty(s);
        if (p.Length == 1) return (s.Length == 1 && (s[0] == p[0] || p[0] == '.'));

        if (p[1] != '*')
        {
            if (String.IsNullOrEmpty(s)) return false;
            return (s[0] == p[0] || p[0] == '.') && IsMatch(s.Substring(1), p.Substring(1));
        }
        while (!String.IsNullOrEmpty(s) && (s[0] == p[0] || p[0] == '.'))
        {
            if (IsMatch(s, p.Substring(2))) return true;
            s = s.Substring(1);
        }
        return IsMatch(s, p.Substring(2));
    }
}