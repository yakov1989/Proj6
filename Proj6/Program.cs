using System;

namespace Proj6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Count_Letter("hello worldl", 'l'));
            //Console.WriteLine(FindSubSequence("1234567","1236"));
            //Console.WriteLine("Enter The Word you Want to change: ");
            //string word = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine(Reverse1(word));
            //Console.WriteLine((IsPallidrum(word)));
            //Console.WriteLine((IsPallidrum1(word)));
            //int[] array = { 1, 2, 70, 4, 5 };
            //Console.WriteLine((MaxNum(array)));

            //string[] Symbols =new string[] { "MSFT", "INTC", "CSCO", "GOOG" };
            //double [] MonthlyGain =new double[] {-0.72,1.05,0.76,-1.49};
            //Console.WriteLine( CompanysGains(Symbols,MonthlyGain));
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] Newarray = (FilterEvens(array));
            for (int i = 0; i < Newarray.Length; i++)
            {
                Console.Write(Newarray[i] + " ");
            }
            Console.WriteLine();
        }

        //Targil 1

        //static int Count_Letter(string sentence,char letter)
        // {
        //     int count = 0;
        //     for(int i=0;i< sentence.Length; i++)
        //     {
        //         if (sentence[i] == letter)
        //             count++;

        //     }
        //     return count;
        // }

        //Targil 2

        //Options 1
        //static bool FindSubSequence(string sequence,string sub)
        //  {

        //      bool Isfound = false;

        //     if (sequence.Contains(sub))
        //      {
        //              Isfound = true;
        //              return Isfound;
        //       }

        //      return Isfound;
        //  }

        //  //Options 2
        //  static bool FindSubSequence2(string sequence, string sub)
        //  {

        //      return sequence.IndexOf(sub) != -1;

        //  }

        //Targil 3

        //opt 1

        //static string Reverse(string word)
        //{
        //    string Reverse = "";            
        //    for (int i = word.Length-1 ; i > -1; i--)
        //    {
        //        Reverse += word[i];
        //    }
        //    return Reverse;
        //}

        ////opt 2


        //static string Reverse1(string word)
        //{
        //    string Reverse = "";
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        Reverse = word[i] + Reverse;
        //    }
        //    return Reverse;
        //}

        //Targil 4

        ////opt 1

        //static bool IsPallidrum(string word)
        //{

        //    for (int i = word.Length - 1, j = 0; i > -1; i--)
        //    {
        //        if (word[j] == word[i])

        //            j++;

        //        else

        //            return false;

        //    }
        //    return true;

        //}
        ////opt 2

        //static bool IsPallidrum1(string word)
        //{
        //    return Reverse1(word) == word;

        //}
        //Targil 5 Arrays
        //static int MaxNum(int [] numbers)
        //{
        //   int Max = 0;
        //    for(int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > Max)
        //            Max = numbers[i];
        //    }
        //    return Max;
        //}

        ////Targil 6 Arrays

        //static string CompanysGains(string[] Companys,double[] gains)
        //{
        //    double max = 0;
        //    string temp="";
        //    for(int i = 0; i < gains.Length; i++)
        //    {
        //        if (gains[i] > max)
        //        {
        //            max = gains[i];
        //            temp = Companys[i];
        //        }
        //    }
        //    return temp;
        //}

        //Targil 7 Multiple references 
        static int[] FilterEvens(int[] numbers)
        {

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;

            }
            int[] EvenArray = new int[count];
            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    EvenArray[j] = numbers[i];
                    j++;
                }
            }
            return EvenArray;
        }
    }


}
