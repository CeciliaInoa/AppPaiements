//Atelier 7 : Gestion des paiements
//Cecilia Inoa



using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            Console.WriteLine("******************Gestion des paiements******************");
            Console.WriteLine();

            //Création de trois instances de la classe CarteCredit
            Console.WriteLine("Achats récents effectués avec carte de crédit");
            Console.WriteLine();
            CarteCredit carte1 = new CarteCredit(97.67, "Courses au supermarché Freshco", 8052);
            CarteCredit carte2 = new CarteCredit(31.90, "Courses au supermarché Metro", 8052);
            CarteCredit carte3 = new CarteCredit(6.60, "Presto frais de transport", 5638);

            //Affichage des détails des objets CarteCredit

            carte1.AfficherDetails();
            carte2.AfficherDetails();
            carte3.AfficherDetails();
            Console.WriteLine();

            //Création de deux instances de la classe PayPal
            Console.WriteLine("Paiements récents faits avec PayPal");
            Console.WriteLine();
            Paypal achat1 = new Paypal(15, "Netflix", "pilar.inoa@hotmail.com");
            Paypal achat2 = new Paypal(12, "Disney Plus", "pilar.inoa@hotmail.com");

            //Affichage des détails des objets PayPal
            achat1.AfficherDetails();
            achat2.AfficherDetails();
            Console.WriteLine();

            //Gérer les instances de ces classes
            
            Console.WriteLine("********Liste des paiements effectués********");
            Console.WriteLine();
            Utilisateur utilisateur = new Utilisateur("Cecilia Inoa");
            //Console.WriteLine();
            

            utilisateur.AjouterPaiement(carte1);
            utilisateur.AjouterPaiement(carte2);
            utilisateur.AjouterPaiement(carte3);
            utilisateur.AjouterPaiement(achat1);
            utilisateur.AjouterPaiement(achat2);

            //Affichage de l'utilisateur
            utilisateur.Afficherinfos();
            Console.WriteLine();

            //Affichage des paiements effectués


            foreach (Paiement paiement in utilisateur.Paiements)
            {
                paiement.AfficherDetails();
           }


        }
    }
}