namespace Hortfruit
{
    partial class Produtos
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
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.btn_listarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_produtos
            // 
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.Location = new System.Drawing.Point(14, 133);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(595, 459);
            this.list_produtos.TabIndex = 0;
            // 
            // btn_listarProduto
            // 
            this.btn_listarProduto.Location = new System.Drawing.Point(14, 90);
            this.btn_listarProduto.Name = "btn_listarProduto";
            this.btn_listarProduto.Size = new System.Drawing.Size(152, 23);
            this.btn_listarProduto.TabIndex = 1;
            this.btn_listarProduto.Text = "Listar Produtos";
            this.btn_listarProduto.UseVisualStyleBackColor = true;
            this.btn_listarProduto.Click += new System.EventHandler(this.btn_listarProduto_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 605);
            this.Controls.Add(this.btn_listarProduto);
            this.Controls.Add(this.list_produtos);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.Button btn_listarProduto;
    }
}