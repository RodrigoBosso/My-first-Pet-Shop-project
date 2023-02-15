using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PetShop
{
    class dbAnimal
    {
        private Int32 connRetorno;
        private conexaoMySql connAnimal = new conexaoMySql();

        public void insereAnimalDBase(string nomeAnimal, int clienteID, int racaID, int especieID, int corID,
            DateTime dataNascimento, int sexo, DateTime dataCadastro, int adotado, string temperamento, int tamanho, string observacao,
            double peso, string foto)
        {
            string sql = "insert into animal(clienteid,racaid,especieid,corid,animalnome,animaldatanascimento," +
                "animalsexo,animaldatacadastro,animaladotado,animaltemperamento,animaltamanho,animalobservacao," +
                "animalpeso,animalfoto) value(" + clienteID + "," + racaID + "," + especieID + "," + corID + ",'" + nomeAnimal.ToString() + "'," +
                "'" + DateTime.Parse(dataNascimento.ToShortDateString().ToString()).ToString("yyyy/MM/dd") + "'" +
                "," + sexo + ",'" + DateTime.Parse(dataCadastro.ToShortDateString().ToString()).ToString("yyyy/MM/dd") + "'," +
                adotado + ",'" + temperamento + "'," + tamanho + ",'" + observacao + "'" +
                "," + peso + ",'" + foto + "');";
            connRetorno = connAnimal.executaSQL(sql.ToString());

        }

        public void excluiAnimalDBase(Int16 codAnimal)
        {
            string sql = "delete from animal where animalid = " + codAnimal + ";";
            connRetorno = connAnimal.executaSQL(sql.ToString());
        }

        public void alteraAnimalDBase(int animalID, string nomeAnimal, int clienteID, int racaID, int especieID, int corID,
            DateTime dataNascimento, int sexo, DateTime dataCadastro, int adotado, string temperamento, int tamanho, string observacao,
            double peso, string foto)
        {
            string sql = "UPDATE animal SET clienteid = " + clienteID + ",racaid = " + racaID + ",especieid = " + especieID + "," +
                "corid = " + corID + ",animalnome = '" + nomeAnimal.ToString() + "',animaldatanascimento = '" + DateTime.Parse(dataNascimento.ToShortDateString().ToString()).ToString("yyyy/MM/dd") + "'," +
                "animalsexo =" + sexo + ",animaldatacadastro = '" + DateTime.Parse(dataCadastro.ToShortDateString().ToString()).ToString("yyyy/MM/dd") + "'," +
                "animaladotado = " + adotado + ",animaltemperamento = '" + temperamento.ToString() + "',animaltamanho = " + tamanho + "," +
                "animalobservacao ='" + observacao.ToString() + "',animalpeso = " + peso + ",animalfoto = '" + foto.ToString() + "'WHERE animalid =" + animalID + ";";
            connRetorno = connAnimal.executaSQL(sql.ToString());
        }

        public MySqlDataAdapter selectAnimalDBase()
        {
            MySqlDataAdapter adapterAnimal = new MySqlDataAdapter();

            string sql = "SELECT animalid, animalnome FROM animal;";
            connRetorno = connAnimal.executaSQL(sql.ToString());
            adapterAnimal = connAnimal.retornaSQL(sql);

            return adapterAnimal;
        }

        public DataTable selectAnimalDBaseGrid()
        {
            DataTable dtAnimal = new DataTable();
            MySqlDataAdapter adapterAnimal = new MySqlDataAdapter();

            adapterAnimal = selectAnimalDBase();
            adapterAnimal.Fill(dtAnimal);

            return dtAnimal;
        }

       
        public MySqlDataAdapter selectAnimalDBase(Int16 codAnimal)
        {
            MySqlDataAdapter adapterAnimal = new MySqlDataAdapter();

            string sql = "SELECT animalid,animalnome,corid,racaid,animalsexo,especieid,clienteid,animaldatanascimento" +
                ",animaldatacadastro,animaladotado,animaltemperamento,animalpeso,animaltamanho,animalobservacao" +
                ",animalfoto FROM animal WHERE animalid="+ codAnimal +";" ;
            connRetorno = connAnimal.executaSQL(sql.ToString());
            adapterAnimal = connAnimal.retornaSQL(sql);

            return adapterAnimal;
        }


        public void setAnimal(string nomeAnimal, int clienteID, int racaID, int especieID, int corID,
            DateTime dataNascimento, int sexo, DateTime dataCadastro, int adotado, string temperamento, int tamanho, string observacao,
            double peso, string foto)
        {
            this.nomeAnimal     = nomeAnimal;
            this.clienteID      = clienteID;
            this.racaID         = racaID;
            this.especieID      = especieID;
            this.corID          = corID;
            this.dataNascimento = dataNascimento;
            this.sexo           = sexo;
            this.dataCadastro   = dataCadastro;
            this.adotado        = adotado;
            this.temperamento   = temperamento;
            this.tamanho        = tamanho;
            this.observacao     = observacao;
            this.peso           = peso;
            this.foto           = foto;
        }

        public string getAnimal()
        {
            return (this.(string nomeAnimal, int clienteID, int racaID, int especieID, int corID,
            DateTime dataNascimento, int sexo, DateTime dataCadastro, int adotado, string temperamento, int tamanho, string observacao,
            double peso, string foto));
        }


    }
}
