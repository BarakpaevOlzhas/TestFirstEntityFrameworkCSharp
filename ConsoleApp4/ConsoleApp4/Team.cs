using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public ICollection<Player> Players { set; get; }        
    }
}
