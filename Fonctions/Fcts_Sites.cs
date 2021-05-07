using GestionMatos.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GestionMatos.Fonctions
{
    class Fcts_Sites
    {
                public static void AjouterSite(Data_Sites dataSite)
        {
            // Fonction permettant l'ajout d'un nouveau site.
            var sql =
                "insert into site (id_site, nom, adresse, cp, ville) values (NULL, @nom, @adresse, @cp, @ville)";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.Text).Value = dataSite.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.Text).Value = dataSite.Adresse;
            cmd.Parameters.Add("@cp", MySqlDbType.Text).Value = dataSite.Cp;
            cmd.Parameters.Add("@ville", MySqlDbType.Text).Value = dataSite.Ville;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion du site : " + dataSite.Nom + " réussie.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'insertion : " + ex.Message, "");
            }
        }

        public static void SupprSite(string id)
        {
            // Fonction permettant la supression d'un site via l'id selectionné
            var sql = "delete from site where id_site = @Id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le site N° " + id + " a bien été supprimé.\n", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors la suppression du site N° " + id + "\n" + ex.Message, "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ModifierSite(Data_Sites dataSite, string id)
        {
            // Fonction permettant la supression d'un site via l'id selectionné
            var sql = "update site set nom = @nom, adresse = @adresse, cp = @cp, ville = @ville where id_site = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nom", MySqlDbType.Text).Value = dataSite.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.Text).Value = dataSite.Adresse;
            cmd.Parameters.Add("@cp", MySqlDbType.Text).Value = dataSite.Cp;
            cmd.Parameters.Add("@ville", MySqlDbType.Text).Value = dataSite.Ville;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le site " + dataSite.Nom + " a bien été modifié.\n", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la modification " + ex.Message, "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
