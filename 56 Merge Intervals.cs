/**
    order the array based on the value on intervals.

    then compare the first one with next, if overlap, then update
    and compare from first again, since first element is already changed.
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,  new Comparison<int[]>( 
            (x,y) => { return x[0] < y[0] ? -1 : (x[0] == y[0] ? 0 : 1); }
            ));
        
        List<int[]> input = new List<int[]>();
        foreach(var item in intervals){
            Console.WriteLine(item[0] +":"+item[1]);
            input.Add(item);
        }
        return Merge(input).ToArray();
        
    }
    
    public List<int[]> Merge(List<int[]> input){
        for(int i = 0; i< input.Count - 1; i++){
            if(input[i][1] >= input[i+1][0]){
                input[i][0] = Math.Min(input[i][0], input[i+1][0]);
                input[i][1] = Math.Max(input[i][1], input[i+1][1]);
                input.RemoveAt(i+1);
                i--;
            }
        }
        return input;
    }
}