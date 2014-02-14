using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class AddUserForm : Form
    {
        private DatabaseEntities db;
        private User _user;

        public AddUserForm(User user = null)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            this._user = user;
            if (this._user != null)
            {
                textBoxUsername.Text = this._user.Username;
                richTextBoxDetails.Text = this._user.Details;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords are not equal!");
                return;
            }
            User tmp = this._user ?? new User();
            tmp.Access = this._user != null ? this._user.Access : 1;
            tmp.Username = textBoxUsername.Text;
            tmp.Password = Utils.GetMD5Hash(textBoxPassword.Text);
            tmp.Details = richTextBoxDetails.Text;
            if (_user != null)
            {
                db.Users.Attach(_user);
                db.Entry(_user).CurrentValues.SetValues(tmp);
                db.Entry(_user).State = EntityState.Modified;
            }
            else
            {
                db.Users.Add(tmp);
            }
            db.SaveChanges();
            this.Close();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
            richTextBoxDetails.Text = String.Empty;
        }
    }
}
