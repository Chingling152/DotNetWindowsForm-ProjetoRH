namespace Projeto.Modelos {
    /// <summary>
    /// Define um cargo ocupado por um ou mais Funcionarios
    /// </summary>
    class Cargo {
        /// <summary>
        /// Representa o ID do Cargo
        /// </summary>
        public readonly long ID;
        /// <summary>
        /// Representa o cargo do usuario
        /// </summary>
        public readonly string Nome;
        /// <summary>
        /// Construtor da classe Cargos
        /// </summary>
        /// <param name="ID">ID do Cargo</param>
        /// <param name="Nome">Nome do cargo</param>
        public Cargo(long ID, string Nome) {
            this.ID = ID;
            this.Nome = Nome;
        }
    }
}
