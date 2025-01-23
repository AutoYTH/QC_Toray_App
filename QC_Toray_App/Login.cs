namespace QC_Toray_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbLogin.Focus();
            this.ActiveControl = null; // Ensure no control is focused
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperatingPage operatingPage = new OperatingPage();
            operatingPage.ShowDialog();
            this.Close();
        }
    }
}
