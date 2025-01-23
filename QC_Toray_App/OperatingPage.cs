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
            lblOperation.Text = "Hover Now!";
            //lblOperation.ForeColor = Color.BlueViolet;
        }

        private void lblOperation_MouseLeave(object sender, EventArgs e)
        {
            lblOperation.Text = "Operation";
        }

        private void lblSizePass_Click(object sender, EventArgs e)
        {
            lblSizePass.BackColor = SystemColors.ActiveCaption;
            lblSizeFail.BackColor = SystemColors.ButtonHighlight;
        }

        private void lblSizePass_MouseHover(object sender, EventArgs e)
        {
            //if (lblSizePass.BackColor != SystemColors.ActiveCaption)
            //{
            //    lblSizePass.BackColor = SystemColors.Control;
            //}
            ////lblSizePass.BorderStyle = BorderStyle.Fixed3D;
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

        
    }
}
