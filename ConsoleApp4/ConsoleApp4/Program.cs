using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SportContext())
            {
                var result = context.Players.ToList();
            }
        }
    }
}
