using SistemaMarcenariaRodrigues.Acoes.EntradaSaida;
using SistemaMarcenariaRodrigues.Acoes.Produtos;
using SistemaMarcenariaRodrigues.Exportar;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Forms.EntradaSaida
{
    public partial class FormConsultaEstoque : Form
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

        public FormConsultaEstoque()
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

        private void AlimentaCB()
        {
            ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();

            cbQtdPagina.Items.Add(10);
            cbQtdPagina.Items.Add(50);
            cbQtdPagina.Items.Add(100);
            cbQtdPagina.SelectedIndex = 0;

            cbFiltroProduto.DataSource = produtosAcoesDB.Select(0, null, null, null, null, 1, null, null, null);
            cbFiltroProduto.DisplayMember = "Produto";
            cbFiltroProduto.ValueMember = "Id";
            cbFiltroProduto.Enabled = true;
            cbFiltroProduto.SelectedIndex = 0;
        }

        private void AlimentaDGV()
        {
            EstoqueAcoesDB estoqueAcoesDB = new EstoqueAcoesDB();
            List<string> listaContagemSoma = new List<string>();

            listaContagemSoma = estoqueAcoesDB.Count((int)cbFiltroProduto.SelectedValue);
            totalDeRegistros = int.Parse(listaContagemSoma[0]);

            if (totalDeRegistros > 0)
            {
                int calculoPaginas = totalDeRegistros / int.Parse(cbQtdPagina.Text);
                int numeroDePaginas = calculoPaginas + 1;
                lbPagina.Text = pagina + "/" + numeroDePaginas;
            }
            else
                dgvEstoque.DataSource = null;
            if (ultimaPosicao < totalDeRegistros)
            {
                dgvEstoque.DataSource = estoqueAcoesDB.Select(
                    (int)cbFiltroProduto.SelectedValue,
                    ultimaPosicao,
                    int.Parse(cbQtdPagina.Text));
                if (dgvEstoque.DataSource != null)
                {
                    dgvEstoque.Columns["Codigo"].HeaderText = "Código";
                    dgvEstoque.Columns["TipoMovimento"].HeaderText = "Tipo Movimento";
                    dgvEstoque.Columns["Data"].HeaderText = "Data";
                    dgvEstoque.Columns["Quantidade"].HeaderText = "Quantidade";
                    dgvEstoque.Columns["Valor"].HeaderText = "Valor Entrada / Saída";
                    dgvEstoque.Columns["OperacaoFiscal"].HeaderText = "Operação Fiscal";
                    dgvEstoque.Columns["Serie"].HeaderText = "Série";
                    dgvEstoque.Columns["Notafiscal"].HeaderText = "Nota Fiscal";
                    dgvEstoque.Columns["FornecedorCliente"].HeaderText = "Fornecedor / Cliente";
                    dgvEstoque.Columns["Complemento"].HeaderText = "Complemento";
                    dgvEstoque.Columns["ValorMovimento"].HeaderText = "Valor Movimento";
                    dgvEstoque.Columns["QuantidadeTotal"].HeaderText = "Quantidade Total";
                    dgvEstoque.Columns["ValorTotal"].HeaderText = "Valor Total";
                    dgvEstoque.Columns["CustoMedio"].HeaderText = "Custo Médio";

                    dgvEstoque.Columns["Codigo"].DisplayIndex = 1;
                    dgvEstoque.Columns["TipoMovimento"].DisplayIndex = 2;
                    dgvEstoque.Columns["Data"].DisplayIndex = 3;
                    dgvEstoque.Columns["Quantidade"].DisplayIndex = 4;
                    dgvEstoque.Columns["Valor"].DisplayIndex = 5;
                    dgvEstoque.Columns["OperacaoFiscal"].DisplayIndex = 6;
                    dgvEstoque.Columns["Serie"].DisplayIndex = 7;
                    dgvEstoque.Columns["Notafiscal"].DisplayIndex = 8;
                    dgvEstoque.Columns["FornecedorCliente"].DisplayIndex = 9;
                    dgvEstoque.Columns["Complemento"].DisplayIndex = 10;
                    dgvEstoque.Columns["ValorMovimento"].DisplayIndex = 11;
                    dgvEstoque.Columns["QuantidadeTotal"].DisplayIndex = 12;
                    dgvEstoque.Columns["ValorTotal"].DisplayIndex = 13;
                    dgvEstoque.Columns["CustoMedio"].DisplayIndex = 14;

                    dgvEstoque.Columns["IdOperacao"].Visible = false;
                }
            }
            else
                dgvEstoque.DataSource = null;

            chaveFiltro = true;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            pagina = 1;
            cbFiltroProduto.Enabled = false;
            AlimentaDGV();
            cbFiltroProduto.Enabled = true;
            btProximaPagina.Enabled = true;
            btPaginaAnterior.Enabled = true;

            AlimentaTela();
        }

        private void AlimentaTela()
        {
            ProdutosAcoesDB produtosAcoesDB = new ProdutosAcoesDB();
            List<ProdutosModel> produtosModel = new List<ProdutosModel>();
            int IdProduto = (int)cbFiltroProduto.SelectedValue;

            produtosModel = produtosAcoesDB.Select(IdProduto, null, null, null, null, 1, null, null, null);

            lbFiltroResultadoProduto.Visible = true;
            lbFiltroResultadoData.Visible = true;
            lbFiltroResultadoDim.Visible = true;
            lbFiltroResultadoFornecedor.Visible = true;

            lbFiltroResultadoProduto.Text = produtosModel[0].Id.ToString();
            lbFiltroResultadoData.Text = produtosModel[0].Data.ToString();
            lbFiltroResultadoDim.Text = produtosModel[0].Dimensoes.ToString();
            lbFiltroResultadoFornecedor.Text = produtosModel[0].Fornecedor.ToString();

            if(dgvEstoque.Rows.Count > 0)
            {
                lbRodapeVTResultado.Visible = true;
                lbRodapeVTResultado.Text = dgvEstoque.Rows[dgvEstoque.Rows.Count - 1].Cells["ValorTotal"].Value.ToString();
            }
            else
            {
                lbRodapeVTResultado.Visible = false;
                lbRodapeVTResultado.Text = "";
            }

        }

        private void btProximaPagina_Click(object sender, EventArgs e)
        {
            if (dgvEstoque != null && ultimaPosicao < totalDeRegistros - int.Parse(cbQtdPagina.Text))
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
            if (dgvEstoque.Rows.Count > 0 && chaveFiltro)
            {
                ultimaPosicao = 0;
                pagina = 1;
                AlimentaDGV();
            }
            else
                pagina = 0;
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel exportarExcel = new ExportarExcel();
            exportarExcel.Exportar(dgvEstoque);
        }
    }
}
