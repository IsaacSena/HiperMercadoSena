namespace HiperMercadoSena.View
{
    partial class telaAlterarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAlterarProdutos));
            label4 = new Label();
            btx_alterar = new Button();
            nud_quantidade = new NumericUpDown();
            cbx_nomeproduto = new ComboBox();
            cbx_categoria = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btx_excluir = new Button();
            label5 = new Label();
            btx_valorproduto = new TextBox();
            label6 = new Label();
            tbx_pesquisar = new TextBox();
            btx_pesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(238, 9);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 33;
            label4.Text = "Alterar Produtos";
            // 
            // btx_alterar
            // 
            btx_alterar.Location = new Point(427, 437);
            btx_alterar.Name = "btx_alterar";
            btx_alterar.Size = new Size(75, 23);
            btx_alterar.TabIndex = 32;
            btx_alterar.Text = "Alterar";
            btx_alterar.UseVisualStyleBackColor = true;
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(462, 260);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(71, 23);
            nud_quantidade.TabIndex = 31;
            // 
            // cbx_nomeproduto
            // 
            cbx_nomeproduto.FormattingEnabled = true;
            cbx_nomeproduto.Location = new Point(157, 260);
            cbx_nomeproduto.Name = "cbx_nomeproduto";
            cbx_nomeproduto.Size = new Size(170, 23);
            cbx_nomeproduto.TabIndex = 30;
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(157, 213);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(170, 23);
            cbx_categoria.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 263);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 28;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 263);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 27;
            label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 216);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 26;
            label1.Text = "Categoria";
            // 
            // btx_excluir
            // 
            btx_excluir.Location = new Point(157, 439);
            btx_excluir.Name = "btx_excluir";
            btx_excluir.Size = new Size(75, 23);
            btx_excluir.TabIndex = 34;
            btx_excluir.Text = "Excluir";
            btx_excluir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 306);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 35;
            label5.Text = "Valor do Produto";
            // 
            // btx_valorproduto
            // 
            btx_valorproduto.Location = new Point(157, 303);
            btx_valorproduto.Name = "btx_valorproduto";
            btx_valorproduto.Size = new Size(100, 23);
            btx_valorproduto.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 77);
            label6.Name = "label6";
            label6.Size = new Size(153, 15);
            label6.TabIndex = 37;
            label6.Text = "Digite o Código do Produto";
            // 
            // tbx_pesquisar
            // 
            tbx_pesquisar.Location = new Point(293, 74);
            tbx_pesquisar.Name = "tbx_pesquisar";
            tbx_pesquisar.Size = new Size(240, 23);
            tbx_pesquisar.TabIndex = 38;
            // 
            // btx_pesquisar
            // 
            btx_pesquisar.Location = new Point(125, 124);
            btx_pesquisar.Name = "btx_pesquisar";
            btx_pesquisar.Size = new Size(408, 37);
            btx_pesquisar.TabIndex = 39;
            btx_pesquisar.Text = "Pesquisar";
            btx_pesquisar.UseVisualStyleBackColor = true;
            // 
            // telaAlterarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(652, 495);
            Controls.Add(btx_pesquisar);
            Controls.Add(tbx_pesquisar);
            Controls.Add(label6);
            Controls.Add(btx_valorproduto);
            Controls.Add(label5);
            Controls.Add(btx_excluir);
            Controls.Add(label4);
            Controls.Add(btx_alterar);
            Controls.Add(nud_quantidade);
            Controls.Add(cbx_nomeproduto);
            Controls.Add(cbx_categoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaAlterarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaAlterarProdutos";
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btx_alterar;
        private NumericUpDown nud_quantidade;
        private ComboBox cbx_nomeproduto;
        private ComboBox cbx_categoria;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btx_excluir;
        private Label label5;
        private TextBox btx_valorproduto;
        private Label label6;
        private TextBox tbx_pesquisar;
        private Button btx_pesquisar;
    }
}