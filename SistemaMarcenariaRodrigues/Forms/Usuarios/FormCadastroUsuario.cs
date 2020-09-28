using SistemaMarcenariaRodrigues.Acoes.Usuario;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Forms.Usuarios
{
    public partial class FormCadastroUsuario : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool chaveFiltro = false;
        private int ultimaPosicao = 0;
        private int totalDeRegistros = 0;
        private int pagina = 1;

        public FormCadastroUsuario()
        {
            InitializeComponent();
            AlimentaCB();
        }

        private void panelBarraJanela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Suprimir_Bt();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Suprimir_Bt();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suprimir_Bt()
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    btMaximizar.Visible = false;
                    btNormal.Visible = true;
                }
                else
                {
                    btNormal.Visible = false;
                    btMaximizar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema");
                RegistraLog.Log("Erro ao suprimir botões de Maximizar ou Restaurar" + ex);
            }
        }

        private void btAbrirCadastro_Click(object sender, EventArgs e)
        {
            gbEditar.Hide();
            gbCadastro.Show();
        }

        private void btAbrirEdicao_Click(object sender, EventArgs e)
        {
            gbCadastro.Hide();
            gbEditar.Show();
            if(dgvUsuarios.DataSource != null)
                AlimentaEditar();
        }

        private void btEsconderCadastro_Click(object sender, EventArgs e)
        {
            gbCadastro.Hide();
        }

        private void btEsconderEditar_Click(object sender, EventArgs e)
        {
            gbEditar.Hide();
        }

        private void AtivaData()
        {
            if (ckFiltroData.Checked == true)
            {
                dtFiltroInicio.Enabled = true;
                dtFiltroFim.Enabled = true;
            }
            else
            {
                dtFiltroInicio.Enabled = false;
                dtFiltroFim.Enabled = false;
            }
        }

        private void AlimentaCB()
        {
            PrivilegioAcoesDB privilegioAcoesDB = new PrivilegioAcoesDB();
            List<PrivilegioModel> privilegioModels = new List<PrivilegioModel>();

            cbQtdPagina.Items.Add(10);
            cbQtdPagina.Items.Add(50);
            cbQtdPagina.Items.Add(100);
            cbQtdPagina.SelectedIndex = 0;

            cbEditarStatus.Items.Add("Inativo");
            cbEditarStatus.Items.Add("Ativo");
            cbEditarStatus.SelectedIndex = 1;

            cbFiltroStatus.Items.Add("Todos");
            cbFiltroStatus.Items.Add("Ativo");
            cbFiltroStatus.Items.Add("Inativo");
            cbFiltroStatus.SelectedIndex = 0;

            privilegioModels.Add(new PrivilegioModel() { Id = 0, Nome = "Todos" });
            foreach (var item in privilegioAcoesDB.Select(null, null, 1, null, null, null, null, null))
                privilegioModels.Add(item);

            cbFiltroPrivilegio.DataSource = privilegioModels;
            cbFiltroPrivilegio.DisplayMember = "Nome";
            cbFiltroPrivilegio.ValueMember = "Id";
            cbFiltroPrivilegio.Enabled = true;
            cbFiltroPrivilegio.SelectedIndex = 0;

            cbEditarPrivilegio.DataSource = privilegioAcoesDB.Select(null, null, 1, null, null, null, null, null);
            cbEditarPrivilegio.DisplayMember = "Nome";
            cbEditarPrivilegio.ValueMember = "Id";
            cbEditarPrivilegio.Enabled = true;
            cbEditarPrivilegio.SelectedIndex = 0;

            cbCadastroPrivilegio.DataSource = privilegioAcoesDB.Select(null, null, 1, null, null, null, null, null);
            cbCadastroPrivilegio.DisplayMember = "Nome";
            cbCadastroPrivilegio.ValueMember = "Id";
            cbCadastroPrivilegio.Enabled = true;
            cbCadastroPrivilegio.SelectedIndex = 0;
        }

        private void AlimentaDGV()
        {
            try
            {
                UsuarioAcoesDB usuarioAcoesDB = new UsuarioAcoesDB();
                List<string> listaContagemSoma = new List<string>();

                string ordem = "";
                if (rbFiltroCrescente.Checked)
                    ordem = "crescente";
                if (rbFiltroDecrescente.Checked)
                    ordem = "decrescente";

                listaContagemSoma = usuarioAcoesDB.Count(
                    txFiltroUsuario.Text == "" ? null : txFiltroUsuario.Text,
                    txFiltroNome.Text == "" ? null : txFiltroNome.Text,
                    txFiltroEmail.Text == "" ? null : txFiltroEmail.Text,
                    (int)cbFiltroPrivilegio.SelectedValue,
                    cbFiltroStatus.SelectedIndex,
                    ckFiltroData.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                    ckFiltroData.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null);

                totalDeRegistros = int.Parse(listaContagemSoma[0]);

                if (totalDeRegistros > 0)
                {
                    int calculoPaginas = totalDeRegistros / int.Parse(cbQtdPagina.Text);
                    int numeroDePaginas = calculoPaginas + 1;
                    lbPagina.Text = pagina + "/" + numeroDePaginas;
                }
                else
                    dgvUsuarios.DataSource = null;
                if (ultimaPosicao < totalDeRegistros)
                {
                    dgvUsuarios.DataSource = usuarioAcoesDB.Select(
                        txFiltroUsuario.Text == "" ? null : txFiltroUsuario.Text,
                        txFiltroNome.Text == "" ? null : txFiltroNome.Text,
                        txFiltroEmail.Text == "" ? null : txFiltroEmail.Text,
                        (int)cbFiltroPrivilegio.SelectedValue,
                        cbFiltroStatus.SelectedIndex,
                        ckFiltroData.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                        ckFiltroData.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null,
                        ordem,
                        ultimaPosicao,
                        int.Parse(cbQtdPagina.Text));

                    if (dgvUsuarios.DataSource != null)
                    {
                        dgvUsuarios.Columns["Id"].HeaderText = "Id";
                        dgvUsuarios.Columns["Usuario"].HeaderText = "Usuário";
                        dgvUsuarios.Columns["Senha"].HeaderText = "Senha";
                        dgvUsuarios.Columns["Nome"].HeaderText = "Nome";
                        dgvUsuarios.Columns["Email"].HeaderText = "E-Mail";
                        dgvUsuarios.Columns["Privilegio"].HeaderText = "Privilégio";
                        dgvUsuarios.Columns["Status"].HeaderText = "Status";
                        dgvUsuarios.Columns["Data"].HeaderText = "Data";

                        dgvUsuarios.Columns["Id"].DisplayIndex = 1;
                        dgvUsuarios.Columns["Usuario"].DisplayIndex = 2;
                        dgvUsuarios.Columns["Senha"].DisplayIndex = 3;
                        dgvUsuarios.Columns["Nome"].DisplayIndex = 4;
                        dgvUsuarios.Columns["Email"].DisplayIndex = 5;
                        dgvUsuarios.Columns["Privilegio"].DisplayIndex = 6;
                        dgvUsuarios.Columns["Status"].DisplayIndex = 7;
                        dgvUsuarios.Columns["Data"].DisplayIndex = 8;

                        dgvUsuarios.Columns["IdPrivilegio"].Visible = false;
                    }

                    chaveFiltro = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar informações de Usuarios");
                RegistraLog.Log($"Erro ao retornar dados de Usuarios -- {ex}");
            }
        }

        private void desativarEntradas(bool desativar)
        {
            try
            {
                if (desativar)
                {
                    txCadastroEmail.Enabled = false;
                    txCadastroNome.Enabled = false;
                    txCadastroSenha.Enabled = false;
                    txCadastroUsuario.Enabled = false;
                    txEditarEmail.Enabled = false;
                    txEditarNome.Enabled = false;
                    txEditarSenha.Enabled = false;
                    txEditarUsuario.Enabled = false;
                    txFiltroEmail.Enabled = false;
                    txFiltroNome.Enabled = false;
                    txFiltroUsuario.Enabled = false;

                    cbCadastroPrivilegio.Enabled = false;
                    cbEditarPrivilegio.Enabled = false;
                    cbEditarStatus.Enabled = false;
                    cbFiltroPrivilegio.Enabled = false;
                    cbFiltroStatus.Enabled = false;
                    cbQtdPagina.Enabled = false;

                    ckFiltroData.Enabled = false;
                    rbFiltroCrescente.Enabled = false;
                    rbFiltroDecrescente.Enabled = false;

                    btAbrirCadastro.Enabled = false;
                    btAbrirEdicao.Enabled = false;
                    btCadastrar.Enabled = false;
                    btEditar.Enabled = false;
                    btEsconderCadastro.Enabled = false;
                    btEsconderEditar.Enabled = false;
                }
                else
                {
                    txCadastroEmail.Enabled = true;
                    txCadastroNome.Enabled = true;
                    txCadastroSenha.Enabled = true;
                    txCadastroUsuario.Enabled = true;
                    txEditarEmail.Enabled = true;
                    txEditarNome.Enabled = true;
                    txEditarSenha.Enabled = true;
                    txEditarUsuario.Enabled = true;
                    txFiltroEmail.Enabled = true;
                    txFiltroNome.Enabled = true;
                    txFiltroUsuario.Enabled = true;

                    cbCadastroPrivilegio.Enabled = true;
                    cbEditarPrivilegio.Enabled = true;
                    cbEditarStatus.Enabled = true;
                    cbFiltroPrivilegio.Enabled = true;
                    cbFiltroStatus.Enabled = true;
                    cbQtdPagina.Enabled = true;

                    ckFiltroData.Enabled = true;
                    rbFiltroCrescente.Enabled = true;
                    rbFiltroDecrescente.Enabled = true;

                    btAbrirCadastro.Enabled = true;
                    btAbrirEdicao.Enabled = true;
                    btCadastrar.Enabled = true;
                    btEditar.Enabled = true;
                    btEsconderCadastro.Enabled = true;
                    btEsconderEditar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desativar Entradas");
                RegistraLog.Log($"Erro ao desativar entradas -- {ex}");
            }
        }

        private void AlimentaEditar()
        {
            cbEditarStatus.SelectedIndex = dgvUsuarios.DataSource == null ?
                -1 : dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Status"].Value.ToString() == "Ativo" ?
                1 : 0;
            cbEditarPrivilegio.SelectedValue = dgvUsuarios.DataSource == null ?
                    -1 : (int)dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["IdPrivilegio"].Value;

            txEditarNome.Text = dgvUsuarios.DataSource == null ?
                    "" : dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Nome"].Value.ToString();
            txEditarEmail.Text = dgvUsuarios.DataSource == null ?
                    "" : dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Email"].Value.ToString();
            txEditarUsuario.Text = dgvUsuarios.DataSource == null ?
                    "" : dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Usuario"].Value.ToString();
            lbEditarIdResultado.Text = dgvUsuarios.DataSource == null ?
                    "" : dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Id"].Value.ToString();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            pagina = 1;
            desativarEntradas(true);
            AlimentaDGV();
            desativarEntradas(false);
            btProximaPagina.Enabled = true;
            btPaginaAnterior.Enabled = true;

            if (gbEditar.Visible)
                AlimentaEditar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaEmail(txCadastroEmail.Text) || txCadastroEmail.Text == "")
                {
                    UsuarioAcoesDB usuarioAcoesDB = new UsuarioAcoesDB();
                    MessageBox.Show(usuarioAcoesDB.Insert(
                        txCadastroUsuario.Text == "" ? null : txCadastroUsuario.Text,
                        txCadastroNome.Text == "" ? null : txCadastroNome.Text,
                        txCadastroSenha.Text == "" ? null : txCadastroSenha.Text,
                        txCadastroEmail.Text == "" ? null : txCadastroEmail.Text,
                        (int)cbCadastroPrivilegio.SelectedValue));

                    AlimentaDGV();
                }
                else
                    MessageBox.Show("E-Mail invalido");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Usuario, contate o desenvolvedor");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.DataSource != null)
                {
                    if (VerificaEmail(txEditarEmail.Text) || txEditarEmail.Text == "")
                    {
                        UsuarioAcoesDB usuarioAcoesDB = new UsuarioAcoesDB();
                        MessageBox.Show(usuarioAcoesDB.Upgrade(
                            (int)dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells["Id"].Value,
                            txEditarUsuario.Text == "" ? null : txEditarUsuario.Text,
                            txEditarNome.Text == "" ? null : txEditarNome.Text,
                            txEditarSenha.Text == "" ? null : txEditarSenha.Text,
                            txEditarEmail.Text == "" ? null : txEditarEmail.Text,
                            (int)cbEditarPrivilegio.SelectedValue,
                            cbEditarStatus.SelectedIndex));

                        AlimentaDGV();
                    }
                    else
                        MessageBox.Show("E-Mail invalido");
                }
                else
                    MessageBox.Show("Não á usuario selecionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Usuario, contate o desenvolvedor");
                RegistraLog.Log($"Erro ao clicar no botão editar -- {ex}");
            }
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.DataSource != null)
                AlimentaEditar();
        }

        private void btProximaPagina_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios != null && ultimaPosicao < totalDeRegistros - int.Parse(cbQtdPagina.Text))
            {
                pagina++;

                ultimaPosicao += int.Parse(cbQtdPagina.Text);
                btProximaPagina.Enabled = false;
                btPaginaAnterior.Enabled = false;
                AlimentaDGV();
                btProximaPagina.Enabled = true;
                btPaginaAnterior.Enabled = true;
            }
        }

        private void btPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (ultimaPosicao > 0)
            {
                pagina--;
                ultimaPosicao -= int.Parse(cbQtdPagina.Text);
            }

            if (ultimaPosicao < 0)
            {
                pagina = 1;
                ultimaPosicao = 0;
            }
            btProximaPagina.Enabled = false;
            btPaginaAnterior.Enabled = false;
            AlimentaDGV();
            btProximaPagina.Enabled = true;
            btPaginaAnterior.Enabled = true;
        }

        private void cbQtdPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0 && chaveFiltro)
            {
                ultimaPosicao = 0;
                pagina = 1;
                AlimentaDGV();
            }
            else
                pagina = 0;
        }

        private void ckFiltroData_CheckedChanged(object sender, EventArgs e)
        {
            AtivaData();
        }

        private bool VerificaEmail(string email)
        {
            try
            {
                Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

                if (rg.IsMatch(email))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar e-mail");
                RegistraLog.Log($"Erro ao validar e-mail -- {ex}");
                return false;
            }
        }

        private void txCadastroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txEditarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
    }
}
