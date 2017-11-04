using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Senai.Projetos.Modelos {
    class Dependencia {

        //variaveis
        private long id;

        private string descricao;

        //encapsulamento
        public long Id {
            get { return id; }
            set { id = value; }
        }

        public string Descricao {
            get{return descricao; }
            set{descricao = value;}
        }
        
        //construtor
        public Dependencia(long id , string desc){
            this.id = id;
            this.descricao = desc;
        }

        public Dependencia(){           
        }

        public override string ToString() {
            return this.descricao;
        }

    }
}
