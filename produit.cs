public class Produit
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }

    public Produit(int id, string nom, decimal prix)
    {
        Id = id;
        Nom = nom;
        Prix = prix;
    }
}
