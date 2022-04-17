using Abstraite_Interface.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraite_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(7, 5); Rectangle r2 = new Rectangle(17, 12); Rectangle r3 = new Rectangle(13, 9);
            Cercle c1 = new Cercle(5.6F); Cercle c2 = new Cercle(15F); Cercle c3 = new Cercle(35F);
            List<IFigure> figures = new List<IFigure>();
            figures.Add(r1); figures.Add(r2); figures.Add(r3); figures.Add(c1); figures.Add(c2); figures.Add(c3);
            foreach(IFigure f in figures)
            {
                //Console.WriteLine(f);
                if (f is Cercle)
                {
                    Cercle c = (Cercle)f;
                    Console.WriteLine(c);
                }
            }

            Console.ReadKey();
        }
    }
}
