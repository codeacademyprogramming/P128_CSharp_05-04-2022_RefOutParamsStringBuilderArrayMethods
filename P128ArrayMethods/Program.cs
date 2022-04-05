using System;
using System.Linq;

namespace P128ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5,7,15};

            //int[] arr1 = new int[0];
            //arr1[0] = 15;
            //arr1[1] = 33;
            //arr1[6] = 66;


            //int[] arr2 = { };

            //int[] arr = { 5,7,5,6,7};
            //Console.WriteLine(arr.Length);

            //Array.Resize(ref arr, arr.Length+1);
            //arr[arr.Length - 1] = 35;

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr[arr.Length-1]);
            //int[] arr = { };

            //while (true)
            //{
            //    Console.WriteLine("Element Elave Etmek Isdeyirsizni?  y / n");
            //    string chose = Console.ReadLine();
            //    if (chose == "y")
            //    {
            //        Console.WriteLine("Daxil Et:");
            //        string strNum = Console.ReadLine();
            //        int num = int.Parse(strNum);
            //        Array.Resize(ref arr, arr.Length + 1);
            //        arr[arr.Length - 1] = num;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            int[] arr = { 77,5, 15, 35,15, 99,35 };
            int[] arr1 = { 5, 66 };
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());
            Console.WriteLine(arr.Contains(36));
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Array.Clear(arr,0, arr.Length);

            //int len = arr.Length;

            //for (int i = 0; i < len; i++)
            //{
            //    Array.Resize(ref arr, arr.Length - 1);
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            int first = Array.IndexOf(arr, 15);

            Console.WriteLine(Array.IndexOf(arr,15, first + 1));
        }
    }
}
