namespace SistemaMarcenariaRodrigues.Forms.Produtos
{
    partial class FormCadastroProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lbPagina = new System.Windows.Forms.Label();
            this.btProximaPagina = new System.Windows.Forms.Button();
            this.btPaginaAnterior = new System.Windows.Forms.Button();
            this.lbQuantidadePagina = new System.Windows.Forms.Label();
            this.cbQtdPagina = new System.Windows.Forms.ComboBox();
            this.gbFiltroOrdenar = new System.Windows.Forms.GroupBox();
            this.rbFiltroDecrescente = new System.Windows.Forms.RadioButton();
            this.rbFiltroCrescente = new System.Windows.Forms.RadioButton();
            this.lbFiltroFornecedor = new System.Windows.Forms.Label();
            this.txFiltroFornecedor = new System.Windows.Forms.TextBox();
            this.lbFiltroProduto = new System.Windows.Forms.Label();
            this.txFiltroProduto = new System.Windows.Forms.TextBox();
            this.txFiltroCodigo = new System.Windows.Forms.TextBox();
            this.lbFiltroCodigo = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.lbEditarCodigoR = new System.Windows.Forms.Label();
            this.lbRditarCodigo = new System.Windows.Forms.Label();
            this.lbEditarStatus = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.btEsconderEditar = new System.Windows.Forms.Button();
            this.lbEditarDetalhes = new System.Windows.Forms.Label();
            this.txEditarDetalhes = new System.Windows.Forms.TextBox();
            this.lbEditarFornecedor = new System.Windows.Forms.Label();
            this.txEditarFornecedor = new System.Windows.Forms.TextBox();
            this.txEditarProduto = new System.Windows.Forms.TextBox();
            this.lcEditarDomensoes = new System.Windows.Forms.Label();
            this.txEditarDimensoes = new System.Windows.Forms.TextBox();
            this.lbEditarProduto = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.btAbrirCadastro = new System.Windows.Forms.Button();
            this.btAbrirEdicao = new System.Windows.Forms.Button();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btEsconderCadastro = new System.Windows.Forms.Button();
            this.lbCadastroDetalhes = new System.Windows.Forms.Label();
            this.txCadastroDetalhes = new System.Windows.Forms.TextBox();
            this.lbCadastroFornecedor = new System.Windows.Forms.Label();
            this.txCadastroFornecedor = new System.Windows.Forms.TextBox();
            this.txCadastroProduto = new System.Windows.Forms.TextBox();
            this.lbCadastroDimensoes = new System.Windows.Forms.Label();
            this.txCadastroDimensoes = new System.Windows.Forms.TextBox();
            this.lbCadastroProduto = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.panelBarraJanela.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbFiltroOrdenar.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.gbPreco.SuspendLayout();
            this.gbCadastro.SuspendLayout();
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
            this.panelBarraJanela.Size = new System.Drawing.Size(954, 25);
            this.panelBarraJanela.TabIndex = 4;
            this.panelBarraJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraJanela_MouseMove);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(882, 0);
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
            this.btMaximizar.Location = new System.Drawing.Point(907, -1);
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
            this.btFechar.Location = new System.Drawing.Point(931, 0);
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
            this.lbTituloJanela.Size = new System.Drawing.Size(70, 16);
            this.lbTituloJanela.TabIndex = 0;
            this.lbTituloJanela.Text = "Produtos";
            // 
            // btNormal
            // 
            this.btNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNormal.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Normal;
            this.btNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNormal.FlatAppearance.BorderSize = 0;
            this.btNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNormal.Location = new System.Drawing.Point(907, 0);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(23, 23);
            this.btNormal.TabIndex = 3;
            this.btNormal.UseVisualStyleBackColor = true;
            this.btNormal.Click += new System.EventHandler(this.btNormal_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.dgvProdutos);
            this.panelDesktop.Controls.Add(this.gbFiltro);
            this.panelDesktop.Controls.Add(this.gbEditar);
            this.panelDesktop.Controls.Add(this.gbPreco);
            this.panelDesktop.Controls.Add(this.gbCadastro);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 25);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(954, 511);
            this.panelDesktop.TabIndex = 5;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 326);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(954, 149);
            this.dgvProdutos.TabIndex = 10;
            this.dgvProdutos.Click += new System.EventHandler(this.dgvProdutos_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.BackColor = System.Drawing.Color.LightGray;
            this.gbFiltro.Controls.Add(this.lbPagina);
            this.gbFiltro.Controls.Add(this.btProximaPagina);
            this.gbFiltro.Controls.Add(this.btPaginaAnterior);
            this.gbFiltro.Controls.Add(this.lbQuantidadePagina);
            this.gbFiltro.Controls.Add(this.cbQtdPagina);
            this.gbFiltro.Controls.Add(this.gbFiltroOrdenar);
            this.gbFiltro.Controls.Add(this.lbFiltroFornecedor);
            this.gbFiltro.Controls.Add(this.txFiltroFornecedor);
            this.gbFiltro.Controls.Add(this.lbFiltroProduto);
            this.gbFiltro.Controls.Add(this.txFiltroProduto);
            this.gbFiltro.Controls.Add(this.txFiltroCodigo);
            this.gbFiltro.Controls.Add(this.lbFiltroCodigo);
            this.gbFiltro.Controls.Add(this.btPesquisar);
            this.gbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(0, 234);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(954, 92);
            this.gbFiltro.TabIndex = 7;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // lbPagina
            // 
            this.lbPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPagina.AutoSize = true;
            this.lbPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagina.Location = new System.Drawing.Point(876, 68);
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
            this.btProximaPagina.Location = new System.Drawing.Point(919, 63);
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
            this.btPaginaAnterior.Location = new System.Drawing.Point(847, 63);
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
            this.lbQuantidadePagina.Location = new System.Drawing.Point(676, 68);
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
            this.cbQtdPagina.Location = new System.Drawing.Point(760, 65);
            this.cbQtdPagina.Name = "cbQtdPagina";
            this.cbQtdPagina.Size = new System.Drawing.Size(81, 21);
            this.cbQtdPagina.TabIndex = 6;
            this.cbQtdPagina.SelectedIndexChanged += new System.EventHandler(this.cbQtdPagina_SelectedIndexChanged);
            // 
            // gbFiltroOrdenar
            // 
            this.gbFiltroOrdenar.Controls.Add(this.rbFiltroDecrescente);
            this.gbFiltroOrdenar.Controls.Add(this.rbFiltroCrescente);
            this.gbFiltroOrdenar.Location = new System.Drawing.Point(554, 18);
            this.gbFiltroOrdenar.Name = "gbFiltroOrdenar";
            this.gbFiltroOrdenar.Size = new System.Drawing.Size(211, 38);
            this.gbFiltroOrdenar.TabIndex = 47;
            this.gbFiltroOrdenar.TabStop = false;
            this.gbFiltroOrdenar.Text = "Ordenar";
            // 
            // rbFiltroDecrescente
            // 
            this.rbFiltroDecrescente.AutoSize = true;
            this.rbFiltroDecrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFiltroDecrescente.Location = new System.Drawing.Point(118, 15);
            this.rbFiltroDecrescente.Name = "rbFiltroDecrescente";
            this.rbFiltroDecrescente.Size = new System.Drawing.Size(86, 17);
            this.rbFiltroDecrescente.TabIndex = 4;
            this.rbFiltroDecrescente.Text = "Decrescente";
            this.rbFiltroDecrescente.UseVisualStyleBackColor = true;
            // 
            // rbFiltroCrescente
            // 
            this.rbFiltroCrescente.AutoSize = true;
            this.rbFiltroCrescente.Checked = true;
            this.rbFiltroCrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFiltroCrescente.Location = new System.Drawing.Point(17, 15);
            this.rbFiltroCrescente.Name = "rbFiltroCrescente";
            this.rbFiltroCrescente.Size = new System.Drawing.Size(73, 17);
            this.rbFiltroCrescente.TabIndex = 3;
            this.rbFiltroCrescente.TabStop = true;
            this.rbFiltroCrescente.Text = "Crescente";
            this.rbFiltroCrescente.UseVisualStyleBackColor = true;
            // 
            // lbFiltroFornecedor
            // 
            this.lbFiltroFornecedor.AutoSize = true;
            this.lbFiltroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroFornecedor.Location = new System.Drawing.Point(337, 20);
            this.lbFiltroFornecedor.Name = "lbFiltroFornecedor";
            this.lbFiltroFornecedor.Size = new System.Drawing.Size(104, 13);
            this.lbFiltroFornecedor.TabIndex = 45;
            this.lbFiltroFornecedor.Text = "Fornecedor Principal";
            // 
            // txFiltroFornecedor
            // 
            this.txFiltroFornecedor.Location = new System.Drawing.Point(340, 36);
            this.txFiltroFornecedor.Name = "txFiltroFornecedor";
            this.txFiltroFornecedor.Size = new System.Drawing.Size(208, 20);
            this.txFiltroFornecedor.TabIndex = 2;
            // 
            // lbFiltroProduto
            // 
            this.lbFiltroProduto.AutoSize = true;
            this.lbFiltroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroProduto.Location = new System.Drawing.Point(123, 20);
            this.lbFiltroProduto.Name = "lbFiltroProduto";
            this.lbFiltroProduto.Size = new System.Drawing.Size(44, 13);
            this.lbFiltroProduto.TabIndex = 43;
            this.lbFiltroProduto.Text = "Produto";
            // 
            // txFiltroProduto
            // 
            this.txFiltroProduto.Location = new System.Drawing.Point(126, 36);
            this.txFiltroProduto.Name = "txFiltroProduto";
            this.txFiltroProduto.Size = new System.Drawing.Size(208, 20);
            this.txFiltroProduto.TabIndex = 1;
            // 
            // txFiltroCodigo
            // 
            this.txFiltroCodigo.Location = new System.Drawing.Point(15, 36);
            this.txFiltroCodigo.Name = "txFiltroCodigo";
            this.txFiltroCodigo.Size = new System.Drawing.Size(105, 20);
            this.txFiltroCodigo.TabIndex = 0;
            this.txFiltroCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFiltroCodigo_KeyPress);
            // 
            // lbFiltroCodigo
            // 
            this.lbFiltroCodigo.AutoSize = true;
            this.lbFiltroCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroCodigo.Location = new System.Drawing.Point(12, 20);
            this.lbFiltroCodigo.Name = "lbFiltroCodigo";
            this.lbFiltroCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCodigo.TabIndex = 24;
            this.lbFiltroCodigo.Text = "Codigo";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPesquisar.Location = new System.Drawing.Point(852, 20);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(90, 23);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.BackColor = System.Drawing.Color.LightGray;
            this.gbEditar.Controls.Add(this.lbEditarCodigoR);
            this.gbEditar.Controls.Add(this.lbRditarCodigo);
            this.gbEditar.Controls.Add(this.lbEditarStatus);
            this.gbEditar.Controls.Add(this.cbEditarStatus);
            this.gbEditar.Controls.Add(this.btEsconderEditar);
            this.gbEditar.Controls.Add(this.lbEditarDetalhes);
            this.gbEditar.Controls.Add(this.txEditarDetalhes);
            this.gbEditar.Controls.Add(this.lbEditarFornecedor);
            this.gbEditar.Controls.Add(this.txEditarFornecedor);
            this.gbEditar.Controls.Add(this.txEditarProduto);
            this.gbEditar.Controls.Add(this.lcEditarDomensoes);
            this.gbEditar.Controls.Add(this.txEditarDimensoes);
            this.gbEditar.Controls.Add(this.lbEditarProduto);
            this.gbEditar.Controls.Add(this.btEditar);
            this.gbEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.Location = new System.Drawing.Point(0, 117);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(954, 117);
            this.gbEditar.TabIndex = 9;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            this.gbEditar.Visible = false;
            // 
            // lbEditarCodigoR
            // 
            this.lbEditarCodigoR.AutoSize = true;
            this.lbEditarCodigoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarCodigoR.Location = new System.Drawing.Point(12, 39);
            this.lbEditarCodigoR.Name = "lbEditarCodigoR";
            this.lbEditarCodigoR.Size = new System.Drawing.Size(51, 13);
            this.lbEditarCodigoR.TabIndex = 49;
            this.lbEditarCodigoR.Text = "Produto";
            // 
            // lbRditarCodigo
            // 
            this.lbRditarCodigo.AutoSize = true;
            this.lbRditarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRditarCodigo.Location = new System.Drawing.Point(12, 20);
            this.lbRditarCodigo.Name = "lbRditarCodigo";
            this.lbRditarCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbRditarCodigo.TabIndex = 48;
            this.lbRditarCodigo.Text = "Codigo";
            // 
            // lbEditarStatus
            // 
            this.lbEditarStatus.AutoSize = true;
            this.lbEditarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarStatus.Location = new System.Drawing.Point(310, 19);
            this.lbEditarStatus.Name = "lbEditarStatus";
            this.lbEditarStatus.Size = new System.Drawing.Size(37, 13);
            this.lbEditarStatus.TabIndex = 47;
            this.lbEditarStatus.Text = "Status";
            // 
            // cbEditarStatus
            // 
            this.cbEditarStatus.FormattingEnabled = true;
            this.cbEditarStatus.Location = new System.Drawing.Point(313, 35);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(121, 21);
            this.cbEditarStatus.TabIndex = 46;
            // 
            // btEsconderEditar
            // 
            this.btEsconderEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEsconderEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEsconderEditar.FlatAppearance.BorderSize = 0;
            this.btEsconderEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsconderEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEsconderEditar.Location = new System.Drawing.Point(931, 12);
            this.btEsconderEditar.Name = "btEsconderEditar";
            this.btEsconderEditar.Size = new System.Drawing.Size(17, 18);
            this.btEsconderEditar.TabIndex = 15;
            this.btEsconderEditar.Text = "V";
            this.btEsconderEditar.UseVisualStyleBackColor = false;
            this.btEsconderEditar.Click += new System.EventHandler(this.btEsconderEditar_Click);
            // 
            // lbEditarDetalhes
            // 
            this.lbEditarDetalhes.AutoSize = true;
            this.lbEditarDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarDetalhes.Location = new System.Drawing.Point(440, 20);
            this.lbEditarDetalhes.Name = "lbEditarDetalhes";
            this.lbEditarDetalhes.Size = new System.Drawing.Size(49, 13);
            this.lbEditarDetalhes.TabIndex = 45;
            this.lbEditarDetalhes.Text = "Detalhes";
            // 
            // txEditarDetalhes
            // 
            this.txEditarDetalhes.Location = new System.Drawing.Point(443, 36);
            this.txEditarDetalhes.Multiline = true;
            this.txEditarDetalhes.Name = "txEditarDetalhes";
            this.txEditarDetalhes.Size = new System.Drawing.Size(208, 69);
            this.txEditarDetalhes.TabIndex = 3;
            // 
            // lbEditarFornecedor
            // 
            this.lbEditarFornecedor.AutoSize = true;
            this.lbEditarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarFornecedor.Location = new System.Drawing.Point(12, 66);
            this.lbEditarFornecedor.Name = "lbEditarFornecedor";
            this.lbEditarFornecedor.Size = new System.Drawing.Size(104, 13);
            this.lbEditarFornecedor.TabIndex = 43;
            this.lbEditarFornecedor.Text = "Fornecedor Principal";
            // 
            // txEditarFornecedor
            // 
            this.txEditarFornecedor.Location = new System.Drawing.Point(15, 85);
            this.txEditarFornecedor.Name = "txEditarFornecedor";
            this.txEditarFornecedor.Size = new System.Drawing.Size(208, 20);
            this.txEditarFornecedor.TabIndex = 1;
            // 
            // txEditarProduto
            // 
            this.txEditarProduto.Location = new System.Drawing.Point(99, 36);
            this.txEditarProduto.Name = "txEditarProduto";
            this.txEditarProduto.Size = new System.Drawing.Size(208, 20);
            this.txEditarProduto.TabIndex = 0;
            // 
            // lcEditarDomensoes
            // 
            this.lcEditarDomensoes.AutoSize = true;
            this.lcEditarDomensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcEditarDomensoes.Location = new System.Drawing.Point(226, 66);
            this.lcEditarDomensoes.Name = "lcEditarDomensoes";
            this.lcEditarDomensoes.Size = new System.Drawing.Size(59, 13);
            this.lcEditarDomensoes.TabIndex = 26;
            this.lcEditarDomensoes.Text = "Dimensões";
            // 
            // txEditarDimensoes
            // 
            this.txEditarDimensoes.Location = new System.Drawing.Point(229, 85);
            this.txEditarDimensoes.Name = "txEditarDimensoes";
            this.txEditarDimensoes.Size = new System.Drawing.Size(208, 20);
            this.txEditarDimensoes.TabIndex = 2;
            // 
            // lbEditarProduto
            // 
            this.lbEditarProduto.AutoSize = true;
            this.lbEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarProduto.Location = new System.Drawing.Point(96, 20);
            this.lbEditarProduto.Name = "lbEditarProduto";
            this.lbEditarProduto.Size = new System.Drawing.Size(44, 13);
            this.lbEditarProduto.TabIndex = 24;
            this.lbEditarProduto.Text = "Produto";
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEditar.Location = new System.Drawing.Point(852, 83);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(90, 23);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // gbPreco
            // 
            this.gbPreco.BackColor = System.Drawing.Color.LightGray;
            this.gbPreco.Controls.Add(this.btAbrirCadastro);
            this.gbPreco.Controls.Add(this.btAbrirEdicao);
            this.gbPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(0, 475);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(954, 36);
            this.gbPreco.TabIndex = 8;
            this.gbPreco.TabStop = false;
            // 
            // btAbrirCadastro
            // 
            this.btAbrirCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbrirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAbrirCadastro.FlatAppearance.BorderSize = 0;
            this.btAbrirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAbrirCadastro.Location = new System.Drawing.Point(689, 10);
            this.btAbrirCadastro.Name = "btAbrirCadastro";
            this.btAbrirCadastro.Size = new System.Drawing.Size(128, 23);
            this.btAbrirCadastro.TabIndex = 16;
            this.btAbrirCadastro.Text = "CADASTRAR";
            this.btAbrirCadastro.UseVisualStyleBackColor = false;
            this.btAbrirCadastro.Click += new System.EventHandler(this.btAbrirCadastro_Click);
            // 
            // btAbrirEdicao
            // 
            this.btAbrirEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbrirEdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAbrirEdicao.FlatAppearance.BorderSize = 0;
            this.btAbrirEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirEdicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAbrirEdicao.Location = new System.Drawing.Point(823, 10);
            this.btAbrirEdicao.Name = "btAbrirEdicao";
            this.btAbrirEdicao.Size = new System.Drawing.Size(128, 23);
            this.btAbrirEdicao.TabIndex = 17;
            this.btAbrirEdicao.Text = "EDITAR";
            this.btAbrirEdicao.UseVisualStyleBackColor = false;
            this.btAbrirEdicao.Click += new System.EventHandler(this.btAbrirEdicao_Click);
            // 
            // gbCadastro
            // 
            this.gbCadastro.BackColor = System.Drawing.Color.LightGray;
            this.gbCadastro.Controls.Add(this.btEsconderCadastro);
            this.gbCadastro.Controls.Add(this.lbCadastroDetalhes);
            this.gbCadastro.Controls.Add(this.txCadastroDetalhes);
            this.gbCadastro.Controls.Add(this.lbCadastroFornecedor);
            this.gbCadastro.Controls.Add(this.txCadastroFornecedor);
            this.gbCadastro.Controls.Add(this.txCadastroProduto);
            this.gbCadastro.Controls.Add(this.lbCadastroDimensoes);
            this.gbCadastro.Controls.Add(this.txCadastroDimensoes);
            this.gbCadastro.Controls.Add(this.lbCadastroProduto);
            this.gbCadastro.Controls.Add(this.btCadastrar);
            this.gbCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(0, 0);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(954, 117);
            this.gbCadastro.TabIndex = 6;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            this.gbCadastro.Visible = false;
            // 
            // btEsconderCadastro
            // 
            this.btEsconderCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEsconderCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEsconderCadastro.FlatAppearance.BorderSize = 0;
            this.btEsconderCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsconderCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEsconderCadastro.Location = new System.Drawing.Point(931, 12);
            this.btEsconderCadastro.Name = "btEsconderCadastro";
            this.btEsconderCadastro.Size = new System.Drawing.Size(17, 18);
            this.btEsconderCadastro.TabIndex = 14;
            this.btEsconderCadastro.Text = "V";
            this.btEsconderCadastro.UseVisualStyleBackColor = false;
            this.btEsconderCadastro.Click += new System.EventHandler(this.btEsconderCadastro_Click);
            // 
            // lbCadastroDetalhes
            // 
            this.lbCadastroDetalhes.AutoSize = true;
            this.lbCadastroDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroDetalhes.Location = new System.Drawing.Point(440, 20);
            this.lbCadastroDetalhes.Name = "lbCadastroDetalhes";
            this.lbCadastroDetalhes.Size = new System.Drawing.Size(49, 13);
            this.lbCadastroDetalhes.TabIndex = 45;
            this.lbCadastroDetalhes.Text = "Detalhes";
            // 
            // txCadastroDetalhes
            // 
            this.txCadastroDetalhes.Location = new System.Drawing.Point(443, 36);
            this.txCadastroDetalhes.Multiline = true;
            this.txCadastroDetalhes.Name = "txCadastroDetalhes";
            this.txCadastroDetalhes.Size = new System.Drawing.Size(208, 69);
            this.txCadastroDetalhes.TabIndex = 12;
            // 
            // lbCadastroFornecedor
            // 
            this.lbCadastroFornecedor.AutoSize = true;
            this.lbCadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroFornecedor.Location = new System.Drawing.Point(226, 17);
            this.lbCadastroFornecedor.Name = "lbCadastroFornecedor";
            this.lbCadastroFornecedor.Size = new System.Drawing.Size(104, 13);
            this.lbCadastroFornecedor.TabIndex = 43;
            this.lbCadastroFornecedor.Text = "Fornecedor Principal";
            // 
            // txCadastroFornecedor
            // 
            this.txCadastroFornecedor.Location = new System.Drawing.Point(229, 36);
            this.txCadastroFornecedor.Name = "txCadastroFornecedor";
            this.txCadastroFornecedor.Size = new System.Drawing.Size(208, 20);
            this.txCadastroFornecedor.TabIndex = 10;
            // 
            // txCadastroProduto
            // 
            this.txCadastroProduto.Location = new System.Drawing.Point(15, 36);
            this.txCadastroProduto.Name = "txCadastroProduto";
            this.txCadastroProduto.Size = new System.Drawing.Size(208, 20);
            this.txCadastroProduto.TabIndex = 9;
            // 
            // lbCadastroDimensoes
            // 
            this.lbCadastroDimensoes.AutoSize = true;
            this.lbCadastroDimensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroDimensoes.Location = new System.Drawing.Point(226, 66);
            this.lbCadastroDimensoes.Name = "lbCadastroDimensoes";
            this.lbCadastroDimensoes.Size = new System.Drawing.Size(59, 13);
            this.lbCadastroDimensoes.TabIndex = 26;
            this.lbCadastroDimensoes.Text = "Dimensões";
            // 
            // txCadastroDimensoes
            // 
            this.txCadastroDimensoes.Location = new System.Drawing.Point(229, 85);
            this.txCadastroDimensoes.Name = "txCadastroDimensoes";
            this.txCadastroDimensoes.Size = new System.Drawing.Size(208, 20);
            this.txCadastroDimensoes.TabIndex = 11;
            // 
            // lbCadastroProduto
            // 
            this.lbCadastroProduto.AutoSize = true;
            this.lbCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroProduto.Location = new System.Drawing.Point(12, 20);
            this.lbCadastroProduto.Name = "lbCadastroProduto";
            this.lbCadastroProduto.Size = new System.Drawing.Size(44, 13);
            this.lbCadastroProduto.TabIndex = 24;
            this.lbCadastroProduto.Text = "Produto";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCadastrar.Location = new System.Drawing.Point(852, 82);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // FormCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBarraJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroProdutos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBarraJanela.ResumeLayout(false);
            this.panelBarraJanela.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbFiltroOrdenar.ResumeLayout(false);
            this.gbFiltroOrdenar.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbPreco.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
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
        private System.Windows.Forms.Label lbFiltroProduto;
        private System.Windows.Forms.TextBox txFiltroProduto;
        private System.Windows.Forms.TextBox txFiltroCodigo;
        private System.Windows.Forms.Label lbFiltroCodigo;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Label lbCadastroDetalhes;
        private System.Windows.Forms.TextBox txCadastroDetalhes;
        private System.Windows.Forms.Label lbCadastroFornecedor;
        private System.Windows.Forms.TextBox txCadastroFornecedor;
        private System.Windows.Forms.TextBox txCadastroProduto;
        private System.Windows.Forms.Label lbCadastroDimensoes;
        private System.Windows.Forms.TextBox txCadastroDimensoes;
        private System.Windows.Forms.Label lbCadastroProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lbFiltroFornecedor;
        private System.Windows.Forms.TextBox txFiltroFornecedor;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label lbEditarDetalhes;
        private System.Windows.Forms.TextBox txEditarDetalhes;
        private System.Windows.Forms.Label lbEditarFornecedor;
        private System.Windows.Forms.TextBox txEditarFornecedor;
        private System.Windows.Forms.TextBox txEditarProduto;
        private System.Windows.Forms.Label lcEditarDomensoes;
        private System.Windows.Forms.TextBox txEditarDimensoes;
        private System.Windows.Forms.Label lbEditarProduto;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.Button btAbrirCadastro;
        private System.Windows.Forms.Button btAbrirEdicao;
        private System.Windows.Forms.Button btEsconderEditar;
        private System.Windows.Forms.Button btEsconderCadastro;
        private System.Windows.Forms.GroupBox gbFiltroOrdenar;
        private System.Windows.Forms.RadioButton rbFiltroDecrescente;
        private System.Windows.Forms.RadioButton rbFiltroCrescente;
        private System.Windows.Forms.Label lbPagina;
        private System.Windows.Forms.Button btProximaPagina;
        private System.Windows.Forms.Button btPaginaAnterior;
        private System.Windows.Forms.Label lbQuantidadePagina;
        private System.Windows.Forms.ComboBox cbQtdPagina;
        private System.Windows.Forms.Label lbEditarStatus;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.Label lbEditarCodigoR;
        private System.Windows.Forms.Label lbRditarCodigo;
    }
}