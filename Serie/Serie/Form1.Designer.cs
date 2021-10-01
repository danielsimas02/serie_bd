
namespace Serie
{
    partial class Confirme
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Ano = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgConfirme = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(87, 45);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 0;
            // 
            // Ano
            // 
            this.Ano.Location = new System.Drawing.Point(461, 45);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(60, 20);
            this.Ano.TabIndex = 1;
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(275, 45);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(100, 20);
            this.Categoria.TabIndex = 2;
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(107, 103);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(308, 20);
            this.Descricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descricao";
            // 
            // dgConfirme
            // 
            this.dgConfirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbID,
            this.tbNome,
            this.tbCategoria,
            this.tbDescricao,
            this.tbAno});
            this.dgConfirme.Location = new System.Drawing.Point(49, 270);
            this.dgConfirme.Name = "dgConfirme";
            this.dgConfirme.Size = new System.Drawing.Size(693, 150);
            this.dgConfirme.TabIndex = 8;
            // 
            // tbID
            // 
            this.tbID.HeaderText = "ID";
            this.tbID.Name = "tbID";
            // 
            // tbNome
            // 
            this.tbNome.HeaderText = "Nome";
            this.tbNome.Name = "tbNome";
            // 
            // tbCategoria
            // 
            this.tbCategoria.HeaderText = "Categoria";
            this.tbCategoria.Name = "tbCategoria";
            // 
            // tbDescricao
            // 
            this.tbDescricao.HeaderText = "Descricao";
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Width = 350;
            // 
            // tbAno
            // 
            this.tbAno.HeaderText = "Ano";
            this.tbAno.Name = "tbAno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(589, 45);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(46, 20);
            this.ID.TabIndex = 11;
            // 
            // Confirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgConfirme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.Nome);
            this.Name = "Confirme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Ano;
        private System.Windows.Forms.TextBox Categoria;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgConfirme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
    }
}

