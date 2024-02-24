using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace Bacusmo_Prelim
{
    public partial class StudentDB : Form
    {
        public StudentDB()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo stdinfo = new StudentInfo(this);
            stdinfo.Show();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); saveFileDialog.Filter =
"XLS (*.xls)|*.xls|" + "XLT (*.xlt)|*.xlt|" + "XLSX (*.xlsx)|*.xlsx|" + "XLSM (*.xlsm)|*.xlsm|" + "XLTX (*.xltx)|*.xltx|" + "XLTM (*.xltm)|*.xltm|" + "ODS (*.ods)|*.ods|" + "OTS (*.ots)|*.ots|" + "CSV (*.csv)|*.csv|" + "TSV (*.tsv)|*.tsv|" + "HTML (*.html)|*.html|" +
"MHTML (.mhtml)|*.mhtml|" + "PDF (*.pdf)|*.pdf|" +
"XPS (*.xps)|*.xps|" + "BMP (*.bmp)|*.bmp|" + "GIF (*.gif)|*.gif|" + "JPEG (*.jpg)|*.jpg|" + "PNG (*.png)|*.png|" + "TIFF (*.tif)|*.tif|" + "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                DataGridViewConverter.ImportFromDataGridView(worksheet, this.dgv_database, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }

    }
}