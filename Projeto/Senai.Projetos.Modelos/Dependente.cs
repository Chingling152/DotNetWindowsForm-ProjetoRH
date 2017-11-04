using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Senai.Projetos.Modelos {
    class Dependente {
        //variaveis 
        private long id;
        private string nome;
        private string cpf;
        private DateTime date;

       //COMPOSIÇÃO
        private Dependencia depe;
        private Funcionario func;


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

        public Funcionario Funcionario {
            get { return func; }
            set { func = value; }
        }

        public Dependencia Dependencia {
            get { return depe; }
            set { depe = value; }
        }

        public DateTime Data {
            get { return date; }
            set { date = value; }
        }

        public Dependente(){

        }

    }
}
