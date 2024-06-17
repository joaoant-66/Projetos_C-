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
    public partial class form_update_dados_cliente : Form
    {
        public form_update_dados_cliente()
        {
            InitializeComponent();
        }
        //comando que realiza a atualização do nome do cliente,baseado no ID dele...
        private void update_nome_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(novo_nome.Text))
            {
                MessageBox.Show("Campo de Nome vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                novo_nome.Clear();
                novo_nome.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set nome = @nome WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@nome", novo_nome.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de nome atualizado com sucesso!", "Sucesso!");
                novo_nome.Clear();
                con.Close();
            }
        }
        //comando que realiza a atualização do CPF do cliente, baseado no ID dele...
        private void update_cpf_Click(object sender, EventArgs e)
        {
            const string textboxvazio = "   /   /   -"; //Variável que possui a máscara do textbox
            if (textBox_update_cpf_cliente.Text == textboxvazio) //compara a máscara vazia com o texto do textbox, se sim gera erro.
            {
                MessageBox.Show("Campo de CPF vazio. Tente novamente.","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_update_cpf_cliente.Clear();
                textBox_update_cpf_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set CPF = @CPF WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@CPF", textBox_update_cpf_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de CPF atualizado com sucesso!", "Sucesso!");
                textBox_update_cpf_cliente.Clear();
                con.Close();
            }
        }
        //comando que realiza a atualização do RG do cliente, baseado no ID dele...
        private void update_rg_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_update_rg_cliente.Text))
            {
                MessageBox.Show("Campo de RG vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_update_rg_cliente.Clear();
                textBox_update_rg_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set RG = @RG WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@RG", textBox_update_rg_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de RG atualizado com sucesso!", "sucesso");
                textBox_update_rg_cliente.Clear();
                con.Close();

            }
        }
        //comando que realiza a atualização da data de nascimento do cliente, baseado no ID dele...
        private void update_datanascimento_Click(object sender, EventArgs e)
        {
            const string datanascimentovazia = "  /  /"; //Variável que possui a máscara do textbox
            if (maskedTextBox_update_datanascimento.Text == datanascimentovazia) //compara a máscara vazia com o texto do textbox, se sim gera erro.
            {
                MessageBox.Show("Campo de Data de nascimento vazia. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox_update_datanascimento.Clear();
                maskedTextBox_update_datanascimento.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set datanascimento = @datanascimento WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@datanascimento", maskedTextBox_update_datanascimento.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de data de nascimento atualizado com sucesso!", "Sucesso!");
                maskedTextBox_update_datanascimento.Clear();
                con.Close();

            }

        }
        //comando que realiza a atualização do sexo do cliente, baseado no ID dele...
        private void update_sexo_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(comboBox_sexo_cliente.Text))
            {
                MessageBox.Show("Campo de Sexo vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_sexo_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set sexo = @sexo WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@sexo", comboBox_sexo_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de sexo atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }
        //comando que realiza a atualização do CEP do cliente, baseado no ID dele...
        private void update_cep_Click(object sender, EventArgs e)
        {
            const string CEP_vazio = "     -"; //Variável que possui a máscara do textbox
            if (textBox_CEP_cliente.Text == CEP_vazio) //compara a máscara vazia com o texto do textbox, se sim gera erro.
            {
                MessageBox.Show("Campo de CEP vazio. Tente Novamente.","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CEP_cliente.Clear();
                textBox_CEP_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set CEP = @CEP WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@CEP", textBox_CEP_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de CEP atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }
        //comando que realiza a atualização do endereço do cliente, baseado no ID dele...
        private void update_endereco_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_endereco_cliente.Text))
            {
                MessageBox.Show("Campo de endereço vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_endereco_cliente.Clear();
                textBox_endereco_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set endereco = @endereco WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@endereco", textBox_endereco_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de endereço atualizado com sucesso!", "Sucesso!");
                con.Close();
            }

        }
        //comando que realiza a atualização das condiçoes médicas do cliente, baseado no ID dele...
        private void update_comorbidades_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_comorbidades_cliente.Text))
            {
                MessageBox.Show("Campo de condições médicas vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_comorbidades_cliente.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set condicoes_medicas = @condicoes_medicas WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@condicoes_medicas", textBox_comorbidades_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de condições médicas atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }
        //comando que realiza a atualização da forma de pagamento do cliente, baseado no ID dele...
        private void update_formapagamento_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(comboBox_metodo_pagamento_cliente.Text))
            {
                MessageBox.Show("Campo de forma de pagamento vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_metodo_pagamento_cliente.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set forma_pagamento = @forma_pagamento WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@forma_pagamento", comboBox_metodo_pagamento_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de forma de pagamento atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }
        //comando que realiza a atualização da data de pagamento do cliente,baseado no ID dele...
        private void update_datapagamento_Click(object sender, EventArgs e)
        {
            const string datapagamento_vazio = "  /  /";
            if(maskedTextBox_data_pagamento_cliente.Text == datapagamento_vazio)
            {
                MessageBox.Show("Campo de data de pagamento vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox_data_pagamento_cliente.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set data_pagamento = @data_pagamento WHERE Id = @Id ", con);
                cmd.Parameters.AddWithValue("@data_pagamento", maskedTextBox_data_pagamento_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de data de pagamento atualizada com sucesso!", "Sucesso!");
                con.Close();

            }

        }
        //comando que realiza a atualização do cliente, baseado no ID dele...
        private void update_valormensalidade_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_valor_mensalidade_cliente.Text))
            {
                MessageBox.Show("Campo de valor da mensalidade vazio. Tente novamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_valor_mensalidade_cliente.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set valor_mensalidade = @valor_mensalidade WHERE Id = @Id ", con);
                cmd.Parameters.AddWithValue("@valor_mensalidade", Convert.ToDecimal(textBox_valor_mensalidade_cliente.Text));
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de valor da mensalidade atualizada com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_nomebeneficiario_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_nome_beneficiario1.Text))
            {
                MessageBox.Show("Campo de nome do Beneficiário 1 vazio. Tente novamente.");
                textBox_nome_beneficiario1.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set beneficiario_nome1 = @beneficiario_nome1 WHERE Id = @Id",con);
                cmd.Parameters.AddWithValue("@beneficiario_nome1", textBox_nome_beneficiario1.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de nome do beneficiário 1 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_cpfbeneficiario_Click(object sender, EventArgs e)
        {
            const string textboxvazio_cpf = "   /   /   -"; //Variável que possui a máscara do textbox
            if(textBox_CPF_beneficiario1.Text == textboxvazio_cpf)
            {
                MessageBox.Show("Campo de CPF do beneficiário 1 vazio. Tente Novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CPF_beneficiario1.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set CPF_beneficiario1 = @CPF_beneficiario1 WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@CPF_beneficiario1", textBox_CPF_beneficiario1.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de CPF do beneficiário 1 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_rgbeneficiario_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_RG_beneficiario1.Text))
            {
                MessageBox.Show("Campo de RG do beneficiário 1 vazio. Tente Novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_RG_beneficiario1.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set RG_beneficiario1 = @RG_beneficiario1 WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("RG_beneficiario1", textBox_RG_beneficiario1.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de RG do beneficiário 1 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_nomebeneficiario2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_nome_beneficiario2.Text))
            {
                MessageBox.Show("Campo de nome do beneficiário 2 vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nome_beneficiario2.Focus();


            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set beneficiario_nome2 = @beneficiario_nome2 WHERE Id = @Id",con);
                cmd.Parameters.AddWithValue("@beneficiario_nome2", textBox_nome_beneficiario2.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de nome do beneficiário 2 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_cpfbeneficiario2_Click(object sender, EventArgs e)
        {
            const string textbox_vazio = "   /   /   -";
            if(textbox_vazio ==  textBox_CPF_beneficiario2.Text)
            {
                MessageBox.Show("Campo de CPF do beneficiario 2 vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CPF_beneficiario2.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set CPF_beneficiario2 = @CPF_beneficiario2 WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@CPF_beneficiario2", textBox_CPF_beneficiario2.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de CPF do beneficiario 2 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_rgbeneficiario2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_RG_beneficiario2.Text))
            {
                MessageBox.Show("Campo de RG do beneficiario 2 vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_RG_beneficiario2.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set RG_beneficiario2 = @RG_beneficiario2 WHERE Id = @Id ", con);
                cmd.Parameters.AddWithValue("@RG_beneficiario2", textBox_RG_beneficiario2.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de RG do beneficiário 2 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void update_nomebeneficiario3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_nome_beneficiario3.Text))
            {
                MessageBox.Show("Campo de nome do beneficiário 3 vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nome_beneficiario3.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set beneficiarionome3 = @beneficiarionome3 WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@beneficiarionome3", textBox_nome_beneficiario3.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de nome do beneficiário 3 atualizado com sucesso!", "Sucesso!");
                con.Close();


            }

        }

        private void update_cpfbeneficiario3_Click(object sender, EventArgs e)
        {
            const string textbox_vazio = "   /   /   -";
            if(textbox_vazio == textBox_CPF_beneficiario3.Text)
            {
                MessageBox.Show("Campo de CPF do beneficiário 3 vazio. Tente novamente.","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CPF_beneficiario3.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set CPF_beneficiario3 = @CPF_beneficiario3 WHERE Id = @Id",con);
                cmd.Parameters.AddWithValue("@CPF_beneficiario3", textBox_CPF_beneficiario3.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de CPF do beneficiário 3 atualizado com sucesso!", "Sucesso!");
                con.Close();
            }

        }

        private void update_rgbeneficiario3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_RG_beneficiario3.Text))
            {
                MessageBox.Show("Campo de RG do beneficiário 3 vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_RG_beneficiario3.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set RG_beneficiario3 = @RG_beneficiario3 WHERE Id = @Id",con);
                cmd.Parameters.AddWithValue("@RG_beneficiario3", textBox_RG_beneficiario3.Text);
                cmd.Parameters.AddWithValue("@Id",textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de RG do beneficiário 3 atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }

        private void button_update_cliente_Click(object sender, EventArgs e)
        {
            //Retorno ao menu principal...
            Form_menu_principal tela = new Form_menu_principal();
            this.Hide();
            tela.Show();
        }
        //comando que realiza o update do status do cliente
        private void button_status_cliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox_status_cliente.Text))
            {
                MessageBox.Show("Campo do status do cliente vazio. Tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_status_cliente.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9E400OI;Initial Catalog=DB_prototipo;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente set status = @status WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@status", comboBox_status_cliente.Text);
                cmd.Parameters.AddWithValue("@Id", textBox_id_cliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Campo de status do cliente atualizado com sucesso!", "Sucesso!");
                con.Close();

            }

        }
    }
}
