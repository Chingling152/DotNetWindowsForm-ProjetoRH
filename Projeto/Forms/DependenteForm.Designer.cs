namespace Projeto.Forms {
    partial class DependenteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.dgv_Depe = new System.Windows.Forms.DataGridView();
            this.cbo_Func = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Depe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Depe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data De Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(18, 39);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(166, 34);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.White;
            this.txt_Nome.Location = new System.Drawing.Point(190, 39);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(299, 34);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.BackColor = System.Drawing.Color.White;
            this.txt_Cpf.Location = new System.Drawing.Point(737, 39);
            this.txt_Cpf.Mask = "000,000,000-00";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(166, 34);
            this.txt_Cpf.TabIndex = 3;
            this.txt_Cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtp_Data
            // 
            this.dtp_Data.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Data.Location = new System.Drawing.Point(495, 39);
            this.dtp_Data.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(228, 34);
            this.dtp_Data.TabIndex = 2;
            this.dtp_Data.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dgv_Depe
            // 
            this.dgv_Depe.AllowUserToAddRows = false;
            this.dgv_Depe.AllowUserToDeleteRows = false;
            this.dgv_Depe.AllowUserToResizeColumns = false;
            this.dgv_Depe.AllowUserToResizeRows = false;
            this.dgv_Depe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Depe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Depe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Depe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Depe.Location = new System.Drawing.Point(18, 186);
            this.dgv_Depe.MultiSelect = false;
            this.dgv_Depe.Name = "dgv_Depe";
            this.dgv_Depe.ReadOnly = true;
            this.dgv_Depe.RowHeadersVisible = false;
            this.dgv_Depe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Depe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Depe.Size = new System.Drawing.Size(591, 256);
            this.dgv_Depe.TabIndex = 8;
            this.dgv_Depe.SelectionChanged += new System.EventHandler(this.dgv_Depe_SelectionChanged);
            // 
            // cbo_Func
            // 
            this.cbo_Func.BackColor = System.Drawing.Color.White;
            this.cbo_Func.FormattingEnabled = true;
            this.cbo_Func.Location = new System.Drawing.Point(190, 111);
            this.cbo_Func.Name = "cbo_Func";
            this.cbo_Func.Size = new System.Drawing.Size(299, 37);
            this.cbo_Func.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Funcionario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dependencia";
            // 
            // cbo_Depe
            // 
            this.cbo_Depe.BackColor = System.Drawing.Color.White;
            this.cbo_Depe.FormattingEnabled = true;
            this.cbo_Depe.Location = new System.Drawing.Point(495, 111);
            this.cbo_Depe.Name = "cbo_Depe";
            this.cbo_Depe.Size = new System.Drawing.Size(228, 37);
            this.cbo_Depe.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_rg
            // 
            this.txt_rg.AccessibleDescription = "CPF do Funcionario";
            this.txt_rg.AccessibleName = "CPF";
            this.txt_rg.BackColor = System.Drawing.Color.White;
            this.txt_rg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_rg.Location = new System.Drawing.Point(905, 111);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rg.Mask = "000,000,000-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(164, 34);
            this.txt_rg.TabIndex = 18;
            this.txt_rg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxt_tel
            // 
            this.mtxt_tel.BackColor = System.Drawing.Color.White;
            this.mtxt_tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxt_tel.Location = new System.Drawing.Point(18, 111);
            this.mtxt_tel.Margin = new System.Windows.Forms.Padding(2);
            this.mtxt_tel.Mask = "(99) 0000-0000";
            this.mtxt_tel.Name = "mtxt_tel";
            this.mtxt_tel.Size = new System.Drawing.Size(164, 34);
            this.mtxt_tel.TabIndex = 17;
            this.mtxt_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefone";
            // 
            // DependenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 454);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.mtxt_tel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_Depe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_Func);
            this.Controls.Add(this.dgv_Depe);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "DependenteForm";
            this.ShowIcon = false;
            this.Text = "Cadastro De Dependentes";
            this.Load += new System.EventHandler(this.DependenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Depe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.MaskedTextBox txt_Cpf;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.DataGridView dgv_Depe;
        private System.Windows.Forms.ComboBox cbo_Func;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Depe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.MaskedTextBox mtxt_tel;
        private System.Windows.Forms.Label label7;
    }
}