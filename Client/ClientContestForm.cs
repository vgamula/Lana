using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace Client
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
                    var res = db.Results.FirstOrDefault(t=>t.TaskId == item.Id);
                    if (res != null)
                        page.labelTime.Text = (res.IsPassed == 1 ? res.PassingTime.ToString() : String.Empty);
                    tabPage.Text = tabName.ToString() + (res != null ? (res.IsPassed==1 ? ": PASSED":String.Empty):String.Empty);
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

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ResultsForm(this._contest)).ShowDialog();
        }
    }
}
