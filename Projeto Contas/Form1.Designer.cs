namespace Projeto_Contas
{
    partial class Contas
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnmultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbtndivisao = new System.Windows.Forms.RadioButton();
            this.rbtnsubtracao = new System.Windows.Forms.RadioButton();
            this.rbtnadicao = new System.Windows.Forms.RadioButton();
            this.lblresultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.BackColor = System.Drawing.Color.Gray;
            this.txtn1.Location = new System.Drawing.Point(14, 57);
            this.txtn1.Margin = new System.Windows.Forms.Padding(5);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(426, 34);
            this.txtn1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "1º Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "2º Número";
            // 
            // txtn2
            // 
            this.txtn2.BackColor = System.Drawing.Color.Gray;
            this.txtn2.Location = new System.Drawing.Point(14, 159);
            this.txtn2.Margin = new System.Windows.Forms.Padding(5);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(426, 34);
            this.txtn2.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Gray;
            this.btncalcular.Location = new System.Drawing.Point(12, 398);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(188, 106);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpar.Location = new System.Drawing.Point(206, 423);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(125, 56);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Gray;
            this.btnsair.Location = new System.Drawing.Point(730, 466);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(122, 47);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rbtnmultiplicacao);
            this.groupBox1.Controls.Add(this.rbtndivisao);
            this.groupBox1.Controls.Add(this.rbtnsubtracao);
            this.groupBox1.Controls.Add(this.rbtnadicao);
            this.groupBox1.Location = new System.Drawing.Point(464, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha Uma Opção";
            // 
            // rbtnmultiplicacao
            // 
            this.rbtnmultiplicacao.AutoSize = true;
            this.rbtnmultiplicacao.Location = new System.Drawing.Point(18, 145);
            this.rbtnmultiplicacao.Name = "rbtnmultiplicacao";
            this.rbtnmultiplicacao.Size = new System.Drawing.Size(183, 31);
            this.rbtnmultiplicacao.TabIndex = 3;
            this.rbtnmultiplicacao.TabStop = true;
            this.rbtnmultiplicacao.Text = "Multiplicação *";
            this.rbtnmultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbtndivisao
            // 
            this.rbtndivisao.AutoSize = true;
            this.rbtndivisao.Location = new System.Drawing.Point(18, 108);
            this.rbtndivisao.Name = "rbtndivisao";
            this.rbtndivisao.Size = new System.Drawing.Size(119, 31);
            this.rbtndivisao.TabIndex = 2;
            this.rbtndivisao.TabStop = true;
            this.rbtndivisao.Text = "Divisão /";
            this.rbtndivisao.UseVisualStyleBackColor = true;
            // 
            // rbtnsubtracao
            // 
            this.rbtnsubtracao.AutoSize = true;
            this.rbtnsubtracao.Location = new System.Drawing.Point(18, 71);
            this.rbtnsubtracao.Name = "rbtnsubtracao";
            this.rbtnsubtracao.Size = new System.Drawing.Size(143, 31);
            this.rbtnsubtracao.TabIndex = 1;
            this.rbtnsubtracao.TabStop = true;
            this.rbtnsubtracao.Text = "Subtração -";
            this.rbtnsubtracao.UseVisualStyleBackColor = true;
            // 
            // rbtnadicao
            // 
            this.rbtnadicao.AutoSize = true;
            this.rbtnadicao.Location = new System.Drawing.Point(18, 34);
            this.rbtnadicao.Name = "rbtnadicao";
            this.rbtnadicao.Size = new System.Drawing.Size(122, 31);
            this.rbtnadicao.TabIndex = 0;
            this.rbtnadicao.TabStop = true;
            this.rbtnadicao.Text = "Adição +";
            this.rbtnadicao.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblresultado.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(363, 285);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 37);
            this.lblresultado.TabIndex = 8;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(861, 525);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Contas";
            this.Text = "Contas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnmultiplicacao;
        private System.Windows.Forms.RadioButton rbtndivisao;
        private System.Windows.Forms.RadioButton rbtnsubtracao;
        private System.Windows.Forms.RadioButton rbtnadicao;
        private System.Windows.Forms.Label lblresultado;
    }
}

