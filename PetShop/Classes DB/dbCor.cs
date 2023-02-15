using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PetShop
{
    class dbCor
    {
        private conexaoMySql connCor = new conexaoMySql();
        private Int32 connRetorno;

        public void insereCorDBase(string cor)
        {
            string sql = "INSERT INTO cor(cornome) VALUE('" + cor.ToString() + "');";

            connRetorno = connCor.executaSQL(sql.ToString());

        }

        public void excluiCorDBase(Int16 codCor)
        {
            string sql = "DELETE FROM cor WHERE"+ codCor.ToString() +";" ;

            connRetorno = connCor.executaSQL(sql.ToString());
        }

        public void alteraCorDBase(string cor, Int16 codCor)
        {
            string sql = "UPDATE cor SET cornome ='" + cor.ToString() + "' WHERE corid = " + codCor.ToString() + ";";

            connRetorno = connCor.executaSQL(sql.ToString());
        }

        public DataTable selectCorDBaseGrid()
        {
            DataTable dtCor = new DataTable();
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();

            adapterCor = selectCorDBase();
            adapterCor.Fill(dtCor);

            return dtCor;
        }

        public MySqlDataAdapter selectCorDBase()
        {
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();
            string sql = "SELECT * FROM cor;";

            connRetorno = connCor.executaSQL(sql.ToString());
            adapterCor = connCor.retornaSQL(sql);

            return adapterCor;
        }
        public MySqlDataAdapter selectCorDBase(Int16 codCor)
        {
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();
            string sql = "SELECT cornome FROM cor WHERE corid =" + codCor + ";";

            connRetorno = connCor.executaSQL(sql.ToString());
            adapterCor = connCor.retornaSQL(sql);

            return adapterCor;
        }


        public void setcor(string corse) 
        {
            this.cor = corse ;
        }

        public string getcor()
        {
            return (this.cor) ;
         }

       
    }
}
