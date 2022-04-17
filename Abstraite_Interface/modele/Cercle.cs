using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraite_Interface.modele
{
    class Cercle : IFigure
    {
        private float rayon;

        public Cercle(float rayon)
        {
            this.rayon = rayon;
        }
        public float Perimetre()
        {
            return 2 * 3.14F * this.rayon;
        }

        public float Surface()
        {
            return 3.14F * this.rayon * this.rayon;
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendFormat("Cercle\nRayon={0}\n" +
                "Surface={1}\nPerimetre={2}\n", this.rayon,
                 this.Surface(), this.Perimetre());
            return message.ToString();
        }

        public float getRayon()
        {
            return this.rayon;
        }
    }
}
