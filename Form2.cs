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
            txtbox_humano.Text = String.Empty;
            txtbox_mali.Text = String.Empty;
        }

        private void bnt_encriptar_Click(object sender, EventArgs e)
        {
            List<string> lixo = new List<string>();

            string[] letras = new string[] { "*a", "¨5", "85", "6ç", "@9", "0_", "*%", "[=", "6+", "$7", "´9", "9+", "!v", "8d", "4o", "#7", "-*", "?u", "C#", "^~", "G4", "+i"};
            lixo.AddRange(letras);

            if (txtbox_humano.Text != "")
            {
                string converter = "";
                int numero = 0, nlixo = 0;
                txtbox_mali.Text = String.Empty;
                for (int i = 0; i < txtbox_humano.Text.Length; i++)
                {
                    numero += 1;
                    if (numero > 3) numero = 1;
                    nlixo += 1;
                    if (nlixo > 21) nlixo = 0;
                    if (i >= 0) converter = txtbox_humano.Text.Substring(i, 1);
                    txtbox_mali.Text += Encriptar.EncriptarTexto(converter, Convert.ToString(numero)) + lixo[nlixo];
                }
                txtbox_humano.Text = String.Empty;
            }
            else
            {
                string converter = "";
                txtbox_humano.Text = String.Empty;
                for (int i = 0; i < txtbox_mali.Text.Length; i += 2)
                {
                    if (i >= 0) converter = txtbox_mali.Text.Substring(i, 2);
                    txtbox_humano.Text += Decriptar.DecriptarTexto(converter);
                }
                txtbox_mali.Text = String.Empty;
            }

            
        }

        private void txtbox_humano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
