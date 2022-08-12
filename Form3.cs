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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bnt_voltar_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void bnt_decriptar_Click(object sender, EventArgs e)
        {
            string converter = "";
            txtbox_humano.Text = String.Empty;
            for (int i = 0; i < txtbox_mali.Text.Length; i += 2)
            {
                if (i >= 0) converter = txtbox_mali.Text.Substring(i, 2);
                txtbox_humano.Text += Decriptar.DecriptarTexto(converter);
            }
        }
    }
}
