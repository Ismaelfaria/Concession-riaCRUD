using ConcessionáriaAPI.Controller;
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
            var control = new ConcessionariaController();
            control.carregarContato(listCarro);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var control = new ConcessionariaController();
            control.deletarCarro(id);
            control.carregarContato(listCarro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var carro = new Carro();
            this.Hide();
            carro.ShowDialog();
            this.Close();
        }
    }
}
