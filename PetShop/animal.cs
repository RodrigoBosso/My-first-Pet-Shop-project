using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class animal
    {
        private int animalID;
        private string nomeAnimal;
        private int cor;
        private int raca;
        private int sexo;
        private int especie;
        private int cliente;
        private DateTime dataNascimento;
        private DateTime dataCadastro;
        private int adotado;
        private string temperamento;
        private double peso;
        private int tamanho;
        private string observacao;
        private string foto;

        public void setAnimalID(int value) {
            animalID = value;
        }
        public int getAnimalID() {
            return animalID;
        }

        public void setnomeAnimal(string value)
        {
            nomeAnimal = value;
        }
        public string getnomeAnimal()
        {
            return nomeAnimal;
        }

        public void setCor(int value)
        {
            cor = value;
        }
        public int getCor()
        {
            return cor;
        }

        public void setRaca(int value)
        {
            raca = value;
        }
        public int getRaca()
        {
            return raca;
        }

        public void setSexo(int value)
        {
            sexo = value;
        }
        public int getSexo()
        {
            return sexo;
        }

        public void setEspecie(int value)
        {
            especie = value;
        }
        public int getEspecie()
        {
            return especie;
        }

        public void setCliente(int value)
        {
            cliente = value;
        }
        public int getCliente()
        {
            return cliente;
        }

        public void setAnimalDataNascimento(DateTime value)
        {
            dataNascimento = value;
        }

        public DateTime getAnimalDataNascimento()
        {
            return dataNascimento;
        }

        public void setAnimalDataCadastro(DateTime value)
        {
            dataCadastro= value;
        }

        public DateTime getAnimalDataCadastro()
        {
            return dataCadastro;
        }

        public void setAdotado(int value)
        {
            adotado = value;
        }
        public int getAdotado()
        {
            return adotado;
        }

        public void setTemperamento(string value)
        {
            temperamento = value;
        }
        public string getTemperamento()
        {
            return temperamento;
        }

        public void setPeso(double value)
        {
            peso = value;
        }
        public double getPeso()
        {
            return peso;
        }

        public void setTamanho(int value)
        {
            tamanho = value;
        }
        public int getTamanho()
        {
            return tamanho;
        }

        public void setObservacao(string value)
        {
            observacao = value;
        }
        public string getObservacao()
        {
            return observacao;
        }

        public void setFoto(string value)
        {
            foto = value;
        }
        public string getFoto()
        {
            return foto;
        }
    }
}
