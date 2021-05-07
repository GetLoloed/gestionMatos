using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionMatos.Fonctions
{
    internal class Fcts_DB
    {
        public static MySqlConnection GetConnection()
        {
            // Fonction permettant de se connecter à la base de données MySQL.
            var sql = "datasource=localhost;port=3306;username=root;password=;database=gestionmatos;";
            var connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL erreur \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }

        public static MySqlDataReader ExecuteReader(string sql)
        {
            // Fonction pour réduire le code lors de l'utilisation du Reader
            try
            {
                var con = GetConnection();
                MySqlDataReader reader;
                var cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static void AffichNRech(string query, DataGridView dgv)
        {
            // Fonction permettant de récupérer les données d'une table et de les afficher dans une DataGridView.

            var sql = query;
            var con = GetConnection();
            var cmd = new MySqlCommand(sql, con);
            var adp = new MySqlDataAdapter(cmd);
            var tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


        public static void ComboData(string query, string member, string value, ComboBox cb)
        {
            // Fonction permettant de récupérer les données pour les afficher dans une Combobox

            var sql = query;
            var con = GetConnection();
            var cmd = new MySqlCommand(sql, con);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cb.DisplayMember = member; // Nom de l'item
            cb.ValueMember = value; // Valeur de l'item
            cb.DataSource = dt; // Provenance des données
        }
    }
}