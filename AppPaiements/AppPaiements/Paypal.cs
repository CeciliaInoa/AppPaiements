using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }
        public Paypal(double montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Montant: {Montant} $ CA, description : {Description}, email: {Courriel}");

        }
    }
}