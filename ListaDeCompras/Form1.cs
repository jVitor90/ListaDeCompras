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
            //Verificar se o textbox não está vazio
            if (TxtbCadastrar.Text == "")
            {
                //Mostra um messagebox de erro 
                MessageBox.Show("Digite um item para ser cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Adiciona um item a lista e limpa o textbox
                LstbListaDeCompras.Items.Add(TxtbCadastrar.Text);
                TxtbCadastrar.Clear();
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Verifica se o lista contém itens ou não
            if (LstbListaDeCompras.Items.Count == 0)
            {
               //Mostra mensagem de erro caso não contenha itens na lista 
               MessageBox.Show("A lista está vazia", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //Limpar listbox e o textbox
                LstbListaDeCompras.Items.Clear();
                TxtbCadastrar.Clear();
            }
        }

        private void LstbListaDeCompras_DoubleClick(object sender, EventArgs e)
        {

            //Verificar se não existe um item selecionado no listbox
            if (LstbListaDeCompras.SelectedIndex != -1)
            {
                //Mostra uma messagebox para confirmar se o usuario deseja apagar o item 
                 DialogResult resultado = MessageBox.Show("Deseja realmente excluir o item selecionado?","Excluir",
                 MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                 if (resultado == DialogResult.Yes)
                 {
                    //Apaga o item selecionado
                     LstbListaDeCompras.Items.RemoveAt(LstbListaDeCompras.SelectedIndex);
                 }

                 else
                 {
                    //Desseleciona item 
                     LstbListaDeCompras.SelectedIndex = -1;
                 }
            }
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Encerrar o programa
            Application.Exit();
        }

        private void TxtbCadastrar_KeyDown_1(object sender, KeyEventArgs e)
        {
            //Adiciona o item a lista usando a tecla "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                BtnCadastrar.PerformClick();
            }
        }

        private void TxtbCadastrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Não permitir que o usuario escreva numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}