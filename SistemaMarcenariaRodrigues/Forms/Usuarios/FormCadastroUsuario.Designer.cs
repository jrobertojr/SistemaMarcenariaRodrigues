namespace SistemaMarcenariaRodrigues.Forms.Usuarios
{
    partial class FormCadastroUsuario
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.btAbrirCadastro = new System.Windows.Forms.Button();
            this.btAbrirEdicao = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.dtFiltroFim = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroStatus = new System.Windows.Forms.Label();
            this.cbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.lbFiltroPrivilegio = new System.Windows.Forms.Label();
            this.txFiltroEmail = new System.Windows.Forms.TextBox();
            this.cbFiltroPrivilegio = new System.Windows.Forms.ComboBox();
            this.lbFiltroEmail = new System.Windows.Forms.Label();
            this.txFiltroNome = new System.Windows.Forms.TextBox();
            this.lbFiltroNome = new System.Windows.Forms.Label();
            this.txFiltroUsuario = new System.Windows.Forms.TextBox();
            this.lbFiltroUsuario = new System.Windows.Forms.Label();
            this.ckFiltroData = new System.Windows.Forms.CheckBox();
            this.dtFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.lbPagina = new System.Windows.Forms.Label();
            this.btProximaPagina = new System.Windows.Forms.Button();
            this.btPaginaAnterior = new System.Windows.Forms.Button();
            this.lbQuantidadePagina = new System.Windows.Forms.Label();
            this.cbQtdPagina = new System.Windows.Forms.ComboBox();
            this.gbFiltroOrdenar = new System.Windows.Forms.GroupBox();
            this.rbFiltroDecrescente = new System.Windows.Forms.RadioButton();
            this.rbFiltroCrescente = new System.Windows.Forms.RadioButton();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.lbEditarStatus = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.lbEditarPrivilegio = new System.Windows.Forms.Label();
            this.cbEditarPrivilegio = new System.Windows.Forms.ComboBox();
            this.txEditarEmail = new System.Windows.Forms.TextBox();
            this.lbEditarEmail = new System.Windows.Forms.Label();
            this.txEditarNome = new System.Windows.Forms.TextBox();
            this.lbEditarNome = new System.Windows.Forms.Label();
            this.txEditarSenha = new System.Windows.Forms.TextBox();
            this.lbEditarSenha = new System.Windows.Forms.Label();
            this.txEditarUsuario = new System.Windows.Forms.TextBox();
            this.lbEditarUsuario = new System.Windows.Forms.Label();
            this.lbEditarIdResultado = new System.Windows.Forms.Label();
            this.lbEditarId = new System.Windows.Forms.Label();
            this.btEsconderEditar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.lbCadastroPrivilegio = new System.Windows.Forms.Label();
            this.cbCadastroPrivilegio = new System.Windows.Forms.ComboBox();
            this.txCadastroEmail = new System.Windows.Forms.TextBox();
            this.lbCadastroEmail = new System.Windows.Forms.Label();
            this.txCadastroNome = new System.Windows.Forms.TextBox();
            this.lbCadastroNome = new System.Windows.Forms.Label();
            this.txCadastroSenha = new System.Windows.Forms.TextBox();
            this.lbCadastroSenha = new System.Windows.Forms.Label();
            this.btEsconderCadastro = new System.Windows.Forms.Button();
            this.txCadastroUsuario = new System.Windows.Forms.TextBox();
            this.lbCadastroUsuario = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.panelBarraJanela.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbPreco.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.gbFiltroOrdenar.SuspendLayout();
            this.gbEditar.SuspendLayout();
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
            this.panelBarraJanela.Size = new System.Drawing.Size(965, 25);
            this.panelBarraJanela.TabIndex = 5;
            this.panelBarraJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraJanela_MouseMove);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(893, 0);
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
            this.btMaximizar.Location = new System.Drawing.Point(918, -1);
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
            this.btFechar.Location = new System.Drawing.Point(942, 0);
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
            this.lbTituloJanela.Size = new System.Drawing.Size(151, 16);
            this.lbTituloJanela.TabIndex = 0;
            this.lbTituloJanela.Text = "Cadastro de Usuário";
            // 
            // btNormal
            // 
            this.btNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNormal.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Normal;
            this.btNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btNormal.FlatAppearance.BorderSize = 0;
            this.btNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNormal.Location = new System.Drawing.Point(918, 0);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(23, 23);
            this.btNormal.TabIndex = 3;
            this.btNormal.UseVisualStyleBackColor = true;
            this.btNormal.Click += new System.EventHandler(this.btNormal_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.dgvUsuarios);
            this.panelDesktop.Controls.Add(this.gbPreco);
            this.panelDesktop.Controls.Add(this.gbFiltro);
            this.panelDesktop.Controls.Add(this.gbEditar);
            this.panelDesktop.Controls.Add(this.gbCadastro);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 25);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(965, 519);
            this.panelDesktop.TabIndex = 6;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 339);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(965, 144);
            this.dgvUsuarios.TabIndex = 13;
            this.dgvUsuarios.Click += new System.EventHandler(this.dgvUsuarios_Click);
            // 
            // gbPreco
            // 
            this.gbPreco.BackColor = System.Drawing.Color.LightGray;
            this.gbPreco.Controls.Add(this.btAbrirCadastro);
            this.gbPreco.Controls.Add(this.btAbrirEdicao);
            this.gbPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(0, 483);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(965, 36);
            this.gbPreco.TabIndex = 12;
            this.gbPreco.TabStop = false;
            // 
            // btAbrirCadastro
            // 
            this.btAbrirCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbrirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAbrirCadastro.FlatAppearance.BorderSize = 0;
            this.btAbrirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAbrirCadastro.Location = new System.Drawing.Point(700, 10);
            this.btAbrirCadastro.Name = "btAbrirCadastro";
            this.btAbrirCadastro.Size = new System.Drawing.Size(128, 23);
            this.btAbrirCadastro.TabIndex = 200;
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
            this.btAbrirEdicao.Location = new System.Drawing.Point(834, 10);
            this.btAbrirEdicao.Name = "btAbrirEdicao";
            this.btAbrirEdicao.Size = new System.Drawing.Size(128, 23);
            this.btAbrirEdicao.TabIndex = 201;
            this.btAbrirEdicao.Text = "EDITAR";
            this.btAbrirEdicao.UseVisualStyleBackColor = false;
            this.btAbrirEdicao.Click += new System.EventHandler(this.btAbrirEdicao_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.BackColor = System.Drawing.Color.LightGray;
            this.gbFiltro.Controls.Add(this.dtFiltroFim);
            this.gbFiltro.Controls.Add(this.lbFiltroStatus);
            this.gbFiltro.Controls.Add(this.cbFiltroStatus);
            this.gbFiltro.Controls.Add(this.lbFiltroPrivilegio);
            this.gbFiltro.Controls.Add(this.txFiltroEmail);
            this.gbFiltro.Controls.Add(this.cbFiltroPrivilegio);
            this.gbFiltro.Controls.Add(this.lbFiltroEmail);
            this.gbFiltro.Controls.Add(this.txFiltroNome);
            this.gbFiltro.Controls.Add(this.lbFiltroNome);
            this.gbFiltro.Controls.Add(this.txFiltroUsuario);
            this.gbFiltro.Controls.Add(this.lbFiltroUsuario);
            this.gbFiltro.Controls.Add(this.ckFiltroData);
            this.gbFiltro.Controls.Add(this.dtFiltroInicio);
            this.gbFiltro.Controls.Add(this.lbPagina);
            this.gbFiltro.Controls.Add(this.btProximaPagina);
            this.gbFiltro.Controls.Add(this.btPaginaAnterior);
            this.gbFiltro.Controls.Add(this.lbQuantidadePagina);
            this.gbFiltro.Controls.Add(this.cbQtdPagina);
            this.gbFiltro.Controls.Add(this.gbFiltroOrdenar);
            this.gbFiltro.Controls.Add(this.btPesquisar);
            this.gbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(0, 234);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(965, 105);
            this.gbFiltro.TabIndex = 11;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // dtFiltroFim
            // 
            this.dtFiltroFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtFiltroFim.CustomFormat = "dd/MM/yyyy";
            this.dtFiltroFim.Enabled = false;
            this.dtFiltroFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFiltroFim.Location = new System.Drawing.Point(522, 73);
            this.dtFiltroFim.Name = "dtFiltroFim";
            this.dtFiltroFim.Size = new System.Drawing.Size(97, 20);
            this.dtFiltroFim.TabIndex = 105;
            // 
            // lbFiltroStatus
            // 
            this.lbFiltroStatus.AutoSize = true;
            this.lbFiltroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroStatus.Location = new System.Drawing.Point(379, 58);
            this.lbFiltroStatus.Name = "lbFiltroStatus";
            this.lbFiltroStatus.Size = new System.Drawing.Size(37, 13);
            this.lbFiltroStatus.TabIndex = 104;
            this.lbFiltroStatus.Text = "Status";
            // 
            // cbFiltroStatus
            // 
            this.cbFiltroStatus.FormattingEnabled = true;
            this.cbFiltroStatus.Location = new System.Drawing.Point(382, 73);
            this.cbFiltroStatus.Name = "cbFiltroStatus";
            this.cbFiltroStatus.Size = new System.Drawing.Size(134, 21);
            this.cbFiltroStatus.TabIndex = 103;
            // 
            // lbFiltroPrivilegio
            // 
            this.lbFiltroPrivilegio.AutoSize = true;
            this.lbFiltroPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroPrivilegio.Location = new System.Drawing.Point(226, 58);
            this.lbFiltroPrivilegio.Name = "lbFiltroPrivilegio";
            this.lbFiltroPrivilegio.Size = new System.Drawing.Size(49, 13);
            this.lbFiltroPrivilegio.TabIndex = 59;
            this.lbFiltroPrivilegio.Text = "Privilégio";
            // 
            // txFiltroEmail
            // 
            this.txFiltroEmail.Location = new System.Drawing.Point(15, 74);
            this.txFiltroEmail.Name = "txFiltroEmail";
            this.txFiltroEmail.Size = new System.Drawing.Size(208, 20);
            this.txFiltroEmail.TabIndex = 3;
            // 
            // cbFiltroPrivilegio
            // 
            this.cbFiltroPrivilegio.FormattingEnabled = true;
            this.cbFiltroPrivilegio.Location = new System.Drawing.Point(229, 73);
            this.cbFiltroPrivilegio.Name = "cbFiltroPrivilegio";
            this.cbFiltroPrivilegio.Size = new System.Drawing.Size(147, 21);
            this.cbFiltroPrivilegio.TabIndex = 4;
            // 
            // lbFiltroEmail
            // 
            this.lbFiltroEmail.AutoSize = true;
            this.lbFiltroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroEmail.Location = new System.Drawing.Point(12, 58);
            this.lbFiltroEmail.Name = "lbFiltroEmail";
            this.lbFiltroEmail.Size = new System.Drawing.Size(36, 13);
            this.lbFiltroEmail.TabIndex = 64;
            this.lbFiltroEmail.Text = "E-Mail";
            // 
            // txFiltroNome
            // 
            this.txFiltroNome.Location = new System.Drawing.Point(229, 32);
            this.txFiltroNome.Name = "txFiltroNome";
            this.txFiltroNome.Size = new System.Drawing.Size(287, 20);
            this.txFiltroNome.TabIndex = 1;
            // 
            // lbFiltroNome
            // 
            this.lbFiltroNome.AutoSize = true;
            this.lbFiltroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroNome.Location = new System.Drawing.Point(226, 16);
            this.lbFiltroNome.Name = "lbFiltroNome";
            this.lbFiltroNome.Size = new System.Drawing.Size(35, 13);
            this.lbFiltroNome.TabIndex = 62;
            this.lbFiltroNome.Text = "Nome";
            // 
            // txFiltroUsuario
            // 
            this.txFiltroUsuario.Location = new System.Drawing.Point(15, 32);
            this.txFiltroUsuario.Name = "txFiltroUsuario";
            this.txFiltroUsuario.Size = new System.Drawing.Size(208, 20);
            this.txFiltroUsuario.TabIndex = 0;
            // 
            // lbFiltroUsuario
            // 
            this.lbFiltroUsuario.AutoSize = true;
            this.lbFiltroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltroUsuario.Location = new System.Drawing.Point(12, 16);
            this.lbFiltroUsuario.Name = "lbFiltroUsuario";
            this.lbFiltroUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbFiltroUsuario.TabIndex = 60;
            this.lbFiltroUsuario.Text = "Usuário";
            // 
            // ckFiltroData
            // 
            this.ckFiltroData.AutoSize = true;
            this.ckFiltroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFiltroData.Location = new System.Drawing.Point(522, 13);
            this.ckFiltroData.Name = "ckFiltroData";
            this.ckFiltroData.Size = new System.Drawing.Size(104, 17);
            this.ckFiltroData.TabIndex = 7;
            this.ckFiltroData.Text = "Data Inicio / Fim";
            this.ckFiltroData.UseVisualStyleBackColor = true;
            this.ckFiltroData.CheckedChanged += new System.EventHandler(this.ckFiltroData_CheckedChanged);
            // 
            // dtFiltroInicio
            // 
            this.dtFiltroInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtFiltroInicio.CustomFormat = "dd/MM/yyyy";
            this.dtFiltroInicio.Enabled = false;
            this.dtFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFiltroInicio.Location = new System.Drawing.Point(522, 32);
            this.dtFiltroInicio.Name = "dtFiltroInicio";
            this.dtFiltroInicio.Size = new System.Drawing.Size(97, 20);
            this.dtFiltroInicio.TabIndex = 8;
            // 
            // lbPagina
            // 
            this.lbPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPagina.AutoSize = true;
            this.lbPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagina.Location = new System.Drawing.Point(887, 81);
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
            this.btProximaPagina.Location = new System.Drawing.Point(930, 76);
            this.btProximaPagina.Name = "btProximaPagina";
            this.btProximaPagina.Size = new System.Drawing.Size(23, 23);
            this.btProximaPagina.TabIndex = 100;
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
            this.btPaginaAnterior.Location = new System.Drawing.Point(858, 76);
            this.btPaginaAnterior.Name = "btPaginaAnterior";
            this.btPaginaAnterior.Size = new System.Drawing.Size(23, 23);
            this.btPaginaAnterior.TabIndex = 100;
            this.btPaginaAnterior.Text = "<";
            this.btPaginaAnterior.UseVisualStyleBackColor = false;
            this.btPaginaAnterior.Click += new System.EventHandler(this.btPaginaAnterior_Click);
            // 
            // lbQuantidadePagina
            // 
            this.lbQuantidadePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantidadePagina.AutoSize = true;
            this.lbQuantidadePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadePagina.Location = new System.Drawing.Point(687, 81);
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
            this.cbQtdPagina.Location = new System.Drawing.Point(771, 78);
            this.cbQtdPagina.Name = "cbQtdPagina";
            this.cbQtdPagina.Size = new System.Drawing.Size(81, 21);
            this.cbQtdPagina.TabIndex = 100;
            this.cbQtdPagina.SelectedIndexChanged += new System.EventHandler(this.cbQtdPagina_SelectedIndexChanged);
            // 
            // gbFiltroOrdenar
            // 
            this.gbFiltroOrdenar.Controls.Add(this.rbFiltroDecrescente);
            this.gbFiltroOrdenar.Controls.Add(this.rbFiltroCrescente);
            this.gbFiltroOrdenar.Location = new System.Drawing.Point(641, 18);
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
            this.rbFiltroDecrescente.TabIndex = 6;
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
            this.rbFiltroCrescente.TabIndex = 5;
            this.rbFiltroCrescente.TabStop = true;
            this.rbFiltroCrescente.Text = "Crescente";
            this.rbFiltroCrescente.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPesquisar.Location = new System.Drawing.Point(863, 33);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(90, 23);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.BackColor = System.Drawing.Color.LightGray;
            this.gbEditar.Controls.Add(this.lbEditarStatus);
            this.gbEditar.Controls.Add(this.cbEditarStatus);
            this.gbEditar.Controls.Add(this.lbEditarPrivilegio);
            this.gbEditar.Controls.Add(this.cbEditarPrivilegio);
            this.gbEditar.Controls.Add(this.txEditarEmail);
            this.gbEditar.Controls.Add(this.lbEditarEmail);
            this.gbEditar.Controls.Add(this.txEditarNome);
            this.gbEditar.Controls.Add(this.lbEditarNome);
            this.gbEditar.Controls.Add(this.txEditarSenha);
            this.gbEditar.Controls.Add(this.lbEditarSenha);
            this.gbEditar.Controls.Add(this.txEditarUsuario);
            this.gbEditar.Controls.Add(this.lbEditarUsuario);
            this.gbEditar.Controls.Add(this.lbEditarIdResultado);
            this.gbEditar.Controls.Add(this.lbEditarId);
            this.gbEditar.Controls.Add(this.btEsconderEditar);
            this.gbEditar.Controls.Add(this.btEditar);
            this.gbEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.Location = new System.Drawing.Point(0, 117);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(965, 117);
            this.gbEditar.TabIndex = 10;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            this.gbEditar.Visible = false;
            // 
            // lbEditarStatus
            // 
            this.lbEditarStatus.AutoSize = true;
            this.lbEditarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarStatus.Location = new System.Drawing.Point(504, 20);
            this.lbEditarStatus.Name = "lbEditarStatus";
            this.lbEditarStatus.Size = new System.Drawing.Size(37, 13);
            this.lbEditarStatus.TabIndex = 102;
            this.lbEditarStatus.Text = "Status";
            // 
            // cbEditarStatus
            // 
            this.cbEditarStatus.FormattingEnabled = true;
            this.cbEditarStatus.Location = new System.Drawing.Point(507, 35);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(83, 21);
            this.cbEditarStatus.TabIndex = 101;
            // 
            // lbEditarPrivilegio
            // 
            this.lbEditarPrivilegio.AutoSize = true;
            this.lbEditarPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarPrivilegio.Location = new System.Drawing.Point(440, 67);
            this.lbEditarPrivilegio.Name = "lbEditarPrivilegio";
            this.lbEditarPrivilegio.Size = new System.Drawing.Size(49, 13);
            this.lbEditarPrivilegio.TabIndex = 59;
            this.lbEditarPrivilegio.Text = "Privilégio";
            // 
            // cbEditarPrivilegio
            // 
            this.cbEditarPrivilegio.FormattingEnabled = true;
            this.cbEditarPrivilegio.Location = new System.Drawing.Point(443, 82);
            this.cbEditarPrivilegio.Name = "cbEditarPrivilegio";
            this.cbEditarPrivilegio.Size = new System.Drawing.Size(147, 21);
            this.cbEditarPrivilegio.TabIndex = 20;
            // 
            // txEditarEmail
            // 
            this.txEditarEmail.Location = new System.Drawing.Point(229, 83);
            this.txEditarEmail.Name = "txEditarEmail";
            this.txEditarEmail.Size = new System.Drawing.Size(208, 20);
            this.txEditarEmail.TabIndex = 19;
            // 
            // lbEditarEmail
            // 
            this.lbEditarEmail.AutoSize = true;
            this.lbEditarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarEmail.Location = new System.Drawing.Point(226, 67);
            this.lbEditarEmail.Name = "lbEditarEmail";
            this.lbEditarEmail.Size = new System.Drawing.Size(36, 13);
            this.lbEditarEmail.TabIndex = 57;
            this.lbEditarEmail.Text = "E-Mail";
            // 
            // txEditarNome
            // 
            this.txEditarNome.Location = new System.Drawing.Point(303, 36);
            this.txEditarNome.Name = "txEditarNome";
            this.txEditarNome.Size = new System.Drawing.Size(198, 20);
            this.txEditarNome.TabIndex = 17;
            // 
            // lbEditarNome
            // 
            this.lbEditarNome.AutoSize = true;
            this.lbEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarNome.Location = new System.Drawing.Point(300, 20);
            this.lbEditarNome.Name = "lbEditarNome";
            this.lbEditarNome.Size = new System.Drawing.Size(35, 13);
            this.lbEditarNome.TabIndex = 55;
            this.lbEditarNome.Text = "Nome";
            // 
            // txEditarSenha
            // 
            this.txEditarSenha.Location = new System.Drawing.Point(15, 83);
            this.txEditarSenha.Name = "txEditarSenha";
            this.txEditarSenha.Size = new System.Drawing.Size(208, 20);
            this.txEditarSenha.TabIndex = 18;
            // 
            // lbEditarSenha
            // 
            this.lbEditarSenha.AutoSize = true;
            this.lbEditarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarSenha.Location = new System.Drawing.Point(12, 67);
            this.lbEditarSenha.Name = "lbEditarSenha";
            this.lbEditarSenha.Size = new System.Drawing.Size(38, 13);
            this.lbEditarSenha.TabIndex = 53;
            this.lbEditarSenha.Text = "Senha";
            // 
            // txEditarUsuario
            // 
            this.txEditarUsuario.Location = new System.Drawing.Point(89, 36);
            this.txEditarUsuario.Name = "txEditarUsuario";
            this.txEditarUsuario.Size = new System.Drawing.Size(208, 20);
            this.txEditarUsuario.TabIndex = 16;
            this.txEditarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txEditarUsuario_KeyPress);
            // 
            // lbEditarUsuario
            // 
            this.lbEditarUsuario.AutoSize = true;
            this.lbEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarUsuario.Location = new System.Drawing.Point(86, 20);
            this.lbEditarUsuario.Name = "lbEditarUsuario";
            this.lbEditarUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbEditarUsuario.TabIndex = 51;
            this.lbEditarUsuario.Text = "Usuário";
            // 
            // lbEditarIdResultado
            // 
            this.lbEditarIdResultado.AutoSize = true;
            this.lbEditarIdResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarIdResultado.Location = new System.Drawing.Point(12, 39);
            this.lbEditarIdResultado.Name = "lbEditarIdResultado";
            this.lbEditarIdResultado.Size = new System.Drawing.Size(74, 13);
            this.lbEditarIdResultado.TabIndex = 49;
            this.lbEditarIdResultado.Text = "idResultado";
            this.lbEditarIdResultado.Visible = false;
            // 
            // lbEditarId
            // 
            this.lbEditarId.AutoSize = true;
            this.lbEditarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarId.Location = new System.Drawing.Point(12, 20);
            this.lbEditarId.Name = "lbEditarId";
            this.lbEditarId.Size = new System.Drawing.Size(16, 13);
            this.lbEditarId.TabIndex = 48;
            this.lbEditarId.Text = "Id";
            // 
            // btEsconderEditar
            // 
            this.btEsconderEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEsconderEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEsconderEditar.FlatAppearance.BorderSize = 0;
            this.btEsconderEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsconderEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEsconderEditar.Location = new System.Drawing.Point(942, 12);
            this.btEsconderEditar.Name = "btEsconderEditar";
            this.btEsconderEditar.Size = new System.Drawing.Size(17, 18);
            this.btEsconderEditar.TabIndex = 100;
            this.btEsconderEditar.Text = "V";
            this.btEsconderEditar.UseVisualStyleBackColor = false;
            this.btEsconderEditar.Click += new System.EventHandler(this.btEsconderEditar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEditar.Location = new System.Drawing.Point(863, 83);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(90, 23);
            this.btEditar.TabIndex = 21;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // gbCadastro
            // 
            this.gbCadastro.BackColor = System.Drawing.Color.LightGray;
            this.gbCadastro.Controls.Add(this.lbCadastroPrivilegio);
            this.gbCadastro.Controls.Add(this.cbCadastroPrivilegio);
            this.gbCadastro.Controls.Add(this.txCadastroEmail);
            this.gbCadastro.Controls.Add(this.lbCadastroEmail);
            this.gbCadastro.Controls.Add(this.txCadastroNome);
            this.gbCadastro.Controls.Add(this.lbCadastroNome);
            this.gbCadastro.Controls.Add(this.txCadastroSenha);
            this.gbCadastro.Controls.Add(this.lbCadastroSenha);
            this.gbCadastro.Controls.Add(this.btEsconderCadastro);
            this.gbCadastro.Controls.Add(this.txCadastroUsuario);
            this.gbCadastro.Controls.Add(this.lbCadastroUsuario);
            this.gbCadastro.Controls.Add(this.btCadastrar);
            this.gbCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(0, 0);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(965, 117);
            this.gbCadastro.TabIndex = 7;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            this.gbCadastro.Visible = false;
            // 
            // lbCadastroPrivilegio
            // 
            this.lbCadastroPrivilegio.AutoSize = true;
            this.lbCadastroPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroPrivilegio.Location = new System.Drawing.Point(440, 59);
            this.lbCadastroPrivilegio.Name = "lbCadastroPrivilegio";
            this.lbCadastroPrivilegio.Size = new System.Drawing.Size(49, 13);
            this.lbCadastroPrivilegio.TabIndex = 32;
            this.lbCadastroPrivilegio.Text = "Privilégio";
            // 
            // cbCadastroPrivilegio
            // 
            this.cbCadastroPrivilegio.FormattingEnabled = true;
            this.cbCadastroPrivilegio.Location = new System.Drawing.Point(443, 74);
            this.cbCadastroPrivilegio.Name = "cbCadastroPrivilegio";
            this.cbCadastroPrivilegio.Size = new System.Drawing.Size(147, 21);
            this.cbCadastroPrivilegio.TabIndex = 14;
            // 
            // txCadastroEmail
            // 
            this.txCadastroEmail.Location = new System.Drawing.Point(229, 75);
            this.txCadastroEmail.Name = "txCadastroEmail";
            this.txCadastroEmail.Size = new System.Drawing.Size(208, 20);
            this.txCadastroEmail.TabIndex = 13;
            // 
            // lbCadastroEmail
            // 
            this.lbCadastroEmail.AutoSize = true;
            this.lbCadastroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroEmail.Location = new System.Drawing.Point(226, 59);
            this.lbCadastroEmail.Name = "lbCadastroEmail";
            this.lbCadastroEmail.Size = new System.Drawing.Size(36, 13);
            this.lbCadastroEmail.TabIndex = 30;
            this.lbCadastroEmail.Text = "E-Mail";
            // 
            // txCadastroNome
            // 
            this.txCadastroNome.Location = new System.Drawing.Point(229, 36);
            this.txCadastroNome.Name = "txCadastroNome";
            this.txCadastroNome.Size = new System.Drawing.Size(361, 20);
            this.txCadastroNome.TabIndex = 11;
            // 
            // lbCadastroNome
            // 
            this.lbCadastroNome.AutoSize = true;
            this.lbCadastroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroNome.Location = new System.Drawing.Point(226, 20);
            this.lbCadastroNome.Name = "lbCadastroNome";
            this.lbCadastroNome.Size = new System.Drawing.Size(35, 13);
            this.lbCadastroNome.TabIndex = 1;
            this.lbCadastroNome.Text = "Nome";
            // 
            // txCadastroSenha
            // 
            this.txCadastroSenha.Location = new System.Drawing.Point(15, 75);
            this.txCadastroSenha.Name = "txCadastroSenha";
            this.txCadastroSenha.Size = new System.Drawing.Size(208, 20);
            this.txCadastroSenha.TabIndex = 12;
            // 
            // lbCadastroSenha
            // 
            this.lbCadastroSenha.AutoSize = true;
            this.lbCadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroSenha.Location = new System.Drawing.Point(12, 59);
            this.lbCadastroSenha.Name = "lbCadastroSenha";
            this.lbCadastroSenha.Size = new System.Drawing.Size(38, 13);
            this.lbCadastroSenha.TabIndex = 26;
            this.lbCadastroSenha.Text = "Senha";
            // 
            // btEsconderCadastro
            // 
            this.btEsconderCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEsconderCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEsconderCadastro.FlatAppearance.BorderSize = 0;
            this.btEsconderCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsconderCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEsconderCadastro.Location = new System.Drawing.Point(942, 12);
            this.btEsconderCadastro.Name = "btEsconderCadastro";
            this.btEsconderCadastro.Size = new System.Drawing.Size(17, 18);
            this.btEsconderCadastro.TabIndex = 100;
            this.btEsconderCadastro.Text = "V";
            this.btEsconderCadastro.UseVisualStyleBackColor = false;
            this.btEsconderCadastro.Click += new System.EventHandler(this.btEsconderCadastro_Click);
            // 
            // txCadastroUsuario
            // 
            this.txCadastroUsuario.Location = new System.Drawing.Point(15, 36);
            this.txCadastroUsuario.Name = "txCadastroUsuario";
            this.txCadastroUsuario.Size = new System.Drawing.Size(208, 20);
            this.txCadastroUsuario.TabIndex = 10;
            this.txCadastroUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCadastroUsuario_KeyPress);
            // 
            // lbCadastroUsuario
            // 
            this.lbCadastroUsuario.AutoSize = true;
            this.lbCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroUsuario.Location = new System.Drawing.Point(12, 20);
            this.lbCadastroUsuario.Name = "lbCadastroUsuario";
            this.lbCadastroUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbCadastroUsuario.TabIndex = 0;
            this.lbCadastroUsuario.Text = "Usuário";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCadastrar.Location = new System.Drawing.Point(863, 82);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(965, 544);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBarraJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroUsuario";
            this.Text = "FormCadastroUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBarraJanela.ResumeLayout(false);
            this.panelBarraJanela.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbPreco.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbFiltroOrdenar.ResumeLayout(false);
            this.gbFiltroOrdenar.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Label lbCadastroPrivilegio;
        private System.Windows.Forms.ComboBox cbCadastroPrivilegio;
        private System.Windows.Forms.TextBox txCadastroEmail;
        private System.Windows.Forms.Label lbCadastroEmail;
        private System.Windows.Forms.TextBox txCadastroNome;
        private System.Windows.Forms.Label lbCadastroNome;
        private System.Windows.Forms.TextBox txCadastroSenha;
        private System.Windows.Forms.Label lbCadastroSenha;
        private System.Windows.Forms.Button btEsconderCadastro;
        private System.Windows.Forms.TextBox txCadastroUsuario;
        private System.Windows.Forms.Label lbCadastroUsuario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Label lbFiltroPrivilegio;
        private System.Windows.Forms.ComboBox cbFiltroPrivilegio;
        private System.Windows.Forms.TextBox txEditarEmail;
        private System.Windows.Forms.Label lbEditarEmail;
        private System.Windows.Forms.TextBox txEditarNome;
        private System.Windows.Forms.Label lbEditarNome;
        private System.Windows.Forms.TextBox txEditarSenha;
        private System.Windows.Forms.Label lbEditarSenha;
        private System.Windows.Forms.TextBox txEditarUsuario;
        private System.Windows.Forms.Label lbEditarUsuario;
        private System.Windows.Forms.Label lbEditarIdResultado;
        private System.Windows.Forms.Label lbEditarId;
        private System.Windows.Forms.Button btEsconderEditar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txFiltroEmail;
        private System.Windows.Forms.Label lbFiltroEmail;
        private System.Windows.Forms.TextBox txFiltroNome;
        private System.Windows.Forms.Label lbFiltroNome;
        private System.Windows.Forms.TextBox txFiltroUsuario;
        private System.Windows.Forms.Label lbFiltroUsuario;
        private System.Windows.Forms.CheckBox ckFiltroData;
        private System.Windows.Forms.DateTimePicker dtFiltroInicio;
        private System.Windows.Forms.Label lbPagina;
        private System.Windows.Forms.Button btProximaPagina;
        private System.Windows.Forms.Button btPaginaAnterior;
        private System.Windows.Forms.Label lbQuantidadePagina;
        private System.Windows.Forms.ComboBox cbQtdPagina;
        private System.Windows.Forms.GroupBox gbFiltroOrdenar;
        private System.Windows.Forms.RadioButton rbFiltroDecrescente;
        private System.Windows.Forms.RadioButton rbFiltroCrescente;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.Button btAbrirCadastro;
        private System.Windows.Forms.Button btAbrirEdicao;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbEditarPrivilegio;
        private System.Windows.Forms.ComboBox cbEditarPrivilegio;
        private System.Windows.Forms.Label lbFiltroStatus;
        private System.Windows.Forms.ComboBox cbFiltroStatus;
        private System.Windows.Forms.Label lbEditarStatus;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.DateTimePicker dtFiltroFim;
    }
}