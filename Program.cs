using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();   //Read the Lsit and create the list

            int limit = nums.Count / 2;

            for (int i = 0; i < limit; i++)
            {
                nums[i] = nums[i] + nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
