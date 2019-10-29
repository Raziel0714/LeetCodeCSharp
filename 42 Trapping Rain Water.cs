public class Solution {
    public int Trap(int[] height) {
        List<int> point = new List<int>();
        if(height.Length <= 1) return 0;
        
        if(height[0] > height[1]) point.Add(0);
        
        for(int i=1; i<height.Length-1; i++){
            if((height[i] > height[i-1] && height[i] >= height[i+1]) || (height[i] >= height[i-1] && height[i] > height[i+1])){
                point.Add(i);
            }
        }
                                                                                                                        
        if(height[height.Length-1] > height[height.Length-2]) point.Add(height.Length-1);                                                                                                 
        List<int> ponitt = UpdateList(height, point);
        
        foreach(var i in ponitt){
            Console.WriteLine(i);
        }
        
        int res = 0;
        
        for(int i = 0; i < point.Count - 1; i++){
            int temp = Math.Min(height[point[i]], height[point[i+1]]);
            
            for(int j = point[i] + 1; j<point[i+1] ; j++){
                res += Math.Max((temp - height[j]), 0);
            }
        }
        return res;
    }
    
    private List<int> UpdateList(int[] height, List<int> top){
        if(top.Count <= 2) return top;
        for(int i = 1; i<top.Count - 1; i++){
            if(height[top[i]] <= height[top[i-1]] && height[top[i]] <= height[top[i+1]]){
                top.RemoveAt(i);
                return UpdateList(height, top);
            }
        }
        return top;
    }
}