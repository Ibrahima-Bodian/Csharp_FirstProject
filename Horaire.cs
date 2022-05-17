using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project
{
    class Horaire
    {
        private int Heure;
        private int minute;
        private int seconde;

        public bool Creer(int H, int min, int sec)
        {
            bool res = false;
            if (H <= 23 && H >= 0 && min <= 59 && min >= 0 && sec <= 59 && sec >= 0)
            {
                this.Heure = H;
                this.minute = min;
                this.seconde = sec;
                res = true;
            }
            return res;
        }


        public string enchaine()
        {
            return (this.Heure + " h " + this.minute + " min " + this.seconde + " sec");
        }
        public void saisir()
        {
            do
            {
                Console.Out.Write("Heure :");
                this.Heure = Convert.ToInt32(Console.In.ReadLine());
            } while (this.Heure < 0 || this.Heure >= 24);
            do
            {
                Console.Out.Write("minute :");
                this.minute = Convert.ToInt32(Console.In.ReadLine());
            } while (this.seconde < 0 || this.seconde >= 60);
            do
            {
                Console.Out.Write("seconde :");
                this.minute = Convert.ToInt32(Console.In.ReadLine());
            } while (this.seconde < 0 || this.seconde >= 60);

        }

            public string enChaine()
            {
                return (this.Heure + " h " + this.minute + " min " + this.seconde + " sec");
            }
            public Horaire Ajouter(Horaire H)
            {
                Horaire HR;
                HR = new Horaire();
                HR.seconde = this.seconde + H.seconde;
                HR.minute = this.minute + H.minute;
                HR.Heure = this.Heure + H.Heure;
                if (HR.seconde > 59)
                {
                    HR.seconde = HR.seconde - 60;
                    HR.minute = HR.minute + 1;
                }
                if (HR.minute > 59)
                {
                    HR.minute = HR.minute - 60;
                    HR.Heure = HR.Heure + 1;
                }
                if (HR.Heure > 23)
                    HR.Heure = HR.Heure - 24;

                return HR;
            }
            public Horaire Soustraire(Horaire H)
            {
                Horaire HR;
                HR = new Horaire();
                HR.seconde = this.seconde - H.seconde;
                HR.minute = this.minute - H.minute;
                HR.Heure = this.Heure - H.Heure;
                if (HR.seconde < 0)
                {
                    HR.seconde = HR.seconde + 60;
                    HR.minute = HR.minute - 1;
                }
                if (HR.minute > 59)
                {
                    HR.minute = HR.minute + 60;
                    HR.Heure = HR.Heure - 1;
                }
                if (HR.Heure > 23)
                    HR.Heure = HR.Heure + 24;

                return HR;
            }
        }
}
