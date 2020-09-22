namespace SistemaMarcenariaRodrigues.Forms.EntradaSaida
{
    partial class FormConsultaEstoque
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
            this.panelBarraJanela = new System.Windows.Forms.Panel();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbTituloJanela = new System.Windows.Forms.Label();
            this.btNormal = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.btExportar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lbFiltroResultadoDim = new System.Windows.Forms.Label();
            this.lbFiltroDimensao = new System.Windows.Forms.Label();
            this.lbFiltroResultadoData = new System.Windows.Forms.Label();
            this.lbFiltroData = new System.Windows.Forms.Label();
            this.lbFiltroResultadoFornecedor = new System.Windows.Forms.Label();
            this.lbFiltroFornecedor = new System.Windows.Forms.Label();
            this.lbFiltroResultadoProduto = new System.Windows.Forms.Label();
            this.lbFiltroCodigo = new System.Windows.Forms.Label();
            this.cbFiltroProduto = new System.Windows.Forms.ComboBox();
            this.lbFiltroProduto = new System.Windows.Forms.Label();
            this.lbPagina = new System.Windows.Forms.Label();
            this.btProximaPagina = new System.Windows.Forms.Button();
            this.btPaginaAnterior = new System.Windows.Forms.Button();
            this.lbQuantidadePagina = new System.Windows.Forms.Label();
            this.cbQtdPagina = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbRodapeValorTotal = new System.Windows.Forms.Label();
            this.lbRodapeVTResultado = new System.Windows.Forms.Label();
            this.panelBarraJanela.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.gbPreco.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraJanela
            // 
            this.panelBarraJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBarraJanela.Controls.Add(this.btMinimizar);
            this.panelBarraJanela.Controls.Add(this.btMaximizar);
            this.panelBarraJanela.Controls.Add(this.btFechar);
            this.panelBarraJanela.Controls.Add(this.lbTituloJanela);
            this.panelBarraJanela.Controls.Add(this.btNormal);
            this.panelBarraJanela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraJanela.Location = new System.Drawing.Point(0, 0);
            this.panelBarraJanela.Name = "panelBarraJanela";
            this.panelBarraJanela.Size = new System.Drawing.Size(960, 25);
            this.panelBarraJanela.TabIndex = 6;
            this.panelBarraJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraJanela_MouseMove);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(888, 0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Maximizar;
            this.btMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.Location = new System.Drawing.Point(913, -1);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btMaximizar.TabIndex = 1;
            this.btMaximizar.UseVisualStyleBackColor = true;
            this.btMaximizar.Visible = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Fechar01;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(937, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(23, 23);
            this.btFechar.TabIndex = 0;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbTituloJanela
            // 
            this.lbTituloJanela.AutoSize = true;
            this.lbTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTituloJanela.Location = new System.Drawing.Point(12, 6);
            this.lbTituloJanela.Name = "lbTituloJanela";
            this.lbTituloJanela.Size = new System.Drawing.Size(65, 16);
            this.lbTituloJanela.TabIndex = 0;
            this.lbTituloJanela.Text = "Estoque";
            // 
            // btNormal
            // 
            this.btNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNormal.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Normal;
            this.btNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNormal.FlatAppearance.BorderSize = 0;
            this.btNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNormal.Location = new System.Drawing.Point(913, 0);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(23, 23);
            this.btNormal.TabIndex = 3;
            this.btNormal.UseVisualStyleBackColor = true;
            this.btNormal.Click += new System.EventHandler(this.btNormal_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.dgvEstoque);
            this.panelDesktop.Controls.Add(this.gbPreco);
            this.panelDesktop.Controls.Add(this.gbFiltro);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 25);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(960, 517);
            this.panelDesktop.TabIndex = 7;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 124);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(960, 357);
            this.dgvEstoque.TabIndex = 14;
            // 
            // gbPreco
            // 
            this.gbPreco.BackColor = System.Drawing.Color.LightGray;
            this.gbPreco.Controls.Add(this.lbRodapeVTResultado);
            this.gbPreco.Controls.Add(this.lbRodapeValorTotal);
            this.gbPreco.Controls.Add(this.btExportar);
            this.gbPreco.Controls.Add(this.btImprimir);
            this.gbPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(0, 481);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(960, 36);
            this.gbPreco.TabIndex = 13;
            this.gbPreco.TabStop = false;
            // 
            // btExportar
            // 
            this.btExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExportar.FlatAppearance.BorderSize = 0;
            this.btExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btExportar.Location = new System.Drawing.Point(695, 10);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(128, 23);
            this.btExportar.TabIndex = 16;
            this.btExportar.Text = "EXPORTAR";
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btImprimir.Location = new System.Drawing.Point(829, 10);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(128, 23);
            this.btImprimir.TabIndex = 17;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.BackColor = System.Drawing.Color.LightGray;
            this.gbFiltro.Controls.Add(this.lbFiltroResultadoDim);
            this.gbFiltro.Controls.Add(this.lbFiltroDimensao);
            this.gbFiltro.Controls.Add(this.lbFiltroResultadoData);
            this.gbFiltro.Controls.Add(this.lbFiltroData);
            this.gbFiltro.Controls.Add(this.lbFiltroResultadoFornecedor);
            this.gbFiltro.Controls.Add(this.lbFiltroFornecedor);
            this.gbFiltro.Controls.Add(this.lbFiltroResultadoProduto);
            this.gbFiltro.Controls.Add(this.lbFiltroCodigo);
            this.gbFiltro.Controls.Add(this.cbFiltroProduto);
            this.gbFiltro.Controls.Add(this.lbFiltroProduto);
            this.gbFiltro.Controls.Add(this.lbPagina);
            this.gbFiltro.Controls.Add(this.btProximaPagina);
            this.gbFiltro.Controls.Add(this.btPaginaAnterior);
            this.gbFiltro.Controls.Add(this.lbQuantidadePagina);
            this.gbFiltro.Controls.Add(this.cbQtdPagina);
            this.gbFiltro.Controls.Add(this.btPesquisar);
            this.gbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(0, 0);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(960, 124);
            this.gbFiltro.TabIndex = 12;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // lbFiltroResultadoDim
            // 
            this.lbFiltroResultadoDim.AutoSize = true;
            this.lbFiltroResultadoDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroResultadoDim.Location = new System.Drawing.Point(189, 95);
            this.lbFiltroResultadoDim.Name = "lbFiltroResultadoDim";
            this.lbFiltroResultadoDim.Size = new System.Drawing.Size(67, 13);
            this.lbFiltroResultadoDim.TabIndex = 75;
            this.lbFiltroResultadoDim.Text = "00m x 00m";
            this.lbFiltroResultadoDim.Visible = false;
            // 
            // lbFiltroDimensao
            // 
            this.lbFiltroDimensao.AutoSize = true;
            this.lbFiltroDimensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroDimensao.Location = new System.Drawing.Point(189, 75);
            this.lbFiltroDimensao.Name = "lbFiltroDimensao";
            this.lbFiltroDimensao.Size = new System.Drawing.Size(59, 13);
            this.lbFiltroDimensao.TabIndex = 74;
            this.lbFiltroDimensao.Text = "Dimensões";
            // 
            // lbFiltroResultadoData
            // 
            this.lbFiltroResultadoData.AutoSize = true;
            this.lbFiltroResultadoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroResultadoData.Location = new System.Drawing.Point(91, 95);
            this.lbFiltroResultadoData.Name = "lbFiltroResultadoData";
            this.lbFiltroResultadoData.Size = new System.Drawing.Size(75, 13);
            this.lbFiltroResultadoData.TabIndex = 73;
            this.lbFiltroResultadoData.Text = "00/00/0000";
            this.lbFiltroResultadoData.Visible = false;
            // 
            // lbFiltroData
            // 
            this.lbFiltroData.AutoSize = true;
            this.lbFiltroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroData.Location = new System.Drawing.Point(91, 75);
            this.lbFiltroData.Name = "lbFiltroData";
            this.lbFiltroData.Size = new System.Drawing.Size(30, 13);
            this.lbFiltroData.TabIndex = 72;
            this.lbFiltroData.Text = "Data";
            // 
            // lbFiltroResultadoFornecedor
            // 
            this.lbFiltroResultadoFornecedor.AutoSize = true;
            this.lbFiltroResultadoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroResultadoFornecedor.Location = new System.Drawing.Point(189, 35);
            this.lbFiltroResultadoFornecedor.Name = "lbFiltroResultadoFornecedor";
            this.lbFiltroResultadoFornecedor.Size = new System.Drawing.Size(135, 13);
            this.lbFiltroResultadoFornecedor.TabIndex = 71;
            this.lbFiltroResultadoFornecedor.Text = "Retorno do fornecedor";
            this.lbFiltroResultadoFornecedor.Visible = false;
            // 
            // lbFiltroFornecedor
            // 
            this.lbFiltroFornecedor.AutoSize = true;
            this.lbFiltroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroFornecedor.Location = new System.Drawing.Point(189, 16);
            this.lbFiltroFornecedor.Name = "lbFiltroFornecedor";
            this.lbFiltroFornecedor.Size = new System.Drawing.Size(104, 13);
            this.lbFiltroFornecedor.TabIndex = 70;
            this.lbFiltroFornecedor.Text = "Fornecedor Principal";
            // 
            // lbFiltroResultadoProduto
            // 
            this.lbFiltroResultadoProduto.AutoSize = true;
            this.lbFiltroResultadoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroResultadoProduto.Location = new System.Drawing.Point(12, 95);
            this.lbFiltroResultadoProduto.Name = "lbFiltroResultadoProduto";
            this.lbFiltroResultadoProduto.Size = new System.Drawing.Size(51, 13);
            this.lbFiltroResultadoProduto.TabIndex = 69;
            this.lbFiltroResultadoProduto.Text = "Produto";
            this.lbFiltroResultadoProduto.Visible = false;
            // 
            // lbFiltroCodigo
            // 
            this.lbFiltroCodigo.AutoSize = true;
            this.lbFiltroCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroCodigo.Location = new System.Drawing.Point(12, 76);
            this.lbFiltroCodigo.Name = "lbFiltroCodigo";
            this.lbFiltroCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCodigo.TabIndex = 68;
            this.lbFiltroCodigo.Text = "Codigo";
            // 
            // cbFiltroProduto
            // 
            this.cbFiltroProduto.FormattingEnabled = true;
            this.cbFiltroProduto.Location = new System.Drawing.Point(15, 33);
            this.cbFiltroProduto.Name = "cbFiltroProduto";
            this.cbFiltroProduto.Size = new System.Drawing.Size(151, 21);
            this.cbFiltroProduto.TabIndex = 54;
            // 
            // lbFiltroProduto
            // 
            this.lbFiltroProduto.AutoSize = true;
            this.lbFiltroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroProduto.ForeColor = System.Drawing.Color.Black;
            this.lbFiltroProduto.Location = new System.Drawing.Point(12, 16);
            this.lbFiltroProduto.Name = "lbFiltroProduto";
            this.lbFiltroProduto.Size = new System.Drawing.Size(44, 13);
            this.lbFiltroProduto.TabIndex = 53;
            this.lbFiltroProduto.Text = "Produto";
            // 
            // lbPagina
            // 
            this.lbPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPagina.AutoSize = true;
            this.lbPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagina.ForeColor = System.Drawing.Color.Black;
            this.lbPagina.Location = new System.Drawing.Point(882, 100);
            this.lbPagina.Name = "lbPagina";
            this.lbPagina.Size = new System.Drawing.Size(40, 13);
            this.lbPagina.TabIndex = 52;
            this.lbPagina.Text = "Pagina";
            // 
            // btProximaPagina
            // 
            this.btProximaPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btProximaPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btProximaPagina.Enabled = false;
            this.btProximaPagina.FlatAppearance.BorderSize = 0;
            this.btProximaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximaPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btProximaPagina.Location = new System.Drawing.Point(925, 95);
            this.btProximaPagina.Name = "btProximaPagina";
            this.btProximaPagina.Size = new System.Drawing.Size(23, 23);
            this.btProximaPagina.TabIndex = 8;
            this.btProximaPagina.Text = ">";
            this.btProximaPagina.UseVisualStyleBackColor = false;
            this.btProximaPagina.Click += new System.EventHandler(this.btProximaPagina_Click);
            // 
            // btPaginaAnterior
            // 
            this.btPaginaAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPaginaAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPaginaAnterior.Enabled = false;
            this.btPaginaAnterior.FlatAppearance.BorderSize = 0;
            this.btPaginaAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaginaAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPaginaAnterior.Location = new System.Drawing.Point(853, 95);
            this.btPaginaAnterior.Name = "btPaginaAnterior";
            this.btPaginaAnterior.Size = new System.Drawing.Size(23, 23);
            this.btPaginaAnterior.TabIndex = 7;
            this.btPaginaAnterior.Text = "<";
            this.btPaginaAnterior.UseVisualStyleBackColor = false;
            this.btPaginaAnterior.Click += new System.EventHandler(this.btPaginaAnterior_Click);
            // 
            // lbQuantidadePagina
            // 
            this.lbQuantidadePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantidadePagina.AutoSize = true;
            this.lbQuantidadePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadePagina.ForeColor = System.Drawing.Color.Black;
            this.lbQuantidadePagina.Location = new System.Drawing.Point(682, 100);
            this.lbQuantidadePagina.Name = "lbQuantidadePagina";
            this.lbQuantidadePagina.Size = new System.Drawing.Size(78, 13);
            this.lbQuantidadePagina.TabIndex = 49;
            this.lbQuantidadePagina.Text = "Qtd por Pagina";
            // 
            // cbQtdPagina
            // 
            this.cbQtdPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQtdPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQtdPagina.FormattingEnabled = true;
            this.cbQtdPagina.Location = new System.Drawing.Point(766, 97);
            this.cbQtdPagina.Name = "cbQtdPagina";
            this.cbQtdPagina.Size = new System.Drawing.Size(81, 21);
            this.cbQtdPagina.TabIndex = 6;
            this.cbQtdPagina.SelectedIndexChanged += new System.EventHandler(this.cbQtdPagina_SelectedIndexChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPesquisar.Location = new System.Drawing.Point(858, 47);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(90, 23);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // lbRodapeValorTotal
            // 
            this.lbRodapeValorTotal.AutoSize = true;
            this.lbRodapeValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodapeValorTotal.Location = new System.Drawing.Point(12, 14);
            this.lbRodapeValorTotal.Name = "lbRodapeValorTotal";
            this.lbRodapeValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lbRodapeValorTotal.TabIndex = 69;
            this.lbRodapeValorTotal.Text = "Valor Total:";
            // 
            // lbRodapeVTResultado
            // 
            this.lbRodapeVTResultado.AutoSize = true;
            this.lbRodapeVTResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodapeVTResultado.Location = new System.Drawing.Point(79, 14);
            this.lbRodapeVTResultado.Name = "lbRodapeVTResultado";
            this.lbRodapeVTResultado.Size = new System.Drawing.Size(51, 13);
            this.lbRodapeVTResultado.TabIndex = 70;
            this.lbRodapeVTResultado.Text = "Produto";
            this.lbRodapeVTResultado.Visible = false;
            // 
            // FormConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBarraJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaEstoque";
            this.Text = "FormConsultaEstoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBarraJanela.ResumeLayout(false);
            this.panelBarraJanela.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraJanela;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbTituloJanela;
        private System.Windows.Forms.Button btNormal;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.ComboBox cbFiltroProduto;
        private System.Windows.Forms.Label lbFiltroProduto;
        private System.Windows.Forms.Label lbPagina;
        private System.Windows.Forms.Button btProximaPagina;
        private System.Windows.Forms.Button btPaginaAnterior;
        private System.Windows.Forms.Label lbQuantidadePagina;
        private System.Windows.Forms.ComboBox cbQtdPagina;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label lbFiltroResultadoProduto;
        private System.Windows.Forms.Label lbFiltroCodigo;
        private System.Windows.Forms.Label lbFiltroResultadoFornecedor;
        private System.Windows.Forms.Label lbFiltroFornecedor;
        private System.Windows.Forms.Label lbFiltroResultadoData;
        private System.Windows.Forms.Label lbFiltroData;
        private System.Windows.Forms.Label lbFiltroResultadoDim;
        private System.Windows.Forms.Label lbFiltroDimensao;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label lbRodapeVTResultado;
        private System.Windows.Forms.Label lbRodapeValorTotal;
    }
}