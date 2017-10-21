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
            
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            //instancia um funcionario

            Funcionario funcionario = new Funcionario(){
                Nome_ = txt_nome.Text ,
                Cpf_ = mtxt_cpf.Text ,
                Rg_ = txt_rg.Text,
                Email_ = txt_email.Text,
                Telefone_ = mtxt_tel.Text
            };

            FuncDao dao = new FuncDao();
            dao.Salvar(funcionario);

        }
    }
}
