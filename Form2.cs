using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_MALI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bnt_trocar_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.ShowDialog();
        }

        private void bnt_encriptar_Click(object sender, EventArgs e)
        {
            string converter = "";
            int numero = 0;
            txtbox_mali.Text = String.Empty;
            for (int i = 0; i < txtbox_humano.Text.Length; i++)
            {
                numero += + 1;
                if (numero > 3) numero = 1;
                if (i >= 0) converter = txtbox_humano.Text.Substring(i, 1);

                txtbox_mali.Text += Encriptar.EncriptarTexto(converter, Convert.ToString(numero));
            }
            MessageBox.Show(Convert.ToString(numero));
        }
    }
}
