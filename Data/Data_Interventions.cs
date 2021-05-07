namespace GestionMatos.Data
{
    class Data_Interventions
    {
        public Data_Interventions(string DateInter, string Com, string Id_mat)
        {
            this.DateInter = DateInter;
            this.Com = Com;
            this.Id_mat = Id_mat;
        }

        public string DateInter { get; set; }
        public string Com { get; set; }
        public string Id_mat { get; set; }
    }
}
