using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Senai.Projetos.Dao;
using Projeto.Senai.Projetos.Modelos;

namespace Projeto.Senai.Projetos.Forms {
    public partial class DependenciaForm : Form {

        public DependenciaForm() {
            InitializeComponent();
        }
        private void DependenciaForm_Load(object sender, EventArgs e) {
            //metodo pra preencher dados
            PrencherDados();
            //limpa pra não ter nada selecionado ao iniciar
            limpar();
        }
        private void PrencherDados() {
            DepenDao dao = new DepenDao();
            dgv_dep.DataSource = dao.Consultar();
        }
        private void limpar(){
            txt_desc.Clear();
            txt_id.Clear();
        }

        //botões

        private void btn_limpar_Click(object sender, EventArgs e) {
            limpar();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(txt_desc.Text)) {
                MessageBox.Show("Preencha A Caixa De Texto Por Favor");
            } else {
                Dependencia dep = new Dependencia() {
                    Descricao = txt_desc.Text
                };

                if(!string.IsNullOrEmpty(txt_desc.Text)) {
                    //cria um id do tipo long
                    long ID = 0;
                    //se o numero do ID puder ser convertido para um long
                    if(long.TryParse(txt_id.Text, out ID)) {
                        //seta a id do funcionario pra ID da text box
                        dep.Id = ID;
                    }
                }
                DepenDao dao = new DepenDao();
                dao.Salvar(dep);

                limpar();
                PrencherDados();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e) {
            //verifica se o valor é nulo ou vazio
            if(string.IsNullOrEmpty(txt_id.Text)) {

                string msg = "Selecione um funcionario na lista abaixo";
                string titulo = "Operação não Realizada...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else {
                //instancia um funcionario
                Dependencia dep = new Dependencia();

                //cria um id pro funcionario 
                long id = 0;

                ///converte a strind da text box id para um long
                if(long.TryParse(txt_id.Text, out id)) {
                    //atribui o id da text box ao id do funcionario
                    dep.Id = id;
                }
                //instancia a DAO (ainda n sei oq é ._.)
                DepenDao dao = new DepenDao();

                //confirmação
                DialogResult resposta = MessageBox.Show("Voce Tem Certeza Que Quer\nExcluir A Dependencia De ID : " + dep.Id, "Excluir Dependencia...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta.Equals(DialogResult.Yes)) {
                    //exclui o funcionario
                    dao.Excluir(dep);
                    MessageBox.Show("Dependencia De ID : " + dep.Id + "\nRemovida Com Sucesso");
                }
            }
            //atualiza os dados
            PrencherDados();
            limpar();
        }

        private void dgv_dep_SelectionChanged(object sender, EventArgs e) {
            if(dgv_dep.CurrentRow != null) {
                txt_id.Text = dgv_dep.CurrentRow.Cells[0].Value.ToString();
                txt_desc.Text = dgv_dep.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
