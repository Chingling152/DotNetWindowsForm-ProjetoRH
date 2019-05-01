namespace Projeto.Modelos {
    class TipoDependencia {

        //variaveis
        private readonly long id;

        private readonly string tipoDependencia;
        
        //construtor
        public TipoDependencia(long id , string tipoDependencia) {
            this.id = id;
            this.tipoDependencia = tipoDependencia;
        }

        public override string ToString() {
            return this.tipoDependencia;
        }

    }
}
