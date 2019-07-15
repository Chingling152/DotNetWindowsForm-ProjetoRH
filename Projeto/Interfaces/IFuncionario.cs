using Projeto.Modelos;
using System.Collections.Generic;

namespace Projeto.Interfaces {
    /// <summary>
    /// Interface que lida com dados somente relativos a Funcionarios
    /// </summary>
    interface IFuncionario : IDao<Funcionario>, IPessoa{
        /// <summary>
        /// Busca um grupo de funcionarios pelo cargo
        /// </summary>
        /// <param name="cargo">Cargo do funcionario</param>
        /// <returns>Uma lista de usuarios com o mesmo cargo</returns>
        List<Funcionario> Consultar(Cargo cargo);
        /// <summary>
        /// Procura um grupo de funcionarios com salario entre 2 valores
        /// </summary>
        /// <param name="salarioMin">Menor salario a ser procurado</param>
        /// <param name="salarioMax">Maior salario a ser procurado</param>
        /// <returns>Uma lista com todos os funcionarios com o salario entre os 2 valores inseridos por parametro</returns>
        List<Funcionario> Consultar(double salarioMin,double salarioMax);
    }
}
