public class Solution {
    public int MaximumWealth(int[][] accounts) {
        List<int> max = new List<int>();

        for(int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for(int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }
            max.Add(sum);
        }
        return max.Max();
    }
}
