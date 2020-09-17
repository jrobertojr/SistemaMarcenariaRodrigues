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

namespace SistemaMarcenariaRodrigues.Forms.Config
{
    public partial class FormConfigDB : Form
    {
        public FormConfigDB()
        {
            InitializeComponent();
            alimentaTexto();
        }

        private void alimentaTexto()
        {
            txServer.Text = Properties.Settings.Default.ServidorDB;
            txDataBase.Text = Properties.Settings.Default.BaseDados;
            txUser.Text = Properties.Settings.Default.UsuarioDB;
            txPassword.Text = Properties.Settings.Default.Senha;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txServer.Text != "" || txDataBase.Text != "" || txUser.Text != "" || txPassword.Text != "")
                {
                    Properties.Settings.Default.ServidorDB = txServer.Text;
                    Properties.Settings.Default.BaseDados = txDataBase.Text;
                    Properties.Settings.Default.UsuarioDB = txUser.Text;
                    Properties.Settings.Default.Senha = txPassword.Text;
                }
                else
                    MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar configuração, contate o desenvolvedor");
                RegistraLog.Log($"Erro ao salvar configuração para conexão com bando de dados -- {ex}");
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuração não foi alterada");
            this.Hide();
        }
    }
}
