namespace Cadastrar_Aluno_forms
{
    partial class frm_Turma_Separada
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button bnt_ordenar;
            System.Windows.Forms.Button bnt_adcAluno;
            System.Windows.Forms.Button bnt_excluirAluno;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bnt_notas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            bnt_ordenar = new System.Windows.Forms.Button();
            bnt_adcAluno = new System.Windows.Forms.Button();
            bnt_excluirAluno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            button1.Location = new System.Drawing.Point(869, 8);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(233, 45);
            button1.TabIndex = 28;
            button1.Text = "Excluir Turma";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_ordenar
            // 
            bnt_ordenar.BackColor = System.Drawing.Color.RoyalBlue;
            bnt_ordenar.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            bnt_ordenar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            bnt_ordenar.Location = new System.Drawing.Point(867, 15);
            bnt_ordenar.Name = "bnt_ordenar";
            bnt_ordenar.Size = new System.Drawing.Size(189, 42);
            bnt_ordenar.TabIndex = 28;
            bnt_ordenar.Text = "Ordenar";
            bnt_ordenar.UseVisualStyleBackColor = false;
            bnt_ordenar.Click += new System.EventHandler(this.bnt_ordenar_Click);
            // 
            // bnt_adcAluno
            // 
            bnt_adcAluno.BackColor = System.Drawing.Color.RoyalBlue;
            bnt_adcAluno.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            bnt_adcAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            bnt_adcAluno.Location = new System.Drawing.Point(430, 10);
            bnt_adcAluno.Name = "bnt_adcAluno";
            bnt_adcAluno.Size = new System.Drawing.Size(275, 48);
            bnt_adcAluno.TabIndex = 27;
            bnt_adcAluno.Text = "Adicionar Aluno";
            bnt_adcAluno.UseVisualStyleBackColor = false;
            bnt_adcAluno.Click += new System.EventHandler(this.bnt_adcAluno_Click);
            // 
            // bnt_excluirAluno
            // 
            bnt_excluirAluno.BackColor = System.Drawing.Color.Red;
            bnt_excluirAluno.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            bnt_excluirAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            bnt_excluirAluno.Location = new System.Drawing.Point(595, 9);
            bnt_excluirAluno.Name = "bnt_excluirAluno";
            bnt_excluirAluno.Size = new System.Drawing.Size(233, 45);
            bnt_excluirAluno.TabIndex = 29;
            bnt_excluirAluno.Text = "Excluir Aluno";
            bnt_excluirAluno.UseVisualStyleBackColor = false;
            bnt_excluirAluno.Click += new System.EventHandler(this.bnt_excluirAluno_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 77);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(474, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 53);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(501, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "EasyNote";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(bnt_excluirAluno);
            this.panel3.Controls.Add(button1);
            this.panel3.Controls.Add(this.btVoltar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 59);
            this.panel3.TabIndex = 28;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVoltar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltar.Location = new System.Drawing.Point(16, 15);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(149, 39);
            this.btVoltar.TabIndex = 27;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(bnt_ordenar);
            this.panel4.Controls.Add(bnt_adcAluno);
            this.panel4.Controls.Add(this.bnt_notas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 69);
            this.panel4.TabIndex = 29;
            // 
            // bnt_notas
            // 
            this.bnt_notas.BackColor = System.Drawing.Color.RoyalBlue;
            this.bnt_notas.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.bnt_notas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnt_notas.Location = new System.Drawing.Point(56, 11);
            this.bnt_notas.Name = "bnt_notas";
            this.bnt_notas.Size = new System.Drawing.Size(182, 48);
            this.bnt_notas.TabIndex = 26;
            this.bnt_notas.Text = "lanças notas";
            this.bnt_notas.UseVisualStyleBackColor = false;
            this.bnt_notas.Click += new System.EventHandler(this.bnt_notas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 388);
            this.dataGridView1.TabIndex = 30;
            // 
            // frm_Turma_Separada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Turma_Separada";
            this.Text = "frm_Turma_Separada";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bnt_notas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}