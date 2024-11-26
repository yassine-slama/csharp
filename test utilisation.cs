using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var panier = new Panier();

        // Ajouter des produits au panier
        panier.AjouterProduit(new Produit(1, "Livre", 12.99m));
        panier.AjouterProduit(new Produit(2, "Stylo", 2.49m));

        // Afficher le contenu du panier
        panier.AfficherContenu();

        // Calculer le total
        Console.WriteLine($"Total : {panier.CalculerTotal():C}");

        // Passer une commande
        var produitsCommande = panier.ObtenirProduits();
        var commande = new Commande(1, produitsCommande);

        // Afficher les détails de la commande
        commande.AfficherDetails();

        Console.ReadLine();
    }
}
