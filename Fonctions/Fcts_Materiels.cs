using System.Data;
using System.Windows.Forms;
using GestionMatos.Data;
using MySql.Data.MySqlClient;

namespace GestionMatos.Fonctions
{
    internal class Fcts_Materiels
    {
        public static void AjoutMateriel(Data_Materiels DataMAt)
        {
            var sql =
                "insert into materiel (id_mat, nom, referenece, descr, date_instal, mtbf, perime, id_type, id_site, id_client) values (NULL, @nom, @referenece, @descr, @date_instal, @mtbf, @perime, @id_type, @id_site, @id_client)";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = DataMAt.Nom;
            cmd.Parameters.Add("@referenece", MySqlDbType.VarChar).Value = DataMAt.Referenece;
            cmd.Parameters.Add("@descr", MySqlDbType.VarChar).Value = DataMAt.Descr;
            // Conversion du format Text en Date
            cmd.Parameters.Add("@date_instal", MySqlDbType.DateTime).Value = DataMAt.Date_instal;
            // Conversion du format Text en Int32
            cmd.Parameters.Add("@mtbf", MySqlDbType.Int32).Value = DataMAt.Mtbf;
            // Converstion du format Text en Bit
            cmd.Parameters.Add("@perime", MySqlDbType.VarChar).Value = DataMAt.Perime;
            cmd.Parameters.Add("@id_type", MySqlDbType.Int32).Value = DataMAt.Id_type;
            cmd.Parameters.Add("@id_site", MySqlDbType.Int32).Value = DataMAt.Id_site;
            cmd.Parameters.Add("@id_client", MySqlDbType.Int32).Value = DataMAt.Id_client;
            // Try / Catch pour savoir si la requete passe ou non
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le materiel " + DataMAt.Nom + " a bien été ajouté.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SupprMateriel(string id)
        {
            // Fonction permettant la suppression d'un materiel via l'id.
            var sql = "delete from materiel where id_mat = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le materiel N°" + id + " a bien été supprimé.\n", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                    "Erreur lors la suppression du materiel N° " + id + "\n Ce materiel appartient à des interventions",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ModifMat(Data_Materiels dataMat, string id)
        {
            // Fonction permettant la modification d'une intervention

            var sql =
                "update materiel set nom = @nom, referenece = @referenece, descr = @descr, date_instal = @date_instal, mtbf = @mtbf, perime = @perime, id_type = @id_type, id_site = @id_site, id_client = @id_client where id_mat = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = dataMat.Nom;
            cmd.Parameters.Add("@referenece", MySqlDbType.VarChar).Value = dataMat.Referenece;
            cmd.Parameters.Add("@descr", MySqlDbType.VarChar).Value = dataMat.Descr;
            // Conversion du format Text en Date
            cmd.Parameters.Add("@date_instal", MySqlDbType.DateTime).Value = dataMat.Date_instal;
            // Conversion du format Text en Int32
            cmd.Parameters.Add("@mtbf", MySqlDbType.Int32).Value = dataMat.Mtbf;
            // Converstion du format Text en Bit
            cmd.Parameters.Add("@perime", MySqlDbType.VarChar).Value = dataMat.Perime;
            cmd.Parameters.Add("@id_type", MySqlDbType.Int32).Value = dataMat.Id_type;
            cmd.Parameters.Add("@id_site", MySqlDbType.Int32).Value = dataMat.Id_site;
            cmd.Parameters.Add("@id_client", MySqlDbType.Int32).Value = dataMat.Id_client;
            // Try / Catch pour savoir si la requete passe ou non
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le materiel " + dataMat.Nom + " a bien été modifié \n");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EstIntervenu(string id)
        {
            var sql = "update materiel set perime = 'True' where id_mat = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.ExecuteNonQuery();
        }
    }
}