using System.Data.Entity;

namespace ConsoleApp4
{
    public class SportContext : DbContext
    {
        public SportContext()
            : base("name=SportContext")
        {

        }

        public DbSet<Team> Teams { set; get; }
        public DbSet<Player> Players {set;get;}
    }   
}