using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Senai.Projetos.Modelos {
    class Funcionario {
        //variaveis 
        /* Trocar a ordem irá afetar a tabela no datagrid view*/
        private long id;          //celula 0
        private string nome;      //celula 1
        private string cpf;       //celula 2
        private string rg;        //celula 3
        private string email;     //celula 4
        private string telefone;  //celula 5

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
            get { return telefone; }
            set { telefone = value; }
        }

        public Funcionario(long id, string nome, string cpf, string rg, string email, string telefone) {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.telefone = telefone;
        }

        public Funcionario() {
        }

        public override string ToString() {
            return this.nome;
        }
    }
}
