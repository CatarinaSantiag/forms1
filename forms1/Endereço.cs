using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace forms1

{

    internal class Endereço
    {
        private int _id;
        private string _user;
        private string _cep;
        private string _numero;
        private string _rua;
        private string _bairro;
        private string _cidade;
        private string _estado;
        public Endereço
            (int id,
            string user,
            string cep,
            string numero,
            string rua,
            string bairro,
            string cidade,
            string estado)
        {
            Id = id;
            User = user;
            Cep = cep;
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public int Id
        {
            set
            {
                _id = value;
            } //atribuicao de valor

            get { return _id; } //retornar o valor 
        }
        public string User
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo USER");

                _user = value;
            } //atribuicao de valor

            get { return _user; } //retornar o valor 
        }

        public string Cep
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo CEP");

                _cep = value;
            }
            get { return _cep; }
        }
        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo NUMERO");

                _numero = value;
            }
            get { return _numero; }
        }
        public string Rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo RUA");

                _rua = value;
            }
            get { return _rua; }
        }
        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo BAIRRO");

                _bairro = value;
            }
            get { return _bairro; }
        }
        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo CIDADE");

                _cidade = value;
            }
            get { return _cidade; }
        }
        public string Estado
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo ESTADO");

                _estado = value;
            }
            get { return _estado; }
        }
    }
}
