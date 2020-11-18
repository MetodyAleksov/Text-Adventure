using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class PlayerChar
    {
        public PlayerChar(string name, string klass, Dictionary<string, double> atributes)
        {
            Name = name;
            Klass = klass;
            Background = "None";
            Atributes = atributes;
            Abilities = new Dictionary<string, List<string>>();
            Skills = new Dictionary<string, int>();
            Inventory = new List<string>();
        }
        //Atributes for playerChar
        public string Name { get; set; }
        public string Klass { get; set; }
        public string Background { get; set; }
        public Dictionary<string, double> Atributes { get; set; }
        public Dictionary<string, List<string>> Abilities { get; set; }
        public Dictionary<string, int> Skills { get; set; }
        public List<string> Inventory { get; set; }
    }
}
