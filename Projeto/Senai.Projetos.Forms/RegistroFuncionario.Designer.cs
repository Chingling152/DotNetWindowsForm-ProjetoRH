namespace Projeto.Senai.Projetos.Forms {
    partial class RegistroFuncionario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvg_func = new System.Windows.Forms.DataGridView();
            this.mtxt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_func)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mtxt_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxt_cpf.Location = new System.Drawing.Point(387, 28);
            this.mtxt_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(122, 26);
            this.mtxt_cpf.TabIndex = 2;
            this.mtxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(11, 29);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(122, 26);
            this.txt_id.TabIndex = 0;
            this.txt_id.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nome.Location = new System.Drawing.Point(137, 29);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(246, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_email.Location = new System.Drawing.Point(11, 78);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(248, 26);
            this.txt_email.TabIndex = 3;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(389, 6);
            this.CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(40, 20);
            this.CPF.TabIndex = 8;
            this.CPF.Text = "CPF";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(393, 108);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(116, 47);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Excluir";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(263, 108);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(120, 47);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefone";
            // 
            // dvg_func
            // 
            this.dvg_func.AllowUserToAddRows = false;
            this.dvg_func.AllowUserToDeleteRows = false;
            this.dvg_func.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "-";
            this.dvg_func.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_func.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_func.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_func.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_func.Location = new System.Drawing.Point(7, 159);
            this.dvg_func.Margin = new System.Windows.Forms.Padding(1);
            this.dvg_func.MultiSelect = false;
            this.dvg_func.Name = "dvg_func";
            this.dvg_func.ReadOnly = true;
            this.dvg_func.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvg_func.RowHeadersVisible = false;
            this.dvg_func.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_func.Size = new System.Drawing.Size(502, 303);
            this.dvg_func.TabIndex = 15;
            this.dvg_func.SelectionChanged += new System.EventHandler(this.dvg_func_SelectionChanged);
            // 
            // mtxt_tel
            // 
            this.mtxt_tel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mtxt_tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxt_tel.Location = new System.Drawing.Point(263, 78);
            this.mtxt_tel.Margin = new System.Windows.Forms.Padding(2);
            this.mtxt_tel.Mask = "(99) 0000-0000";
            this.mtxt_tel.Name = "mtxt_tel";
            this.mtxt_tel.Size = new System.Drawing.Size(120, 26);
            this.mtxt_tel.TabIndex = 4;
            this.mtxt_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_rg
            // 
            this.txt_rg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_rg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_rg.Location = new System.Drawing.Point(387, 78);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rg.Mask = "0000000000";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(122, 26);
            this.txt_rg.TabIndex = 5;
            this.txt_rg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // RegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 475);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.mtxt_tel);
            this.Controls.Add(this.dvg_func);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Funcionario";
            this.Load += new System.EventHandler(this.RegistroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_func)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvg_func;
        private System.Windows.Forms.MaskedTextBox mtxt_tel;
        private System.Windows.Forms.MaskedTextBox txt_rg;
    }
}