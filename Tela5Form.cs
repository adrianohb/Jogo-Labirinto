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
    public partial class Tela5Form : Form
    {
        public Tela5Form()
        {
            InitializeComponent();
        }

        private void btnESQ5_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }

        private void btnCIMA5_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela2Form Tela2Form = new Tela2Form();
            Tela2Form.Show();
            this.Hide();
        }

        private void btnBAIXO5_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela6Form Tela6Form = new Tela6Form();
            Tela6Form.Show();
            this.Hide();
        }

        private void btnDIR5_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela4Form Tela4Form = new Tela4Form();
            Tela4Form.Show();
            this.Hide();
        }
    }
}
