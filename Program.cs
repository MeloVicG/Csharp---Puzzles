using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        public static int[] RandomArray()
        {
            Random randArr = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = randArr.Next(5, 25);
                Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static String TossCoin()
        {
            Console.WriteLine("Tossing a Coin");
            String Toss;
            //nothing in Toss
            Random randomGen = new Random();

            if (randomGen.Next(1, 11) > 5)
            {
                Toss = "Heads ";
                Console.Write(Toss);
            }
            else
            {
                Toss = "Tails ";
                Console.Write(Toss);
            }
            // Console.WriteLine(Toss);

            return Toss;
            //have to return value
        }

        public static double TossMultipleCoin(int num)
        {
            Console.WriteLine("Tossing Multiple Coins");
            Random randomGen = new Random();
            int Head = 0;
            int Tail = 0;
            for(int i = 0; i < num ; i++)
            {
                string TossResult = TossCoin();
                if (TossResult == "Heads ")
                {
                    Head += 1;
                }
                else
                {
                    Tail += 1;
                }
            }
                double ratio = (double)Head / (double)Tail;
                return ratio;

                // red squigly **Use of unassigned local variable 'TossMult' 
                // red squigly TossMult wasnt assigned to anything 

                // red squigly Ratio Cannot implicitly convert type 'double' to 'string'
                // String was labled at function assign changed to double 
        }
        
        public static List<string> Namez()
        {
            List<string> Names = new List<string>();
            Names.Add("Vic");
            Names.Add("Bianca");
            Names.Add("Zach");
            Names.Add("Spence");
            Names.Add("Sujung");
            Names.Add("Maddy");

            Random randomGen = new Random();

            for(int i = 0; i < Names.Count; i++)
            {
                int randomIdx = randomGen.Next(0,6);
                string temp = Names[i];
                Names[i] = Names[randomIdx];
                Names[randomIdx] = temp;
            }
            
            foreach(string entry in Names)
            {
                Console.WriteLine("-fullList: " + entry);
            }

            for(int j = 0; j < Names.Count; j++)
            {
                if(Names[j].Length > 5)
                {
                    Console.WriteLine("-greater Than 5 List: " + Names[j]);
                }
            }
            return Names;
            
            //E.. Cannot implicitly convert type 'System.Collections.Generic.List<string>' to 'string' 
            //S.. Names was a string but needed a List<string> to be returned
        }
        static void Main(string[] args)
        {
            // RandomArray();

            // Console.WriteLine(TossCoin());
            // TossCoin();

            // Console.WriteLine(TossMultipleCoin(5));
            Console.WriteLine(Namez());


        }
    }
}
