using System;
using System.IO;

namespace Lab03_IO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(ProductOfThree(getNums()));
            // medianNumber();
            //ReadFromFile();
            //WriteToFile();
            int[] testArr = new int[] { 2, 20, 30, 31, 33, 12, 13};
            Console.WriteLine(MostDuplicates(testArr));
        }

        public static string getNums()
        {
            Console.WriteLine("Please enter three numbers seperated by a space.");

            return Console.ReadLine();
        }

        //============= Challenge 1
        public static decimal ProductOfThree(String str)
        {
            string[] nums = str.Split(" ");

            if (nums.Length < 3) return 0;

            try 
            {
                return Convert.ToDecimal(nums[0]) * Convert.ToDecimal(nums[1]) * Convert.ToDecimal(nums[2]);
            }catch
            {
                Console.WriteLine($"{nums[0]},{nums[1]},{nums[2]} are not all numbers.");
                return 0;
            }
            
            }

        //=============== Challenge 2
        public static decimal medianNumber()
        {
            decimal total = 0, enteredNum = 0;                               
            do
            {

                Console.Write("Please provide a number between 2 - 10: ");
                try
                {
                    string input = Console.ReadLine();
                    int numbEntered = Convert.ToInt32(input);
                    if (numbEntered < 2 || numbEntered > 10)
                    {
                        Console.WriteLine("That number was not between 2 and 10...");
                    }
                    else
                    {
                        for (int i = 1; i <= numbEntered; i++)
                        {
                            bool badNum = true;
                            do
                            {
                                try
                                {
                                    Console.Write($"{i} of {numbEntered} - Enter a number: ");
                                    enteredNum = Convert.ToInt32(Console.ReadLine());
                                    badNum = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Try entering in a number.");
                                }

                            } while (badNum);

                            if (enteredNum < 0)
                            {
                                Console.WriteLine("Enter a number greater than 0");
                                i--;
                            }
                            else
                            {
                                total += enteredNum;
                            }
                        }
                        Console.WriteLine($"The average of these {numbEntered} numbers is: {total / numbEntered}");
                        return total / numbEntered;
                    }
                }
                catch
                {
                    Console.WriteLine($"That wasn't even a number!");
                }
            } while (true);          
        }

        //============== Challenge 3
        public static void PrintPattern()
        {
            Console.WriteLine("    *    \n" +
                              "   ***   \n" +
                              "  *****  \n" +
                              "******** \n" +
                              "  *****  \n" +
                              "   ***   \n" +
                              "    *    \n");
        }

        //=============== Challenge 4
        /// Algorithm: Would love to sort the array but because the lab requirments that will not work
        /// Set a variable for max times found and a variable for the value that was found
        /// create an out for loop to step through array
        /// set counter to one
        /// create an inner for loop to step through the array
        /// compare value at inner index to value at outer index
        /// if equal increment counter
        /// after leaving inner for compare counter to max counter
        /// if greater then replace values in max counter and value with counter and current value
        /// when leaving outer for if max counter is equal to 1 return the first index of the array
        /// else return the value in the variable
        public static int MostDuplicates(int[] arr)
        {
            int maxCount = 0, returnValue = 0;

            for (int j = 0; j < arr.Length ; j++)
            {
                int counter = 1;

                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[j] == arr[i])
                    {
                        counter++;
                    }               
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    returnValue = arr[j];
                }
            }
            if (maxCount == 1) return arr[0];
            return returnValue;
        }

        //=============== Challenge 6
        public static void WriteToFile()
        {
            string path = "../../../words.txt";
            Console.WriteLine("What would you like to save to the words file?");
            string str = Console.ReadLine();
            File.WriteAllText(path, str);
        }

        //Challenge 7
        public static void ReadFromFile()
        {
            string path = "../../../words.txt";
            string getText = File.ReadAllText(path);
            Console.WriteLine(getText);
        }

    }
}
