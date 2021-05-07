using System.Data;
using System.Windows.Forms;
using GestionMatos.Data;
using MySql.Data.MySqlClient;

namespace GestionMatos.Fonctions
{
    internal class Fcts_Clients
    {
        public static void AjouterClient(Data_Clients dataClient)
        {
            var sql = "insert into client (id_client, nom, adresse) values (NULL, @nom, @adresse)";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.Text).Value = dataClient.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.Text).Value = dataClient.Adresse;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion du client : " + dataClient.Nom + " réussie.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'insertion : " + ex.Message, "");
            }
        }

        public static void SupprClient(string id)
        {
            // Fonction permettant la supression d'un client via l'id selectionné
            var sql = "delete from client where id_client = @Id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client N°" + id + " a bien été supprimé.\n", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                    "Le client n° " + id +
                    " est lié à un materiel étant en cours de maintenance.\nVeuillez supprimer les interventions en cours.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ModifierClient(Data_Clients dataClient, string id)
        {
            // Fonction permettant la supression d'un client via l'id selectionné
            var sql = "update client set nom = @nom, adresse = @adresse where id_client = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = dataClient.Nom;
            cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = dataClient.Adresse;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client " + dataClient.Nom + " a bien été modifié.\n", "Information",
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