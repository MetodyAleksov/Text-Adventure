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

        //Overall char creation method returns PlayerChar class
        static PlayerChar CharacterCreator()
        {
            Console.Clear();
            //Place Holders
            Console.WriteLine("Welcome to Eldere the continent's biggest city, at least as far as you know.");
            Console.WriteLine();
            Console.WriteLine("Did you come here to find wealth or perhaps a meaning to your otherwise meaningless life.");
            Console.WriteLine();

            //Adding skills and abilities based on the class and atributes
            

            //returns the player char for easier use in the Main method
            string name = NameGen();
            string background = BackGround();
            PlayerChar player = AtributeDist(name, background);

            //

            return player;
        }

        //Submethods for the char creation
        static string BackGround()
        {
            string background = String.Empty;
            while (true)
            {
                //PH
                Console.WriteLine("What were you before coming here?");
                Console.WriteLine();

                Console.WriteLine("1) Commoner");
                Console.WriteLine("2) Monastic Disciple");
                Console.WriteLine("3) Soldier");
                Console.WriteLine("4) Grandson of the Old Lord");

                string input = Console.ReadLine().ToLower();
                string input2 = String.Empty;

                if (input == "1" || input == "commoner" || input == "1)")
                {
                    //flavour text
                    Console.WriteLine("");
                    Console.WriteLine("Are you satisfied? Y/N");
                    input2 = Console.ReadLine().ToLower();
                    if (input2 == "yes" || input2 == "y")
                    {
                        background = "commoner";
                        break;
                    }
                }
                else if (input == "2" || input == "2)" || input == "monastic disciple")
                {
                    //flavour text
                    Console.WriteLine();
                    Console.WriteLine("Are you satisfied? Y/N");
                    input2 = Console.ReadLine().ToLower();
                    if (input2 == "yes" || input2 == "y")
                    {
                        background = "monastic disciple";
                        break;
                    }
                }
                else if (input == "3" || input == "3)" || input == "soldier")
                {
                    //flavour text
                    Console.WriteLine();
                    Console.WriteLine("Are you satisfied? Y/N");
                    input2 = Console.ReadLine().ToLower();
                    if (input2 == "yes" || input2 == "y")
                    {
                        background = "soldier";
                        break;
                    }
                }
                else if (input == "4" || input == "4)" || input == "grandson of the old lord")
                {
                    //flavour text
                    Console.WriteLine();
                    Console.WriteLine("Are you satisfied? Y/N");
                    input2 = Console.ReadLine().ToLower();
                    if (input2 == "yes" || input2 == "y")
                    {
                        background = "grandson of the old lord";
                        break;
                    }
                }

            }

            return background;
        }
        static List<string> ClassSelect(string background)
        {
            string background1 = String.Empty;
            string klass = String.Empty;

                Console.Clear();
                //Console.WriteLine();
                //Console.WriteLine("What did you do before coming here");
                //Just put them somewhere here. Make sure to check the way they look first tho
                //warrior klass 
                //Console.WriteLine();
                //Console.WriteLine("A) Were you a mercenery for hire.");
                //Console.WriteLine();
                //Draw them after the introduction not before 
                //Console.WriteLine("     ^^^^^^^^^^^ ");
                //Console.WriteLine(" <//===========\\\\>");
                //Console.WriteLine("<//   _      _  \\\\>");
                //Console.WriteLine("<||  / \\ .. / \\  ||");
                //Console.WriteLine("<||  )  (  )  (  ||>");
                //Console.WriteLine("<||  \\ / || \\ /  ||> ");
                //Console.WriteLine("<||   ^  ||  ^   ||>");
                //Console.WriteLine("<||      ||      ||>");
                //Console.WriteLine("<||      ||      ||>");
                //Console.WriteLine("<||      ||      ||>");
                //Console.WriteLine("<||      ()      ||>");
                //Console.WriteLine("<\\\\             //>");
                //Console.WriteLine(" <\\\\===========//>");
                //Console.WriteLine("    vvvvvvvvvvv");
                //Console.WriteLine();
                //sourcerer klass 
                //cw tab tab e shortcut ako taka ti e bavno
                //Console.WriteLine("B) Or perhaps you studied magic in a local college.");
                //Console.WriteLine("");
                //Console.WriteLine(" *//===========\\\\*");
                //Console.WriteLine("*//      /\\     \\\\*");
                //Console.WriteLine("*||   /\\//\\\\/\\   ||* ");
                //Console.WriteLine("*||  /// /\\ \\\\\\  ||* ");
                //Console.WriteLine("*|| ||| (\\/) ||| ||*");
                //Console.WriteLine("*|| ||| |**| ||| ||*");
                //Console.WriteLine("*|| ||| \\\\// ||| ||*");
                //Console.WriteLine("*|| |||  ||  ||| ||*");
                //Console.WriteLine("*||  \\\\\\_||_///  ||*");
                //Console.WriteLine("*||      ||      ||*");
                //Console.WriteLine("*\\\\      ||     //*");
                //Console.WriteLine(" *\\===========//*");
                //Console.WriteLine("    ***********");
                //Console.WriteLine();

                //Default classes
                Console.WriteLine("Default classes: ");
                Console.WriteLine("1) Warrior");
                Console.WriteLine("2) Rogue");
                Console.WriteLine("3) Healer");
                Console.WriteLine();
                Console.WriteLine("Background classes: ");

                //For getting special classes from backgrounds
                if (background == "soldier")
                {
                    Console.WriteLine("4) Battlemaster");
                    Console.WriteLine("5) Monstrosity Hunter");
                }
                else if (background == "monastery disciple")
                {
                    Console.WriteLine("4) Duelist");
                    Console.WriteLine("5) Sorcerer");
                }
                else if (background == "grandson of the old lord")
                {
                    Console.WriteLine("4) Blood Wielder");
                }
                else if (background == "commoner")
                {
                    Console.WriteLine("4) Farmer");
                }
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();

                if (input == "1" || input == "1)" || input == "warrior")
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Warrior";
                }
                else if (input == "2" || input == "2)" || input == "rogue")
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Rogue";
                }
                else if (input == "3" || input == "3)" || input == "healer")
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Healer";
                }
                else if (background == "soldier" && (input == "4)" || input == "4" || input == "battlemaster"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Mattlemaster";
                }
                else if (background == "soldier" && (input == "5)" || input == "5" || input == "monstrosity hunter"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Monstrosity Hunter";
                }
                else if (background == "monastic desciple" && (input == "4)" || input == "4" || input == "duelist"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Duelist";
                }
                else if (background == "monastic desciple" && (input == "5)" || input == "5" || input == "sorcerer"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Sorcerer";
                }
                else if (background == "grandson of the old lord" && (input == "4)" || input == "4" || input == "blood wielder"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Blood Wielder";
                }
                else if (background == "commoner" && (input == "4)" || input == "4" || input == "farmer"))
                {
                //Flavour text
                Console.WriteLine();
                    klass = "Farmer";
                }

            List<string> details = new List<string>();
            details.Add(klass);
     
            return details;
        }
        static PlayerChar AtributeDist(string name1, string background)
        {
            //Invoking classselect
            List<string> details = ClassSelect(background);
            string klass = details[0];
            

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
            atributes.Add("armor", 8 + atributes["dogde"]);

            //Taking all atributes for the creator leaving the person to add some more later on
            int pointsToAdd = 10;
            PlayerChar player = new PlayerChar(name1, klass, atributes);
            player.Background = background;

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
                Console.WriteLine($"{player.Name} the {player.Background} Class: {player.Klass} Stats:" +
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
                    List<string> playerSelect = ClassSelect(background);
                    player.Background = playerSelect[0];
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
        //Submethods end
    }
}

