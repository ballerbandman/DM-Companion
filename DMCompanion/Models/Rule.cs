using System.Collections.Generic;

namespace DMCompanion.Models{
    public class Rule{
       public int ID {get; set;}
       public string Name {get; set;} = "";
       public string Preview {get; set;} = "";
       public string FullDescription {get; set;} = "";
       public List<tag> Tags{get; set;} = new List<tag>();

    }

}