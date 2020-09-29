namespace SistemaMarcenariaRodrigues
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btEntradaSaida = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenuUsuarios = new System.Windows.Forms.Panel();
            this.btCadastroUsuario = new System.Windows.Forms.Button();
            this.panelMenuEntradaSaida = new System.Windows.Forms.Panel();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btCadastroInventario = new System.Windows.Forms.Button();
            this.panelMenuProduto = new System.Windows.Forms.Panel();
            this.btAdmTarefas = new System.Windows.Forms.Button();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelMenuUsuarios.SuspendLayout();
            this.panelMenuEntradaSaida.SuspendLayout();
            this.panelMenuProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btUsuario);
            this.panelMenu.Controls.Add(this.btEntradaSaida);
            this.panelMenu.Controls.Add(this.btProdutos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(942, 31);
            this.panelMenu.TabIndex = 1;
            // 
            // btUsuario
            // 
            this.btUsuario.FlatAppearance.BorderSize = 0;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btUsuario.Location = new System.Drawing.Point(236, 5);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(83, 23);
            this.btUsuario.TabIndex = 2;
            this.btUsuario.Text = "USUÁRIOS";
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btEntradaSaida
            // 
            this.btEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntradaSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEntradaSaida.Location = new System.Drawing.Point(104, 5);
            this.btEntradaSaida.Name = "btEntradaSaida";
            this.btEntradaSaida.Size = new System.Drawing.Size(126, 23);
            this.btEntradaSaida.TabIndex = 1;
            this.btEntradaSaida.Text = "ENTRADA E SAÍDA";
            this.btEntradaSaida.UseVisualStyleBackColor = true;
            this.btEntradaSaida.Click += new System.EventHandler(this.btEntradaSaida_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btProdutos.Location = new System.Drawing.Point(12, 5);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(86, 23);
            this.btProdutos.TabIndex = 0;
            this.btProdutos.Text = "PRODUTOS";
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelMenuUsuarios);
            this.panelDesktop.Controls.Add(this.panelMenuEntradaSaida);
            this.panelDesktop.Controls.Add(this.panelMenuProduto);
            this.panelDesktop.Controls.Add(this.panelMenuLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 31);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(942, 475);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Click += new System.EventHandler(this.panelDeskTop_Click);
            // 
            // panelMenuUsuarios
            // 
            this.panelMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuUsuarios.Controls.Add(this.btCadastroUsuario);
            this.panelMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuUsuarios.Location = new System.Drawing.Point(0, 40);
            this.panelMenuUsuarios.Name = "panelMenuUsuarios";
            this.panelMenuUsuarios.Size = new System.Drawing.Size(942, 20);
            this.panelMenuUsuarios.TabIndex = 5;
            this.panelMenuUsuarios.Visible = false;
            // 
            // btCadastroUsuario
            // 
            this.btCadastroUsuario.FlatAppearance.BorderSize = 0;
            this.btCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCadastroUsuario.Location = new System.Drawing.Point(258, 0);
            this.btCadastroUsuario.Name = "btCadastroUsuario";
            this.btCadastroUsuario.Size = new System.Drawing.Size(154, 20);
            this.btCadastroUsuario.TabIndex = 1;
            this.btCadastroUsuario.Text = "CADASTRO DE USUÁRIO";
            this.btCadastroUsuario.UseVisualStyleBackColor = true;
            this.btCadastroUsuario.Click += new System.EventHandler(this.btCadastroUsuario_Click);
            // 
            // panelMenuEntradaSaida
            // 
            this.panelMenuEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuEntradaSaida.Controls.Add(this.btEstoque);
            this.panelMenuEntradaSaida.Controls.Add(this.btCadastroInventario);
            this.panelMenuEntradaSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuEntradaSaida.Location = new System.Drawing.Point(0, 20);
            this.panelMenuEntradaSaida.Name = "panelMenuEntradaSaida";
            this.panelMenuEntradaSaida.Size = new System.Drawing.Size(942, 20);
            this.panelMenuEntradaSaida.TabIndex = 3;
            this.panelMenuEntradaSaida.Visible = false;
            // 
            // btEstoque
            // 
            this.btEstoque.FlatAppearance.BorderSize = 0;
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEstoque.Location = new System.Drawing.Point(295, 0);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(80, 20);
            this.btEstoque.TabIndex = 2;
            this.btEstoque.Text = "ESTOQUE";
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btCadastroInventario
            // 
            this.btCadastroInventario.FlatAppearance.BorderSize = 0;
            this.btCadastroInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastroInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCadastroInventario.Location = new System.Drawing.Point(135, 0);
            this.btCadastroInventario.Name = "btCadastroInventario";
            this.btCadastroInventario.Size = new System.Drawing.Size(154, 20);
            this.btCadastroInventario.TabIndex = 1;
            this.btCadastroInventario.Text = "CADASTRO INVENTARIO";
            this.btCadastroInventario.UseVisualStyleBackColor = true;
            this.btCadastroInventario.Click += new System.EventHandler(this.btCadastroInventario_Click);
            // 
            // panelMenuProduto
            // 
            this.panelMenuProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuProduto.Controls.Add(this.btAdmTarefas);
            this.panelMenuProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProduto.Location = new System.Drawing.Point(0, 0);
            this.panelMenuProduto.Name = "panelMenuProduto";
            this.panelMenuProduto.Size = new System.Drawing.Size(942, 20);
            this.panelMenuProduto.TabIndex = 2;
            this.panelMenuProduto.Visible = false;
            // 
            // btAdmTarefas
            // 
            this.btAdmTarefas.FlatAppearance.BorderSize = 0;
            this.btAdmTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmTarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAdmTarefas.Location = new System.Drawing.Point(38, 0);
            this.btAdmTarefas.Name = "btAdmTarefas";
            this.btAdmTarefas.Size = new System.Drawing.Size(80, 20);
            this.btAdmTarefas.TabIndex = 1;
            this.btAdmTarefas.Text = "CADASTRO";
            this.btAdmTarefas.UseVisualStyleBackColor = true;
            this.btAdmTarefas.Click += new System.EventHandler(this.btAdmTarefas_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuLogo.BackgroundImage = global::SistemaMarcenariaRodrigues.Properties.Resources.Logo_MR;
            this.panelMenuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenuLogo.Location = new System.Drawing.Point(246, 103);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(435, 266);
            this.panelMenuLogo.TabIndex = 4;
            this.panelMenuLogo.Click += new System.EventHandler(this.panelMenuLogo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(942, 506);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcenaria Rodrigues";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelMenuUsuarios.ResumeLayout(false);
            this.panelMenuEntradaSaida.ResumeLayout(false);
            this.panelMenuProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btEntradaSaida;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenuProduto;
        private System.Windows.Forms.Button btAdmTarefas;
        private System.Windows.Forms.Panel panelMenuEntradaSaida;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btCadastroInventario;
        private System.Windows.Forms.Panel panelMenuLogo;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Panel panelMenuUsuarios;
        private System.Windows.Forms.Button btCadastroUsuario;
    }
}

