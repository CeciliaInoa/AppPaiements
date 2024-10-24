//Atelier 7 : Gestion des paiements
//Cecilia Inoa
//Création de la classe CarteCredit


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte{ get; set; }
        public CarteCredit(double montant, string description, int carte) : base(montant, description)
        {
            NumeroCarte = carte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Montant: {Montant} $ CA, description : {Description}, numéro_carte: {NumeroCarte}");

        }
    }
}
