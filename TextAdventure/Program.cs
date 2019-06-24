using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(userName  + ", you're on your way to a camping trip with some friends");
            string lightMonster = "Sternlicht";

            Console.WriteLine("The radio starts to fiz up and you hear...");
            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)
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
            Console.Clear();

            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You pull the car to a stop and you glance over at your friends ");
            Console.WriteLine("only to find them hypnotized by a glowing light");
            Console.ReadKey();
            Console.WriteLine(" ");


            string speakOrRunResponse;
            Console.WriteLine("Their fate is in your hands!");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Will you try to SPEAK to the light or will you RUN?");
            speakOrRunResponse = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;          
            if (speakOrRunResponse == "SPEAK")
            {
                Console.WriteLine(userName + ":" +  " What do you want, how can I set them free?");
                Console.WriteLine(lightMonster + ":" +  " What do you want, how can I set them free?");
                Console.WriteLine(" ");
            }
            else if (speakOrRunResponse == "Run")
            {
                Console.WriteLine("You try to open the door, ");
            }

            
            
        }   
    }
}


            