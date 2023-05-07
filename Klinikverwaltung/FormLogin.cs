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
                MessageBox.Show("Login successful", "Info",MessageBoxButtons.OK);
                
                FormMainMenu fmm = new FormMainMenu();

                Hide();
                fmm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Benutzername und Passwort stimmen nicht überein", "Info", MessageBoxButtons.OK);
            }
        }

        private void btnTempSkip_Click(object sender, EventArgs e)
        {
            FormMainMenu fmm = new FormMainMenu();

            Hide();
            fmm.ShowDialog();
            Close();
        }
    }
}