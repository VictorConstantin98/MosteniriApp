using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosteniriApp
{
    internal class FlyShuperHero : Superhero
    {
        public override void loveste() //override specifica ca se suprascrie metoda din clasa parinte
        {
            Console.WriteLine("loveste din zbor");
        }

        /*
        public override void invingeRaufacatorii()
        {
            // nu putem suprascrie o metoda care nu este marcata ca virtual
        }
        */

        public override void mentioneazaSuperPuterea()
        {
            Console.WriteLine("Zboara");
        }
    }
}
