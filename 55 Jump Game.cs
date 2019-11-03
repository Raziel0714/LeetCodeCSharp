/**
    create an array of bool to mark every point is able to jump or not
    then loop the nums array, if current node is true , then set all reachable
    node flag to true. 

    return the last element in the flag array.
*/

public class Solution {
    public bool CanJump(int[] nums) {
        if(nums.Length < 2) return true;
        bool[] flag = new bool[nums.Length];
        
        for(int i =0 ; i < nums.Length; i++){
            if(flag[i] == true || i == 0){
                fastFill(flag, i+1, Math.Min(nums.Length - 1, i+nums[i]));
            }
        }
        return flag[nums.Length - 1];
    }
    
    private void fastFill(bool[] flag, int start, int end){
        for(int i = start; i<= end; i++){
            flag[i] = true;
        }
    }
}