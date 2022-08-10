using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void localizacao_Click(object sender, EventArgs e)
        {
            Form fu = new Form();
            fu.ShowDialog();
        }

        private void localizacao_Click_1(object sender, EventArgs e)
        {
            Curiosidades fu = new Curiosidades();
            fu.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            avaliacao fu = new avaliacao();
            fu.ShowDialog();
        }
    }
}
