namespace SistemaMarcenariaRodrigues.Forms.Config
{
    partial class FormConfigDB
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
            this.lbTituloJanela = new System.Windows.Forms.Label();
            this.txServer = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.txDataBase = new System.Windows.Forms.TextBox();
            this.lbDB = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panelBarraJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraJanela
            // 
            this.panelBarraJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBarraJanela.Controls.Add(this.lbTituloJanela);
            this.panelBarraJanela.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraJanela.Location = new System.Drawing.Point(0, 0);
            this.panelBarraJanela.Name = "panelBarraJanela";
            this.panelBarraJanela.Size = new System.Drawing.Size(340, 25);
            this.panelBarraJanela.TabIndex = 3;
            // 
            // lbTituloJanela
            // 
            this.lbTituloJanela.AutoSize = true;
            this.lbTituloJanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTituloJanela.Location = new System.Drawing.Point(12, 6);
            this.lbTituloJanela.Name = "lbTituloJanela";
            this.lbTituloJanela.Size = new System.Drawing.Size(212, 16);
            this.lbTituloJanela.TabIndex = 0;
            this.lbTituloJanela.Text = "Configuração Base de Dados";
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(134, 28);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(193, 20);
            this.txServer.TabIndex = 7;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.Location = new System.Drawing.Point(8, 32);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(71, 16);
            this.lbServer.TabIndex = 8;
            this.lbServer.Text = "Servidor:";
            // 
            // txDataBase
            // 
            this.txDataBase.Location = new System.Drawing.Point(134, 57);
            this.txDataBase.Name = "txDataBase";
            this.txDataBase.Size = new System.Drawing.Size(193, 20);
            this.txDataBase.TabIndex = 9;
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDB.Location = new System.Drawing.Point(8, 58);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(120, 16);
            this.lbDB.TabIndex = 10;
            this.lbDB.Text = "Base de Dados:";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(134, 83);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(193, 20);
            this.txUser.TabIndex = 11;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(8, 84);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(66, 16);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "Usuario:";
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(134, 109);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(193, 20);
            this.txPassword.TabIndex = 13;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(8, 110);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 16);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Senha:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(237, 177);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 28);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(134, 177);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(90, 28);
            this.btSalvar.TabIndex = 16;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(340, 217);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txDataBase);
            this.Controls.Add(this.lbDB);
            this.Controls.Add(this.txServer);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.panelBarraJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfigDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigDB";
            this.panelBarraJanela.ResumeLayout(false);
            this.panelBarraJanela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraJanela;
        private System.Windows.Forms.Label lbTituloJanela;
        private System.Windows.Forms.TextBox txServer;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txDataBase;
        private System.Windows.Forms.Label lbDB;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
    }
}