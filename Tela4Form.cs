using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Labirinto
{
    public partial class Tela4Form : Form
    {
        public Tela4Form()
        {
            InitializeComponent();
        }

        private void btnESQ4_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela1Form Tela1Form = new Tela1Form();
            Tela1Form.Show();
            this.Hide();
        }

        private void btnCIMA4_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela6Form Tela6Form = new Tela6Form();
            Tela6Form.Show();
            this.Hide();
        }

        private void btnBAIXO4_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela5Form Tela5Form = new Tela5Form();
            Tela5Form.Show();
            this.Hide();
        }

        private void btnDIR4_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }
    }
}
