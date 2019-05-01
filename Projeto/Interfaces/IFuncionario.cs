using Projeto.Modelos;
using System.Collections.Generic;

namespace Projeto.Interfaces {
    interface IFuncionario {
        List<Funcionario> Consultar(Cargo cargo);
    }
}
