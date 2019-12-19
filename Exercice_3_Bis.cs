using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3._1_Classe
{

        class Article
        {
            private String reference;
            private String designation;
            private int prixHT;
            private static int tauxTVA = 20;

            public Article()
            {
            }

        public Article(Article unArticle)
        {
            this.reference = unArticle.reference;
            this.designation = unArticle.designation;
            this.prixHT = unArticle.prixHT;
        }

        public Article(string reference, string designation, int prixHT)
            {
                this.reference = reference;
                this.designation = designation;
                this.prixHT = prixHT;
            }

            public Article(int prixHT)
            {
                Console.WriteLine("Veuillez renseigner la Référence de l'Article : ");
                this.reference = Console.ReadLine();
                Console.WriteLine("Veuillez renseigner la Désignation de l'Article : ");
                this.designation = Console.ReadLine();
                this.prixHT = prixHT;
                Console.ReadLine();
            }

            public string Reference { get => reference; set => reference = value; }
            public string Designation { get => designation; set => designation = value; }
            public int PrixHT { get => prixHT; set => prixHT = value; }
            public int TauxTVA { get => tauxTVA; set => tauxTVA = value; }

            public int calculerPrixTTC()
            {
                int prixTTC = this.prixHT + (this.prixHT * this.TauxTVA / 100);
                Console.WriteLine("Prix TTC : " + prixTTC + " euros");
                Console.ReadLine();
                return prixTTC;
            }

            public void afficherArticle()
            {
                Console.WriteLine("Article N° " + this.reference);
                Console.WriteLine(this.designation);
                Console.WriteLine("PrixHT : " + this.prixHT + " Euros");
                Console.WriteLine("Taux de TVA : " + this.TauxTVA);
                Console.ReadLine();
            }

        }


        class Program
        {
            static void Main(string[] args)
            {

                Article casque = new Article("854987458", "Casque Audio Haute Qualité", 240);
                casque.afficherArticle();
                int prixTTCcasque = casque.calculerPrixTTC();
                Article casque2 = new Article(casque);
                casque2.afficherArticle();
                int prixTTCcasque2 = casque2.calculerPrixTTC();
                Article robe = new Article();
                robe.afficherArticle();
                int prixTTCRobe = robe.calculerPrixTTC();
                Article livre = new Article(15);
                livre.afficherArticle();
                int prixTTCLivre = livre.calculerPrixTTC();

            }
        }
    }
