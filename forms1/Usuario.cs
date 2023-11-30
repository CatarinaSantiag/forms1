using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1

{

    internal class Usuario
    {
        private int _id;
        private string _user;
        private string _passwords;

        public Usuario
            (string user,
            string passwords)
        {
            User = user;
            Passwords = passwords;
        }
        public Usuario
            (int id, string user,
            string passwords)
        {
            Id = id;
            User = user;
            Passwords = passwords;
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

        public string Passwords
        {
            set
            {
               

                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha corretamente o campo SENHA");

                _passwords = value;

              
            }


            get { return _passwords; }
        }

    }
}
