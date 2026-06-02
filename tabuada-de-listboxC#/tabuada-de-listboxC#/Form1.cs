using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada_de_listboxC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Text = "Gerando tabuada...";

            int numero = Convert.ToInt32(txtNumero.Text);

            listBoxTabuada.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBoxTabuada.Items.Add(
                    numero + " x " + i + " = " + (numero * i)
                );
            } 
        }

    }
}
