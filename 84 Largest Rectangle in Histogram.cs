/**
    divide and conquer , keep looking for next samll subset's answer, and compare with current one.

*/

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        return Largest(heights, 0, heights.Length-1);
    }
    
    public int Largest(int[] heights, int start, int end){
        if(start > end) return 0;
        int pos = start;
        for(int i= start; i<= end; i++){
            if(heights[i] < heights[pos]){
                pos = i;
            }
        }
        return Math.Max(heights[pos] * (end-start+1),Math.Max(Largest(heights, start, pos-1), Largest(heights, pos+1, end)));
    }
}