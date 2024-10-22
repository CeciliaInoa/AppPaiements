using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur 
    {
        public string Nom { get; set; }
        public List<Paiement> paiements { get; set; }
        public Utilisateur(string nom) 
        {
            Nom = nom;
            paiements= new List<Paiement>();
        }
        
        public void AfficherDetails()
        {
            Console.WriteLine($"Nom: {Nom}");

        }
        public void AjouterPaiement(Paiement paiement)
        {
           
                paiements.Add(paiement); }
    }
}


