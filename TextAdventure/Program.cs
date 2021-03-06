﻿using System;
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
            Console.WriteLine(player.ToString());
        }

        //Overall char creation method returns PlayerChar class
        static PlayerChar CharacterCreator()
        {
            Console.Clear();
            //Place Holders
            Console.WriteLine("     You open your eyes and are welcomed by the sight of empty," +
                "\ndarkening skies. The air around is getting colder, but its chilliness isn’t" +
                "\nwhat woke you up. A song reaches your ears – soft, gentle tune, with a sort" +
                "\nof grim undertone hidden within the lyrics. The voice behind the melody is" +
                "\nmelancholic and evokes a fleeting sense of nostalgia within you. Maybe you’ve" +
                "\nheard this one before, in another time and place.");
            WriteColor($"     \nYou get up to find that the other people from the" +
                $"\ncaravan are nowhere to be seen. Only the remains of a long dead" +
                $"\nfire scar the ground nearby in charcoal black. The road is but" +
                $"\na faint trace in the dying crimson dusk. Everything else is" +
                $"\nobscured by the shadows of [the forest], with its tremendous" +
                $"\ntrees like an army of colossi over your head. ", ConsoleColor.Yellow);
            Console.WriteLine();
            WriteColor("\n      Everything else is obscured…" +
                "\nExcept the [songstress]. She lifts a head of black hair and lets" +
                "\nthe lyre’s strings ring out and fall silent. A pair of light" +
                "\neyes meets yours. The features of her pale faces remain calm. ", ConsoleColor.Yellow);
            Console.WriteLine();
            WriteColor($"\n     “I wondered when you’d wake up,” the woman says," +
                $"\nher voice the only sound in the clearing, echoing beyond into" +
                $"\nthe rows of trees. “The others left long ago. But fear not," +
                $"\nthere’s still plenty of time to reach your destination." +
                $"\nAlthough that cannot happen if you don’t listen and answer to me.”", ConsoleColor.Yellow);
            Console.WriteLine("\nYou nod, strangely content with the weirdness of the situation. She clears her throat. ");
            WriteColor("\n“What is your [name], lone traveler?”", ConsoleColor.Yellow);

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
                    Console.WriteLine("+2 Health");
                    Console.WriteLine("+2 Agility");
                    WriteColor("[-3 Intellect]", ConsoleColor.Red);
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
                    if (input2.ToLower() == "yes" || input2.ToLower() == "y")
                    {
                        background = "monastic disciple";
                        break;
                    }
                }
                else if (input == "3" || input == "3)" || input == "soldier")
                {
                    //flavour text
                    WriteColor($"     Indeed, you’ve got an air of danger around you, like you’ve escaped from death by" +
                        $"\nthe skin of your teeth a couple times, and not thanks to sheer luck. It’s a tough life" +
                        $"\nout on the [battlefield], no two opinions about that. Under whose banner did you serve?" +
                        $"\n[The Old Lord’s], perhaps? Or the [warlords of the West]? ", ConsoleColor.Yellow);
                    WriteColor($"The [mercenaries] are undoubtedly\nthose that interest me the most, though. Fighting for" +
                        $"the one with deepest pockets.\nIt can be perplexing to think that a man is able go into the field" +
                        $"\nand risk his very being for money. But that makes the feasts afterwards even better, doesn’t it?", ConsoleColor.Yellow);
                    WriteColor($"\n   Anyway, did you specify in any weapon, or are you a jack of all trades? Sometimes" +
                        $"\neven a simple dagger might be enough to end a rival mercenary. But those monsters? I’ve seen" +
                        $"\nsome of them withstand quite a beating like it’s nothing. I’d bet you know a lot more about that than me.", ConsoleColor.Yellow);
                    Console.WriteLine();
                    Console.WriteLine("\nThe years spent in training around war camps, coupled with the wealth of combat" +
                        "\nexperience, make you agile and quite strong, however you definitely didn’t have a chance to" +
                        "\nindulge in the mysteries of scrolls and parchments:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("+3 Strenght");
                    Console.WriteLine("+3 Agility");
                    WriteColor("[-3 Intellect]", ConsoleColor.Red);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("The soldier enables the basic classes:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("2) Rogue");
                    Console.WriteLine("3) Healer");
                    Console.ResetColor();
                    Console.WriteLine("and the special classes:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("4) Battlemaster");
                    Console.WriteLine("5) Monstrocity Hunter");
                    Console.ResetColor();
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
                        "\ndaughter of his. Then, a lot would still respect you out of fear." +
                        "\n   In any case, some semblance of your grandfather’s might lie within those painfully" +
                        "\nordinary veins of yours. They don’t call your kind [the Blessed] for no reason, after all.", ConsoleColor.Yellow);
                    Console.WriteLine();
                    WriteColor("\nHaving the blood of the powerful Old Lord (either by birth or transfusion)" +
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
                else if (background1.ToLower() == "monastic disciple")
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
                    Console.WriteLine("3) Blood Wielder");
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
                else if ((input == "3" || input == "3)" || input == "healer") && background1.ToLower() != "grandson of the old lord")
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Healer";
                }
                else if (background == "soldier" && (input == "4)" || input == "4" || input == "battlemaster"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Battlemaster";
                }
                else if (background == "soldier" && (input == "5)" || input == "5" || input == "monstrosity hunter"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Monstrosity Hunter";
                }
                else if (background == "monastic disciple" && (input == "4)" || input == "4" || input == "duelist"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Duelist";
                }
                else if (background == "monastic disciple" && (input == "5)" || input == "5" || input == "sorcerer"))
                {
                    //Flavour text
                    Console.WriteLine();
                    klass = "Sorcerer";
                }
                else if (background == "grandson of the old lord" && (input == "3)" || input == "3" || input == "blood wielder"))
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

            //Adding class specific bonuses to stats
            if (player.Background.ToLower() == "commoner")
            {
                player.Atributes["strenght"] += 2;
                player.Atributes["agility"] += 2;
                player.Atributes["intellect"] -= 2;
            }
            else if (player.Background.ToLower() == "soldier")
            {
                player.Atributes["intellect"] -= 3;
                player.Atributes["strenght"] += 3;
                player.Atributes["agility"] += 3;
            }
            else if (player.Background.ToLower() == "monastic disciple")
            {
                player.Atributes["strenght"] += 2;
                player.Atributes["intellect"] += 1;
            }
            else if (player.Background.ToLower() == "grandson of the old lord")
            {
                player.Atributes["health"] += 4;
                player.Atributes["intellect"] += 3;
                player.Abilities = new Dictionary<string, List<string>>();
                player.Abilities.Add("passive", new List<string>());
                player.Abilities["passive"].Add("blood rage");
            }

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
                WriteColor($"{player.Name} the [{player.Background}] Class: [{player.Klass}]\nStats:", ConsoleColor.Green);
                WriteColor($"\n[Strenght] -> [{atributes["strenght"]}]", ConsoleColor.Red);
                WriteColor($"\n[Agility] -> [{atributes["agility"]}]", ConsoleColor.DarkGreen);
                WriteColor($"\n[Intellect] -> [{atributes["intellect"]}]", ConsoleColor.Cyan);
                if (player.Klass.ToLower() == "sorcerer")
                {
                    WriteColor($"\n[Magika] -> [{atributes["magika"] + Math.Round(atributes["intellect"] / 10)}]", ConsoleColor.Magenta);
                }
                Console.WriteLine();
                Console.WriteLine("Unaugmentable stats:");
                WriteColor($"[Health] -> [{atributes["health"] + Math.Round(atributes["strenght"] / 10)}] -> [health] = 10 + str / 10 rounded", ConsoleColor.Red);
                WriteColor($"\n[Dogde] -> [{atributes["dogde"]}] -> [dogde] = 1 + agi / 10 rounded", ConsoleColor.DarkGreen);
                WriteColor($"\n[Armor] -> [{atributes["armor"] + atributes["dogde"]}] -> [armor] = AV(Armor value from items) + dodge / (armor type eg. Light /1 medium /2 heavy / 4)", ConsoleColor.White);
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
            //Skill addition
            Dictionary<string, Dictionary<string, int>> skillsMele = new Dictionary<string, Dictionary<string, int>>();
            skillsMele.Add("Active", new Dictionary<string, int>());
            skillsMele["Active"].Add("Lunge", 0);
            //Passive skills
            skillsMele.Add("Passive", new Dictionary<string, int>());
            skillsMele["Passive"].Add("Long Blade", 0);
            skillsMele["Passive"].Add("Short Blade", 0);
            skillsMele["Passive"].Add("Bow", 0);
            skillsMele["Passive"].Add("Blunt", 0);
            skillsMele["Passive"].Add("Light Armor", 0);
            skillsMele["Passive"].Add("Medium Armor", 0);
            skillsMele["Passive"].Add("Heavy Armor", 0);

            //Spells
            //End

            //Points to spend
            int points = 5;
            int n = 1;
            while (points > 0)
            {
                //Introduction
                Console.Clear();
                Console.WriteLine("         Place Holder            ");
                WriteColor($"\n[{player.Name}]'s Class: [{player.Klass}]", ConsoleColor.Green);
                WriteColor($"\nAtributes: " +
                    $"\n[Health - {player.Atributes["health"]}]" +
                    $"\n[Strenght - {player.Atributes["strenght"]}]" +
                    $"\n[Agility - {player.Atributes["agility"]}]" +
                    $"\n[Intellect - {player.Atributes["intellect"]}]", ConsoleColor.Cyan);
                Console.WriteLine();
                Console.WriteLine("Skills:");

                foreach (var category in skillsMele)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{category.Key}:");
                    foreach (var skill in category.Value)
                    {
                        Console.WriteLine($"{n}) {skill.Key} -> {skill.Value}lv");
                        n++;
                    }
                    n = 1;
                }
                Console.WriteLine();
                Console.WriteLine($"Points to add: {points}");
                Console.WriteLine();
                Console.WriteLine("Command: add/remove");
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "add")
                {
                    Console.WriteLine("Command: Type(Active/Passive), Skillname, amount");
                    input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    if (skillsMele.ContainsKey(input[0]))
                    {
                        if (skillsMele[input[0]].ContainsKey(input[1]))
                        {
                            skillsMele[input[0]][input[1]] += int.Parse(input[2]);
                            points -= int.Parse(input[2]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid skillname");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid type");
                    }
                }
                else if (input[0] == "remove")
                {
                    Console.WriteLine("Command: Type(Active/Passive), Skillname, amount");
                    if (skillsMele.ContainsKey(input[0]))
                    {
                        if (skillsMele[input[0]].ContainsKey(input[1]))
                        {
                            skillsMele[input[0]][input[1]] -= int.Parse(input[2]);
                            points += int.Parse(input[2]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid skillname");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid type");
                    }
                }
                else if (input[0] == "back")
                {
                    player = AtributeDist(player.Name, player.Background);
                }
            }

            foreach (var item in skillsMele)
            {
                foreach (var skill in item.Value)
                {
                    if (skill.Value > 0)
                    {
                        player.Skills.Add(skill.Key, skill.Value);
                    }
                }
            }
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

