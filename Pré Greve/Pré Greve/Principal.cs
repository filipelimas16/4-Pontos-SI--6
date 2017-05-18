using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pré_Greve
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_1 frmTela1 = new Tela_1();
            frmTela1.MdiParent = this;
            frmTela1.Show();

            this.toolStripStatusLabel1.Text = "Tela 1";
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_2 frmTela2 = new Tela_2();
            frmTela2.MdiParent = this;
            frmTela2.Show();

            this.toolStripStatusLabel1.Text = "Tela 2";
        }
    }
}
