using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosteniriApp
{
    internal class Superhero : Superputere // este o clasa normala pentru ca suprascrie toate metodele abstracte
    {
        public override string ToString()
        {
            return "I am SuperHero";
        }

        public void Salveaza()
        {
            Console.WriteLine("SuperHero saves the world!");
        }

        public void invingeRaufacatorii()
        {
            Console.WriteLine("Invinge Raufacatorul");
        }

        public virtual void loveste()
        {
            Console.WriteLine("Loveste");
        }

        public override void mentioneazaSuperPuterea() // suprascrie metoda abstracta 
        {
            Console.WriteLine("Superhero are o superputere");
        }

        public virtual void primeste()
        {
            Console.WriteLine("Primeste");
        }
    }
}
