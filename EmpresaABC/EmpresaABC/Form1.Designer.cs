namespace EmpresaABC
{
    partial class FormularioCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lblPCD = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtPCD = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(67, 61);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Cliente";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(69, 155);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(74, 26);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(69, 195);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(69, 26);
            this.lblidade.TabIndex = 2;
            this.lblidade.Text = "Idade:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(69, 238);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(82, 26);
            this.lblsalario.TabIndex = 3;
            this.lblsalario.Text = "Salário:";
            this.lblsalario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPCD
            // 
            this.lblPCD.AutoSize = true;
            this.lblPCD.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCD.Location = new System.Drawing.Point(69, 275);
            this.lblPCD.Name = "lblPCD";
            this.lblPCD.Size = new System.Drawing.Size(55, 26);
            this.lblPCD.TabIndex = 4;
            this.lblPCD.Text = "PCD:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(157, 155);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(97, 26);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(157, 195);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(97, 26);
            this.txtidade.TabIndex = 6;
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(157, 238);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(97, 26);
            this.txtsalario.TabIndex = 7;
            // 
            // txtPCD
            // 
            this.txtPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCD.Location = new System.Drawing.Point(157, 275);
            this.txtPCD.Name = "txtPCD";
            this.txtPCD.Size = new System.Drawing.Size(97, 26);
            this.txtPCD.TabIndex = 8;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(74, 369);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(118, 48);
            this.btncadastrar.TabIndex = 9;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(243, 369);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(103, 48);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // FormularioCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtPCD);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblPCD);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioCadastroCliente";
            this.Text = "Empresa ABC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lblPCD;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtPCD;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnsair;
    }
}

