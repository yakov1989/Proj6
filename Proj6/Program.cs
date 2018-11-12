using System;

namespace Proj6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Count_Letter("hello worldl", 'l'));
            //Console.WriteLine(FindSubSequence("1234567","1236"));
            Console.WriteLine("Enter The Word you Want to change: ");
            string word = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Reverse1(word));


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

        static string Reverse(string word)
        {
            string Reverse = "";            
            for (int i = word.Length-1 ; i > -1; i--)
            {
                Reverse += word[i];
            }
            return Reverse;
        }
        //opt 2

            static string Reverse1(string word)
        {
            string Reverse = "";
            for (int i = 0; i <word.Length; i++)
            {
                Reverse = word[i]+Reverse;
            }
            return Reverse;
        }

    }
}
