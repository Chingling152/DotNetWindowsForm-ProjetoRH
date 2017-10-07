using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            MessageBox.Show("Desenvolvido Por Franklin","Projeto RH v.0.0.2");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) {

        }
    }
}
