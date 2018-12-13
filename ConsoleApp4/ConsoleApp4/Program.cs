using System.Linq;

namespace DataEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AllLive sqlContext = new AllLive())
            {
                var result = sqlContext.People.ToList();
            }
        }
    }
}
