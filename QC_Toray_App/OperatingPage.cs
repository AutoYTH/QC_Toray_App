using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;

//using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QC_Toray_App
{
    public partial class OperatingPage : Form
    {
        // Declare a list to store label instances
        List<Label> recordLabels = new List<Label>();
        public OperatingPage()
        {
            InitializeComponent();

            // Use the existing DataGridView instance (Panel Report)
            SetupDataGridView(dgvReport1);
            SetupDataGridView(dgvReport2);

            // Generate test data and bind it to dgvReport1
            DataTable table1 = GenerateTestDataReport1();
            dgvReport1.DataSource = table1;

            // Generate test data and bind it to dgvReport2
            DataTable table2 = GenerateTestDataReport2();
            dgvReport2.DataSource = table2;


            // Customize column headers to mimic the image
            FormatColumns(dgvReport1);

            // First Page be Operation
            pnlOperation.BringToFront();

            // Create and add labels dynamically
            recordLabels = CreateListLabel();
            // Assign the click event
            for (int i = 0; i < recordLabels.Count; i++) {
                recordLabels[i].Click += RecordLabel_Click;
            }

        }

        private List<Label> CreateListLabel()
        {
            // Crete Label List
            List<Label> list = new List<Label>();
            list.Add(lblRecSizeFail);
            list.Add(lblRecMisscut1);
            list.Add(lblRecMisscut2);
            list.Add(lblRecMisscut3);
            list.Add(lblRecLink1);
            list.Add(lblRecLink2);
            list.Add(lblRecLink3);
            list.Add(lblRecLink4);
            list.Add(lblRecDefect);
            list.Add(lblRecGF1);
            list.Add(lblRecGF2);
            list.Add(lblRecGF3);
            list.Add(lblRecMeyani);
            list.Add(lblRecFM);
            list.Add(lblRecBlackSpot1);
            list.Add(lblRecBlackSpot2);
            list.Add(lblRecBlackSpot3);
            list.Add(lblRecBlackSpot4);
            list.Add(lblRecCA);
            list.Add(lblRecMacaloni1);
            list.Add(lblRecMacaloni2);
            list.Add(lblRecMacaloni3);
            list.Add(lblRecMacaloni4);

            return list; 
        }

        private void RecordLabel_Click(object sender, EventArgs e) {
            if (sender is Label label) {
                // Toggle between "Pass" and "Fail" states
                if (label.Text == "Pass")
                {
                    label.Text = "Fail";
                    label.BackColor = Color.FromArgb(255, 192, 192); // red
                }
                else
                {
                    label.Text = "Pass";
                    label.BackColor = Color.FromArgb(192, 255, 192); // greem
                }
            }
        }

        private void SetupDataGridView(DataGridView dataGridView)
        {
            // Configure basic properties for the DataGridView
            //dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
        }

        private DataTable GenerateTestDataReport1()
        {
            DataTable table = new DataTable();

            // Define columns based on the image structure
            table.Columns.Add("Batch No.", typeof(string));
            table.Columns.Add("Batch 21", typeof(string));
            table.Columns.Add("Batch 22", typeof(string));
            table.Columns.Add("Batch 24", typeof(string));
            table.Columns.Add("Batch 26", typeof(string));

            // Add rows of data (mimicking the data in the table)
            table.Rows.Add("Lot. No.", "50164102", "", "", "");
            table.Rows.Add("Item", "", "", "", "");
            table.Rows.Add("1. Pellet shape", "", "", "", "");
            table.Rows.Add("  1.1 Pellet size", "Pass", "Pass", "Pass", "Pass");
            table.Rows.Add("  1.2 Misscut of pellets", "0", "0", "0", "0");
            table.Rows.Add("    (1) Double length", "2", "0", "0", "0");
            table.Rows.Add("    (2) Triple length", "0", "0", "0", "0");
            table.Rows.Add("  1.3 Linkage of pellets", "", "", "", "");
            table.Rows.Add("    (1) Double linkage", "3", "0", "0", "0");
            table.Rows.Add("    (2) Triple linkage", "1", "0", "0", "0");
            table.Rows.Add("1.4 Defect of cutting plane", "0", "0", "0", "0");
            table.Rows.Add("2. GF not Distribution", "", "", "", "");
            table.Rows.Add("  Level 1", "≥ 2", "0", "0", "0");
            table.Rows.Add("  Level 2", "0", "0", "0", "0");
            table.Rows.Add("3. Meyani", "", "", "", "");
            table.Rows.Add("  Not change color. ≥ 15", "0", "0", "0", "0");
            table.Rows.Add("4. Foreign materials", "", "", "", "");
            table.Rows.Add("5. Black Spot", "", "", "", "");
            table.Rows.Add("  (1) SS (0.08 mm²)", "≥ 2", "0", "0", "0");
            table.Rows.Add("6. Color abnormal", "", "", "", "");
            table.Rows.Add("7. Macaroni", "", "", "", "");
            table.Rows.Add("  (1) SS (1.00 mm²)", "≥ 2", "0", "0", "0");
            table.Rows.Add("Remark", "", "", "", "");
            table.Rows.Add("Judgment (OK/NG)", "OK", "OK", "OK", "OK");
            table.Rows.Add("Check By", "Miss.Nuanyai", "Miss.Nuanyai", "Miss.Nuanyai", "Miss.Nuanyai");
            table.Rows.Add("Date", "1/7/2025", "1/7/2025", "1/7/2025", "1/7/2025");

            return table;
        }

        private DataTable GenerateTestDataReport2()
        {
            DataTable table = new DataTable();
            // Define columns based on the image structure
            table.Columns.Add("Line", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Grade", typeof(string));
            table.Columns.Add("Bt", typeof(string));
            table.Columns.Add("Lot", typeof(string));
            table.Columns.Add("Check", typeof(string));
            table.Columns.Add("Result", typeof(string));
            table.Columns.Add("PIC", typeof(string));
            table.Columns.Add("Remark", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Date", typeof(string));

            // Add rows of data (mimicking the data in the table)
            table.Rows.Add("C", "PBT", "1401x34 HB", "176", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            table.Rows.Add("C", "PBT", "1401x34 HB", "177", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            table.Rows.Add("B", "PBT", "1401x34 HB", "178", "50164909", "1", "OK", "Miss.Thanika", "เม็ดเฉียง", "9:34", "1/19/2025");
            table.Rows.Add("B", "PBT", "1401x34 HB", "179", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            table.Rows.Add("B", "PBT", "1401x34 HB", "30", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            table.Rows.Add("B", "PBT", "1401x34 HB", "52", "50164909", "1", "OK", "Miss.Thanika", "เม็ดเฉียง", "9:34", "1/19/2025");
            table.Rows.Add("D", "PBT", "1401x34 HB", "273", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            table.Rows.Add("TC", "NYLON", "1401x34 HB", "5", "50164909", "1", "OK", "Miss.Thanika", "", "9:34", "1/19/2025");
            return table;
        }

        private void FormatColumns(DataGridView dataGridView)
        {
            // Set column headers
            dataGridView.Columns[0].HeaderText = "Batch No";
            dataGridView.Columns[1].HeaderText = "21";
            dataGridView.Columns[2].HeaderText = "22";
            dataGridView.Columns[3].HeaderText = "24";
            dataGridView.Columns[4].HeaderText = "26";

            // Adjust column widths
            //dataGridView.Columns[0].Width = 300; // Make the "Item" column wider
        }

        private void OperatingPage_Load(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void lblLogout_MouseHover(object sender, EventArgs e)
        {
            //lblLogout.Font = new Font(lblLogout.Font, FontStyle.Underline | FontStyle.Bold);
            lblLogout.ForeColor = Color.MediumPurple;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            //lblLogout.Font = new Font(lblLogout.Font, FontStyle.Bold);
            lblLogout.ForeColor = SystemColors.MenuHighlight;
        }

        private void lblOperation_Click(object sender, EventArgs e)
        {
            pnlOperation.BringToFront();
        }

        private void lblOperation_MouseHover(object sender, EventArgs e)
        {
            //lblOperation.Font = new Font(lblOperation.Font, FontStyle.Underline | FontStyle.Bold);
            lblOperation.ForeColor = Color.MediumPurple;
        }

        private void lblOperation_MouseLeave(object sender, EventArgs e)
        {
            //lblOperation.Font = new Font(lblOperation.Font, FontStyle.Bold);
            lblOperation.ForeColor = SystemColors.MenuHighlight;
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            pnlReport.BringToFront();
        }
        private void lblReport_MouseHover(object sender, EventArgs e)
        {
            //lblReport.Font = new Font(lblReport.Font, FontStyle.Underline | FontStyle.Bold);
            lblReport.ForeColor = Color.MediumPurple;
        }
        private void lblReport_MouseLeave(object sender, EventArgs e)
        {
            //lblReport.Font = new Font(lblReport.Font, FontStyle.Bold);
            lblReport.ForeColor = SystemColors.MenuHighlight;
        }

        private void lblReport2_Click(object sender, EventArgs e)
        {
            pnlReport2.BringToFront();
        }
        private void lblReport2_MouseHover(object sender, EventArgs e)
        {
            //lblReport.Font = new Font(lblReport.Font, FontStyle.Underline | FontStyle.Bold);
            lblReport2.ForeColor = Color.MediumPurple;
        }
        private void lblReport2_MouseLeave(object sender, EventArgs e)
        {
            //lblReport.Font = new Font(lblReport.Font, FontStyle.Bold);
            lblReport2.ForeColor = SystemColors.MenuHighlight;
        }
        private void lblSizePass_Click(object sender, EventArgs e)
        {
        }

        private void lblSizePass_MouseLeave(object sender, EventArgs e)
        {
            if (lblSizePass.BackColor != SystemColors.ActiveCaption)
            {
                lblSizePass.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private void lblSizeFail_Click(object sender, EventArgs e)
        {
            lblSizePass.BackColor = SystemColors.ButtonHighlight;
            lblRecSizeFail.BackColor = SystemColors.ActiveCaption;
        }

        private void pnlOperation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPDFReport1_Click(object sender, EventArgs e)
        {
            // Export DataGridView data to PDF
            // Define Directory
            //string fileName = @"C:\MyExports\ExportedData.pdf";
            //ExportDataGridViewToPDF(dgvReport1, "ExportedData.pdf");
            // Open SaveFileDialog for the user to choose the file location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "ExportedData.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Export the PDF to the chosen location
                    ExportDataGridViewToPDF_Select_Directory(dgvReport1, saveFileDialog.FileName);
                }
            }
        }

        private void btnPDFReport2_Click(object sender, EventArgs e)
        {
            // Export DataGridView data to PDF
            // Define Directory
            //string fileName = @"C:\MyExports\ExportedData.pdf";
            //ExportDataGridViewToPDF(dgvReport1, "ExportedData.pdf");
            // Open SaveFileDialog for the user to choose the file location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "ExportedData.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Export the PDF to the chosen location
                    ExportDataGridViewToPDF_Select_Directory(dgvReport2, saveFileDialog.FileName);
                }
            }
        }



        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
            try
            {
                // Create a PDF document
                Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
                pdfDoc.Open();

                // Add a title to the PDF
                pdfDoc.Add(new Paragraph("Exported Data from DataGridView"));
                pdfDoc.Add(new Paragraph(" ")); // Add some space

                // Create a PDF table with the same number of columns as the DataGridView
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;

                // Add the headers from the DataGridView to the PDF table
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                // Add the rows from the DataGridView to the PDF table
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }

                // Add the table to the PDF document
                pdfDoc.Add(pdfTable);

                // Close the PDF document
                pdfDoc.Close();

                MessageBox.Show($"PDF exported successfully to {fileName}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataGridViewToPDF_Select_Directory(DataGridView dgv, string filePath)
        {
            try
            {
                // Create a PDF document
                Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();
                MessageBox.Show(filePath);
                // Add a title to the PDF
                pdfDoc.Add(new Paragraph("Exported Data from DataGridView"));
                pdfDoc.Add(new Paragraph(" ")); // Add some space

                // Create a PDF table with the same number of columns as the DataGridView
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;

                // Add the headers from the DataGridView to the PDF table
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                // Add the rows from the DataGridView to the PDF table
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }

                // Add the table to the PDF document
                pdfDoc.Add(pdfTable);

                // Close the PDF document
                pdfDoc.Close();

                MessageBox.Show($"PDF exported successfully to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
