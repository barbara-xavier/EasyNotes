namespace Cadastrar_Aluno_forms
{
    partial class frm_aluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.TextBox();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.txNascimento = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrar.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCadastrar.Location = new System.Drawing.Point(311, 441);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(316, 51);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(338, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Aluno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 77);
            this.panel1.TabIndex = 2;
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Location = new System.Drawing.Point(99, 163);
            this.txNome.Multiline = true;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(260, 25);
            this.txNome.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 53);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "EasyNote";
            // 
            // txTelefone
            // 
            this.txTelefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTelefone.Location = new System.Drawing.Point(343, 362);
            this.txTelefone.Multiline = true;
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(260, 25);
            this.txTelefone.TabIndex = 4;
            // 
            // txCPF
            // 
            this.txCPF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCPF.Location = new System.Drawing.Point(99, 261);
            this.txCPF.Multiline = true;
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(260, 25);
            this.txCPF.TabIndex = 2;
            // 
            // txNascimento
            // 
            this.txNascimento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNascimento.Location = new System.Drawing.Point(555, 163);
            this.txNascimento.Multiline = true;
            this.txNascimento.Name = "txNascimento";
            this.txNascimento.Size = new System.Drawing.Size(260, 25);
            this.txNascimento.TabIndex = 1;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVoltar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltar.Location = new System.Drawing.Point(30, 469);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(149, 39);
            this.btVoltar.TabIndex = 8;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(98, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(555, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dt.Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(99, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(556, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(345, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não Informar"});
            this.cbSexo.Location = new System.Drawing.Point(555, 262);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(258, 24);
            this.cbSexo.TabIndex = 3;
            // 
            // frm_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 592);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txNascimento);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCadastrar);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frm_aluno";
            this.Text = "Cadastrar_Aluno";
            this.Load += new System.EventHandler(this.frm_aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txNascimento;
        private System.Windows.Forms.TextBox txCPF;
        private System.Windows.Forms.TextBox txTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSexo;
    }
}

