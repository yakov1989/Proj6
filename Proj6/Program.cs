using System;

namespace Proj6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Count_Letter("hello worldl", 'l'));
            Console.WriteLine(FindSubSequence("1234567","1236"));
            
            
        }

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
       //Options 1
      static bool FindSubSequence(string sequence,string sub)
        {

            bool Isfound = false;
           
           if (sequence.Contains(sub))
            {
                    Isfound = true;
                    return Isfound;
             }
          
            return Isfound;
        }

        //Options 2
        static bool FindSubSequence2(string sequence, string sub)
        {

            return sequence.IndexOf(sub) != -1;

        }
    }
}
