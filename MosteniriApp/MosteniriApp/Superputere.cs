using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosteniriApp
{
    internal abstract class Superputere // aceasta clasa este o clasa abstracta pentru ca are o metoda abstracta
    {
        abstract public void mentioneazaSuperPuterea(); // este o metoda abstracta(nu are corp/implementare, are doar semnatura)
        //rolul este de a obliga clasele care mostenesc aceasta clasa sa suprascrie metoda
    }
}
