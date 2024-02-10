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
    public partial class TelainicialForm : Form
    {
        public TelainicialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre a tela inicial
            Tela1Form Tela1Form = new Tela1Form();
            Tela1Form.Show();
            this.Hide();
        }
    }
}
