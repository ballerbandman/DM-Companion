using System.Collections.Generic;

namespace DMCompanion.Models{
    public class tag{
        public int ID {get; set;}
        public string Name {get; set;} = "";
        public string Description {get; set;} = "";
        public List<Rule> Rules {get; set;} = new List<Rule>();
    }
}