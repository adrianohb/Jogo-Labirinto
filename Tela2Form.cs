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
    public partial class Tela2Form : Form
    {
        public Tela2Form()
        {
            InitializeComponent();
        }

        private void btnESQ2_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela5Form Tela5Form = new Tela5Form();
            Tela5Form.Show();
            this.Hide();
        }

        private void btnDIR2_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela4Form Tela4Form = new Tela4Form();
            Tela4Form.Show();
            this.Hide();
        }

        private void btnCIMA2_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela1Form Tela1Form = new Tela1Form();
            Tela1Form.Show();
            this.Hide();
        }

        private void btnBAIXO2_Click(object sender, EventArgs e)
        {
            //Abre a próxima tela
            Tela3Form Tela3Form = new Tela3Form();
            Tela3Form.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns, resposta correta!");
            btnBAIXO2.Enabled = true;
            btnCIMA2.Enabled = true;
            btnDIR2.Enabled = true;
            btnESQ2.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Opssss, resposta errada!");
            checkBox1.Checked = false;  
           
        }
    }
}
