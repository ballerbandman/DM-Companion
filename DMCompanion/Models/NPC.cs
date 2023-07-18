using Stsrem.Collections.Generic;

namespace DMCompanion.Models{
    public class NPC : Creature{
        public List<string> PersonalityTraits {get; set;}
        public string Ideals {get; set;}
        public string Bonds {get; set;}
        public string Flaws {get; set;}
        public string Background {get; set;}
        
    }
}