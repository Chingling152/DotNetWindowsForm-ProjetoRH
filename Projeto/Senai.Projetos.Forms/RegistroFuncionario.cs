using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Senai.Projetos.Forms;
using Projeto.Senai.Projetos.Modelos;
using Projeto.Senai.Projetos.Dao;

namespace Projeto.Senai.Projetos.Forms {
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
            //verifica se o valor é nulo ou vazio
            if(string.IsNullOrEmpty(txt_id.Text)) {

                string msg = "Selecione um funcionario na lista abaixo";
                string titulo = "Operação não Realizada...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else {
                //instancia um funcionario
                Funcionario fun = new Funcionario();

                //cria um id pro funcionario 
                long id = 0;

                ///converte a strind da text box id para um long
                if(long.TryParse(txt_id.Text, out id)) {
                    //atribui o id da text box ao id do funcionario
                    fun.ID = id;
                }
                //instancia a DAO (ainda n sei oq é ._.)
                FuncDao dao = new FuncDao();

                //confirmação
                DialogResult resposta =  MessageBox.Show("Voce Tem Certeza Que Quer\nExcluir O Funcionario De ID : " + fun.ID, "Excluir Funcionario...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta.Equals(DialogResult.Yes)) {
                    //exclui o funcionario
                    dao.Excluir(fun);
                    MessageBox.Show("Funcionario De ID : " + fun.ID + "\nRemovido Com Sucesso");
                }
            }
            //atualiza os dados
            PrencherDados();
            limpar();
        }

        //botão salvar
        private void btn_salvar_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(txt_nome.Text) ||
               string.IsNullOrEmpty(mtxt_cpf.Text) || 
               string.IsNullOrEmpty(txt_rg.Text)   || 
               string.IsNullOrEmpty(txt_email.Text)|| 
               string.IsNullOrEmpty(mtxt_tel.Text))
            {
                MessageBox.Show("Por Favor Preencha Todos Os Dados","Exceção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else{       
                //instancia um funcionario
                Funcionario funcionario = new Funcionario() {
                    Nome = txt_nome.Text,
                    Cpf = mtxt_cpf.Text,
                    Rg = txt_rg.Text,
                    Email = txt_email.Text,
                    Telefone = mtxt_tel.Text
                };

                //OBTEM O ID DO FUNCIONARIO SE O TEXTBOX NÃO ESTIVER VAZIO
                if(!string.IsNullOrEmpty(txt_id.Text)) {
                    //cria um id do tipo long
                    long ID = 0;
                    //se o numero do ID puder ser convertido para um long
                    if(long.TryParse(txt_id.Text, out ID)) {
                        //seta a id do funcionario pra ID da text box
                        funcionario.ID = ID;
                    }
                }

                //cria um novo objeto DAO 
                FuncDao dao = new FuncDao();
                dao.Salvar(funcionario);

                //LIMPA E PREENCHE OS DADOS
                limpar();
                PrencherDados();
            }
        }

        // evento de seleção do dvg_func
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

        //metodo pra preencher dados
        private void PrencherDados() {
            FuncDao dao = new FuncDao();
            dvg_func.DataSource = dao.Consultar();
            dvg_func.Columns["Rg"].Visible = false;
        }

        //metodo pra limpar as text boxes
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
            Funcionario fun = new FuncDao().Consulta(cpf);

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
