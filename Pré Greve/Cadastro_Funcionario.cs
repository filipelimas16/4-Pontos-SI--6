using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hortfruit
{
    public partial class Cadastro_Funcionario : Form
    {
        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        private int cargo = 0;
        private Double salario;

        public Cadastro_Funcionario()
        {
            InitializeComponent();
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Funcionario(id,nome, salario, tipo)");
            sql.Append("Values (@id,@nome, @salario, @tipo)");
            switch (cmd_cargo.Text)
            {
                case "Gerente":
                    cargo = 1;
                    break;
                case "Operario":
                    cargo = 2;
                    break;
                case "Vendedor":
                    cargo = 3;
                    break;
            }
            SqlCommand command = null;
            try
            {
                salario = Convert.ToDouble(text_salario.Text);

                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@id", text_cod.Text));
                command.Parameters.Add(new SqlParameter("@nome", text_nome.Text));
                command.Parameters.Add(new SqlParameter("@salario", salario));
                command.Parameters.Add(new SqlParameter("@tipo", cargo));
                //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar");
                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
