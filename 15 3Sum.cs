/**
/**
	Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

	Note:

	The solution set must not contain duplicate triplets.

	Example:

	Given array nums = [-1, 0, 1, 2, -1, -4],

	A solution set is:
	[
	  [-1, 0, 1],
	  [-1, -1, 2]
	]
*/

/**
	Use back track to deep looping the array 
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0; i<nums.Length; i++){
        	if(i != 0 && nums[i] == nums[i-1]){
                Console.WriteLine(i+":"+nums[i]+":"+nums[i-1]);
        		continue;
        	}else{
        		List<int> temp = new List<int>();
        		temp.Add(nums[i]);
        		FindSum(nums, i+1, -nums[i], temp, res);
        	}
        }
        return res;
    }

    private IList<IList<int>> FindSum(int[] nums, int start, int target, List<int> ans, List<IList<int>> res){
    	if(target == 0 && ans.Count() == 3){
    		res.Add(new List<int>(ans));
    		return res;
    	}
        
    	for(int i = start; i<nums.Length; i++){
            if(i != start && nums[i] == nums[i-1]){
                continue;
            }
    		ans.Add(nums[i]);
    		FindSum(nums, i+1, target - nums[i], ans, res);
    		ans.RemoveAt(ans.Count() - 1);
    	}
        return null;
    }
}

/**
	this method can be more effecient.
	since this is looking for the sum of three numbers, we can sort the array
	locate first number, and then find another two numbers, since the array is sorted, we can find from 
	both sides, and adjust the position according to the sum of the two numbers.
*/

public class Solution {
     public IList<IList<int>> ThreeSum(int[] nums) {
        if (nums == null || nums.Length <= 2) return new List<IList<int>>();
        var res = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0; i<nums.Length -2; i++){
        	if(i > 0 && nums[i] == nums[i-1]){
        		continue;
        	}

        	int left = i+1; int right = nums.Length - 1;
            int target = -nums[i];
        	while(left < right){
        		int tempS = nums[left] + nums[right];
        		if(tempS < target){
        			left++;
        		}else if(tempS > target){
        			right--;
        		}else{
        			res.Add(new List<int>{nums[i], nums[left], nums[right]});
                    while(left<nums.Length-1 && nums[left] == nums[left+1]) {left++;}
        		    while(right > left && nums[right] == nums[right - 1]) {right--;}
        			left++;
        			right--;
        		}
        		
        	}
        }
        return res;
    }
}