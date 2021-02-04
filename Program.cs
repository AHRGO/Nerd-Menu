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
                
                bool key1 = true;
                bool key2 = true;
                
                Console.WriteLine("Hello There! What do you want to do today? Please, write the letter of the menu you want to visit and then, hit Enter");
                Console.WriteLine("[A] Magic Menu");
                Console.WriteLine("[B] RPG Menu");
                Console.WriteLine();
                Console.WriteLine("Exit program [X]");
                string resp = Console.ReadLine();
                resp = resp.ToLower();
                Console.Clear();

                if (resp == "a")
                {
                    
                    do
                    {
                        Console.WriteLine("Welcome to your Magic Menu! What can I do for you today?");
                        Console.WriteLine("[A] Color Deck Generator");
                        Console.WriteLine();
                        Console.WriteLine("[<] Return to the previous Menu");
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
                                Console.WriteLine();
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
                else if (resp == "b")
                {
                    do
                    {
                        
                        Console.WriteLine("Welcome, welcome! Tell-me, what do you want today?");
                        Console.WriteLine("[A] Roll a die");
                        Console.WriteLine();
                        Console.WriteLine("[<] Return to previous Menu");
                        
                        resp = Console.ReadLine();
                        resp = resp.ToLower();
                        Console.Clear();
                        if (resp == "a")
                        {
                            do
                            {
                                Console.WriteLine("Choose a die: ");
                                Console.WriteLine("[1] d4");
                                Console.WriteLine("[2] d6");
                                Console.WriteLine("[3] d8");
                                Console.WriteLine("[4] d10");
                                Console.WriteLine("[5] d12");
                                Console.WriteLine("[6] d20");
                                Console.WriteLine("[7] d100");
                                Console.WriteLine("[8] Custom Value");
                                Console.WriteLine();
                                Console.WriteLine("[<] Return to previous Menu");
                                int[] die_num = { 0, 5, 7, 9, 11, 13, 21, 101 }; //0 is set as first index to become more easy to "navigate" trought the array using the player's given number. the number of faces of each die needed to be increased by 1 to the random() works correctly
                                var input_die = Console.ReadLine();
                                bool is_num =  int.TryParse(input_die,out int d_face); //identifies if the character the user entered is a number. If don't, is_num will become false. Otherway d_face recieves the number

                                int result;
                                int die;
                                Console.Clear();
                                if (is_num)
                                {
                                    if (d_face <= 7)
                                    {
                                        do
                                        {
                                            result = DiceRoller(die_num[d_face]);
                                            Console.WriteLine(result);
                                            Console.WriteLine();
                                            Console.WriteLine("[A] Roll again");
                                            Console.WriteLine("[<] Back to previous Menu");
                                            resp = Console.ReadLine();
                                            Console.Clear();

                                        }
                                        while (resp != "<");


                                    }
                                    else if (d_face == 8)
                                    {                                 
                                        do
                                        {
                                            Console.Write("Well, enter a value:");
                                            result = Convert.ToInt32(Console.ReadLine());
                                            do
                                            {
                                                Console.WriteLine("Actual die: d"+result);
                                                Console.WriteLine();
                                                die = DiceRoller(result + 1);
                                                Console.WriteLine(die);
                                                Console.WriteLine();
                                                Console.WriteLine("[A] Roll again");
                                                Console.WriteLine("[B] Change dice");
                                                Console.WriteLine("[<] Back to previous Menu");
                                                resp = Console.ReadLine();
                                                resp.ToLower();
                                                Console.Clear();

                                            }
                                            while (resp == "a");
                                             
                                        }
                                        while (resp != "<");

                                    }

                                }
                                else if (input_die == "<")
                                {
                                    key2 = false;

                                }
                                else
                                {
                                    Console.WriteLine("Sorry, wrong command pal");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                Console.Clear();
                            }
                            while (key2);
                            
                            
                        }
                        else if (resp == "<")
                        {
                            key1 = false;
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

        static int DiceRoller(int num_face)
        {
            Random dice = new Random();
            int roll = dice.Next(1, num_face);
            return roll;
        }
        
        static void NpcGenerator()
        {
        }
    }
}
