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

                //while (i == 2)
                //{
                //    Console.ForegroundColor = ConsoleColor.White;
                //    Console.WriteLine("Help");

                //}
                //Console.Clear();
            }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("...coming from the radio.");
            Console.ReadKey();

            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(2000);
                Console.WriteLine("You pull the car to a stop and you glance over at your friends ");
                Console.WriteLine("only to find them frozen in a daze");
                Console.WriteLine(" ");

                string response;
                Console.WriteLine("Will you LOOK or will you RUN first?");
                response = Console.ReadLine();

    
                if(response == "LOOK")
                {
                    Console.WriteLine(" Something Happens ");
                }
                else if
                {
                    Console.WriteLine("something else happens");
                }
                 else
                {
                Console.WriteLine("You must make a choise");
                }
            

                      









            //Console.WriteLine("C#, Git, GitHub, Visual Studio!");
            //Console.WriteLine("Are you intered in coding .. see if it is for you. What are you waiting for? ..Take our mini intro to coding and YOU get to decide!");
            //Console.WriteLine(" ");

        }
    }
}
