using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Senai.Projetos.Modelos;
using Projeto.Senai.Projetos.Dao;

namespace Projeto.Senai.Projetos.Forms {
    public partial class DependenteForm : Form {

        public DependenteForm() {
            InitializeComponent();
        }

        private void PreencheDados(){
            dgv_Depe.DataSource = new DependenteDao().Consultar();
        }

        private void PreencherCbo(){
            cbo_Depe.DataSource = new DepenDao().Consultar();
            cbo_Depe.DisplayMember = "Descricao";

            cbo_Func.DataSource = new FuncDao().Consultar();
            cbo_Func.DisplayMember = "Nome";
        }

        private void limpar(){
            txt_ID.Clear();
            txt_Cpf.Clear();
            dtp_Data.Value = DateTime.Today;
            txt_Nome.Clear();
            PreencherCbo();
            txt_Cpf.Focus();
        }

        private void dgv_Depe_SelectionChanged(object sender, EventArgs e) {
            //TextBox = DataGridView.Linha.CelulaDaColuna.Valor.String;
            txt_ID.Text = dgv_Depe.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = dgv_Depe.CurrentRow.Cells[1].Value.ToString();
            txt_Cpf.Text = dgv_Depe.CurrentRow.Cells[2].Value.ToString();
            cbo_Func.Text = dgv_Depe.CurrentRow.Cells[3].Value.ToString();
            cbo_Depe.Text = dgv_Depe.CurrentRow.Cells[4].Value.ToString();
            dtp_Data.Value = (DateTime)dgv_Depe.CurrentRow.Cells[5].Value;
        }

        private void DependenteForm_Load(object sender, EventArgs e) {
            PreencheDados();
            PreencherCbo();
            limpar();
        }

        //BOTÃO DE SALVAR
        private void button2_Click(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(txt_Nome.Text) ||
               string.IsNullOrEmpty(txt_Cpf.Text)){
                MessageBox.Show("Por Favor Preencha Todos Os Dados", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                //cria um objeto do tipo dependente
                Dependente dependente = new Dependente{
                    Nome = txt_Nome.Text,
                    Cpf = txt_Cpf.Text,
                    Data = dtp_Data.Value,                  
                };

                if(!string.IsNullOrEmpty(txt_ID.Text)) {
                    //cria um id do tipo long
                    long ID = 0;
                    //se o numero do ID puder ser convertido para um long
                    if(long.TryParse(txt_ID.Text, out ID)) {
                        //seta a id do funcionario pra ID da text box
                        dependente.ID = ID;
                    }
                }
                Dependencia dependencia = (Dependencia)cbo_Depe.SelectedItem;
                Funcionario func = (Funcionario)cbo_Func.SelectedItem;
                dependente.Funcionario = func;
                dependente.Dependencia = dependencia;
                DependenteDao dao = new DependenteDao();
                dao.Salvar(dependente);  
                
                PreencheDados();
            }
            
        }
        //BOTÃO DE LIMPAR
        private void button3_Click(object sender, EventArgs e) {
            limpar();
        }
        //BOTÃO DE EXCLUIR
        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
