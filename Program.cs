using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab4NateS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int diceNum = 2;
            int roll1;
            int roll2;
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();

            int sides = 101;
            Console.WriteLine("How many sides are there(up to 100)");
            while (!(sides > 0 && sides <= 100))
            {
                try
                { sides = int.Parse(Console.ReadLine()) + 1; }
                catch { sides = 101; Console.WriteLine("Please enter a valid number"); }
            } 


                /* Console.WriteLine("How many dice do you want to roll, up to 200?");
                 do
                 {
                     try
                     { diceNum = int.Parse(Console.ReadLine()) + 1; }
                     catch { diceNum = 0; Console.WriteLine("Please enter a valid number"); }
                 }
                 while (diceNum > 0 && diceNum <= 200);*/
                string reroll = "y";
            while (reroll != "n" || reroll != "no")
            {
                Console.WriteLine("Hit ENTER to roll those dice!");
                Console.ReadLine();
                Console.WriteLine("Roll:");

                /*for (int i = 0; i < diceNum; i++)
                {
                    roll1 = RandomRoll(sides);
                    Console.WriteLine(roll1);
                }*/

                roll1 = (int)RandomRoll(sides);
                roll2 = (int)RandomRoll2(sides);

                Console.WriteLine(roll1); 
                Console.WriteLine(roll2);
                DiceRollerVoice(roll1, roll2);

                Console.WriteLine("Would you like to roll again?(y/n)");
                reroll = Console.ReadLine().ToLower();
            }
        }
        public static double RandomRoll(int S)
        {

            Random rnd = new Random();

            int roll = rnd.Next(1, S);
            return roll;
        }
        public static double RandomRoll2(int S)
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
      
            double roll = 0;
            while (roll == 0)
            {
                roll = rand.NextDouble() ;
                roll = (int)(roll * S);
            }
            
            
            return roll;
        }
        public static void DiceRollerVoice(int roll1, int roll2)
        {
            if (roll1 == 1 && roll2 == 1) { Console.WriteLine("Snake Eyes!"); }
            else if (roll1 == 2 && roll2 == 2) { Console.WriteLine("Box Cars!"); }
            else if (roll1 + roll2 == 7) { Console.WriteLine("Craps!"); }
        }
    }
}
