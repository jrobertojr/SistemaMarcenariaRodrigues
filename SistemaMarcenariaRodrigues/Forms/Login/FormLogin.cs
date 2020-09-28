using SistemaMarcenariaRodrigues.Acoes.Usuario;
using SistemaMarcenariaRodrigues.Controle_de_Usuario;
using SistemaMarcenariaRodrigues.Criptografia;
using SistemaMarcenariaRodrigues.Forms.Config;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Forms.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioLoginAcoesDB usuarioAcoes = new UsuarioLoginAcoesDB();

                if (txUsuario.Text == "" && txSenha.Text == "")
                    MessageBox.Show("Usuario e Senha devem ser preenchidos");
                else if (txUsuario.Text == "")
                    MessageBox.Show("Usuario deve ser preenchido");
                else if (txSenha.Text == "")
                    MessageBox.Show("Senha deve ser preenchida");
                else
                {
                    List<UsuarioModel> usruarios = usuarioAcoes.Select(txUsuario.Text,0);

                    if (usruarios == null)
                        MessageBox.Show("Usuario não existe");
                    else if (usruarios[0].Senha != HashMd5.GerarMd5(txSenha.Text))
                        MessageBox.Show("Senha incorreta");
                    else
                    {
                        Session.Instance.UserID = usruarios[0].Id;
                        Main formMenu = new Main();
                        MessageBox.Show($"Bem vindo {usruarios[0].Nome}");
                        this.Hide();
                        formMenu.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir tela de Menu, contade o desenvolvedor.");
                RegistraLog.Log($"Erro no metodo de chamado da tela Main --- {ex}");
            }
            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormConfigDB formConfigDB = new FormConfigDB();
            formConfigDB.Show();
        }
    }
}
