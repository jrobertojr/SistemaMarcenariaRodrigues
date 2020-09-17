using SistemaMarcenariaRodrigues.Forms.Produtos;
using SistemaMarcenariaRodrigues.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            panelMenuProduto.Show();
        }

        private void panelDeskTop_Click(object sender, EventArgs e)
        {
            panelMenuProduto.Hide();
        }

        private void btAdmTarefas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormCadastroProdutos>();
        }
    }
}
