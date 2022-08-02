// Linear Search Algorithm Using C#
// Praveen Kumar - https://github.com/ipravn/

public class Solution {
    public int CountNegatives(int[][] grid) {
        int count = 0;
        int m = grid.Length;
        for(int i = 0; i < m ; i++)
        {
            for(int j = 0 ; j< grid[i].Length ; j++)
            {
                if(grid[i][j] < 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
