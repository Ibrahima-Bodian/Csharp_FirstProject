using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Horaire h1, h2, h3;
            h1 = new Horaire();
            h2 = new Horaire();
            if (h1.Creer(12, 15, 25))
                if (h2.Creer(8,25,50))
                {
                    Console.Out.WriteLine("h1 : " + h1.enchaine());
                        Console.Out.WriteLine("h2 : " + h2.enchaine());
                    }
                else
                {
                    Console.Out.WriteLine("Création de h1 impossible !!!");
                }
        }


        static void Main2(string[] args)
        {
            Console.WriteLine("Coucou Ibra !");
            Compte cpt1, cpt2;

            cpt1 = new Compte();
            cpt1.init(456, "Dupont");

            cpt2 = new Compte();
             cpt2.init(395, "Durant");

            cpt1.crediter(1500);
            cpt1.Debiter(500);
            cpt2.crediter(1600);
            cpt2.Debiter(500);
            Console.Out.WriteLine(cpt1.enChaine());
            Console.Out.WriteLine(cpt2.enChaine());
            Console.Out.WriteLine(cpt2.EstSuperieur(cpt1));
 
        }
    }
}
