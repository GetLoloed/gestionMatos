using System.Data;
using System.Windows.Forms;
using GestionMatos.Data;
using MySql.Data.MySqlClient;

namespace GestionMatos.Fonctions
{
    internal class Fcts_Interventions
    {
        public static void AjoutInter(Data_Interventions dataInter)
        {
            // Fonction permettant l'insertion d'une nouvelle intervention
            var sql =
                "insert into intervention (id_intervention, dateInter, com, id_mat) values (NULL, @dateinter, @com, @id_mat)";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@dateinter", MySqlDbType.DateTime).Value = dataInter.DateInter; // Date d'intervention
            cmd.Parameters.Add("@com", MySqlDbType.VarChar).Value = dataInter.Com; // Commentaire
            cmd.Parameters.Add("@id_mat", MySqlDbType.Int32).Value = dataInter.Id_mat; // Id du materiel
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention programmée !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SupprInter(string id)
        {
            // Fonction permettant la suppression d'une intervention

            var sql = "delete from intervention where id_intervention = @Id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention N° " + id + " deprogrammée.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ModifInter(Data_Interventions dataInter, string id)
        {
            // Fonction permettant la modification d'une intervention

            var sql =
                "update intervention set dateInter = @dateInter, com = @com ,id_mat = @id_mat where id_intervention = @id";
            var con = Fcts_DB.GetConnection();
            var cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@dateinter", MySqlDbType.DateTime).Value = dataInter.DateInter;
            cmd.Parameters.Add("@com", MySqlDbType.VarChar).Value = dataInter.Com;

            // Conversion du format text en Int
            cmd.Parameters.Add("@id_mat", MySqlDbType.Int32).Value = dataInter.Id_mat;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification de l'intervation N° " + id + " terminé");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Intervenu(string id)
        {
            var sql = "UPDATE intervention SET finie = 'True' WHERE intervention.id_intervention = @id; ";
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