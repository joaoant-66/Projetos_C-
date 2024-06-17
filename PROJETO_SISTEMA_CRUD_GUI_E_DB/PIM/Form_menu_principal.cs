using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Form_menu_principal : Form
    {
        public Form_menu_principal()
        {
            InitializeComponent();
        }

        private void button_cadastrocliente_Click(object sender, EventArgs e)
        {
            //leva a área de cadastro de cliente...
            Form_Cadastro_cliente cadastro = new Form_Cadastro_cliente();
            this.Hide();
            cadastro.Show();

        }

        private void button_pesquisarcliente_Click(object sender, EventArgs e)
        {
            //Leva a área de pesquisa de cliente...
            Form_Pesquisa_cliente pesquisa = new Form_Pesquisa_cliente();
            this.Hide();
            pesquisa.Show();
        }

        private void button_atualizar_dados_cliente_Click(object sender, EventArgs e)
        {
            //leva a área de atualização de dados do cliente...
            form_update_dados_cliente update = new form_update_dados_cliente();
            this.Hide();
            update.Show();

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do programa ?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Obrigado por utilizar o programa! até mais.");
                Application.Exit();
            }
        }

        private void Form_menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
