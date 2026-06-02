using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_visualC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Text = "Sua calculadora visual!!! ";

            var numero1 = Convert.ToDouble(txtNumero1.Text);
            var numero2 = Convert.ToDouble(txtNumero2.Text);

            var resultado = numero1 + numero2;

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            var numero1 = Convert.ToDouble(txtNumero1.Text);
            var numero2 = Convert.ToDouble(txtNumero2.Text);

            var resultado = numero1 - numero2;

            lblResultado.Text = "Seu resultado é " + resultado;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            var numero1 = Convert.ToDouble(txtNumero1.Text);
            var numero2 = Convert.ToDouble(txtNumero2.Text);

            var resultado = numero1 * numero2;

            lblResultado.Text = "Seu resultado é? " + resultado;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            var numero1 = Convert.ToDouble(txtNumero1.Text);
            var numero2 = Convert.ToDouble(txtNumero2.Text);

            if (numero2 != 0)
            {
                var resultado = numero1 / numero2;
                lblResultado.Text = "Seu resultado é? " + resultado;
            }
            else
            {
                MessageBox.Show("Não é possível dividir por zero.");
            }
        }
    }
    
}
