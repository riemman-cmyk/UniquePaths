namespace UniquePaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(get_number_of_ways(n,m));
        }

        static int get_number_of_ways(int n, int m)
        {
            int[,] board = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                board[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                board[0, j] = 1;
            }
            for (int k = 1; k < m; k++)
            {
                for (int r = 1; r < n; r++)
                {
                    board[k, r] = board[k - 1, r] + board[k, r - 1];
                }
            }
            return board[m - 1, n - 1];
        }
    }
}
