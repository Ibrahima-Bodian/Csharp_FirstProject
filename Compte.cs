using System;
using System.Collections.Generic;
using System.Text;

namespace First_Projet
{
    class Compte
    {
        private int numero;
        private string nom;
        private float solde;
        
        public void init(int numSai, string nomSai)
        {
            this.numero = numSai;
            this.nom = nomSai;
            this.solde = 0;
        }
        public void crediter(float montantSai)
        {
            this.solde = this.solde + montantSai;
        }

        public void Debiter(float montantSai)
        {
            this.solde = this.solde - montantSai;
        }

        public bool Debiteur(float montantSai)
        {
            if (this.solde < 0)
                return true;
            else
                return false;
        }


        public bool EstSuperieur(Compte cpte)
        {
            if (this.solde > cpte.solde)
                return true;
            else
                return false;
        }
        public string enChaine()
        {
            return ("N ° : " + this.numero + ", nom : " + this.nom + ", solde : " + this.solde);
        }
        
    }
}
