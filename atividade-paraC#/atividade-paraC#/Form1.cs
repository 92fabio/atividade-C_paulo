using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_paraC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Text = "Faça seu login!!! ";

            var nomeUsuario = textNomeUsuario.Text;
            var senhaUsuario = textSenhaUsuario.Text;


            if (nomeUsuario == "fabio furtado" && senhaUsuario == "1234")
            {
                MessageBox.Show("Login realizado com sucesso...");
            }
            else
            {
                MessageBox.Show("Algo deu errado");
            } 
        }
    }
}
