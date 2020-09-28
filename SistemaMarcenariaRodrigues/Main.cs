using SistemaMarcenariaRodrigues.Acoes.Usuario;
using SistemaMarcenariaRodrigues.Controle_de_Usuario;
using SistemaMarcenariaRodrigues.Forms.EntradaSaida;
using SistemaMarcenariaRodrigues.Forms.Produtos;
using SistemaMarcenariaRodrigues.Forms.Usuarios;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ControleDeUsuario();
        }

        private void ControleDeUsuario()
        {
            UsuarioLoginAcoesDB usuarioLoginAcoesDB = new UsuarioLoginAcoesDB();
            UsuarioModel usuarioModel = new UsuarioModel();
            usuarioModel = usuarioLoginAcoesDB.Select(null, Session.Instance.UserID)[0];

            if (usuarioModel.IdPrivilegio == 1)
                btUsuario.Enabled = true;
            else
                btUsuario.Enabled = false;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void AbrirFormNoPainel<Forms>() where Forms : Form, new()
        {
            try
            {
                Form formulario;
                formulario = panelDesktop.Controls.OfType<Forms>().FirstOrDefault();

                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    panelDesktop.Controls.Add(formulario);
                    panelDesktop.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                        formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema");
                RegistraLog.Log($"Erro ao tentar abrir janela no Panel principal --- {ex}");
            }
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            panelMenuEntradaSaida.Hide();
            panelMenuUsuarios.Hide();

            panelMenuProduto.Show();
        }

        private void btEntradaSaida_Click(object sender, EventArgs e)
        {
            panelMenuProduto.Hide();
            panelMenuUsuarios.Hide();

            panelMenuEntradaSaida.Show();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            panelMenuEntradaSaida.Hide();
            panelMenuProduto.Hide();

            panelMenuUsuarios.Show();
        }

        private void panelDeskTop_Click(object sender, EventArgs e)
        {
            panelMenuProduto.Hide();
            panelMenuEntradaSaida.Hide();
            panelMenuUsuarios.Hide();
        }
        private void panelMenuLogo_Click(object sender, EventArgs e)
        {
            panelMenuProduto.Hide();
            panelMenuEntradaSaida.Hide();
            panelMenuUsuarios.Hide();
        }

        private void btAdmTarefas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormCadastroProdutos>();
        }

        private void btCadastroInventario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormCadastroInventario>();
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormConsultaEstoque>();
        }

        private void btCadastroUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormCadastroUsuario>();
        }
    }
}
