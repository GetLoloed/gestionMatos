using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatos.Data
{
    class Data_Materiels
    {
        public Data_Materiels(string Nom, string Referenece, string Descr, string Date_instal, string Mtbf, string Perime, string Id_type, string Id_site, string Id_client)
        {
            this.Nom = Nom;
            this.Referenece = Referenece;
            this.Descr = Descr;
            this.Date_instal = Date_instal;
            this.Mtbf = Mtbf;
            this.Perime = Perime;
            this.Id_type = Id_type;
            this.Id_site = Id_site;
            this.Id_client = Id_client;
        }

        public string Nom { get; set; }
        public string Referenece { get; set; }
        public string Descr { get; set; }
        public string Date_instal { get; set; }
        public string Mtbf { get; set; }
        public string Perime { get; set; }
        public string Id_type { get; set; }
        public string Id_site { get; set; }
        public string Id_client { get; set; }
    }
}
