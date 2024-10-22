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

            //Création trois instances de la classe CarteCredit
            Console.WriteLine("Instances de la classe CarteCredit avec des achats récents");
            Console.WriteLine();
            CarteCredit carte1 = new CarteCredit(97.67, "Courses au supermarché Freshco", 8052);
            CarteCredit carte2 = new CarteCredit(31.90, "Courses au supermarché Metro", 8052);
            CarteCredit carte3 = new CarteCredit(6.60, "Presto frais de transport", 5638);

            //Affichage des détails des objets CarteCredit

            carte1.AfficherDetails();
            carte2.AfficherDetails();
            carte3.AfficherDetails();
            Console.WriteLine();

            //Création deux instances de la classe PayPal
            Console.WriteLine("Instances de la classe PayPal avec des paiements faits récemment");
            Console.WriteLine();
            Paypal achat1 = new Paypal(15, "Netflix", "pilar.inoa@hotmail.com");
            Paypal achat2 = new Paypal(12, "Disney Plus", "pilar.inoa@hotmail.com");

            //Affichage des détails des objets PayPal
            achat1.AfficherDetails();
            achat2.AfficherDetails();
            Console.WriteLine();
        }
    }
}