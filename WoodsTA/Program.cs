using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsTA
{
    public class Program
    {
        
        static void Main()
        {

            Console.WriteLine(@"intro.txt");

            bool gamerunning = true;

            while(gamerunning == true)
            {

                int playerLocation = 0;
                string line;

                System.IO.StreamReader file = new System.IO.StreamReader(@"test.txt");

                while ((line = file.ReadLine()) != null)
                {

                    playerLocation++;
                    string read = Console.ReadLine().ToLower();

                    if (read == "go")
                    {
                        System.Console.WriteLine(line);
                    }

                    else if (read == "exit")
                    {
                        gamerunning = false;                    //Problem
                    }
                    
                    else if (read == "go left")
                    {
                        Console.WriteLine("You went left");
                        
                    }

                    else
                    {
                        Console.WriteLine("You kinda just stand there, very confused.");
                    }

                }

                file.Close();

            }

            Console.WriteLine("Press any button to quit");
            Console.ReadKey();
        }
    }
}
