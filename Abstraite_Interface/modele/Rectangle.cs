using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraite_Interface.modele
{
    class Rectangle : Figure
    {
        private float longueur;
        private float largeur;

        public Rectangle(float lon, float lar)
        {
            this.longueur = lon;
            this.largeur = lar;
        }

        public override float Surface()
        {
            return this.longueur * this.largeur;
        }

        public override float Perimetre()
        {
            return 2 * (this.longueur + this.largeur);
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendFormat("Rectangle\nLongueur={0}\n" +
                "Largeur={1}\nSurface={2}\nPerimetre={3}\n", this.longueur,
                this.largeur, this.Surface(), this.Perimetre());
            return message.ToString();
        }
    }
}
