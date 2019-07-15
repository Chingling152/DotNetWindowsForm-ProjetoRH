namespace Projeto.Modelos {
    class TipoDependencia {

        //variaveis
        public readonly long id;

        public readonly string tipoDependencia;
        
        //construtor
        public TipoDependencia(long id , string tipoDependencia) {
            this.id = id;
            this.tipoDependencia = tipoDependencia;
        }
    }
}
