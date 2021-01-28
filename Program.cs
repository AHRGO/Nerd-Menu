using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_things_First
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = true;
            do
            {
                Console.WriteLine("Hello There! What do you want to do today? Please, write the letter of the menu you want to visit and theh, hit Enter");
                Console.WriteLine("Exit program [X]");
                Console.WriteLine("[A] Magic Menu");
                string resp = Console.ReadLine();
                resp = resp.ToLower();
                Console.Clear();

                if (resp == "a")
                {
                    bool key1 = true;
                    do
                    {
                        Console.WriteLine("Welcome to your Magic Menu! What can I do for you today?");
                        Console.WriteLine("[<] Return to the previous Menu");
                        Console.WriteLine("[A] Color Deck Generator");
                        resp = Console.ReadLine();
                        resp = resp.ToLower();
                        Console.Clear();
                        if (resp == "a")
                        {
                            do
                            {
                                MagicDeck();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("[A] Roll Again");
                                Console.WriteLine("[<] Return to the previous Menu");
                                resp = Console.ReadLine();
                                resp = resp.ToLower();
                                if (resp != "a" && resp != "<")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Hey, this command doesn't exist!");
                                    Console.ReadLine();
                                }
                                Console.Clear();
                            }
                            while (resp != "<");

                            
                        }
                        else if (resp == "<" )
                        {
                            key1 = false;
                            Console.Clear();
                        }
                        else 
                        {
                            Console.WriteLine("Oops, didin't found this option. Try again please.");
                            Console.Clear();
                        }
                       
                    }
                    while (key1);
                   
                }
                else if (resp == "x")
                {
                    key = false;
                    Console.WriteLine("Okay, Goodbye!");
                }
                else
                {
                    Console.WriteLine("Hey Hey! I don't know what are you trying to do, but surely this is not the way.");
                }
            }
            while (key);

            Console.ReadLine();
        }

        static void MagicDeck()
        {
            //White, Blue, Black, Red, Green
            string[] colors = { "Mono White", "Mono Blue", "Mono Black", "Mono Red", "Mono green",
                "Azorius (White + Blue)", "Golgari (Black + Green)", "Rakdos (Black + Red)", "Izzet (Blue + Red)",
                "Selesnya (White + Green)", "Dimir (Blue + black)", "Orzhov (White + Black)",
                "Simic (Blue + Green)", "Boros (White + Red)", "Gruul (Red + Green)",
                "Abzan (White + Black + Green)", "Bant (White + Blue + Green)", "Esper (White + Blue + Black)",
                "Grixis (Blue + Black + Red)", "Jeskai (White + Blue + Red)", "Jund (Black + Red + Green)", "Mardu (White + Black + Red)",
                "Naya (White + Red + Green)", "Sultai (Blue + Black + Green)", "Temur(Blue + Red + Green)",
                "Glint (No White)", "Dune (No Blue)", "Ink (No Black)", "Witch (No Red)", "Yore (No Green)", "Penta Color" };

            Random rand = new Random();
            int mtg_index = rand.Next(colors.Length);
            Console.WriteLine("I think that today you must do a " + colors[mtg_index] + " deck");
        }
    }
}
