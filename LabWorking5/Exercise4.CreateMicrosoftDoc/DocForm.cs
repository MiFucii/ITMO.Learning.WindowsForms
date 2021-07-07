using System;
using WordObj = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exercise4.CreateMicrosoftDoc
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        WordObj.Application winword;
        private void NewDocument()
        {
            winword = new WordObj.Application();


            WordObj.Document document = winword.Documents.Add();

            foreach (WordObj.Section section in document.Sections)
            {
                WordObj.Range headerRange = section.Headers[WordObj.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WordObj.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WordObj.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WordObj.WdColorIndex.wdBlue;
                headerRange.Font.Size = 10;
                headerRange.Text = "Верхний колонтитул:" + Environment.NewLine + "Отчет";
            }
            foreach (WordObj.Section wordSection in document.Sections)
            {
                WordObj.Range footerRange =
                wordSection.Footers[WordObj.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = WordObj.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 10;
                footerRange.ParagraphFormat.Alignment =
                WordObj.WdParagraphAlignment.wdAlignParagraphCenter;
                footerRange.Text = "Нижний колонтитул:" + Environment.NewLine + "Отчет";
            }

            document.Content.SetRange(0, 0);
            document.Content.Text = "Отчет" + Environment.NewLine;

            WordObj.Paragraph paragrph = document.Content.Paragraphs.Add();
            object styleHeading1 = "Заголовок 1";
            paragrph.Range.set_Style(styleHeading1);
            paragrph.Range.Text = "Результаты";
            paragrph.Range.InsertParagraphAfter();

            //Создание таблицы 5х5
            WordObj.Table firstTable = document.Tables.Add(paragrph.Range, 5, 5);
            firstTable.Borders.Enable = 1;
            foreach (WordObj.Row row in firstTable.Rows)
            {
                foreach (WordObj.Cell cell in row.Cells)
                {
                    //Заголовок таблицы
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = "Колонка " + cell.ColumnIndex.ToString();
                        cell.Range.Font.Bold = 1;
                        //Задаем шрифт и размер текста
                        cell.Range.Font.Name = "verdana";
                        cell.Range.Font.Size = 10;
                        cell.Shading.BackgroundPatternColor = WordObj.WdColor.wdColorGray25;
                        //Выравнивание текста в заголовках столбцов по центру
                        cell.VerticalAlignment =
                        WordObj.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment =
                        WordObj.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    //Значения ячеек
                    else
                    {
                        cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                    }
                }
            }
            //Показываем документ
            winword.Visible = false;

            ////Сохранение документа
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                document.SaveAs(saveFileDialog.FileName);
                //Закрытие текущего документа
                document.Close();
                document = null;
            }
            else
            {
                //Закрытие приложения Word
                winword.Quit();
                winword = null;
            }
        }

        private void btnCreateDoc_Click(object sender, EventArgs e)
        {
            try
            {
                NewDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
