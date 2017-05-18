using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hortfruit
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
         
           
            Produtos produto = new Produtos();
            produto.MdiParent = this;
            produto.Show();
            this.toolStripStatusLabel1.Text = "Produto";
           

        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario func = new Cadastro_Funcionario();
            func.MdiParent = this;
            func.Show();
            this.toolStripStatusLabel1.Text = "Cadastrar Funcionario";
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void tela3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto produto = new Cadastrar_Produto();
            produto.MdiParent = this;
            produto.Show();
            this.toolStripStatusLabel1.Text = "Cadastrar Produto";
        }

        private void tela4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.MdiParent = this;
            contato.Show();
            this.toolStripStatusLabel1.Text = "Contatos";
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alunos aluno= new Alunos();
            aluno.MdiParent = this;
            aluno.Show();
            this.toolStripStatusLabel1.Text = "Alunos Participantes";
        }
    }
}
