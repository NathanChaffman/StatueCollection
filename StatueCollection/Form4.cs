using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace StatueCollection
{
    public partial class Form4 : Form
    {
        StatueDepot statue;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            statue = new StatueDepot();
            dataGridViewUpdateDelete.DataSource = null;
            dataGridViewUpdateDelete.DataSource = statue.Read();
        }

        private void btnUpdate_Click(object sender, EventArgs e) //opens update window with cell information
        {
            Global.IdtoUpdate = Convert.ToDecimal(dataGridViewUpdateDelete.CurrentRow.Cells[0].Value);
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e) //deletes row
        {
            var id = dataGridViewUpdateDelete.CurrentRow.Cells[0].Value;
            var statueTodelete = statue.FindStatue((decimal)id);
            statue.Delete(statueTodelete);
            dataGridViewUpdateDelete.DataSource = null;
            dataGridViewUpdateDelete.DataSource = statue.Read();
        }

        private void btnRefresh_Click(object sender, EventArgs e) //ToDo: fix refresh
        {
            statue = new StatueDepot();
            dataGridViewUpdateDelete.DataSource = null;
            dataGridViewUpdateDelete.DataSource = statue.Read();
        }

        private void btnMainMenu_Click(object sender, EventArgs e) //closes window
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)  //output to excel
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridViewUpdateDelete.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewUpdateDelete.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewUpdateDelete.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewUpdateDelete.Columns.Count; j++)
                {
                    if (dataGridViewUpdateDelete.Rows[i].Cells[j].Value is null)
                    {
                        worksheet.Cells[i + 2, j + 1] = string.Empty;
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewUpdateDelete.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            workbook.SaveAs("c:\\output\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }
    }
}
