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

        public RegistroFuncionario() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            limpar();
        }

        void limpar(){
            txt_nome.Clear();
            mtxt_cpf.Clear();
            txt_rg.Clear();
            txt_email.Clear();
            mtxt_tel.Clear();
            txt_nome.Focus();
        }


        private void btn_salvar_Click(object sender, EventArgs e) {
            //instancia um funcionario

            Funcionario funcionario = new Funcionario(){
                Nome = txt_nome.Text ,
                Cpf = mtxt_cpf.Text ,
                Rg = txt_rg.Text,
                Email = txt_email.Text,
                Telefone = mtxt_tel.Text
            };

            FuncDao dao = new FuncDao();
            dao.Salvar(funcionario);

            limpar();
            PrencherDados();
        }

        private void RegistroFuncionario_Load(object sender, EventArgs e) {
            PrencherDados();
        }

        private void PrencherDados(){
            FuncDao dao = new FuncDao();
            dvg_func.DataSource = dao.Consultar();
            dvg_func.Columns["ID"].Visible = false;
            dvg_func.Columns["Rg"].Visible = false;
        }

        private void dvg_func_SelectionChanged(object sender, EventArgs e) {
            //se alguma linha for selecionada
                if(dvg_func.CurrentRow!=null){
                    //pegar o id e colocar na text box de id (pode se fazer com as outras colunas da tabela)
                    txt_id.Text = dvg_func.CurrentRow.Cells[0].Value.ToString();
                }
        }
    }
}
