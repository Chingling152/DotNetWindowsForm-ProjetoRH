using System;

namespace Projeto.Modelos {
    class Funcao {
        public readonly long ID;
        public readonly string Descricao;
        public readonly TimeSpan CargaHoraria;
        public readonly Cargo cargo;

        public Funcao(long ID, string Descricao, TimeSpan CargaHoraria, Cargo cargo) {
            this.ID = ID;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.cargo = cargo;
        }
    }
}
