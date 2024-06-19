using cs_algo.Leetcode;

namespace cs_algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 3, 5, 6];
            int target = 5;
            Console.WriteLine($"target {target}: {_35_Search_Insert_Position.SearchInsert(nums, target)}");
            target = 2;
            Console.WriteLine($"target {target}: {_35_Search_Insert_Position.SearchInsert(nums, target)}");
            target = 7;
            Console.WriteLine($"target {target}: {_35_Search_Insert_Position.SearchInsert(nums, target)}");


            Console.ReadKey();
        }
    }
}
