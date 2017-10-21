using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Senai.Projetos.Dao {
    interface IDao<T> {
        void Salvar(T t);
        List<T> Consultar();
        void Excluir(T t);
    }
}

