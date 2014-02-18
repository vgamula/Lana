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
    public partial class ClientContestForm : Form
    {
        private User _user;
        private Contest _contest;

        public ClientContestForm(User user, Contest contest)
        {
            InitializeComponent();
            this._user = user;
            this._contest = contest;
            MakeTabs();
        }

        public void MakeTabs()
        {
            using (var db = new DatabaseEntities())
            {
                char tabName = 'A';
                foreach (var item in db.Tasks.Where(t => t.ContestId == this._contest.Id))
                {
                    TabPage tabPage = new TabPage();
                    MyTabPage page = new MyTabPage(user: this._user, task: item);
                    tabPage.Controls.Add(page);
                    tabPage.Text = tabName.ToString();
                    tabName++;
                    tabControlTasks.TabPages.Add(tabPage);
                }
            }
        }

        private void ClientContestForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControlTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
