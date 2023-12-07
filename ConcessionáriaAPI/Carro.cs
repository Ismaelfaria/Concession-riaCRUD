using Microsoft.Win32;
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
        public Carro()
        {
            InitializeComponent();
        }

        private void SalvarCarro_Click(object sender, EventArgs e)
        {
            var novosCarros = new Model.ConcessionarioNovosCarros(txtNome.Text, txtCor.Text, txtChassi.Text, Convert.ToInt32(txtValor.Text));
            var control = new Controller.ConcessionariaController();
            control.adicionarCarro(novosCarros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registros registro = new Registros();
            this.Hide();
            registro.ShowDialog();
            this.Close();
        }
    }
}
