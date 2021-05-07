namespace GestionMatos.Data
{
    class Data_Sites
    {
        public Data_Sites(string Nom, string Adresse, string Cp, string Ville)
        {
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Cp = Cp;
            this.Ville = Ville;
        }

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
    }
}
