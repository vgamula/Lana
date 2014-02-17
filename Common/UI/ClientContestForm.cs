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
                foreach (var item in db.Tasks.Where(t => t.ContestId == this._contest.Id))
                {
                    TabPage tabPage = new TabPage();
                    MyTabPage page = new MyTabPage();
                    page.labelTitle.Text = item.Title;
                    page.labelDescription.Text = item.Description;
                    tabPage.Controls.Add(page);
                    tabPage.Text = item.Title;
                    tabControl1.TabPages.Add(tabPage);
                }
            }
        }

        private void ClientContestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
