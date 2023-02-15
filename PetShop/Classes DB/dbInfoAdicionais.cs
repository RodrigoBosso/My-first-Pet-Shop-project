using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PetShop
{
    class dbInfoAdicionais
    {
        private conexaoMySql connCor = new conexaoMySql();
        private Int32 connRetorno;

        public DataTable selectClienteDBaseGrid()
        {
            DataTable dtCliente = new DataTable();
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();

            adapterCor = selectClienteDBase();
            adapterCor.Fill(dtCliente);

            return dtCliente;
        }

        public MySqlDataAdapter selectClienteDBase()
        {
            MySqlDataAdapter adapterCliente = new MySqlDataAdapter();
            string sql = "SELECT * FROM cliente;";

            connRetorno = connCor.executaSQL(sql.ToString());
            adapterCliente = connCor.retornaSQL(sql);

            return adapterCliente;
        }

        public DataTable selectEspecieDBaseGrid()
        {
            DataTable dtEspecie = new DataTable();
            MySqlDataAdapter adapterEspecie = new MySqlDataAdapter();

            adapterEspecie = selectEspecieDBase();
            adapterEspecie.Fill(dtEspecie);

            return dtEspecie;
        }

        public MySqlDataAdapter selectEspecieDBase()
        {
            MySqlDataAdapter adapterEspecie = new MySqlDataAdapter();
            string sql = "SELECT * FROM especie;";

            connRetorno = connCor.executaSQL(sql.ToString());
            adapterEspecie = connCor.retornaSQL(sql);

            return adapterEspecie;
        }

        public DataTable selectRacaDBaseGrid()
        {
            DataTable dtRaca = new DataTable();
            MySqlDataAdapter adapterRaca = new MySqlDataAdapter();

            adapterRaca = selectRacaDBase();
            adapterRaca.Fill(dtRaca);

            return dtRaca;
        }

        public MySqlDataAdapter selectRacaDBase()
        {
            MySqlDataAdapter adapterRaca = new MySqlDataAdapter();
            string sql = "SELECT * FROM raca;";

            connRetorno = connCor.executaSQL(sql.ToString());
            adapterRaca = connCor.retornaSQL(sql);

            return adapterRaca;
        }

    }
}
