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
            this.dgv_func = new System.Windows.Forms.DataGridView();
            this.mtxt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_func)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mtxt_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxt_cpf.Location = new System.Drawing.Point(302, 37);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(134, 29);
            this.mtxt_cpf.TabIndex = 1;
            this.mtxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(16, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(254, 29);
            this.txt_id.TabIndex = 0;
            this.txt_id.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nome.Location = new System.Drawing.Point(16, 107);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(254, 29);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_email.Location = new System.Drawing.Point(16, 174);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(254, 29);
            this.txt_email.TabIndex = 4;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(302, 9);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(47, 24);
            this.CPF.TabIndex = 8;
            this.CPF.Text = "CPF";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(177, 209);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 32);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar ";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(78, 209);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(93, 32);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefone";
            // 
            // dgv_func
            // 
            this.dgv_func.AllowUserToAddRows = false;
            this.dgv_func.AllowUserToDeleteRows = false;
            this.dgv_func.AllowUserToOrderColumns = true;
            this.dgv_func.AllowUserToResizeRows = false;
            this.dgv_func.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_func.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_func.Location = new System.Drawing.Point(12, 247);
            this.dgv_func.Name = "dgv_func";
            this.dgv_func.ReadOnly = true;
            this.dgv_func.Size = new System.Drawing.Size(437, 327);
            this.dgv_func.TabIndex = 15;
            // 
            // mtxt_tel
            // 
            this.mtxt_tel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mtxt_tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxt_tel.Location = new System.Drawing.Point(302, 174);
            this.mtxt_tel.Mask = "(99) 0000-0000";
            this.mtxt_tel.Name = "mtxt_tel";
            this.mtxt_tel.Size = new System.Drawing.Size(134, 29);
            this.mtxt_tel.TabIndex = 5;
            this.mtxt_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_rg
            // 
            this.txt_rg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_rg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txt_rg.Location = new System.Drawing.Point(302, 107);
            this.txt_rg.Mask = "00000000000";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(134, 29);
            this.txt_rg.TabIndex = 16;
            this.txt_rg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // RegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 586);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.mtxt_tel);
            this.Controls.Add(this.dgv_func);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_func)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_func;
        private System.Windows.Forms.MaskedTextBox mtxt_tel;
        private System.Windows.Forms.MaskedTextBox txt_rg;
    }
}