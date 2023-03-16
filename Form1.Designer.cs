namespace TABELA_DE_FRUTAS_COM_CHECAGEM_NO_BOTAO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.chKMACA = new System.Windows.Forms.CheckBox();
            this.chKPERA = new System.Windows.Forms.CheckBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a fruta";
            // 
            // chKMACA
            // 
            this.chKMACA.AutoSize = true;
            this.chKMACA.Location = new System.Drawing.Point(34, 77);
            this.chKMACA.Name = "chKMACA";
            this.chKMACA.Size = new System.Drawing.Size(56, 17);
            this.chKMACA.TabIndex = 1;
            this.chKMACA.Text = "MACA";
            this.chKMACA.UseVisualStyleBackColor = true;
            this.chKMACA.CheckedChanged += new System.EventHandler(this.chKMACA_CheckedChanged);
            // 
            // chKPERA
            // 
            this.chKPERA.AutoSize = true;
            this.chKPERA.Location = new System.Drawing.Point(34, 125);
            this.chKPERA.Name = "chKPERA";
            this.chKPERA.Size = new System.Drawing.Size(55, 17);
            this.chKPERA.TabIndex = 2;
            this.chKPERA.Text = "PERA";
            this.chKPERA.UseVisualStyleBackColor = true;
            this.chKPERA.CheckedChanged += new System.EventHandler(this.chKPERA_CheckedChanged);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(461, 39);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(223, 23);
            this.btnEscolha.TabIndex = 3;
            this.btnEscolha.Text = "Escolha uma fruta ao lado e clique Aqui!";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.chKPERA);
            this.Controls.Add(this.chKMACA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chKMACA;
        private System.Windows.Forms.CheckBox chKPERA;
        private System.Windows.Forms.Button btnEscolha;
    }
}

