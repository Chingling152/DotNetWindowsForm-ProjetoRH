using System;

namespace Projeto.Modelos {

    class Dependente : Pessoa {

        public readonly long ID;
        public Funcionario Funcionario_;

        public Dependente(
            long ID, Funcionario Funcionario_,
            long IDPessoa, string Nome, string Cpf, string Rg, string Telefone, DateTime DataNascimento)
            : base(IDPessoa, Nome, Cpf, Rg, Telefone, DataNascimento) {
            this.ID = ID;
            this.Funcionario_ = Funcionario_;
        }
    }
}
