namespace HiperMercadoSena.View
{
    partial class telaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            dtp_data = new DateTimePicker();
            cbx_categoria = new ComboBox();
            cbx_nomeproduto = new ComboBox();
            label8 = new Label();
            nud_quantidade = new NumericUpDown();
            btx_excluir = new Button();
            btx_adicionar = new Button();
            btx_resultado = new Button();
            label4 = new Label();
            tbx_valorproduto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 140);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 198);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 197);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(236, 9);
            label6.Name = "label6";
            label6.Size = new Size(208, 25);
            label6.TabIndex = 5;
            label6.Text = "Adicionar ao Carrinho";
            // 
            // dtp_data
            // 
            dtp_data.Location = new Point(438, 137);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(187, 23);
            dtp_data.TabIndex = 7;
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(153, 137);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(170, 23);
            cbx_categoria.TabIndex = 8;
            // 
            // cbx_nomeproduto
            // 
            cbx_nomeproduto.FormattingEnabled = true;
            cbx_nomeproduto.Location = new Point(153, 195);
            cbx_nomeproduto.Name = "cbx_nomeproduto";
            cbx_nomeproduto.Size = new Size(170, 23);
            cbx_nomeproduto.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 140);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 11;
            label8.Text = "Data";
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(438, 195);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(71, 23);
            nud_quantidade.TabIndex = 12;
            // 
            // btx_excluir
            // 
            btx_excluir.Location = new Point(248, 345);
            btx_excluir.Name = "btx_excluir";
            btx_excluir.Size = new Size(75, 23);
            btx_excluir.TabIndex = 13;
            btx_excluir.Text = "Excluir";
            btx_excluir.UseVisualStyleBackColor = true;
            // 
            // btx_adicionar
            // 
            btx_adicionar.Location = new Point(434, 345);
            btx_adicionar.Name = "btx_adicionar";
            btx_adicionar.Size = new Size(75, 23);
            btx_adicionar.TabIndex = 14;
            btx_adicionar.Text = "Adicionar";
            btx_adicionar.UseVisualStyleBackColor = true;
            // 
            // btx_resultado
            // 
            btx_resultado.Location = new Point(602, 345);
            btx_resultado.Name = "btx_resultado";
            btx_resultado.Size = new Size(75, 23);
            btx_resultado.TabIndex = 15;
            btx_resultado.Text = "Resultado";
            btx_resultado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 256);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 16;
            label4.Text = "Valor do Produto";
            // 
            // tbx_valorproduto
            // 
            tbx_valorproduto.Location = new Point(153, 253);
            tbx_valorproduto.Name = "tbx_valorproduto";
            tbx_valorproduto.Size = new Size(100, 23);
            tbx_valorproduto.TabIndex = 17;
            // 
            // telaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(689, 380);
            Controls.Add(tbx_valorproduto);
            Controls.Add(label4);
            Controls.Add(btx_resultado);
            Controls.Add(btx_adicionar);
            Controls.Add(btx_excluir);
            Controls.Add(nud_quantidade);
            Controls.Add(label8);
            Controls.Add(cbx_nomeproduto);
            Controls.Add(cbx_categoria);
            Controls.Add(dtp_data);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaCliente";
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private DateTimePicker dtp_data;
        private ComboBox cbx_categoria;
        private ComboBox cbx_nomeproduto;
        private Label label8;
        private NumericUpDown nud_quantidade;
        private Button btx_excluir;
        private Button btx_adicionar;
        private Button btx_resultado;
        private Label label4;
        private TextBox tbx_valorproduto;
    }
}