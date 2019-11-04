/**
    This is using dp to solve.
    we keep a left array, right array and height array.
    left represent the most left node that equal to 1
    right represent the most right node equal to 1,
    but we need to consider the record of previous row

    height represent the 1's height in a column

    then we each line can be calculate by the current row and previous row.
    the max value will be ( right - left ) * height

    this is hard, need to review.

*/



public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if(matrix == null || matrix.Length == 0 || matrix[0] == null) return 0;
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        var l = new int[n];
        var r = new int[n];
        var h = new int[n];
        for(int i = 0; i<n; i++){
            r[i] = n;
        }
        int ans = 0;
        
        for(int i = 0; i < m; i++){
            int cur_left = 0;
            int cur_right = n;
            //height
            for(int j = 0; j<n; j++){
                if(matrix[i][j] == '0')
                    h[j] = 0;
                else{
                    h[j]++;
                }
            }
            
            //left
            for(int j=0; j<n; j++){
                if(matrix[i][j] == '0'){
                    l[j] = 0;
                    cur_left = j+1;
                }else{
                    l[j] = Math.Max(cur_left, l[j]);
                }
            }
            
            
            //right
            for(int j=n-1; j>=0; j--){
                if(matrix[i][j] == '0'){
                    r[j] = n;
                    cur_right = j;
                }else{
                    r[j] = Math.Min(cur_right, r[j]);
                }
            }
            
            //answer
            for(int j = 0; j<n; j++){
                ans = Math.Max(ans, (r[j] - l[j]) * h[j]);
            }
        }
        return ans;
    }
}