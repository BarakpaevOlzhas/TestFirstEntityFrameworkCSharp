using System.Data.Entity;

namespace DataEntity
{
    public class AllLive : DbContext
    {
        public AllLive()
            : base("name=SportContext")
        {
        }

        public DbSet<Car> Cars { set; get; }
        public DbSet<Person> People { set;get;}
    }   
}