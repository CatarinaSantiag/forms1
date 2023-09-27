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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butao = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butao
            // 
            this.butao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(124)))));
            this.butao.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butao.Location = new System.Drawing.Point(492, 316);
            this.butao.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.butao.Name = "butao";
            this.butao.Size = new System.Drawing.Size(215, 83);
            this.butao.TabIndex = 0;
            this.butao.Text = "ENTRAR";
            this.butao.UseVisualStyleBackColor = false;
            this.butao.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(540, 136);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Email/Código:";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.BackColor = System.Drawing.Color.Transparent;
            this.lblProntuario.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProntuario.Location = new System.Drawing.Point(567, 212);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(55, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "Senha:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(492, 165);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(215, 22);
            this.txbNome.TabIndex = 4;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbPront
            // 
            this.txbPront.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPront.Location = new System.Drawing.Point(492, 243);
            this.txbPront.Name = "txbPront";
            this.txbPront.PasswordChar = '♥';
            this.txbPront.Size = new System.Drawing.Size(215, 22);
            this.txbPront.TabIndex = 5;
            this.txbPront.TextChanged += new System.EventHandler(this.txbPront_TextChanged_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(322, 405);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 185);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "user";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "senha";
            this.columnHeader2.Width = 87;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(720, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 83);
            this.button2.TabIndex = 8;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 49);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.butao);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

