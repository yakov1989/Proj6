using System;

namespace Proj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count_Letter("hello world",'l'));
        }

       static int Count_Letter(string sentence,char letter)
        {
            int count = 0;
            for(int i=0;i< sentence.Length - 1; i++)
            {
                if (sentence[i] == 'l')
                    count++;

            }
            return count;
      

        }
    }
}
