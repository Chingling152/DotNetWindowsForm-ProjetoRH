namespace Projeto.Senai.Projetos.Forms {
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Depe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data De Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(18, 39);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(99, 29);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(123, 39);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(299, 29);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(432, 98);
            this.txt_Cpf.Mask = "000,000,000-00";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(137, 29);
            this.txt_Cpf.TabIndex = 6;
            this.txt_Cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Data.Location = new System.Drawing.Point(432, 39);
            this.dtp_Data.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(177, 29);
            this.dtp_Data.TabIndex = 7;
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
            this.cbo_Func.FormattingEnabled = true;
            this.cbo_Func.Location = new System.Drawing.Point(18, 98);
            this.cbo_Func.Name = "cbo_Func";
            this.cbo_Func.Size = new System.Drawing.Size(203, 32);
            this.cbo_Func.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Funcionario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dependencia";
            // 
            // cbo_Depe
            // 
            this.cbo_Depe.FormattingEnabled = true;
            this.cbo_Depe.Location = new System.Drawing.Point(227, 98);
            this.cbo_Depe.Name = "cbo_Depe";
            this.cbo_Depe.Size = new System.Drawing.Size(195, 32);
            this.cbo_Depe.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DependenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 454);
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
    }
}