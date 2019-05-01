using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Modelos;
using Projeto.Dao;

namespace Projeto.Forms {
    public partial class RegistroFuncionario : Form {
        //start do form
        public RegistroFuncionario() {
            InitializeComponent();
        }

        //evento load do form
        private void RegistroFuncionario_Load(object sender, EventArgs e) {
            PrencherDados();
            limpar();
        }

        //botão excluir
        private void button1_Click(object sender, EventArgs e) {
            //atualiza os dados
            PrencherDados();
            limpar();
        }

        //botão salvar
        private void btn_salvar_Click(object sender, EventArgs e) {

                dao.Salvar(funcionario);

                //LIMPA E PREENCHE OS DADOS
                limpar();
                PrencherDados();
        }

        /// <summary>
        /// Evento de seleção de alguma linha do dataView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvg_func_SelectionChanged(object sender, EventArgs e) {
            //se alguma linha for selecionada
            if(dvg_func.CurrentRow != null) {
                //pegar o id e colocar na text box de id (pode se fazer com as outras colunas da tabela(MAS EU N QUERO >.<))
                txt_id.Text = dvg_func.CurrentRow.Cells[0].Value.ToString();
                txt_nome.Text = dvg_func.CurrentRow.Cells[1].Value.ToString();
                mtxt_cpf.Text = dvg_func.CurrentRow.Cells[2].Value.ToString();
                txt_rg.Text = dvg_func.CurrentRow.Cells[3].Value.ToString();
                txt_email.Text = dvg_func.CurrentRow.Cells[4].Value.ToString();
                mtxt_tel.Text = dvg_func.CurrentRow.Cells[5].Value.ToString();
            }
        }

        /// <summary>
        /// Metodo para prencher dados
        /// </summary>
        private void PrencherDados() {
            FuncionarioDao dao = new FuncionarioDao();
            dvg_func.DataSource = dao.Consultar();
            dvg_func.Columns["Rg"].Visible = false;
        }

        /// <summary>
        /// Limpa todas as TextBoxes
        /// </summary>
        void limpar() {
            txt_id.Clear();
            txt_nome.Clear();
            mtxt_cpf.Clear();
            txt_rg.Clear();
            txt_email.Clear();
            mtxt_tel.Clear();
            txt_nome.Focus();
        }

        private void mtxt_cpf_Leave(object sender, EventArgs e) {
            //pega o valor da text box e armazena na var cpf
            string cpf = mtxt_cpf.Text;
            
            //cria um objeto do tipo funcionario que é igual à um novo objeto do tipo funcDao 
            //executa o metodo consulta com o parametro cpf e armazena na var fun
            Funcionario fun = new FuncionarioDao().Consulta(cpf);

            //se a variavel fun não for nula

            if(fun!=null){
                txt_id.Text = fun.ID.ToString();
                txt_nome.Text = fun.Nome;
                txt_email.Text = fun.Email;
                mtxt_tel.Text = fun.Telefone;
                txt_rg.Text = fun.Rg;
            }

        }

    }
}
