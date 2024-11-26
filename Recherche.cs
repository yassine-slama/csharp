using System.Collections.Generic;

public class Authentification
{
    private List<Utilisateur> utilisateurs = new List<Utilisateur>();
    private Utilisateur utilisateurConnecte;

    public void Inscription(string nomUtilisateur, string motDePasse, string nom, string email)
    {
        if (utilisateurs.Exists(u => u.NomUtilisateur == nomUtilisateur))
        {
            Console.WriteLine("Nom d'utilisateur déjà pris !");
            return;
        }

        var utilisateur = new Utilisateur(nomUtilisateur, motDePasse, nom, email);
        utilisateurs.Add(utilisateur);
        Console.WriteLine("Inscription réussie !");
    }

    public bool Connexion(string nomUtilisateur, string motDePasse)
    {
        utilisateurConnecte = utilisateurs.Find(u => u.NomUtilisateur == nomUtilisateur && u.MotDePasse == motDePasse);
        if (utilisateurConnecte != null)
        {
            Console.WriteLine("Connexion réussie !");
            return true;
        }
        Console.WriteLine("Nom d'utilisateur ou mot de passe incorrect !");
        return false;
    }

    public void Deconnexion()
    {
        utilisateurConnecte = null;
        Console.WriteLine("Vous êtes déconnecté.");
    }

    public Utilisateur ObtenirUtilisateurConnecte()
    {
        return utilisateurConnecte;
    }
}

