using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificador_Maior_idadeC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Text = "Verifique o seu ano de nascimento";

            int anoNascimento = Convert.ToInt32(txtAnoNascimento.Text);

            int idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 18)
            {
                this.BackColor = Color.Green;
                MessageBox.Show("Maior de idade");
            }
            else
            {
                this.BackColor = Color.Red;
                MessageBox.Show("Menor de idade");
            } 
        }
    }
}
