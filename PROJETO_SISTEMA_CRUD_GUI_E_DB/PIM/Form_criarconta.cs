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

namespace PIM
{
    public partial class Form_criarconta : Form
    {
        public Form_criarconta()
        {
            InitializeComponent();
        }

        private void button_criarconta_Click(object sender, EventArgs e)
        {
            const string textboxvazio = "   /   /   -";

            if (String.IsNullOrEmpty(nome.Text) ||
                datanascimento.MaskedTextProvider.ToDisplayString() == "__ / __ / ____" ||
                String.IsNullOrEmpty(email.Text) ||
                String.IsNullOrEmpty(senha.Text) ||
                String.IsNullOrEmpty(sexo.Text) ||
                cpf.Text == textboxvazio ||
                String.IsNullOrEmpty(rg.Text)
                )
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s).Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome.Clear();
                datanascimento.Clear();
                email.Clear();
                senha.Clear();
                cpf.Clear();
                rg.Clear();

                nome.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_usuario (nome,email,idade,RG,CPF,sexo,senha) VALUES (@nome,@email,@idade,@RG,@CPF,@sexo,@senha)", con);
                con.Open();



                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("idade", datanascimento.Text);
                cmd.Parameters.AddWithValue("@RG", rg.Text);
                cmd.Parameters.AddWithValue("@CPF", cpf.Text);
                cmd.Parameters.AddWithValue("sexo", sexo.GetItemText(sexo.SelectedItem));
                cmd.Parameters.AddWithValue("@senha", senha.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Conta criada com sucesso!retornando ao menu inicial...");
                this.Close();
                Form1 telainicial = new Form1();
                telainicial.Show();
            }
        }

        private void Form_criarconta_Load(object sender, EventArgs e)
        {

        }

        private void datanascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
