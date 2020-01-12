using System;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = TB_username.Text;
            password = TB_password.Text;

            if (User.Login(username, password))
            {
                Globals._Login = true;

                // Close login form
                this.Dispose(false);

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
    }
}
Static void Main()
{
    Application.SetCompatibleTextRenderingDefault(false);
    Application.EnableVisualStyles();
    DialogResult result;
    using (var loginForm = new LoginForm())
        result = loginForm.ShowDialog();
    if (result == DialogResult.OK)
    {
        // login was successful
        //nic nic nic_methodA()
        //methodB()
        Application.Run(new Mainform());
    }
}