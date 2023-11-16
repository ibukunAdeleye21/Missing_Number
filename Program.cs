using System.Transactions;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the list here: ");
            var numArray = Console.ReadLine();

            // Remove the square brackets and split the string by comma
            string[] nums = numArray.TrimStart('[').TrimEnd(']').Split(',');

            // Convert each string to an integer
            int[] numbers = Array.ConvertAll(nums, int.Parse);

            // Create an empty list to contain the missing number
            List<int> missingNumbers = new List<int>();

            // Iterate over the array(numbers) to see which number is missing and add to the empty list (missingNumbers) created
            for (int i = 0; i <= numbers.Length; i++)
            {
                if (!numbers.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            // Convert the missing numbers to a string
            string missingNumbersStr = string.Join(", ", missingNumbers);

            Console.WriteLine($"All numbers except {missingNumbersStr} is in range");
            
        }
    }
}