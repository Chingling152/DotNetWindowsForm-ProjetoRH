using System;

namespace Projeto.Modelos {
    /// <summary>
    /// Define um dependente de um Funcionario
    /// </summary>
    class Dependente : Pessoa {
        /// <summary>
        /// ID do dependente
        /// </summary>
        public readonly long ID;

        /// <summary>
        /// Define a qual funcionario esta pessoa é dependente
        /// </summary>
        public readonly Funcionario Funcionario_;

        /// <summary>
        /// Construtor da classe dependente
        /// </summary>
        /// <param name="ID">Define o ID do dependente</param>
        /// <param name="Funcionario_">Define a qual funcionario esta pessoa é dependente</param>
        /// <param name="IDPessoa">Define o registro do dependente</param>
        /// <param name="Nome">Define o nome do dependente</param>
        /// <param name="Cpf">Define o cpf do dependente</param>
        /// <param name="Rg">Define o rg do dependente</param>
        /// <param name="Telefone">Define o telefone do dependente</param>
        /// <param name="DataNascimento">Define a data de nascimento do dependente</param>
        public Dependente(
            long ID, Funcionario Funcionario_,
            long IDPessoa, string Nome, string Cpf, string Rg, string Telefone, DateTime DataNascimento)
            : base(IDPessoa, Nome, Cpf, Rg, Telefone, DataNascimento,false) {
            this.ID = ID;
            this.Funcionario_ = Funcionario_;
        }
    }
}
