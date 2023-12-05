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
    public partial class Carro : Form
    {
        MySqlConnection conn;
        string sql = "datasource=localhost;username=root;password=123456;database=db_concessionária";
        MySqlCommand command = new MySqlCommand();
        public Carro()
        {
            InitializeComponent();
        }

        private void SalvarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(sql);
                conn.Open();
                command.Connection = conn;
                command.CommandText = "INSERT INTO carro (nome, cor, chassi, valor) VALUE (@n, @c, @ch, @v) ";

                command.Parameters.AddWithValue("@n", txtNome.Text);
                command.Parameters.AddWithValue("@c", txtCor.Text);
                command.Parameters.AddWithValue("@ch", txtChassi.Text);
                command.Parameters.AddWithValue("@v", txtValor.Text);

                command.Prepare();
                command.ExecuteNonQuery();

                MessageBox.Show("Carro Adicionado ao estoque");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Clone();
            }
        }
    }
}
