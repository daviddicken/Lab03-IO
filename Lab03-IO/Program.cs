using System;
using System.IO;

namespace Lab03_IO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadFromFile();
            //WriteToFile();
            //Console.WriteLine(ProductOfThree(getNums()));
        }

        public static string getNums()
        {
            Console.WriteLine("Please enter three numbers seperated by a space.");

            return Console.ReadLine();
        }

        public static decimal ProductOfThree(String str)
        {
            string[] nums = str.Split(" ");

            if (nums.Length < 3) return 0;

            return Convert.ToDecimal(nums[0]) * Convert.ToDecimal(nums[1]) * Convert.ToDecimal(nums[2]);
        }

        //sort array
        // variable for max dupl
        // variable
        public static int MostDuplicates(int[] arr)
        {
            //SORT ARRAY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            int maxCount = 0, returnValue = 0;
           
            for (int j = 0; j < arr.Length; j++)
            {
                int numToCompare = arr[j];
                int counter = 1;

                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (numToCompare == arr[i])
                    {
                        counter++;
                    }
                    else
                    {
                        if(counter > maxCount)
                        {
                            maxCount = counter;
                            returnValue = numToCompare;
                            j = i;
                        }
                        break;
                    }
                }
            }
            return returnValue;
        }

        public static void WriteToFile()
        {
            string path = "../../../words.txt";
            Console.WriteLine("What would you like to save to the words file?");
            string str = Console.ReadLine();
            File.WriteAllText(path, str);
        }

        public static void ReadFromFile()
        {
            string path = "../../../words.txt";
            string getText = File.ReadAllText(path);
            Console.WriteLine(getText);
        }

    }
}
