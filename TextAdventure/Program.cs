using System;
using System.Linq;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   _______       __           _________       _______      _________      ________ ");
            Console.WriteLine(" //EEEEEEE\\    //LL\\        ||DDDDDDDDD\\     //EEEEEEE\\   ||RRRRRRRR\\    //EEEEEEE\\");
            Console.WriteLine("||EE||^^^^^    ||LL||       ||DD||^^||DD||  ||EE||^^^^    ||RR|^^^\\RR\\  ||EE||^^^^^");
            Console.WriteLine("||EE||____     ||LL||       ||DD||  ||DD||  ||EE||___     ||RR|___||RR| ||EE||____");
            Console.WriteLine("||EEEEEEEE\\    ||LL||       ||DD||  ||DD||  ||EEEEEEE\\    ||RRRRRRRRR/  ||EEEEEEEE\\");
            Console.WriteLine("||EE||^^^^^    ||LL||       ||DD||  ||DD||  ||EE||^^^     ||RR|^^\\R\\    ||EE||^^^^^");
            Console.WriteLine("||EE||______   ||LL \\____   ||DD||__||DD||  ||EE||_______ ||RR|   \\R\\   ||EE||______");
            Console.WriteLine("\\EEEEEEEEE//   \\LLLLLLLLL\\   \\DDDDDDDDD//   \\EEEEEEEEEE// ||RR|    \\R\\  \\EEEEEEEEE//");
            Console.WriteLine(" ^^^^^^^^^^    ^^^^^^^^^^^    ^^^^^^^^^^     ^^^^^^^^^^   ^^^^^     ^^^  ^^^^^^^^^^");
            Console.WriteLine("                                 Eldere's Labyrinth");
            Console.ReadKey();
            CharacterCreator();

        }
        static void CharacterCreator()
        {
            Console.Clear();
            //Place Holders
            Console.WriteLine("Welcome to Endere the continent's biggest city, at least as far as you know.");
            Console.WriteLine();
            Console.WriteLine("Did you come here to find wealth or perhaps a meaning to your otherwise meaningless life.");
            Console.WriteLine();

            //Place holder classes
            Console.WriteLine("What is your name lonely traveler?");
            string name = Console.ReadLine();
            string klass = String.Empty;
            Console.WriteLine();
            Console.WriteLine("What did you do before coming here");
            Console.WriteLine("A) Were you a mercenery for hire.");
            Console.WriteLine("B) Or perhaps you studied magic in a local collegev.");
            while (true)
            {
                string classSel = Console.ReadLine().ToLower();
                if (classSel == "a)" || classSel == "a")
                {
                    klass = "Warrior";
                    break;
                }
                else if (classSel == "b)" || classSel == "b")
                {
                    klass = "Sorcerer";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Class");
                }
            }
            //mr taco was here
            Console.WriteLine($"Very well. So you were a {klass} not suprising considering the way you look.");
            Console.WriteLine();
            Console.WriteLine("What were you good at exactly.");
            double health = 10;
            double str = 10;
            double agi = 10;
            double intellect = 10;
            double magika = 10;
            //Taking all atributes for the creator leaving the person to add some more later on
            int pointsToAdd = 10;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Current stats:\nHealth -> {health + Math.Round(str / 10)}\nStrenght -> {str}\nAgility -> {agi}\nDogde -> {1 + Math.Round(agi / 10)}\nIntellect -> {intellect}\nMagika -> {magika + Math.Round(intellect / 10)}");
                Console.WriteLine($"Left augment points: {pointsToAdd}");
                Console.WriteLine($"How many do you want to add to an atribute");
                Console.WriteLine("Atribute: Points:");
                string[] input2 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string atribute = input2[0];
                int pointsToAddToAtrb = int.Parse(input2[1]);

            }
            Console.WriteLine();
            Console.WriteLine("So then would you mind telling me what skills you posses.");
        }
    }
}

