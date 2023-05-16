using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoHelpDesk.DAL
{
     class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conec = new Conexao();
        SqlDataReader dr;

        
        public bool verificarLogin(String login, String senha)
        {
            // esse metodo verifica no banco de dados se tem email e senha e retornar um bool de verdadeiro ou falso 
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conec.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conec.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confirmSenha)
        {
            if (senha.Equals(confirmSenha))
            {
                cmd.CommandText = "insert into logins values(@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                
                try{
                    
                    cmd.Connection = conec.conectar();
                    cmd.ExecuteNonQuery();
                    conec.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                }
                catch(SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados!";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }

            return mensagem;
        }
    }  
    }


