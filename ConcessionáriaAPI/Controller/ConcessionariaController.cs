using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionáriaAPI.Controller
{
    internal class ConcessionariaController
    {
        MySqlConnection conn;
        string sql = ConfigurationManager.AppSettings["databaseInformation"];
        MySqlCommand com = new MySqlCommand();

        public void adicionarCarro(Model.ConcessionarioNovosCarros novoCarro)
        {
            try
            {
                conn = new MySqlConnection(sql);
                conn.Open();
                com.Connection = conn;
                com.CommandText = "INSERT INTO carro (nome, cor, chassi, valor) VALUES (@n, @c, @ch, @v) ";

                com.Parameters.AddWithValue("@n", novoCarro.nome);
                com.Parameters.AddWithValue("@c", novoCarro.cor);
                com.Parameters.AddWithValue("@ch", novoCarro.chassi);
                com.Parameters.AddWithValue("@v", novoCarro.valor);

                com.Prepare();
                com.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void deletarCarro(int? id)
        {
            try
            {
                conn = new MySqlConnection(sql);
                conn.Open();
                com.Connection = conn;
                com.CommandText = "DELETE FROM carro WHERE id=@id ";
                com.Parameters.AddWithValue("@id", id);
                com.Prepare();
                com.ExecuteNonQuery();
                MessageBox.Show("Carro Excluido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void carregarContato(ListView listCarro)
        {
            try
            {
                conn = new MySqlConnection(sql);
                conn.Open();
                MySqlCommand com = new MySqlCommand();
                com.Connection = conn;

                com.CommandText = "SELECT * FROM carro ORDER BY id DESC ";
                com.Prepare();

                MySqlDataReader reader = com.ExecuteReader();
                listCarro.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linhaRegistro = new ListViewItem(row);
                    listCarro.Items.Add(linhaRegistro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
