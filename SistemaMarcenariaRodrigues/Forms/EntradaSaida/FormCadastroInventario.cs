using SistemaMarcenariaRodrigues.Acoes.EntradaSaida;
using SistemaMarcenariaRodrigues.Acoes.Operacoes;
using SistemaMarcenariaRodrigues.Acoes.Produtos;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using SistemaMarcenariaRodrigues.Model.Produtos;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Forms.EntradaSaida
{
    public partial class FormCadastroInventario : Form
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

        public FormCadastroInventario()
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
                MessageBox.Show("Erro no sistema, consulte o desenvolvedor");
                RegistraLog.Log("Erro ao suprimir botões de Maximizar ou Restaurar" + ex);
            }
        }

        private void btAbrirCadastro_Click(object sender, EventArgs e)
        {
            gbEditar.Hide();
            gbCadastro.Show();
            AcceptButton = btCadastrar;
        }

        private void btAbrirEdicao_Click(object sender, EventArgs e)
        {
            gbCadastro.Hide();
            gbEditar.Show();
            if(dgvInventario.DataSource != null)
                AlimentaEditar();

            AcceptButton = btCadastrar;
        }

        private void AlimentaEditar()
        {
            try
            {
                cbEditarStatus.SelectedIndex = dgvInventario.DataSource == null ?
                -1 : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Status"].Value.ToString() == "Ativo" ?
                1 : 0;
                cbEditarOperaco.SelectedValue = dgvInventario.DataSource == null ?
                    -1 : (int)dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Operacao"].Value;
                cbEditarProduto.SelectedValue = dgvInventario.DataSource == null ?
                    -1 : (int)dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Produto"].Value;

                txEditarComplemento.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Complemento"].Value.ToString();
                txEditarFornecedor.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Fornecedor"].Value.ToString();
                txEditarNotaFiscal.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["NotaFiscal"].Value.ToString();
                txEditarQuantidade.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Quantidade"].Value.ToString();
                txEditarSerie.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Serie"].Value.ToString();
                txEditarValorUnitario.Text = dgvInventario.DataSource == null ?
                    "" : dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["ValorEntrada"].Value.ToString()
                    .Trim('R', '$', ' ').Replace(".", "").Replace(",", ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar dados de inventario, consulte o desenvolvedor");
                RegistraLog.Log($@"Erro ao alimentar campos do GroupBox Editar -- {ex}");
            }

        }

        private void AlimentaDGV()
        {
            try
            {
                InventarioAcoesDB inventarioAcoesDB = new InventarioAcoesDB();
                List<string> listaContagemSoma = new List<string>();

                string ordem = "";
                if (rbFiltroCrescente.Checked)
                    ordem = "crescente";
                if (rbFiltroDecrescente.Checked)
                    ordem = "decrescente";

                listaContagemSoma = inventarioAcoesDB.Count(
                    txFiltroId.Text == "" ? 0 : int.Parse(txFiltroId.Text),
                    (int)cbFiltroOperacao.SelectedValue,
                    (int)cbFiltroProduto.SelectedValue,
                    txFiltroFornecedor.Text == "" ? null : txFiltroFornecedor.Text,
                    cbFiltroStatus.SelectedIndex,
                    ckFiltroDatas.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                    ckFiltroDatas.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null);

                totalDeRegistros = int.Parse(listaContagemSoma[0]);

                if(totalDeRegistros > 0)
                {
                    int calculoPaginas = totalDeRegistros / int.Parse(cbQtdPagina.Text);
                    int numeroDePaginas = calculoPaginas + 1;
                    lbPagina.Text = pagina + "/" + numeroDePaginas;
                }
                else
                    dgvInventario.DataSource = null;
                if (ultimaPosicao < totalDeRegistros)
                {
                    dgvInventario.DataSource = inventarioAcoesDB.Select(
                    txFiltroId.Text == "" ? 0 : int.Parse(txFiltroId.Text),
                    (int)cbFiltroOperacao.SelectedValue,
                    (int)cbFiltroProduto.SelectedValue,
                    txFiltroFornecedor.Text == "" ? null : txFiltroFornecedor.Text,
                    cbFiltroStatus.SelectedIndex,
                    ckFiltroDatas.Checked == true ? dtFiltroInicio.Value.ToString("yyyy-MM-dd") : null,
                    ckFiltroDatas.Checked == true ? dtFiltroFim.Value.ToString("yyyy-MM-dd") : null,
                    ordem,
                    ultimaPosicao,
                    int.Parse(cbQtdPagina.Text));

                    if (dgvInventario.DataSource != null)
                    {
                        dgvInventario.Columns["Id"].HeaderText = "Id";
                        dgvInventario.Columns["NomeProduto"].HeaderText = "Produto";
                        dgvInventario.Columns["NomeOperacao"].HeaderText = "Operação";
                        dgvInventario.Columns["Quantidade"].HeaderText = "Quantidade";
                        dgvInventario.Columns["ValorEntrada"].HeaderText = "Valor";
                        dgvInventario.Columns["ValorTotal"].HeaderText = "Valor Total";
                        dgvInventario.Columns["Serie"].HeaderText = "Série";
                        dgvInventario.Columns["NotaFiscal"].HeaderText = "Nota Fiscal";
                        dgvInventario.Columns["Fornecedor"].HeaderText = "Fornecedor / Cliente";
                        dgvInventario.Columns["Seq"].HeaderText = "Seq";
                        dgvInventario.Columns["Complemento"].HeaderText = "Complemento";
                        dgvInventario.Columns["Status"].HeaderText = "Status";
                        dgvInventario.Columns["Data"].HeaderText = "Data";

                        dgvInventario.Columns["Id"].DisplayIndex = 1;
                        dgvInventario.Columns["NomeProduto"].DisplayIndex = 2;
                        dgvInventario.Columns["NomeOperacao"].DisplayIndex = 3;
                        dgvInventario.Columns["Quantidade"].DisplayIndex = 4;
                        dgvInventario.Columns["ValorEntrada"].DisplayIndex = 5;
                        dgvInventario.Columns["ValorTotal"].DisplayIndex = 6;
                        dgvInventario.Columns["Serie"].DisplayIndex = 7;
                        dgvInventario.Columns["NotaFiscal"].DisplayIndex = 8;
                        dgvInventario.Columns["Fornecedor"].DisplayIndex = 9;
                        dgvInventario.Columns["Seq"].DisplayIndex = 10;
                        dgvInventario.Columns["Complemento"].DisplayIndex = 11;
                        dgvInventario.Columns["Status"].DisplayIndex = 12;
                        dgvInventario.Columns["Data"].DisplayIndex = 13;

                        dgvInventario.Columns["Produto"].Visible = false;
                        dgvInventario.Columns["Operacao"].Visible = false;
                    }
                    else
                        dgvInventario.DataSource = null;

                    chaveFiltro = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar inventario, consulte o desenvolvedor");
                RegistraLog.Log("Erro ao retornar dados do iventario" + ex);
            }
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

        private void btProximaPagina_Click(object sender, EventArgs e)
        {
            if (dgvInventario != null && ultimaPosicao < totalDeRegistros - int.Parse(cbQtdPagina.Text))
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
            if (dgvInventario.Rows.Count > 0 && chaveFiltro)
            {
                ultimaPosicao = 0;
                pagina = 1;
                AlimentaDGV();
            }
            else
                pagina = 0;
        }

        private void desativarEntradas(bool desativar)
        {
            if (desativar == true)
                gbFiltro.Enabled = false;
            else
                gbFiltro.Enabled = true;
        }

        private void AlimentaCB()
        {
            try
            {
                OperacoesAcoesDB operacoesAcoesDB = new OperacoesAcoesDB();
                ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();
                List<ProdutosModel> produtosModels = new List<ProdutosModel>();


                cbQtdPagina.Items.Add(10);
                cbQtdPagina.Items.Add(50);
                cbQtdPagina.Items.Add(100);
                cbQtdPagina.SelectedIndex = 0;

                cbEditarStatus.Items.Add("Inativo");
                cbEditarStatus.Items.Add("Ativo");
                cbEditarStatus.SelectedIndex = -1;

                cbFiltroStatus.Items.Add("Todos");
                cbFiltroStatus.Items.Add("Inativo");
                cbFiltroStatus.Items.Add("Ativo");
                cbFiltroStatus.SelectedIndex = 0;

                cbFiltroOperacao.DataSource = operacoesAcoesDB.Select(1, true);
                cbFiltroOperacao.DisplayMember = "Movimento";
                cbFiltroOperacao.ValueMember = "Id";
                cbFiltroOperacao.Enabled = true;
                cbFiltroOperacao.SelectedIndex = 0;

                cbEditarOperaco.DataSource = operacoesAcoesDB.Select(1,false);
                cbEditarOperaco.DisplayMember = "Movimento";
                cbEditarOperaco.ValueMember = "Id";
                cbEditarOperaco.Enabled = true;
                cbEditarOperaco.SelectedIndex = -1;

                produtosModels.Add(new ProdutosModel() { Id = 0, Produto = "Todos" });
                foreach (var item in produtosAcoesDB.Select(0, null, null, null, null, 1, null, null, null))
                    produtosModels.Add(item);

                cbFiltroProduto.DataSource = produtosModels;
                cbFiltroProduto.DisplayMember = "Produto";
                cbFiltroProduto.ValueMember = "Id";
                cbFiltroProduto.Enabled = true;
                cbFiltroProduto.SelectedIndex = 0;

                cbCadastroProduto.DataSource = produtosAcoesDB.Select(0,null,null,null,null,1,null,null,null);
                cbCadastroProduto.DisplayMember = "Produto";
                cbCadastroProduto.ValueMember = "Id";
                cbCadastroProduto.Enabled = true;
                cbCadastroProduto.SelectedValue = 1;

                cbEditarProduto.DataSource = produtosAcoesDB.Select(0,null,null,null,null,1,null,null,null);
                cbEditarProduto.DisplayMember = "Produto";
                cbEditarProduto.ValueMember = "Id";
                cbEditarProduto.Enabled = true;
                cbEditarProduto.SelectedIndex = -1;

                cbCadastroOperacao.DataSource = operacoesAcoesDB.Select(1,false);
                cbCadastroOperacao.DisplayMember = "Movimento";
                cbCadastroOperacao.ValueMember = "Id";
                cbCadastroOperacao.Enabled = true;

                AcceptButton = btPesquisar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de sistema, consulte o desenvolvedor");
                RegistraLog.Log($"Erro ao alimentar ComboBox -- {ex}");
            }
            
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
                InventarioAcoesDB inventarioAcoesDB = new InventarioAcoesDB();
                MessageBox.Show(inventarioAcoesDB.Insert(
                    (int)cbCadastroProduto.SelectedValue,
                    (int)cbCadastroOperacao.SelectedValue,
                    int.Parse(txCadastroQuantidade.Text),
                    double.Parse(txCadastroValorUnitario.Text),
                    txCadastroSerie.Text,
                    txCadastroNotaFiscal.Text,
                    txCadastroFornecedor.Text,
                    txCadastroComplemento.Text));

                cbCadastroProduto.SelectedIndex = -1;
                cbCadastroOperacao.SelectedIndex = -1;
                txCadastroQuantidade.Clear();
                txCadastroValorUnitario.Clear();
                txCadastroSerie.Clear();
                txCadastroNotaFiscal.Clear();
                txCadastroFornecedor.Clear();
                txCadastroComplemento.Clear();

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
                InventarioAcoesDB inventarioAcoesDB = new InventarioAcoesDB();
                MessageBox.Show(inventarioAcoesDB.Update(
                    (int)dgvInventario.Rows[dgvInventario.SelectedRows[0].Index].Cells["Id"].Value,
                    (int)cbEditarProduto.SelectedValue,
                    (int)cbEditarOperaco.SelectedValue,
                    int.Parse(txEditarQuantidade.Text),
                    double.Parse(txEditarValorUnitario.Text),
                    txEditarSerie.Text,
                    txEditarNotaFiscal.Text,
                    txEditarFornecedor.Text,
                    txEditarComplemento.Text,
                    cbEditarStatus.SelectedIndex == 1 ? true : false));

                AlimentaDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto, contate o desenvolvedor");
                RegistraLog.Log($"Erro ao atualizar produto -- {ex}");
            }
        }

        private void btEsconderCadastro_Click(object sender, EventArgs e)
        {
            gbCadastro.Hide();
            AcceptButton = btPesquisar;
        }

        private void btEsconderEditar_Click(object sender, EventArgs e)
        {
            gbEditar.Hide();
            AcceptButton = btPesquisar;
        }

        private void dgvInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.DataSource != null)
                AlimentaEditar();
        }

        private void txCadastroQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txCadastroValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txEditarQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txEditarValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void ckFiltroDatas_CheckedChanged(object sender, EventArgs e)
        {
            AtivaData();
        }

        private void txFiltroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void cbCadastroProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCadastroProduto.DataSource != null)
                AlimentaCadastroSaida(cbCadastroOperacao);
        }

        private void cbCadastroOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCadastroOperacao.DataSource != null)
                AlimentaCadastroSaida(cbCadastroProduto);
        }

        private void AlimentaCadastroSaida(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
            {
                if (cbCadastroOperacao.SelectedValue.ToString() == "2")
                {
                    InventarioAcoesDB inventarioAcoesDB = new InventarioAcoesDB();

                    List<InventarioModel> inventario = inventarioAcoesDB.Select(0, 1,
                        (int)cbCadastroProduto.SelectedValue, null, 0, null, null, "decrescente", null, null);

                    if (inventario.Count > 0)
                    {
                        txCadastroValorUnitario.Enabled = false;
                        txCadastroNotaFiscal.Enabled = false;
                        txCadastroSerie.Enabled = false;

                        txCadastroValorUnitario.Text = inventario[0].ValorEntrada.ToString().Trim('R', '$', ' ').Replace(".", "").Replace(",", ".");
                        txCadastroNotaFiscal.Text = inventario[0].NotaFiscal;
                        txCadastroSerie.Text = inventario[0].Serie;
                    }
                    else
                    {
                        txCadastroValorUnitario.Enabled = true;
                        txCadastroNotaFiscal.Enabled = true;
                        txCadastroSerie.Enabled = true;

                        txCadastroValorUnitario.Text = "";
                        txCadastroNotaFiscal.Text = "";
                        txCadastroSerie.Text = "";
                    }
                }
                else
                {
                    txCadastroValorUnitario.Enabled = true;
                    txCadastroNotaFiscal.Enabled = true;
                    txCadastroSerie.Enabled = true;

                    txCadastroValorUnitario.Text = "";
                    txCadastroNotaFiscal.Text = "";
                    txCadastroSerie.Text = "";
                }
            }
        }
    }
}
