//using System.ComponentModel.DataAnnotations.Schema;

using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Number { set; get; }
        //[ForeignKey("Team")]
        //public int TeamId { set; get; }
        //public Team Team { set; get; }
        public ICollection<Team> Team { set; get; }
    }
}
