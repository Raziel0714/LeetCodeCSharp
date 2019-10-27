/**
	the number bigger then current number is we exchange the digit which is big
	and position is close to the tail
	with digit which is small and position close to the head, 
	like 1,2,3, we exchange 3 and 2, then will be a  
	number bigger than original value.

	but how to find the closed one. 
	so we need to find from the tail, the first number trend start decresing.
	and exchange the closed bigger with the decreased number . then reorder 
	the rest to a decreasing order using bubble sort, we need to make a small change to bubble sort
	the condition inside the loop is j < nums.Length - 1 - (i-start), i - start means 
	we already sort numbers to the end.

	i feel what i wrote here is really a mess....... cry. no one will understand but me.
	but i know im right cause i pass the OJ.
*/
public class Solution{
	public void NextPermutation(int[] nums){
        if(nums.Length == 0 || nums.Length == 1) return;
        
		int p=0;
		int val = 0;
		for(int i = nums.Length - 1; i>=1; i--){
			if(nums[i] > nums[i-1]){
				p = i-1;
				val = nums[p];
                break;
			}
		}
        if(p == 0 && nums[0] > nums[1]) {
            Array.Reverse(nums);
            return;
        }
        
        Console.WriteLine(p+":"+val);
        
        
		int cp=0;
		int cpVal = Int32.MaxValue;
		for(int i = p+1; i<nums.Length; i++){
			if(nums[i] > val && nums[i]-val < cpVal){
				cp = i;
				cpVal = nums[i]-val;
			}
		}
        
        Console.WriteLine(cp+":"+cpVal+":"+p);
        
		int help = nums[p];
		nums[p] = nums[cp];
		nums[cp] = help;
        
        
		Reorder(nums, p+1);

	}

	public void Reorder(int[] nums, int start){
		for(int i = start; i<nums.Length-1; i++){
			for(int j = start; j < nums.Length - 1 - (i-start) ; j++){
				if(nums[j] > nums[j+1])
                    switchNo(nums, j, j+1);
			}
		}
	}

	private void switchNo(int[] nums, int a, int b){
		int temp = nums[a];
		nums[a] = nums[b];
		nums[b] = temp;
	}
}