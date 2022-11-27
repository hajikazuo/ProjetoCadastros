namespace ProjetoCadastros
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.BackgroundImage")));
            this.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(101, 53);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(185, 187);
            this.btnFornecedor.TabIndex = 0;
            this.btnFornecedor.Text = "Cadastrar Fornecedor";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.BackgroundImage")));
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(501, 53);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(185, 187);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Cadastrar Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFornecedor);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnProdutos;
    }
}