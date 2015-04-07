using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipaCoin
{
    class Program
    {
        static Random rng = new Random();
        static int headsCounter = 0;
        static int tailsCounter = 0;

        static void Main(string[] args)
        {
            
            for (int i = 0; i< 1000; i++)
            {
                Console.WriteLine("Flipped: " + FlipaCoin());
            }
            Console.WriteLine("Heads: " + headsCounter);
            Console.WriteLine("Tails: " + tailsCounter);
            Console.ReadKey();
        }
        public static string FlipaCoin()
        {
            if(rng.Next(2) == 0)
            {
                //Heads
                headsCounter = headsCounter + 1;
                return "Heads";
            }
            else 
            {
                //Tails
                tailsCounter = tailsCounter + 1;
                return "Tails";
            }

        }
    }
}
