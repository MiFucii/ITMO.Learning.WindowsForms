using System;
using System.Data;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Exercise1.ConnectionMicrosoftExcel
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;
        DataTable dt = new DataTable();

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = openFileDialog.FileName;
                workbook = app.Workbooks.Open(openFileDialog.FileName);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                dataGridView.DataSource = dt;
                app.Quit();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
