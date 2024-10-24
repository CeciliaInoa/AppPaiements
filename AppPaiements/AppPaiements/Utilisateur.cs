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
        public List<Paiement> Paiements { get; set; }
        public Utilisateur(string nom) 
        {
            Nom = nom;
            Paiements= new List<Paiement>();
        }
        
        public void Afficherinfos()
        {
            Console.WriteLine($"Nom: {Nom}");

        }
        public void AjouterPaiement(Paiement paiement)
        {
           
             Paiements.Add(paiement); }
    }
}


