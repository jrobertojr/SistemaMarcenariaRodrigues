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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btComercial = new System.Windows.Forms.Button();
            this.btLoja = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenuProduto = new System.Windows.Forms.Panel();
            this.btAdmTarefas = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelMenuProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btComercial);
            this.panelMenu.Controls.Add(this.btLoja);
            this.panelMenu.Controls.Add(this.btProdutos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(942, 31);
            this.panelMenu.TabIndex = 1;
            // 
            // btComercial
            // 
            this.btComercial.FlatAppearance.BorderSize = 0;
            this.btComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btComercial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btComercial.Location = new System.Drawing.Point(236, 5);
            this.btComercial.Name = "btComercial";
            this.btComercial.Size = new System.Drawing.Size(108, 23);
            this.btComercial.TabIndex = 2;
            this.btComercial.Text = "COMERCIAL";
            this.btComercial.UseVisualStyleBackColor = true;
            // 
            // btLoja
            // 
            this.btLoja.FlatAppearance.BorderSize = 0;
            this.btLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLoja.Location = new System.Drawing.Point(104, 5);
            this.btLoja.Name = "btLoja";
            this.btLoja.Size = new System.Drawing.Size(126, 23);
            this.btLoja.TabIndex = 1;
            this.btLoja.Text = "LOJA SANDALIARIA";
            this.btLoja.UseVisualStyleBackColor = true;
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
            this.panelDesktop.Controls.Add(this.panelMenuProduto);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 31);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(942, 475);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Click += new System.EventHandler(this.panelDeskTop_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(942, 506);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcenaria Rodrigues";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelMenuProduto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btComercial;
        private System.Windows.Forms.Button btLoja;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenuProduto;
        private System.Windows.Forms.Button btAdmTarefas;
    }
}

