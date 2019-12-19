using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Classe
{
    public class Client
    {
        string cni;
        string nom;
        string prenom;
        string tel;

        public Client(string CNI, string nom, string prenom, string tel)
        {
            this.Cni = CNI;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
        }


        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cni { get => cni; set => cni = value; }

        public void initalisation(string cni, string nom, string prenom)
        {
            this.Cni = cni;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public void afficher()
        {
            Console.WriteLine("Titulaire : " + nom + " " + prenom);
            Console.WriteLine("CNI : " + cni);
            Console.WriteLine("Numéro de Téléphone : " + tel);
            Console.ReadLine();
        }

    }

    public class Compte
    {
        Client proprio;
        int solde;
        Double code;
        static int nbComptes = 0;

        public Compte()
        {
            nbComptes++;
        }

        public Compte(Client proprio, int solde)
        {
            Random rnd = new Random();
            this.proprio = proprio;
            this.solde = solde;
            this.code = rnd.Next(453312, 987415635);
            nbComptes++;
        }

        public void nbCompte()
        {
            Console.WriteLine("Il y a " + nbComptes + " compte(s) crée(s)");
            Console.ReadLine();
        }

        public Client Proprio { get => proprio; set => proprio = value; }
        public int Solde { get => solde; }
        public double Code { get => code; }

        public void crediter(int montant)
        {
            solde = solde + montant;
        }

        public void virement(int montant, Compte adebiter)
        {
            solde += montant;
            adebiter.solde -= montant;
            Console.WriteLine(adebiter.proprio.Prenom + " donne " + montant + " euros à " + proprio.Prenom);
            Console.ReadLine();

        }


        public void débiter(int montant)
        {
            solde -= montant;
        }

        public void virement2(int montant, Compte acrediter)
        {
            solde -= montant;
            acrediter.solde += montant;
            Console.WriteLine(acrediter.proprio.Prenom + " reçoit " + montant + " euros de " + proprio.Prenom);
            Console.ReadLine();

        }

        public void décrire()
        {
            Console.WriteLine("Titulaire : " + proprio.Nom + " " + proprio.Prenom);
            Console.WriteLine("Solde : " + solde);
            Console.WriteLine("Code : " + code);
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("12345645945", "Lopez", "Loriane", "118218");
            Client client2 = new Client("98756412357", "Manenc", "Florent", "3630");

            client1.afficher();
            client2.afficher();

            Compte compte1 = new Compte(client1, 3400);

            compte1.nbCompte();

            Compte compte2 = new Compte(client2, 3700);

            compte2.nbCompte();

            compte1.crediter(100);
            compte2.débiter(100);
            compte1.décrire();
            compte2.décrire();

            compte1.virement(200, compte2);

            compte1.décrire();
            compte2.décrire();

            compte1.virement2(1, compte2);

            compte1.décrire();
            compte2.décrire();

        }
    }
}
