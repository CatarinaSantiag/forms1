namespace forms1
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
            this.butao = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butao
            // 
            this.butao.BackColor = System.Drawing.Color.LightGreen;
            this.butao.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butao.Location = new System.Drawing.Point(67, 211);
            this.butao.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.butao.Name = "butao";
            this.butao.Size = new System.Drawing.Size(213, 59);
            this.butao.TabIndex = 0;
            this.butao.Text = "oi mo";
            this.butao.UseVisualStyleBackColor = false;
            this.butao.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(64, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "label1";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntuario.Location = new System.Drawing.Point(64, 146);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(55, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "label2";
            // 
            // txbPront
            // 
            this.txbPront.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPront.Location = new System.Drawing.Point(67, 174);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(415, 23);
            this.txbPront.TabIndex = 3;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(67, 111);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(254, 23);
            this.txbNome.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.butao);
            this.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.TextBox txbNome;
    }
}

