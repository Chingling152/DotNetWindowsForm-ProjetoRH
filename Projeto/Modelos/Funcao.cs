using System;

namespace Projeto.Modelos {
    class Funcao {
        public readonly long ID;
        public readonly string Descricao;
        public readonly TimeSpan CargaHoraria;
        public readonly long IDCargo;

        public Funcao(long ID, string Descricao, TimeSpan CargaHoraria, long IDCargo) {
            this.ID = ID;
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
            this.IDCargo = IDCargo;
        }
    }
}
