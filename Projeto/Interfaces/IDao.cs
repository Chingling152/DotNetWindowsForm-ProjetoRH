using System.Collections.Generic;

namespace Interfaces {
    /// <summary>
    /// Interface que lida com Alteração Cadastro e Remoção de dados
    /// </summary>
    /// <typeparam name="T">Qualquer classe que tenha ID</typeparam>
    interface IDao<T> {
        /// <summary>
        /// Cadastra um valor no banco de dados , se tiver um ID ja definido , será alterado
        /// </summary>
        /// <param name="item">Item a ser cadastrado ou alterado</param>
        void Salvar(T item);
        /// <summary>
        /// Lista todos os itens cadastrados no banco de dados
        /// </summary>
        /// <returns>Uma lista com todos os itens de uma tabela</returns>
        List<T> Consultar();
        /// <summary>
        /// Remove um item especifico do banco de dados
        /// </summary>
        /// <param name="id">ID do item a ser removido</param>
        void Excluir(long id);
        /// <summary>
        /// Procura um item baseado em seu ID
        /// </summary>
        /// <param name="id">ID do Item</param>
        /// <returns>ID da Consulta</returns>
        T Consultar(long id);
    }
}

