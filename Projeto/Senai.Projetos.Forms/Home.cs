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

namespace Projeto {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }
        //BOTÃO SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult dialogo = MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if(dialogo.Equals(DialogResult.Yes)) {
                Application.Exit();
            }
        }
        //CREDITOS
        private void pictureBox1_Click(object sender, EventArgs e) {
            MessageBox.Show("Desenvolvido Por Franklin","Projeto RH v.0.1.6");
        }
        //MENU REGISTRO DOS FUNCIONARIOS
        private void novoToolStripMenuItem_Click(object sender, EventArgs e) {
            RegistroFuncionario registro = new RegistroFuncionario();
            registro.ShowDialog();
        }
        //MENU REGISTRO DOS DEPENDENTES
        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e) {
            DependenteForm frm = new DependenteForm();
            frm.ShowDialog();
        }
        //MENU REGISTRO DAS DEPENDENCIAS
        private void dependenciaToolStripMenuItem_Click(object sender, EventArgs e) {
            DependenciaForm dependencia = new DependenciaForm();
            dependencia.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioFun relatorio = new RelatorioFun();
            relatorio.ShowDialog();
        }
    }
}
