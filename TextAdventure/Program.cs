using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You're on your way to a camping trip with some friends");
            /*aliens are invading*/
            Console.WriteLine("The radio starts to fiz up and you hear...");
            Console.WriteLine(" ");
            for (int i = 0; i < 4; i++)
            {
                System.Threading.Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING!");
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("...coming from the radio.");
            Console.ReadKey();

            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You pull the car to a stop and you glance over at your friends ");
            Console.WriteLine("only to find them hypnotized by a glowing light");
            Console.ReadKey();
            Console.WriteLine(" ");


            string speakOrRunResponse;
            //bool responded = true;
            Console.WriteLine("Their fate is in your hands!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Will you try to SPEAK to the light or will you RUN?");
            speakOrRunResponse = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            while (speakOrRunResponse != "SPEAK" && speakOrRunResponse != "RUN")
            {
                //responded = false;
                Console.WriteLine("Quick! You have to make a choice!");
                break;
            }
            if (speakOrRunResponse == "SPEAK")
            {
                Console.WriteLine(" Something Happens ");
            }
            else if (speakOrRunResponse == "Run")
            {
                Console.WriteLine("something else happens");
            }
        }   
    }
}
