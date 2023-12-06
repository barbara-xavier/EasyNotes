namespace Cadastrar_Aluno_forms
{
    partial class frm_Turma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txMateria = new System.Windows.Forms.TextBox();
            this.txNomeTurma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(344, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Matéria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(343, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome da Turma";
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVoltar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltar.Location = new System.Drawing.Point(34, 472);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(149, 39);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txMateria
            // 
            this.txMateria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txMateria.Location = new System.Drawing.Point(344, 301);
            this.txMateria.Multiline = true;
            this.txMateria.Name = "txMateria";
            this.txMateria.Size = new System.Drawing.Size(260, 25);
            this.txMateria.TabIndex = 1;
            // 
            // txNomeTurma
            // 
            this.txNomeTurma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txNomeTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNomeTurma.Location = new System.Drawing.Point(344, 182);
            this.txNomeTurma.Multiline = true;
            this.txNomeTurma.Name = "txNomeTurma";
            this.txNomeTurma.Size = new System.Drawing.Size(260, 25);
            this.txNomeTurma.TabIndex = 0;
            this.txNomeTurma.TextChanged += new System.EventHandler(this.txNomeTurma_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 77);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(305, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Nova Turma";
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrar.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCadastrar.Location = new System.Drawing.Point(311, 431);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(316, 51);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 53);
            this.panel2.TabIndex = 25;
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
            // frm_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txMateria);
            this.Controls.Add(this.txNomeTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCadastrar);
            this.Name = "frm_Turma";
            this.Text = "frm_Turma";
            this.Load += new System.EventHandler(this.frm_Turma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txMateria;
        private System.Windows.Forms.TextBox txNomeTurma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}