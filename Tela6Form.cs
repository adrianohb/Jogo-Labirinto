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
    public partial class Tela6Form : Form
    {
        public Tela6Form()
        {
            InitializeComponent();
        }

        private void btnESQ6_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela7Form Tela7Form = new Tela7Form();
            Tela7Form.Show();
            this.Hide();
        }

        private void btnCIMA6_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela5Form Tela5Form = new Tela5Form();
            Tela5Form.Show();
            this.Hide();
        }

        private void btnBAIXO6_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela4Form Tela4Form = new Tela4Form();
            Tela4Form.Show();
            this.Hide();
        }

        private void btnDIR6_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela5Form Tela5Form = new Tela5Form();
            Tela5Form.Show();
            this.Hide();
        }
    }
}
