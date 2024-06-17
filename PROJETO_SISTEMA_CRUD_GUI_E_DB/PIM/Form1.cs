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

namespace PIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button;
        }

        private void textBox_senha_login_TextChanged(object sender, EventArgs e)
        {
            textBox_senha_login.PasswordChar = '*';
        }

        private void button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
            string email, senha;

            email = textBox_email_login.Text;
            senha = textBox_senha_login.Text;

            try
            {
                string query = "SELECT * FROM tb_usuario WHERE email = '" + textBox_email_login.Text + "' AND senha = '" + textBox_senha_login.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    email = textBox_email_login.Text;
                    senha = textBox_senha_login.Text;
                    Form_menu_principal tela = new Form_menu_principal();
                    this.Hide();
                    tela.Show();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos.Tente Novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_email_login.Clear();
                    textBox_senha_login.Clear();

                    textBox_email_login.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Dados inseridos incorretos.Tente novamente.");
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_criarconta tela = new Form_criarconta();
            tela.Show();
        }
    }
}
