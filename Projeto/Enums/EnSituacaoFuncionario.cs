namespace Projeto.Enums {
    /// <summary>
    /// Enumeração que define situação dos funcionarios
    /// </summary>
    enum EnSituacaoFuncionario {
        /// <summary>
        /// Define um funcionario que esta contratado e trabalhando atualmente
        /// </summary>
        Contratado = 1,
        /// <summary>
        /// Define um usuario que esta contratado mas está de ferias
        /// </summary>
        Ferias = 2,
        /// <summary>
        /// Define um funcionario que está estagiando
        /// </summary>
        Estagio = 3,
        /// <summary>
        /// Define um funcionario demitido
        /// </summary>
        Demitido = 4,
    }
}
