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
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Flipped: " + FlipaCoin());
            }
            Console.WriteLine("Heads: " + headsCounter);
            Console.WriteLine("Tails: " + tailsCounter);
            Console.WriteLine("it took " + FlipForHeads() + " number of times");

            Console.ReadKey();
        }
        public static int FlipForHeads()
        {
            int counter = 1;

            while (rng.Next(2) != 0)
            {
                counter++;
            }
            return counter;
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
