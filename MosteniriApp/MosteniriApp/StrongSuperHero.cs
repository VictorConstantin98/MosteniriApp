using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosteniriApp
{
    internal class StrongSuperHero : Superhero
    {
        public void ridicaMasina()
        {
            Console.WriteLine("Ridica Masina");
        }

        public new void invingeRaufacatorii()  // new - folosim pt a ascunde metoda din clasa parinte cu un comportament nou
        {
            Console.WriteLine("Invinge ridicand masina si aruncand-o pe raufacatori");
        }

        public new void mergeSala()
        {
            Console.WriteLine("Merge la sala");
            this.invingeRaufacatorii(); // pentru a apela o metoda din instanta clasei curente
            ((Superhero)this).invingeRaufacatorii(); // pentru a apela o metoda din instata la care s-a castat
            base.invingeRaufacatorii(); // pentru a apela o metoda din clasa parinte ( cuvantul base imi ia informatiile din clasa parinte)
        }

    }
}
