using System.Collections.Generic;

namespace DMCompanion.Models{
    public class NPC : Creature{
        public List<string> npcPersonalityTraits {get; set;} = new List<string>();
        public string Ideals {get; set;} = "";
        public string Bonds {get; set;} = "";
        public string Flaws {get; set;} = "";
        public string Background {get; set;} = "";
        
    }
}