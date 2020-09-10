using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //asks your name
            Console.WriteLine("Hello, what's your name??");

            //reads and memorises whatever they inputted
            string name = Console.ReadLine();

            //says its nice to meet you, then repeats whatever it read in above line
            Sayhello(1000, name);

            Console.ReadLine();
        }
        static void Sayhello(int howmanytimes, string name)
        {
            // a for is a loop
            for (int num = 0; num < howmanytimes; num++)
            {
                Console.WriteLine("hello " + name);

            }
        }

    }

}
