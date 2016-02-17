using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changes on master
            Console.WriteLine("Hello Git on branch 1.1.");

            Console.WriteLine("Stashing this.");

            Console.WriteLine("A new change after stash.");
            Console.WriteLine("Second stash was made and now we're committing something else.");
            Console.WriteLine("Making some new stash.");
        }
    }
}
