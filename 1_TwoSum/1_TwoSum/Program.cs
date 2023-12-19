using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 5 };
            TwoSum(arr, 9);


            int[] TwoSum(int[] nums, int target)
            {
                int firstNum = 0;
                while (firstNum <= nums.Length - 1)
                {
                    for (int i = firstNum + 1; i < nums.Length; i++)
                    {
                        if (nums[firstNum] + nums[i] == target)
                        {

                            return new int[2] { firstNum, i };
                        }


                    }
                    firstNum++;
                }
                return new int[0];
            }
        }
    }
}
