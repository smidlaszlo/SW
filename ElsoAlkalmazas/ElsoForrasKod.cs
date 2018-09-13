using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoAlkalmazas
{
    class ElsoForrasKod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerek egy egesz szamot!");
            string szamSztring = Console.ReadLine();
            int egeszSzam = Convert.ToInt32(szamSztring);
            egeszSzam = Int32.Parse(szamSztring);
            Console.WriteLine("Figyelem" + " emberek!");
            Console.WriteLine("Hello vilag!");
            Console.WriteLine("szam: {1},  {0} {0}", 42, 54);
            Console.WriteLine("pi erteke: {0, 5:n2}", Math.PI);
            Console.WriteLine("bekert szam: {0}", egeszSzam);

            Ember ember = new Ember(12);
            Console.WriteLine(ember.ToString());

            Hallgato diak = new Hallgato("XY", 25);
            //Console.WriteLine(diak.ToString());
            /*tobbsoros megjegyzes
             * masodik sor */
            Console.WriteLine(diak);
            
        }

    }
}
