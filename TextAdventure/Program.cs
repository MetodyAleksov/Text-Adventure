using System;
using System.Collections.Generic;
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
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            

            //This will be the player character for later on
            PlayerChar player = CharacterCreator();

        }
        static PlayerChar CharacterCreator()
        {
            Console.Clear();
            //Place Holders
            Console.WriteLine("Welcome to Eldere the continent's biggest city, at least as far as you know.");
            Console.WriteLine();
            Console.WriteLine("Did you come here to find wealth or perhaps a meaning to your otherwise meaningless life.");
            Console.WriteLine();

            //Skills

            //Adding skills and abilities based on the class and atributes

            Console.WriteLine();
            Console.WriteLine("So then would you mind telling me what skills you posses.");

            //returns the player char for easier use in the Main method
            string name = NameGen();
            PlayerChar player = AtributeDist(name);

            //

            return player;
        }
        static void CombatScene()
        {

        }
        static List<string> ClassSelect()
        {
            string name = String.Empty;
            string klass = String.Empty;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Type back to return to previous step.");
                Console.WriteLine();
                Console.WriteLine("What did you do before coming here");
                //Just put them somewhere here. Make sure to check the way they look first tho
                //warrior klass 
                Console.WriteLine();
                Console.WriteLine("A) Were you a mercenery for hire.");
                Console.WriteLine();
                //Draw them after the introduction not before 
                Console.WriteLine("     ^^^^^^^^^^^ ");
                Console.WriteLine(" <//===========\\\\>");
                Console.WriteLine("<//   _      _  \\\\>");
                Console.WriteLine("<||  / \\ .. / \\  ||");
                Console.WriteLine("<||  )  (  )  (  ||>");
                Console.WriteLine("<||  \\ / || \\ /  ||> ");
                Console.WriteLine("<||   ^  ||  ^   ||>");
                Console.WriteLine("<||      ||      ||>");
                Console.WriteLine("<||      ||      ||>");
                Console.WriteLine("<||      ||      ||>");
                Console.WriteLine("<||      ()      ||>");
                Console.WriteLine("<\\\\             //>");
                Console.WriteLine(" <\\\\===========//>");
                Console.WriteLine("    vvvvvvvvvvv");
                Console.WriteLine();
                //sourcerer klass 
                //cw tab tab e shortcut ako taka ti e bavno
                Console.WriteLine("B) Or perhaps you studied magic in a local college.");
                Console.WriteLine("");
                Console.WriteLine(" *//===========\\\\*");
                Console.WriteLine("*//      /\\     \\\\*");
                Console.WriteLine("*||   /\\//\\\\/\\   ||* ");
                Console.WriteLine("*||  /// /\\ \\\\\\  ||* ");
                Console.WriteLine("*|| ||| (\\/) ||| ||*");
                Console.WriteLine("*|| ||| |**| ||| ||*");
                Console.WriteLine("*|| ||| \\\\// ||| ||*");
                Console.WriteLine("*|| |||  ||  ||| ||*");
                Console.WriteLine("*||  \\\\\\_||_///  ||*");
                Console.WriteLine("*||      ||      ||*");
                Console.WriteLine("*\\\\      ||     //*");
                Console.WriteLine(" *\\===========//*");
                Console.WriteLine("    ***********");
                Console.WriteLine();

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
                else if (classSel == "back")
                {
                    Console.Clear();
                    name = NameGen();
                }
                else
                {
                    Console.WriteLine("Invalid Class");
                }
            }
            List<string> details = new List<string>();
            details.Add(klass);
            if (name != String.Empty)
            {
                details.Add(name);
            }
            return details;
        }
        static PlayerChar AtributeDist(string name1)
        {
            //Invoking classselect
            List<string> details = ClassSelect();
            string klass = details[0];
            string name = name1;
            if (details.Count == 2)
            {
                name = details[1];
            }

            //Default attributes for playerChar some might be augmented because of the way the calcs work
            double health = 10;
            double str = 10;
            double agi = 10;
            double intellect = 10;
            double magika = 10;

            //Dictionary for the atributes for easier use and augmentation of stats
            Dictionary<string, double> atributes = new Dictionary<string, double>();
            atributes.Add("health", health + Math.Round(str / 10));
            atributes.Add("strenght", str);
            atributes.Add("agility", agi);
            atributes.Add("intellect", intellect);
            atributes.Add("magika", magika + Math.Round(intellect / 10));
            atributes.Add("dogde", 1 + Math.Round(agi / 10));
            atributes.Add("armor", 10 + atributes["dogde"]);

            //Taking all atributes for the creator leaving the person to add some more later on
            int pointsToAdd = 10;
            PlayerChar player = new PlayerChar(name, klass, atributes);

            //The character creator UI element and wizard
            //Assigning atributes
            while (pointsToAdd != 0)
            {
                //Help for the creator wizard
                Console.Clear();
                Console.WriteLine($"Type back to return to previous step.");
                Console.WriteLine();
                Console.WriteLine($"Very well. So you were a {klass} not suprising considering the way you look.");
                Console.WriteLine();
                Console.WriteLine("What were you good at exactly.");
                Console.WriteLine();
                Console.WriteLine($"{player.Name}'s stats:" +
                    $"\nStrenght -> {atributes["strenght"]}" +
                    $"\nAgility -> {atributes["agility"]}" +
                    $"\nIntellect -> {atributes["intellect"]}" +
                    $"\nMagika -> {atributes["magika"] + Math.Round(atributes["intellect"] / 10)}");
                Console.WriteLine();
                Console.WriteLine("Unaugmentable stats:");
                Console.WriteLine($"Health-> {atributes["health"] + Math.Round(atributes["strenght"] / 10)} -> health = 10 + str / 10 rounded");
                Console.WriteLine($"Dogde -> {atributes["dogde"]} -> dogde = 1 + agi / 10 rounded");
                Console.WriteLine($"Armor -> {atributes["armor"] + atributes["dogde"]} -> armor = AV(Armor value from items) + dodge");
                Console.WriteLine();
                Console.WriteLine($"Left augment points: {pointsToAdd}");
                Console.WriteLine();
                Console.WriteLine($"How many do you want to add or remove from an atribute");
                Console.WriteLine("Atribute: Add\\Remove: Points:");
                Console.WriteLine("eg. intellect add 2");

                //Saving the input in two vars for easier use later on
                string[] input2 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string atribute = String.Empty;
                int pointsToAddToAtrb = 0;
                string operation = String.Empty;
                
                //Returning to the previous state of the game which in this case is Class Select and player name
                if (input2[0].ToLower() == "back")
                {
                    Console.Clear();
                    List<string> playerSelect = ClassSelect();
                    player.Name = playerSelect[0];
                    player.Klass = playerSelect[1];
                }
                else if (input2.Length != 3)
                {
                    Console.WriteLine("Error Invalid Command");
                }
                else
                {
                    if (!atributes.ContainsKey(input2[0]))
                    {
                        Console.WriteLine("Invalid atribute");
                    }
                    else
                    {
                        atribute = input2[0];
                    }
                    pointsToAddToAtrb = int.Parse(input2[2]);
                    if (input2[1] != "add")
                    {
                        if (input2[1] != "remove")
                        {
                            Console.WriteLine("Invalid command");
                        }
                        else
                        {
                            operation = input2[1];
                        }
                    }
                    else
                    {
                        operation = input2[1];
                    }


                    //Actual code for the wizard
                    if (operation.ToLower() == "add")
                    {
                        if (atributes.ContainsKey(atribute.ToLower()) && atribute.ToLower() != "dodge" && atribute.ToLower() != "health")
                        {
                            if (atributes[atribute] + pointsToAddToAtrb > 20)
                            {
                                Console.WriteLine("Atributes cannot be higher than 20.");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else
                            {
                                atributes[atribute] += pointsToAddToAtrb;
                                pointsToAdd -= pointsToAddToAtrb;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid atribute");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                    }
                    else if (operation.ToLower() == "remove")
                    {
                        if (atributes.ContainsKey(atribute.ToLower()) && atribute.ToLower() != "dodge" && atribute.ToLower() != "health")
                        {
                            if (atributes[atribute] - pointsToAddToAtrb <= 0)
                            {
                                Console.WriteLine("Atributes cannot be less than 1.");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else
                            {
                                atributes[atribute] -= pointsToAddToAtrb;
                                pointsToAdd += pointsToAddToAtrb;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid atribute");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    if (pointsToAdd < 0)
                    {
                        Console.WriteLine($"You have spend too many atribute points. Remove {Math.Abs(pointsToAdd)}");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (pointsToAdd == 0)
                    {
                        break;
                    }
                }
            }
            player.Atributes = atributes;
            return player;
        }
        static string NameGen()
        {
            //Place holder classes
            Console.WriteLine("What is your name lonely traveler?");
            string name = Console.ReadLine();
            Console.WriteLine();

            return name;
        }
        static PlayerChar SkillDist(PlayerChar player)
        {


            return player;
        }
    }
}

