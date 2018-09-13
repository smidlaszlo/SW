using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoAlkalmazas
{
    /// <summary>
    /// Ember osztaly
    /// </summary>
    class Ember
    {
        int egesz;

        private double valosSzam;

        public bool LogikaiProerti { get; set; }

        public double ValosSzam
        {
            get { return valosSzam; }
            set { valosSzam = value; }
        }


        /// <summary>
        /// egy parameteres konstr.
        /// </summary>
        /// <param name="egesz"></param>
        public Ember(int egesz)
        {
            this.egesz = egesz;
        }

        /// <summary>
        /// ToString metodus
        /// </summary>
        /// <returns>diak sztring listaja</returns>
        public override string ToString()
        {
            return "egesz: " + egesz + ", valos: " +
                ValosSzam + ", logikai: " + LogikaiProerti;
        }
    }
}
