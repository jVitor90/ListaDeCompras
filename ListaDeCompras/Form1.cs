using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            if (TxtbCadastrar.Text == "")
            {
                MessageBox.Show("Digite um item para ser cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LstbListaDeCompras.Items.Add(TxtbCadastrar.Text);
                TxtbCadastrar.Clear();
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            if (LstbListaDeCompras.Items.Count > 0)
            {

                LstbListaDeCompras.Items.Clear();
                TxtbCadastrar.Clear();
            }
            else
            {
                MessageBox.Show("A lista está vazia", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstbListaDeCompras_DoubleClick(object sender, EventArgs e)
        {
            if (LstbListaDeCompras.SelectedIndex != -1)
            {

                 DialogResult resultado = MessageBox.Show("Deseja realmente excluir o item selecionado?","Excluir",
                 MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                 if (resultado == DialogResult.Yes)
                 {
                     LstbListaDeCompras.Items.RemoveAt(LstbListaDeCompras.SelectedIndex);
                 }

                 else
                 {
                     LstbListaDeCompras.SelectedIndex = -1;
                 }
            }
        }

        private void TxtbCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              BtnCadastrar.PerformClick();
            }
        }
    }
}