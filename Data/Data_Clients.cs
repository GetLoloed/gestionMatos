namespace GestionMatos.Data
{
    internal class Data_Clients
        {
            public Data_Clients(string nom, string adresse)
            {
                Nom = nom;
                Adresse = adresse;
            }

            public string Nom { get; set; }
            public string Adresse { get; set; }
        }
}
