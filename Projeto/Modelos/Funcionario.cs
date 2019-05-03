using System;
using System.Collections.Generic;

namespace Projeto.Modelos {
    class Funcionario : Pessoa{
        //variaveis 
        /* Trocar a ordem irá afetar a tabela no datagrid view*/
        public readonly long ID;                    //celula 0
        public readonly string Email ;              //celula 4
        public List<Dependente> Dependentes;
        public readonly double Salario;

        public Funcionario(long id, string nome, string cpf, string rg, string email, string telefone,DateTime dataNascimento,Cargo cargo,double salario) :
            base(id,nome,cpf,rg,telefone,dataNascimento,true){
            this.ID = id;
            this.Email = email;
            this.Salario = salario;
        }

        public override string ToString() {
            return Nome;
        }
    }
}
