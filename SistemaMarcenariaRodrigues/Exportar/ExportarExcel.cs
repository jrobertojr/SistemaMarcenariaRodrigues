using ClosedXML.Excel;
using SistemaMarcenariaRodrigues.Log;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Exportar
{
    class ExportarExcel
    {
        public void Exportar(DataGridView tabela)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();

                DataTable datatable = CorverterDataGridView(tabela);
                if (datatable != null)
                {
                    string folderPath = "C:\\Excel\\";
                    folderDlg.ShowNewFolderButton = true;
                    DialogResult result = folderDlg.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        folderPath = folderDlg.SelectedPath;
                        if (!Directory.Exists(folderPath))
                            Directory.CreateDirectory(folderPath);
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            string caminho = Path.Combine(folderPath, $"Estoque {DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}.xlsx");
                            wb.Worksheets.Add(datatable, "Customers");
                            wb.SaveAs(caminho);
                        }

                        MessageBox.Show($"Arquivo Estoque {DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}.xlsx exportado para {folderPath}");
                    }
                }
                else
                    MessageBox.Show($"Erro ao exportar pedidos, consulte o desenvolvedor.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar para Excel");
                RegistraLog.Log($"Erro ao gerar arquivo .xlsx: {ex}");
            }
        }

        private DataTable CorverterDataGridView(DataGridView gridView)
        {
            try
            {
                DataTable tabelaRetorno = new DataTable();

                //Adding the Columns.
                foreach (DataGridViewColumn column in gridView.Columns)
                    tabelaRetorno.Columns.Add(column.HeaderText, column.ValueType);

                //Adding the Rows.
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    tabelaRetorno.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                        tabelaRetorno.Rows[tabelaRetorno.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString() == null ? "" : cell.Value.ToString();
                }

                return tabelaRetorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao converter DataGridView em DataTable -- {ex}");
                return null;
            }

        }
    }
}
