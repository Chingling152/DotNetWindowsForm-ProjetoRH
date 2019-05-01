using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Senai.Projetos.Forms {
    public partial class RelatorioFun : Form {
        public RelatorioFun() {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'empresaDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.empresaDataSet.Funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
