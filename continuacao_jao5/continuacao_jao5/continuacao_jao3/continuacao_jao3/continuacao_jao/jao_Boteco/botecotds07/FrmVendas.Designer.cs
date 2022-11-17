namespace BotecoTDS07
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.txtIDVenda = new System.Windows.Forms.TextBox();
            this.lblIDVenda = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblIDProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizarPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDVenda
            // 
            this.txtIDVenda.Location = new System.Drawing.Point(83, 8);
            this.txtIDVenda.Name = "txtIDVenda";
            this.txtIDVenda.Size = new System.Drawing.Size(187, 20);
            this.txtIDVenda.TabIndex = 0;
            // 
            // lblIDVenda
            // 
            this.lblIDVenda.AutoSize = true;
            this.lblIDVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIDVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVenda.Location = new System.Drawing.Point(12, 9);
            this.lblIDVenda.Name = "lblIDVenda";
            this.lblIDVenda.Size = new System.Drawing.Size(65, 15);
            this.lblIDVenda.TabIndex = 1;
            this.lblIDVenda.Text = "ID Venda";
            // 
            // cbxCliente
            // 
            this.cbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(83, 59);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(511, 21);
            this.cbxCliente.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 261);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(773, 186);
            this.dgv.TabIndex = 3;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnLocalizar.Location = new System.Drawing.Point(276, 6);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(224, 23);
            this.btnLocalizar.TabIndex = 4;
            this.btnLocalizar.Text = "Localizar Pedido / Venda";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 183);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 15);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(93, 183);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(83, 100);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(511, 21);
            this.cbxProduto.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditar.Location = new System.Drawing.Point(467, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar Item";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 15);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 101);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(57, 15);
            this.lblProduto.TabIndex = 10;
            this.lblProduto.Text = "Produto";
            // 
            // lblIDProduto
            // 
            this.lblIDProduto.AutoSize = true;
            this.lblIDProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProduto.Location = new System.Drawing.Point(12, 147);
            this.lblIDProduto.Name = "lblIDProduto";
            this.lblIDProduto.Size = new System.Drawing.Size(75, 15);
            this.lblIDProduto.TabIndex = 11;
            this.lblIDProduto.Text = "ID Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(12, 217);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(62, 15);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor R$";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(208, 185);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(63, 15);
            this.lblEstoque.TabIndex = 13;
            this.lblEstoque.Text = "Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total R$";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(93, 146);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(651, 461);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 16;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(93, 216);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 20);
            this.txtValor.TabIndex = 17;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNovoItem.Location = new System.Drawing.Point(467, 139);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(127, 27);
            this.btnNovoItem.TabIndex = 18;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.Location = new System.Drawing.Point(643, 42);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(133, 33);
            this.btnNovoProduto.TabIndex = 19;
            this.btnNovoProduto.Text = "Novo Pedido";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(467, 214);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 32);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarPedido
            // 
            this.btnAtualizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPedido.Location = new System.Drawing.Point(643, 93);
            this.btnAtualizarPedido.Name = "btnAtualizarPedido";
            this.btnAtualizarPedido.Size = new System.Drawing.Size(133, 37);
            this.btnAtualizarPedido.TabIndex = 21;
            this.btnAtualizarPedido.Text = "Atualizar Pedido";
            this.btnAtualizarPedido.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(332, 486);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(149, 23);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(487, 486);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(149, 23);
            this.btnFinalizarPedido.TabIndex = 24;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(642, 486);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(149, 23);
            this.btnFinalizarVenda.TabIndex = 25;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAtualizarPedido);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblIDProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblIDVenda);
            this.Controls.Add(this.txtIDVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDVenda;
        private System.Windows.Forms.Label lblIDVenda;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblIDProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizarPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnFinalizarVenda;
    }
}