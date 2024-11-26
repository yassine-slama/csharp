using System;

class Program
{
    static void Main(string[] args)
    {
        var auth = new Authentification();
        var navigation = new Navigation();

        // Menu principal
        while (true)
        {
            Console.WriteLine("\n=== MENU PRINCIPAL ===");
            Console.WriteLine("1. Inscription");
            Console.WriteLine("2. Connexion");
            Console.WriteLine("3. Rechercher un produit");
            Console.WriteLine("4. Afficher tous les produits");
            Console.WriteLine("5. Afficher profil (connecté)");
            Console.WriteLine("6. Déconnexion");
            Console.WriteLine("7. Quitter");
            Console.Write("Choisissez une option : ");

            int choix;
            if (!int.TryParse(Console.ReadLine(), out choix))
            {
                Console.WriteLine("Veuillez entrer un numéro valide.");
                continue;
            }

            switch (choix)
            {
                case 1:
                    Console.Write("Nom d'utilisateur : ");
                    var nomUtilisateur = Console.ReadLine();
                    Console.Write("Mot de passe : ");
                    var motDePasse = Console.ReadLine();
                    Console.Write("Nom : ");
                    var nom = Console.ReadLine();
                    Console.Write("Email : ");
                    var email = Console.ReadLine();
                    auth.Inscription(nomUtilisateur, motDePasse, nom, email);
                    break;

                case 2:
                    Console.Write("Nom d'utilisateur : ");
                    var login = Console.ReadLine();
                    Console.Write("Mot de passe : ");
                    var pwd = Console.ReadLine();
                    auth.Connexion(login, pwd);
                    break;

                case 3:
                    Console.Write("Entrez un mot-clé pour la recherche : ");
                    var motCle = Console.ReadLine();
                    navigation.RechercherProduit(motCle);
                    break;

                case 4:
                    navigation.AfficherTousLesProduits();
                    break;

                case 5:
                    var utilisateurConnecte = auth.ObtenirUtilisateurConnecte();
                    if (utilisateurConnecte != null)
                    {
                        utilisateurConnecte.AfficherProfil();
                    }
                    else
                    {
                        Console.WriteLine("Aucun utilisateur connecté.");
                    }
                    break;

                case 6:
                    auth.Deconnexion();
                    break;

                case 7:
                    Console.WriteLine("Au revoir !");
                    return;

                default:
                    Console.WriteLine("Option invalide. Veuillez réessayer.");
                    break;
            }
        }
    }
}
