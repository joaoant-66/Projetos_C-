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
    public partial class Form_Cadastro_cliente : Form
    {
        public Form_Cadastro_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checa se os espaços obrigatorios foram preenchidos,caso eles não foram,o usuario tenta novamente.
            if (String.IsNullOrEmpty(textBox_nome_cliente.Text) ||
                String.IsNullOrEmpty(textBox_cpf_cliente.Text) ||
                String.IsNullOrEmpty(textBox_rg_cliente.Text) ||
                maskedTextBox_datanascimento.MaskedTextProvider.ToDisplayString() == "__ / __ / ____" ||
                String.IsNullOrEmpty(comboBox_sexo_cliente.Text) ||
                String.IsNullOrEmpty(textBox_CEP_cliente.Text) ||
                String.IsNullOrEmpty(textBox_endereco_cliente.Text) ||
                String.IsNullOrEmpty(comboBox_metodo_pagamento_cliente.Text) ||
                maskedTextBox_data_pagamento_cliente.MaskedTextProvider.ToDisplayString() == "__ / __ / ____" ||
                String.IsNullOrEmpty(textBox_valor_mensalidade_cliente.Text)
                )
            {
                MessageBox.Show("Campo(s) obrigatórios vazio(s).Tente Novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nome_cliente.Clear();
                textBox_cpf_cliente.Clear();
                textBox_rg_cliente.Clear();
                maskedTextBox_datanascimento.Clear();
                textBox_CEP_cliente.Clear();
                textBox_endereco_cliente.Clear();
                maskedTextBox_data_pagamento_cliente.Clear();
                textBox_valor_mensalidade_cliente.Clear();

                textBox_nome_beneficiario1.Clear();
                textBox_CPF_beneficiario1.Clear();
                textBox_RG_beneficiario1.Clear();

                textBox_nome_beneficiario2.Clear();
                textBox_CPF_beneficiario2.Clear();
                textBox_RG_beneficiario2.Clear();

                textBox_nome_beneficiario3.Clear();
                textBox_CPF_beneficiario3.Clear();
                textBox_RG_beneficiario3.Clear();

                textBox_nome_cliente.Focus();


            }
            else
            {
                //realização da conexão com o banco de dados...
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_cliente (status,nome,sexo,datanascimento," +
                    "CPF,RG,CEP,endereco,condicoes_medicas,beneficiario_nome1,CPF_beneficiario1," +
                    " RG_beneficiario1, beneficiario_nome2, CPF_beneficiario2," +
                    " RG_beneficiario2, beneficiarionome3, CPF_beneficiario3," +
                    " RG_beneficiario3,forma_pagamento,data_pagamento,valor_mensalidade) VALUES (@status,@nome,@sexo,@datanascimento,@CPF,@RG,@CEP,@endereco,@condicoes_medicas,@beneficiario_nome1,@CPF_beneficiario1,@RG_beneficiario1,@beneficiario_nome2,@CPF_beneficiario2,@RG_beneficiario2,@beneficiarionome3,@CPF_beneficiario3,@RG_beneficiario3,@forma_pagamento,@data_pagamento,@valor_mensalidade)", con);

                con.Open();
                //inserção de dados do cliente
                cmd.Parameters.AddWithValue("@status", "OPEN");
                cmd.Parameters.AddWithValue("@nome", textBox_nome_cliente.Text);
                cmd.Parameters.AddWithValue("@sexo", comboBox_sexo_cliente.GetItemText(comboBox_sexo_cliente.SelectedItem));
                cmd.Parameters.AddWithValue("@datanascimento", maskedTextBox_datanascimento.Text);
                cmd.Parameters.AddWithValue("@CPF", textBox_cpf_cliente.Text);
                cmd.Parameters.AddWithValue("@RG", textBox_rg_cliente.Text);
                cmd.Parameters.AddWithValue("@CEP", textBox_CEP_cliente.Text);
                cmd.Parameters.AddWithValue("@endereco", textBox_endereco_cliente.Text);
                cmd.Parameters.AddWithValue("@condicoes_medicas", textBox_comorbidades_cliente.Text);

                //dados OPCIONAIS do beneficiário 1:
                cmd.Parameters.AddWithValue("@beneficiario_nome1", textBox_nome_beneficiario1.Text);
                cmd.Parameters.AddWithValue("@CPF_beneficiario1", textBox_CPF_beneficiario1.Text);
                cmd.Parameters.AddWithValue("@RG_beneficiario1", textBox_RG_beneficiario1.Text);

                //dados OPCIONAIS do beneficiário 2:
                cmd.Parameters.AddWithValue("@beneficiario_nome2", textBox_nome_beneficiario2.Text);
                cmd.Parameters.AddWithValue("@CPF_beneficiario2", textBox_CPF_beneficiario2.Text);
                cmd.Parameters.AddWithValue("@RG_beneficiario2", textBox_RG_beneficiario2.Text);

                //dados OPCIONAIS do beneficiário 3:
                cmd.Parameters.AddWithValue("@beneficiarionome3", textBox_nome_beneficiario3.Text);
                cmd.Parameters.AddWithValue("@CPF_beneficiario3", textBox_CPF_beneficiario3.Text);
                cmd.Parameters.AddWithValue("@RG_beneficiario3", textBox_RG_beneficiario3.Text);

                //dados de pagamento do cliente:
                cmd.Parameters.AddWithValue("@forma_pagamento", comboBox_metodo_pagamento_cliente.GetItemText(comboBox_metodo_pagamento_cliente.SelectedItem));
                cmd.Parameters.AddWithValue("@data_pagamento", maskedTextBox_data_pagamento_cliente.Text);
                cmd.Parameters.AddWithValue("@valor_mensalidade", Convert.ToDecimal(textBox_valor_mensalidade_cliente.Text));

                cmd.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Apólice do cliente cadastrado com sucesso! Deseja cadastrar outro cliente?", "Sucesso!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    //realiza o cadastro novamente
                    this.Hide();
                    Form_Cadastro_cliente tela_cadastro = new Form_Cadastro_cliente();
                    tela_cadastro.Show();
                }
                else if(dialogResult == DialogResult.No)
                {
                    //leva ao menu principal...
                    this.Hide();
                    Form_menu_principal tela_principal = new Form_menu_principal();
                    tela_principal.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_menu_principal tela = new Form_menu_principal();
            this.Hide();
            tela.Show();
        }
    }
}
