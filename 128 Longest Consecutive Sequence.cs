/**
    the requirement is O(n),
    so we can build a hash, and save all the numbers in hash.
    then we loop the hash, everytime we found a consecutive path, remove them from hash.
    keep update the length of path.

*/

public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach(var item in nums){
            hash.Add(item);
        }
        int ans = 0;
        int pre = 0;
        int next = 0;
        for(int i = 0; i<nums.Length; i++){
            if(hash.Contains(nums[i])){
                hash.Remove(nums[i]);
                pre = nums[i]-1;
                next = nums[i]+1;
                
                while(hash.Contains(pre)){
                    hash.Remove(pre);
                    pre--;
                }
                while(hash.Contains(next)){
                    hash.Remove(next);
                    next++;
                }
                ans = Math.Max(ans, next-pre-1);
            }
        }
        return ans;
    }
}