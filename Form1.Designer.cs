namespace TelaDeCompras
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
            this.lista_produtos = new System.Windows.Forms.ListBox();
            this.lista_compras = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // lista_produtos
            // 
            this.lista_produtos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_produtos.FormattingEnabled = true;
            this.lista_produtos.ItemHeight = 18;
            this.lista_produtos.Location = new System.Drawing.Point(188, 79);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(184, 166);
            this.lista_produtos.TabIndex = 2;
            this.lista_produtos.DoubleClick += new System.EventHandler(this.lista_produtos_DoubleClick);
            // 
            // lista_compras
            // 
            this.lista_compras.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_compras.FormattingEnabled = true;
            this.lista_compras.ItemHeight = 18;
            this.lista_compras.Location = new System.Drawing.Point(431, 79);
            this.lista_compras.Name = "lista_compras";
            this.lista_compras.Size = new System.Drawing.Size(204, 130);
            this.lista_compras.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Compras";
            // 
            // label_total
            // 
            this.label_total.BackColor = System.Drawing.Color.White;
            this.label_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_total.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(428, 212);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(207, 33);
            this.label_total.TabIndex = 5;
            this.label_total.Text = "Compras";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(188, 262);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 38);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Nova compra";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(541, 262);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(94, 38);
            this.btn_finalizar.TabIndex = 7;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.lista_compras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_produtos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista_produtos;
        private System.Windows.Forms.ListBox lista_compras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_finalizar;
    }
}

