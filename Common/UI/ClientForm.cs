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
    public partial class ClientForm : Form
    {
        private User _user;
        public ClientForm(User user)
        {
            InitializeComponent();
            this._user = user;
            LoadContests();
        }

        protected void LoadContests()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxContests.Items.Clear();
                foreach (var item in db.UsersContests.Where(t => t.UserId == this._user.Id).ToList())
                {
                    listBoxContests.Items.Add(item.Contest);
                }
            }
        }
        
        private void listBoxContests_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxContests.SelectedItem == null)
            {
                return;
            }

            (new ClientContestForm(this._user, (Contest)listBoxContests.SelectedItem)).ShowDialog();
            


        }
    }
}
