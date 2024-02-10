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
    public partial class Tela3Form : Form
    {
        public Tela3Form()
        {
            InitializeComponent();
        }

        private void btnDIR3_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }

        private void btnESQ3_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela2Form Tela2Form = new Tela2Form();
            Tela2Form.Show();
            this.Hide();
        }

        private void btnCIMA3_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela1Form Tela1Form = new Tela1Form();
            Tela1Form.Show();
            this.Hide();
        }

        private void btnBAIXO3_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela4Form Tela4Form = new Tela4Form();
            Tela4Form.Show();
            this.Hide();
        }
    }

   
}
