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
    public partial class DependenteForm : Form {

        public DependenteForm() {
            InitializeComponent();
        }

        private void PreencheDados(){
            dgv_Depe.DataSource = new DependenteDao().Consultar();
        }

        private void PreencherCbo(){
            cbo_Depe.DataSource = new TipoDependenciaDao().Consultar();
            cbo_Depe.DisplayMember = "Descricao";

            cbo_Func.DataSource = new FuncionarioDao().Consultar();
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


           PreencheDados();
            
        }
        //BOTÃO DE LIMPAR
        private void button3_Click(object sender, EventArgs e) {
            limpar();
        }

        //BOTÃO DE EXCLUIR
        private void button1_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(txt_ID.Text)){
                string msg = "Selecione um funcionario por favor";
                string titulo = "Operação não realizada";
                MessageBox.Show(msg,titulo,MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
            }else{
                    
                if(!long.TryParse(txt_ID.Text, out long id)){
                }

                DependenteDao dao = new DependenteDao();

                DialogResult resposta = MessageBox.Show("Voce Tem Certeza Que Quer\nExcluir O Dependente De ID : " + dp.ID, "Excluir Dependente...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                    if(resposta.Equals(DialogResult.Yes)){
                        dao.Excluir(id);
                    }
                }

                //atualiza os dados
                PreencheDados();
                limpar();
            }
            
        }
    }
}
