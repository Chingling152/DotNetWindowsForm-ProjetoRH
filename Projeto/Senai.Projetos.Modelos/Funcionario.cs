using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Senai.Projetos.Modelos {
    class Funcionario  {
        //variaveis
        private long id;
        private string nome;
        private string cpf;
        private string rg;
        private string email;
        private string telefone;

        //encapsulamento das variaveis
        public long ID {
            get { return id; }
            set { id = value; }
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg {
            get { return rg; }
            set { rg = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Telefone {
            get {return telefone ;}
            set{telefone = value ; }
        }

        public Funcionario(long id,string nome ,string cpf ,string rg,string email,string telefone){
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.telefone = telefone;
        }

        public Funcionario(){
        }

    }
}
