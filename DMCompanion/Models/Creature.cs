using System.Collections.Generic;

namespace DMCompanion.Models{
    public class Creature{
        public string Name {get; set;}
        public string Description {get; set;}
        public string Size {get; set;}
        public string Type {get; set;}
        public string Alignment {get; set;}
        public int HP {get; set;}
        public int AC {get; set;}
        public int Speed {get; set;} 
        public AbilityScores AbilityScores {get; set;}
        public List<string> Skills {get; set;}
        public List<string> Senses {get; set;}
        public List<string> Languages {get; set;}
        public int CR {get; set;} 
    }
}