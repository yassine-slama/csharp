using System.Collections.Generic;

public class Panier
{
    private List<Produit> produits;

    public Panier()
    {
        produits = new List<Produit>();
    }

    public void AjouterProduit(Produit produit)
    {
        produits.Add(produit);
        Console.WriteLine($"{produit.Nom} a été ajouté au panier.");
    }

    public void RetirerProduit(int idProduit)
    {
        var produit = produits.Find(p => p.Id == idProduit);
        if (produit != null)
        {
            produits.Remove(produit);
            Console.WriteLine($"{produit.Nom} a été retiré du panier.");
        }
        else
        {
            Console.WriteLine("Produit non trouvé dans le panier.");
        }
    }

    public void AfficherContenu()
    {
        if (produits.Count == 0)
        {
            Console.WriteLine("Le panier est vide.");
            return;
        }

        Console.WriteLine("Contenu du panier :");
        foreach (var produit in produits)
        {
            Console.WriteLine($"- {produit.Nom} : {produit.Prix:C}");
        }
    }

    public decimal CalculerTotal()
    {
        decimal total = 0;
        foreach (var produit in produits)
        {
            total += produit.Prix;
        }
        return total;
    }

    public List<Produit> ObtenirProduits()
    {
        return new List<Produit>(produits);
    }
}
