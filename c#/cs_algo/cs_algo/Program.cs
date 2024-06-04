using cs_algo.Leetcode;

namespace cs_algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = _409_Longest_Palindrome.LongestPalindrome("abccccdd");
            int result2 = _409_Longest_Palindrome.LongestPalindrome("bb");
            Console.WriteLine($"result_1: {result1}, result_2: {result2}");


            Console.ReadKey();
        }
    }
}
