using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class LoginForm : Form
    {
        private Form _adminForm;
        private Form _competitorForm;
        private Form _spectator;

        public LoginForm(Form adminForm, Form competitorForm, Form spectator)
        {
            InitializeComponent();
            this._adminForm = adminForm;
            this._competitorForm = competitorForm;
            this._spectator = spectator;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseEntities())
            {
                String username = textBoxUsername.Text;
                String password = Utils.GetMD5Hash(textBoxPassword.Text);

                String message = String.Empty;
                Boolean isGood = true;

                var result = db.Users.FirstOrDefault(t => t.Username == username);

                if (result == null)
                {
                    message = String.Format("There is no user with username {0}!", username);
                    isGood = false;
                }
                else
                {
                    if (result.Password != password)
                    {
                        message = "Password is wrong!";
                        isGood = false;
                    }
                }

                if (!isGood)
                {
                    MessageBox.Show(message);
                    return;
                }
                Form form = null;
                switch (result.Access)
                {
                    case 0: 
                        form = this._adminForm;
                        break;
                    case 1: 
                        form = this._competitorForm;
                        break;
                    default:
                        break;
                }
                if (form != null)
                {
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
