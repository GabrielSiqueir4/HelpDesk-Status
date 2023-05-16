using ProjetoHelpDesk.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHelpDesk.Apresentação
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(textBoxLogin.Text, textBoxSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucessso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home hm = new Home();
                    hm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login Não encontrato, Verifique Login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
