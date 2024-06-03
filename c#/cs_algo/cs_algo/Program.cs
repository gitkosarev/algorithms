using cs_algo.Leetcode;

namespace cs_algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int[], int> dict = new Dictionary<int[], int>();
            dict.Add([2, 7, 11, 15], 9);
            dict.Add([3, 2, 4], 6);
            dict.Add([3, 3], 6);

            foreach (int[] key in dict.Keys)
            {
                int[] result = _1_Two_Sum.TwoSum(key, dict[key]);
                Console.WriteLine($"[0]: {result[0]}, [1]: {result[1]}");
                Console.WriteLine();
            }
        }
    }
}
