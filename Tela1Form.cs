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
    public partial class Tela1Form : Form
    {
        public Tela1Form()
        {
            InitializeComponent();
        }

        private void btnESQ1_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela2Form Tela2Form = new Tela2Form();
            Tela2Form.Show();
            this.Hide();
        }

        private void btnCIMA1_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }

        private void btnBAIXO1_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }

        private void btnDIR1_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela4Form Tela4Form = new Tela4Form();
            Tela4Form.Show();
            this.Hide();
        }
    }
}
