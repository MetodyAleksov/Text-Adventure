using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            player = SkillDist(player);
            //

            return player;
        }

        //Submethods for the char creation
        static string NameGen()
        {
            //Place holder classes
            Console.WriteLine("What is your name lonely traveler?");
            string name = Console.ReadLine();
            Console.WriteLine();

            return name;
        }

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
                    Console.WriteLine("    Small, unimportant people move the world," +
                        "\nbut, in all honesty, it’s hard to stick out among those uncounted thousands," +
                        "\ncoursing through life without accomplishing much of note." +
                        "\nAnd yet maybe it is perhaps a blessing to be one of those" +
                        "\nthat do not shoulder heavy burdens.");
                    Console.WriteLine("    You’re familiar with the plough, I suppose?" +
                        "\nWith the long days on the field, spent in nurturing plants" +
                        "\nthat grow frail and thin beneath the veiled suns?" +
                        "\nWith the prayers at night, with the dim hopes that your crops" +
                        "\nwon’t fail or that your wells won’t be poisoned by whatever" +
                        "\nlurks beneath your feet?");
                    Console.WriteLine("    Or are you an urban dweller," +
                        "\nspending his days behind walls in the cramped streets and tight" +
                        "\nrooms in the lower quarters? The threat of cutthroats in the dark" +
                        "\nshould be all too well-known for you, then. Just as much as that of" +
                        "\nbeing conscripted in the army to die against an unknown foe. Or maybe" +
                        "\nof falling prey to a deadly disease that engulfs whole cities as it ravages" +
                        "\nthe realm.");
                    Console.WriteLine();
                    Console.WriteLine("Due to your arduous hours spend doing manual labour you gain a bonus to:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Health (+2)");
                    Console.WriteLine("Agility (+2)");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("The Commoner origin does not enable specific classes." +
                        "\nIt gives access to the default classes:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Warrior");
                    Console.WriteLine("Rogue");
                    Console.WriteLine("Healer");
                    Console.ResetColor();

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
                    WriteColor("    Now that’s intriguing." +
                        " I’ve never been quite fond of the" +
                        "\nmonks with their robes and [secret rituals].", ConsoleColor.Yellow);
                    WriteColor("\n    It’s hard to imagine spending your youth behind closed walls, in the heart of a" +
                        "\nwilderness so remote and inaccessible that even [monsters] rarely tread it." +
                        "\nBut I’d wager you learned valuable things there.", ConsoleColor.Yellow);
                    WriteColor("\n    Rumors spread about [the monasteries] among the peasantry." +
                        "\nThat the monks can deflect arrows with their bare hands and that swords break upon hitting their bodies," +
                        "\nwhich are as hard as corded steel.", ConsoleColor.Yellow);
                    WriteColor(" \nBut few know about [the magic]. Pulling energy from some" +
                        "\n[unknown plane beyond this world], your brothers can warp and twist" +
                        "\nthe very firmaments of existence to annihilate their enemies.", ConsoleColor.Yellow);
                    WriteColor("\n    A [monastic sorcerer] in action is a terrifying sight to behold, albeit an increasingly" +
                        "\nrare one. They, just as the whole orders, remain far from the ordinary man’s sight, dedicated" +
                        "\nto ancient knowledge and ready to defend their [strongholds] at any cost.", ConsoleColor.Yellow);
                    Console.WriteLine();
                    Console.WriteLine();
                    WriteColor("\n    Due to rigorous mental and physical training over the course of many years," +
                        "\nas well as rich study of the monastic libraries, you’ve honed your mind and body adding: ", ConsoleColor.Yellow);
                    WriteColor("\n[Intellect] +2", ConsoleColor.Cyan);
                    WriteColor("\n[Strenght] +1", ConsoleColor.Cyan);
                    Console.WriteLine();
                    Console.WriteLine("You gain access to the default classes:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("2) Rogue");
                    Console.WriteLine("3) Healer");
                    Console.ResetColor();
                    Console.WriteLine("As well as the special classes:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("4) Duelist");
                    Console.WriteLine("5) Sorcerer");
                    Console.ResetColor();
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
                    WriteColor("    You’ve got no extraordinary looks to you. At first glance, that is. But [the blood] that" +
                        "\nyou carry almost makes your skin let off a dim glimmer at dusk. Some claim that only the" +
                        "\n[Deep Beings] are as powerful as your ancestor. Others say he alone can defend us all from them." +
                        "\nTo live for two thousand years without being dethroned… All that while being able to cure deadly" +
                        "\ninjuries with just a drop of his blood! [The Old Lord] definitely is an enigma." +
                        "\n   But you’re [two generations] removed from him. Even so you would be regarded" +
                        "\nas minor [nobility] in most places, wouldn’t you? Maybe you aren’t even his" +
                        "\n[ndescendant], just a wielder of [transfused] blood from an actual son or" +
                        "\ndaughter of his. Then… A lot would still respect you out of fear." +
                        "\n   In any case, some semblance of your grandfather’s might lie within those painfully" +
                        "\nordinary veins of yours. They don’t call your kind [the Blessed] for no reason, after all.", ConsoleColor.Yellow);
                    Console.WriteLine();
                    WriteColor("Having the blood of the powerful Old Lord (either by birth or transfusion)" +
                        "\ncoursing through your vessels gave either gave your access to higher education" +
                        "\nor gifted you with inborn thirst for knowledge, as well as enhancing your body a bit giving you:", ConsoleColor.Cyan);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n+4 Health");
                    Console.WriteLine("+3 Intelligence");
                    Console.ResetColor();
                    WriteColor("But it also curses you with [blood rage]", ConsoleColor.Red);
                    Console.WriteLine();
                    Console.WriteLine("\nThe Grandson/Granddaughter of the Old Lord enables the default classes except healer:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("2) Rogue");
                    Console.ResetColor();
                    Console.WriteLine($"As well as the special class:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3) Blood Wielder");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Are you satisfied? Y/N");
                    input2 = Console.ReadLine().ToLower();
                    if (input2 == "yes" || input2 == "y")
                    {
                        background = "grandson of the old lord";
                        break;
                    }
                }
                Console.Clear();

            }

            return background;
        }

        static List<string> ClassSelect(string background)
        {
            string background1 = background;
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

                //For getting special classes from backgrounds
                if (background1.ToLower() == "soldier")
                {
                    Console.WriteLine("3) Healer");
                    Console.WriteLine();
                    Console.WriteLine("Background classes: ");
                    Console.WriteLine("4) Battlemaster");
                    Console.WriteLine("5) Monstrosity Hunter");
                }
                else if (background1.ToLower() == "monastery disciple")
                {
                    Console.WriteLine("3) Healer");
                    Console.WriteLine();
                    Console.WriteLine("Background classes: ");
                    Console.WriteLine("4) Duelist");
                    Console.WriteLine("5) Sorcerer");
                }
                else if (background1.ToLower() == "grandson of the old lord")
                {
                    Console.WriteLine();
                    Console.WriteLine("Background classes: ");
                    Console.WriteLine("4) Blood Wielder");
                }
                else if (background1.ToLower() == "commoner")
                {
                    Console.WriteLine("3) Healer");
                    Console.WriteLine();
                    Console.WriteLine("Background classes: ");
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
                    List<string> klasses = ClassSelect(player.Background);
                    player.Klass = klasses[0];
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

        static PlayerChar SkillDist(PlayerChar player)
        {


            return player;
        }
        //Submethods end

        // usage: WriteColor("This is my [message] with inline [color] changes.", ConsoleColor.Yellow);
        static void WriteColor(string message, ConsoleColor color)
        {

            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();

            }


        }
    }
}

