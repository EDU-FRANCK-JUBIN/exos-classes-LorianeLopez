using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_Classe
{

    public class CompteBancaire
    {
        String titulaire;
        float solde;
        String devise;

        int nbCompte;

        public string Titulaire { get => titulaire; set => titulaire = value; }
        public float Solde { get => solde; set => solde = value; }
        public string Devise { get => devise; set => devise = value; }
        public int NbCompte { get => nbCompte; set => nbCompte = value; }

        public CompteBancaire(string titulaire, float solde, string devise)
        {
            this.Titulaire = titulaire;
            this.Solde = solde;
            this.Devise = devise;
        }

        public void crediter(int montant)
        {
            solde += montant;
        }

        public void débiter(int montant)
        {
            solde -= montant;
        }

        public void décrire()
        {
            Console.WriteLine("Titulaire : " + titulaire);
            Console.WriteLine("Solde : " + solde);
            Console.WriteLine("Devise : " + devise);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Loriane Lopez", 3400, "Euros");
            compte.décrire();
            compte.crediter(100);
            compte.décrire();
            compte.débiter(50);
            compte.décrire();
        }
    }
}
