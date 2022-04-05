using System;

namespace P128RefOutParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 7, 15 };

            //Console.WriteLine(arr[0]);

            //ChangeValue(arr);

            //Console.WriteLine(arr[0]);

            //int a = 0;

            ////Console.WriteLine(a);

            //ChangeValue(ref a);

            //Console.WriteLine(a);

            int[] arr = { 5, 7, 15 };

            int a = 15;
            int b = 30;
            int c = 50;

            //ChangeValue(a,"Word",b,c);
            //ChangeValue(a,"Word",b,c,7);
            ChangeValue(a,"Word",b,c,7,15);
        }

        static void ChangeValue(int a, string word, params int[] nums)
        {
            Console.WriteLine(nums[nums.Length-1]);
        }

        //static void ChangeValue(ref int num)
        //{

        //}

        //static void ChangeValue(out int num)
        //{
        //    num = 500;
        //}



    }
}
