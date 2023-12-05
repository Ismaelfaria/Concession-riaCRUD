using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionáriaAPI
{
    public partial class Registros : Form
    {
        MySqlConnection conn;
        string sql = "datasource=localhost;username=root;password=123456;database=db_concessionária";
        private int? id = null;
        public Registros()
        {
            InitializeComponent();

            listCarro.View = View.Details;
            listCarro.LabelEdit = true;
            listCarro.AllowColumnReorder = true;
            listCarro.FullRowSelect = true;
            listCarro.GridLines = true;

            listCarro.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listCarro.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listCarro.Columns.Add("Cor", 100, HorizontalAlignment.Left);
            listCarro.Columns.Add("Chassi", 150, HorizontalAlignment.Left);
            listCarro.Columns.Add("Valor", 100, HorizontalAlignment.Left);

            carregarContatos();
        }
        
        private void listCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itemSelecionado = listCarro.SelectedItems;

            foreach (ListViewItem item in itemSelecionado)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);
            }
        }

        private void carregarContatos()
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new MySqlConnection(sql);
                conn.Open();
                MySqlCommand com = new MySqlCommand();
                com.Connection = conn;

                com.CommandText = "DELETE FROM carro WHERE id=@id ";
                com.Parameters.AddWithValue("@id", id);
                com.Prepare();
                com.ExecuteNonQuery();
                MessageBox.Show("Carro Excluido");
                carregarContatos();

            }
            catch(Exception ex)
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
