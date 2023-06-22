namespace Klinikverwaltung
{
    public partial class FormLogin : Form
    {
        bool userExists = false;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlCommunication.createDatabase();
            SqlCommunication.createTables();
            userExists = SqlCommunication.checkForUser();

            if (!userExists)
            {
                btnRegister.Visible = true;
                btnRegister.Enabled = true;
                lblInfo.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SqlCommunication.login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login successful", "Info",MessageBoxButtons.OK);
                
                FormMainMenu fmm = new FormMainMenu(txtUsername.Text);

                Hide();
                fmm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Benutzername und Passwort stimmen nicht überein", "Info", MessageBoxButtons.OK);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormProfile fp = new FormProfile(true);

            Hide();
            fp.ShowDialog();
            Close();

           if (SqlCommunication.checkForUser())
            {
                FormMainMenu fmm = new FormMainMenu(txtUsername.Text);

                Hide();
                fmm.ShowDialog();
                Close();
            }
        }
    }
}