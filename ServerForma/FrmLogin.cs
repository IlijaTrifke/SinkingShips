using Common.Domain;
using System.Windows.Forms;

namespace ServerForma
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Administrator admin = new Administrator()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };
            admin = Controller.Instance.Login(admin);
            if (admin == null)
            {
                MessageBox.Show("Uneli ste pogresam email ili sifru!");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                Visible = false;
                FrmServer frmServer = new FrmServer(admin);
                frmServer.ShowDialog();
                Visible = true;
            }

        }
    }
}
