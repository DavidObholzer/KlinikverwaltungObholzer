namespace Klinikverwaltung
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlCommunication.createDatabase();
            SqlCommunication.createTables();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SqlCommunication.login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login successful");
            }
        }
    }
}