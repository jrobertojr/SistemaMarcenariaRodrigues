using SistemaMarcenariaRodrigues.Acoes.Produtos;
using SistemaMarcenariaRodrigues.Log;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Forms.Produtos
{
    public partial class FormCadastroProdutos : Form
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

        public FormCadastroProdutos()
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
            AlimentaEditar();
        }

        private void AlimentaEditar()
        {
            if (dgvProdutos.DataSource != null)
            {
                lbEditarCodigoR.Text = dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Id"].Value.ToString();
                txEditarProduto.Text = dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Produto"].Value.ToString();
                txEditarDimensoes.Text = dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Dimensoes"].Value.ToString();
                txEditarFornecedor.Text = dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Fornecedor"].Value.ToString();
                txEditarDetalhes.Text = dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Detalhe"].Value.ToString();
                cbEditarStatus.SelectedIndex =
                    dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].Cells["Status"].Value.ToString() == "Inativo" ? 0 : 1;
            }
            else
                MessageBox.Show("Não à produto para editar");
        }

        private void btEsconderCadastro_Click(object sender, EventArgs e)
        {
            gbCadastro.Hide();
        }

        private void btEsconderEditar_Click(object sender, EventArgs e)
        {
            gbEditar.Hide();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();
                MessageBox.Show(produtosAcoesDB.Insert(txCadastroProduto.Text,txCadastroDimensoes.Text,
                    txCadastroFornecedor.Text,txCadastroDetalhes.Text));

                pagina = 1;
                btProximaPagina.Enabled = true;
                btPaginaAnterior.Enabled = true;

                txCadastroDetalhes.Clear();
                txCadastroDimensoes.Clear();
                txCadastroFornecedor.Clear();
                txCadastroProduto.Clear();

                AlimentaDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto, contate o desenvolvedor");
                RegistraLog.Log($"Erro ao cadastrar produto -- {ex}");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.DataSource != null)
                {
                    ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();
                    MessageBox.Show(produtosAcoesDB.Update(
                        lbEditarCodigoR.Text == "" ? 0 : int.Parse(lbEditarCodigoR.Text),
                        txEditarProduto.Text == "" ? null : txEditarProduto.Text,
                        txEditarDimensoes.Text == "" ? null : txEditarDimensoes.Text,
                        txEditarFornecedor.Text == "" ? null : txEditarFornecedor.Text,
                        txEditarDetalhes.Text == "" ? null : txEditarDetalhes.Text,
                        cbEditarStatus.SelectedIndex == 0 ? false : true));

                    txEditarDetalhes.Clear();
                    txEditarDimensoes.Clear();
                    txEditarFornecedor.Clear();
                    txEditarProduto.Clear();
                    cbEditarStatus.SelectedIndex = 1;

                    AlimentaDGV();
                }
                else
                    MessageBox.Show("Não á produto selecionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto, contate o desenvolvedor");
                RegistraLog.Log($"Erro ao atualizar produto -- {ex}");
            }
        }

        private void AlimentaDGV()
        {
            try
            {
                ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();
                List<string> ListaContagemSoma = new List<string>();

                string ordem = "";
                if (rbFiltroCrescente.Checked)
                    ordem = "crescente";
                if (rbFiltroDecrescente.Checked)
                    ordem = "decrescente";

                ListaContagemSoma = produtosAcoesDB.Count(
                    txFiltroCodigo.Text == "" ? 0 : int.Parse(txFiltroCodigo.Text),
                    txFiltroProduto.Text == "" ? null : txFiltroProduto.Text,
                    txFiltroFornecedor.Text == "" ? null : txFiltroFornecedor.Text,
                    ckFiltroDatas.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                    ckFiltroDatas.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null,
                    cbFiltroStatus.SelectedIndex);

                totalDeRegistros = int.Parse(ListaContagemSoma[0]);

                if(totalDeRegistros > 0)
                {
                    int calculoPaginas = totalDeRegistros / int.Parse(cbQtdPagina.Text);
                    int numeroDePaginas = calculoPaginas + 1;
                    lbPagina.Text = pagina + "/" + numeroDePaginas;
                }
                else
                    dgvProdutos.DataSource = null;
                if (ultimaPosicao < totalDeRegistros)
                {
                    dgvProdutos.DataSource = produtosAcoesDB.Select(
                        txFiltroCodigo.Text == "" ? 0 : int.Parse(txFiltroCodigo.Text),
                        txFiltroProduto.Text == "" ? null : txFiltroProduto.Text,
                        txFiltroFornecedor.Text == "" ? null : txFiltroFornecedor.Text,
                        ckFiltroDatas.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                        ckFiltroDatas.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null,
                        cbFiltroStatus.SelectedIndex,
                        ordem,
                        ultimaPosicao,
                        int.Parse(cbQtdPagina.Text));

                    if (dgvProdutos.DataSource != null)
                    {
                        dgvProdutos.Columns["Id"].HeaderText = "Codigo";
                        dgvProdutos.Columns["Produto"].HeaderText = "Produto";
                        dgvProdutos.Columns["Dimensoes"].HeaderText = "Dimensões";
                        dgvProdutos.Columns["Fornecedor"].HeaderText = "Fornecedor Principal";
                        dgvProdutos.Columns["Detalhe"].HeaderText = "Detalhe";
                        dgvProdutos.Columns["Status"].HeaderText = "Status";
                        dgvProdutos.Columns["Data"].HeaderText = "Data";
                    }
                    else
                        dgvProdutos.DataSource = null;

                    chaveFiltro = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar produtos");
                RegistraLog.Log($"Erro ao pesquisar os produtos {ex}");
            }
        }

        private void btProximaPagina_Click(object sender, EventArgs e)
        {
            if (dgvProdutos != null && ultimaPosicao < totalDeRegistros - int.Parse(cbQtdPagina.Text))
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
            if (dgvProdutos.Rows.Count > 0 && chaveFiltro)
            {
                ultimaPosicao = 0;
                pagina = 1;
                AlimentaDGV();
            }
            else
                pagina = 0;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            pagina = 1;
            desativarEntradas(true);
            AlimentaDGV();
            desativarEntradas(false);
            btProximaPagina.Enabled = true;
            btPaginaAnterior.Enabled = true;
        }

        private void desativarEntradas(bool desativar)
        {
            if (desativar)
            {
                txFiltroCodigo.Enabled = false;
                txFiltroProduto.Enabled = false;
                txFiltroFornecedor.Enabled = false;
                txEditarProduto.Enabled = false;
                txEditarFornecedor.Enabled = false;
                txEditarDimensoes.Enabled = false;
                txEditarDetalhes.Enabled = false;
                txCadastroDetalhes.Enabled = false;
                txCadastroDimensoes.Enabled = false;
                txCadastroFornecedor.Enabled = false;
                txCadastroProduto.Enabled = false;
            }
            else
            {
                txFiltroCodigo.Enabled = true;
                txFiltroProduto.Enabled = true;
                txFiltroFornecedor.Enabled = true;
                txEditarProduto.Enabled = true;
                txEditarFornecedor.Enabled = true;
                txEditarDimensoes.Enabled = true;
                txEditarDetalhes.Enabled = true;
                txCadastroDetalhes.Enabled = true;
                txCadastroDimensoes.Enabled = true;
                txCadastroFornecedor.Enabled = true;
                txCadastroProduto.Enabled = true;
            }
        }

        private void AlimentaCB()
        {
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
        }

        private void AtivaData()
        {
            if (ckFiltroDatas.Checked == true)
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

        private void ckFiltroDatas_CheckedChanged(object sender, EventArgs e)
        {
            AtivaData();
        }

        private void txFiltroCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void dgvProdutos_Click(object sender, EventArgs e)
        {
            AlimentaEditar();
        }
    }
}
