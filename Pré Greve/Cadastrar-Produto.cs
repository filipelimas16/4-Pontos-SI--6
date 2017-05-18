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
    public partial class Cadastrar_Produto : Form
    {
        private Conexao con = null;// abrir o banco
        public SqlConnection ConnectOpen = null; //Abrir a conexão
        private int tipo = 0;
        private double preco;
        private int qtde;
        private int checarId;

        public Cadastrar_Produto()
        {
            InitializeComponent();
            con = new Conexao();
            ConnectOpen = con.ConectarDatabase();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string SqlCommand = "Select * from Produto where id = " + text_cod.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCommand, ConnectOpen);// Adapta os dados para linguagem SQL
            da.Fill(dt); //passa os dados para serem executados.
            if (dt.Rows.Count > 0)/*
                                 Testa se alguma linha do banco de dados foi afetada, caso
                                 não retorne, signifca que o usuário não está cadastrado.
                                 */

            {
               
                checarId = Convert.ToInt16(dt.Rows[0][2]);
                

            }

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Produto(id,nome, preco, quantidade,tipo)");
            sql.Append("Values (@id,@nome, @preco, @quantidade, @tipo)");
            switch (cmd_tipoFruta.Text)
            {
                case "Fruta":
                    tipo = 1;
                    break;
                case "Verduras":
                    tipo = 2;
                    break;
                case "Legume":
                    tipo = 3;
                    break;
            }
            SqlCommand command = null;

            try
            {
                preco = Convert.ToDouble(text_preco.Text);
                qtde = Convert.ToInt16(text_qtde.Text);
                int receberCod = Convert.ToInt16(text_cod.Text);
             if(receberCod == checarId)
                {
                    MessageBox.Show("ID Já exitente!");
                }
                else
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@id", text_cod.Text));
                    command.Parameters.Add(new SqlParameter("@nome", text_nome.Text));
                    command.Parameters.Add(new SqlParameter("@preco", preco));
                    command.Parameters.Add(new SqlParameter("@quantidade", qtde));
                    command.Parameters.Add(new SqlParameter("@tipo", tipo));
                    //utilizado para executar o comando SQL, se não tiver esse comando não insere nada no banco!
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso!");
                    Hide();
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar");
                throw;
            }
        }
    }
 }

