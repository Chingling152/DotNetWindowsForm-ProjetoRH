using Projeto.Modelos;

namespace Projeto.Interfaces {
    interface IPessoa {
        Pessoa Consultar(string cpf);
    }
}
