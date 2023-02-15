using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace PetShop
{
    class conexaoMySql
    {
        private MySqlConnection conexao;
        private MySqlCommand command;


        private void conectaBaseDados() 
        {
 
            conexao = new MySqlConnection("server=localhost;uid=root;database=petshop;pwd=b!#Csxuhk#p6");
           
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        // Desconecta do banco de dados
        private void desconectaBaseDados()
        {
            conexao.Close();
        }

        // implementar opcoes de trratamento de erros
        // o return 0 significa que tudo ocorreu bem
        public Int32 executaSQL(string instrucaoSQL)
        {

            conectaBaseDados();

            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();

            desconectaBaseDados();
            return 0;
        }

        public MySqlDataAdapter retornaSQL(String instrucaoSQL)
        {
            conectaBaseDados();
            MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao);
            desconectaBaseDados();
            return adapter;
        }

    }

}

