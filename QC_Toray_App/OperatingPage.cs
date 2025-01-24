using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QC_Toray_App
{
    public partial class OperatingPage : Form
    {
        public OperatingPage()
        {
            InitializeComponent();
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

        private void lblOperation_MouseHover(object sender, EventArgs e)
        {
        }

        private void lblOperation_MouseLeave(object sender, EventArgs e)
        {
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
            lblSizeFail.BackColor = SystemColors.ActiveCaption;
        }

        private void pnlOperation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
