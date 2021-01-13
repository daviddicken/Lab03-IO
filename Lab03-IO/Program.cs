using System;

namespace Lab03_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductOfThree(getNums()));
        }

        static string getNums()
        {
            Console.WriteLine("Please enter three numbers seperated by a space.");

            return Console.ReadLine();
        }

        static decimal ProductOfThree(String str)
        {
            string[] nums = str.Split(" ");

            if (nums.Length < 3) return 0;

            return Convert.ToDecimal(nums[0]) * Convert.ToDecimal(nums[1]) * Convert.ToDecimal(nums[2]);
        }
    }
}
