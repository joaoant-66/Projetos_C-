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
    public partial class Form_Pesquisa_cliente : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Form_Pesquisa_cliente()
        {
            InitializeComponent();
        }

        private void Form_Pesquisa_cliente_Load(object sender, EventArgs e)
        {

        }

        private void button_pesquisa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM tb_cliente", con);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView_pesquisa.DataSource = dt;
        }

        private void button_ver_clientes_online_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM tb_cliente WHERE status = 'OPEN' ", con);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView_pesquisa.DataSource = dt;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM tb_cliente WHERE status = 'CLOS' ", con);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView_pesquisa.DataSource = dt;

        }

        private void button_pesquisa_nome_cliente_Click(object sender, EventArgs e)
        {
            string string_procura = textBox_nome_pesquisa.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM tb_cliente WHERE nome LIKE '%"+ textBox_nome_pesquisa.Text+"%'  ",con);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView_pesquisa.DataSource = dt;

            textBox_nome_pesquisa.Clear();


        }

        private void pictureBox_voltar_Click(object sender, EventArgs e)
        {
            //Retorno ao menu principal...
            Form_menu_principal tela = new Form_menu_principal();
            this.Hide();
            tela.Show();
        }
    }
}
