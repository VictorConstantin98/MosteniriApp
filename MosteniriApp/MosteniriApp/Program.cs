namespace MosteniriApp
{
    public class Program
    {
        static void Main(string [] args)
        {
            Superhero superhero = new Superhero();
            Console.WriteLine(superhero.ToString());

            StrongSuperHero strongSuperhero = new StrongSuperHero();
            Console.WriteLine(strongSuperhero.ToString());

            superhero.Salveaza();
            strongSuperhero.Salveaza();

            // Supervillan supervillan = new Supervillan();  // nu putem instantia o clasa abstracta
            // Console.WriteLine(supervillan.ToString());

            FlyShuperHero flyShuperHero = new FlyShuperHero();
            Console.WriteLine(flyShuperHero.ToString());
            flyShuperHero.Salveaza();

            strongSuperhero.ridicaMasina();
            
            superhero.invingeRaufacatorii();  // preia metoda din superhero
            strongSuperhero.invingeRaufacatorii(); // preia metoda din strongSuperhero si ascunde metoda din clasa parinte
            ((Superhero)strongSuperhero).invingeRaufacatorii(); // preia metoda din clasa parinte sau la care am castat
            strongSuperhero.mergeSala();

            superhero.loveste();

            flyShuperHero.loveste(); // am suprascris metoda loveste
            ((Superhero)flyShuperHero).loveste(); // preia metoda din flysuperhero pentru ca metoda suprascrie metoda din clasa parinte

            strongSuperhero.loveste();

            // Superputere superputere = new Superputere(); - o clasa abstracta nu poate fi instantiata cu clasa ei


        }
    }
}
