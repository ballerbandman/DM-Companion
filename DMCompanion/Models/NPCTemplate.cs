using System.COllections.Generic;

namespace DMCompanion.Models{
    public class NPCTemplate{
       public string Size {get; set;} = "";
       public string Type {get; set;} = "";
       public string Alignment {get; set;} = "";
       public string AbilityScores {get; set;} = "";
       public list<string> Skills {get; set;} = new List<string>();
       public list<string> Senses {get; set;} = new List<string>();
       public list<string> Languages {get; set;} = new List<string>();
       public int CR {get; set;}
       public list<string> PersonalityTraits {get; set;} = new List<string>();
       public string Ideals {get; set;} = "";
       public string Bonds {get; set;} = "";
       public string Flaws {get; set;} = "";
       public string Background {get; set;} = "";
    }
}