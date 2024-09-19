namespace HiperMercadoSena.View
{
    partial class telaCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastroProduto));
            btx_cadastrar = new Button();
            nud_quantidade = new NumericUpDown();
            cbx_nomeproduto = new ComboBox();
            cbx_categoria = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbx_valorproduto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            SuspendLayout();
            // 
            // btx_cadastrar
            // 
            btx_cadastrar.Location = new Point(275, 289);
            btx_cadastrar.Name = "btx_cadastrar";
            btx_cadastrar.Size = new Size(75, 23);
            btx_cadastrar.TabIndex = 24;
            btx_cadastrar.Text = "Cadastrar";
            btx_cadastrar.UseVisualStyleBackColor = true;
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(180, 182);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(71, 23);
            nud_quantidade.TabIndex = 22;
            // 
            // cbx_nomeproduto
            // 
            cbx_nomeproduto.FormattingEnabled = true;
            cbx_nomeproduto.Location = new Point(180, 138);
            cbx_nomeproduto.Name = "cbx_nomeproduto";
            cbx_nomeproduto.Size = new Size(170, 23);
            cbx_nomeproduto.TabIndex = 20;
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(180, 91);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(170, 23);
            cbx_categoria.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 184);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 17;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 141);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 94);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 15;
            label1.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(158, 9);
            label4.Name = "label4";
            label4.Size = new Size(192, 30);
            label4.TabIndex = 25;
            label4.Text = "Cadastrar Produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 224);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 26;
            label5.Text = "Valor Produto";
            // 
            // tbx_valorproduto
            // 
            tbx_valorproduto.Location = new Point(180, 221);
            tbx_valorproduto.Name = "tbx_valorproduto";
            tbx_valorproduto.Size = new Size(100, 23);
            tbx_valorproduto.TabIndex = 27;
            // 
            // telaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(478, 324);
            Controls.Add(tbx_valorproduto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btx_cadastrar);
            Controls.Add(nud_quantidade);
            Controls.Add(cbx_nomeproduto);
            Controls.Add(cbx_categoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btx_cadastrar;
        private NumericUpDown nud_quantidade;
        private ComboBox cbx_nomeproduto;
        private ComboBox cbx_categoria;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox tbx_valorproduto;
    }
}