using Projeto.Modelos;
using System.Collections.Generic;

namespace Projeto.Interfaces {
    interface IFuncionario {
        List<Funcionario> Consultar(Cargo cargo);
        List<Funcionario> Consultar(double salarioMin,double salarioMax);
        Funcionario ConsultarDependentes(int ID);
    }
}
