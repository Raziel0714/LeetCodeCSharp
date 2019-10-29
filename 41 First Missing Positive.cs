/**
    the time complexity of sorting is bigger than O(n)

    sort the array. then loop nums, 
    we can start counting from the first positve number , if the number is equals to previous one, 
    then continue, or else p++;
*/


public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums.Length == 0) return 1;
        Array.Sort(nums);
        int p = 1;
        for(int i=0; i<nums.Length; i++){
            if(nums[i] > 0){
                if(i > 0 && nums[i] == nums[i-1]){
                    continue;
                }
                if(nums[i] > p){
                    return p;
                }
                p++;
            }
        }
        return p;
    }
}


/**
    Loop the array, put all the positive num to the right position.

    then compoare if nums[i] equals to i+1 or not , if not ,then return.

*/
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int l = nums.Length;
        for(int i=0; i<l; i++){
            if(nums[i] > 0 && nums[i] <= l && nums[nums[i] - 1] != nums[i]){
                Console.WriteLine(i + ":"+nums[i]);
                Swap(i, nums[i]-1, nums);
                i--;
            }
        }
        foreach(var i in nums){
            Console.Write(i+" ");
        }
        
        for(int i = 0; i<l; i++){
            if(nums[i] != i+1){
                return i+1;
            }
        }
        return l+1;
    }
    private void Swap(int a, int b, int[] nums){
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}
