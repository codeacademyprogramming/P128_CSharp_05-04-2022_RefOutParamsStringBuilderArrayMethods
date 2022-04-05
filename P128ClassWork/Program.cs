using System;
using System.Text;

namespace P128ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soz Daxil Edin");

            Console.WriteLine(ReverseStr(Console.ReadLine()));
        }

        static StringBuilder ReverseStr(string sentences)
        {
            string[] words = sentences.Split(' ');

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length-1; j >= 0; j--)
                {
                    result.Append(words[i][j]);
                }

                if (i != words.Length-1)
                    result.Append('-');
            }

            return result;
        }

        //static string ReverseStrOld(string sentences)
        //{
        //    string[] words = sentences.Split(' ');

        //    string result = "";

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        //string word = words[i];

        //        for (int j = words[i].Length-1; j >= 0; j--)
        //        {
        //            result += words[i][j];
        //            //result += word[j];
        //        }

        //        if (i != words.Length-1)
        //        {
        //            result += '-';
        //        }

        //        //if (word != words[words.Length-1])
        //        //{
        //        //    result += '-';

        //        //}
        //    }

        //    return result;
        //}

        //static string ReverseStr(string str)
        //{
        //    string result = "";

        //    for (int i = str.Length-1; i >= 0; i--)
        //    {
        //        result += str[i];
        //    }

        //    return result;
        //}
    }
}
