using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoAlkalmazas
{
    class Hallgato : Ember
    {
        public string Nev { get; set; }

        public Hallgato(string nev, int egesz):base(egesz)
        {
            Nev = nev;
        }

        public override string ToString()
        {
            return Nev + " - " + base.ToString();
        }
    }
}
