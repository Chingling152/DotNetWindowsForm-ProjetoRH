using Projeto.Modelos;

namespace Projeto.Interfaces {
    /// <summary>
    /// Classe que lida com qualquer dado relacionado tanto a Funcionarios quanto Dependentes
    /// </summary>
    interface IPessoa {
        /// <summary>
        /// Procura qualquer usuario pelo CPF
        /// </summary>
        /// <param name="cpf">CPF do usuario</param>
        /// <returns>Uma pessoa se ela existir</returns>
        Pessoa Consultar(string cpf);
    }
}
