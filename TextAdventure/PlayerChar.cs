using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class PlayerChar
    {
        public PlayerChar(string name, string clas, double strenght, double agility, double intelect, double magika, Dictionary<string, List<string>> abilities)
        {
            Name = name;
            Class = clas;
            Health = 10 * (strenght / 10);
            Strenght = strenght;
            Dodge = 1 + (agility / 10);
            Agility = agility;
            Intelect = intelect;
            Magika = magika * (intelect / 10);
            Abilities = abilities;
            Inventory = new List<string>();
            Skills = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public double Health { get; set; }
        public double Strenght { get; set; }
        public double Dodge { get; set; }
        public double Agility { get; set; }
        public double Intelect { get; set; }
        public double Magika { get; set; }
        public Dictionary<string, List<string>> Abilities { get; set; }
        public Dictionary<string, int> Skills { get; set; }
        public List<string> Inventory { get; set; }
    }
}
