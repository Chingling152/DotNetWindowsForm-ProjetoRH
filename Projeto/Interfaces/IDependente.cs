using Projeto.Modelos;
using System.Collections.Generic;

namespace Projeto.Interfaces {
    /// <summary>
    /// Interface que lida com dados de Dependentes
    /// </summary>
    interface IDependente  : IDao<Dependente> , IPessoa{
        /// <summary>
        /// Procura todos os dependentes de um Funcionario
        /// </summary>
        /// <param name="IDFuncionario">ID do funcionario</param>
        /// <returns>Uma lista com todos os Dependentes de um funcionario</returns>
        List<Dependente> VerDependentes(long IDFuncionario);
    }
}
