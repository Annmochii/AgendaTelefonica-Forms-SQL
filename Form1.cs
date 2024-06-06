using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula20240606AgendaTelefonica
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Aula20240606;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                conexao.Open();
                var selectCmd = conexao.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Contato;";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read()) 
                {
                    /*Console.WriteLine("Nome: " + leitorDados["Nome"] + "Sobrenome: " + leitorDados["Sobrenome"]);

                    dataGridView1.DataSource.Add();*/
                    

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                conexao.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
