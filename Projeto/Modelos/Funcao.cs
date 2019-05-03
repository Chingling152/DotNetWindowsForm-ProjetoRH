using System;

namespace Projeto.Modelos {
    class Funcao {
        public readonly long ID;
        public readonly string Descricao;
        public readonly TimeSpan CargaHoraria;
        public readonly long IDFuncionario;

        public Funcao(long ID, string Descricao, TimeSpan CargaHoraria, long IDFuncionario) {
            this.ID = ID;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.IDFuncionario = IDFuncionario;
        }
    }
}
