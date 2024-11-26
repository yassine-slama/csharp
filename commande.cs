using System;

public class Commande
{
    public int Id { get; set; }
    public List<Produit> Produits { get; set; }
    public decimal Total { get; set; }
    public DateTime DateCommande { get; set; }

    public Commande(int id, List<Produit> produits)
    {
        Id = id;
        Produits = produits;
        Total = 0;
        foreach (var produit in produits)
        {
            Total += produit.Prix;
        }
        DateCommande = DateTime.Now;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Commande #{Id} passée le {DateCommande}");
        Console.WriteLine("Produits :");
        foreach (var produit in Produits)
        {
            Console.WriteLine($"- {produit.Nom} : {produit.Prix:C}");
        }
        Console.WriteLine($"Total : {Total:C}");
    }
}
