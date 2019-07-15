using Projeto.Enums;
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
        public readonly Funcao Funcao_;
        public readonly EnSituacaoFuncionario Situacao;

        public Funcionario(long id,long idPessoa, string nome, string cpf, string rg, string email, string telefone,DateTime dataNascimento,Funcao funcao,double salario,EnSituacaoFuncionario situacao) :
            base(idPessoa,nome,cpf,rg,telefone,dataNascimento,true){
            this.ID = id;
            this.Email = email;
            this.Salario = salario;
            this.Funcao_ = funcao;
            this.Situacao = situacao;
        }

        public override string ToString() {
            return Nome;
        }
    }
}
