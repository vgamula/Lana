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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            ShowUsers();
        }

        protected void ShowUsers()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxUsers.Items.Clear();
                foreach (var item in db.Users)
                {
                    listBoxUsers.Items.Add(item);
                }
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new AddUserForm()).ShowDialog();
            ShowUsers();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            (new AddUserForm((User)listBoxUsers.SelectedItem)).ShowDialog();
            ShowUsers();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete current record?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new DatabaseEntities())
                {
                    User contest = (User)listBoxUsers.SelectedItem;
                    var item = db.Users.FirstOrDefault(t => t.Id == contest.Id);
                    if (item != null)
                    {
                        db.Users.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            ShowUsers();
        }
    }
}
