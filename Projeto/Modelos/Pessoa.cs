using System;
namespace Projeto.Modelos {
    class Pessoa {

        public readonly long IDPessoa;
        public readonly string Nome;                //celula 1
        public readonly string Cpf;                 //celula 2
        public readonly string Rg;                 //celula 3
        public readonly string Telefone;           //celula 5
        public readonly DateTime DataNascimento;    //celula 6
        public readonly bool Funcionario;

        public Pessoa(long IDPessoa, string Nome, string Cpf, string Rg, string Telefone, DateTime DataNascimento,bool Funcionario) {
            this.IDPessoa = IDPessoa;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.Telefone = Telefone;
            this.DataNascimento = DataNascimento;
            this.Funcionario = Funcionario;
        }
    }
}
