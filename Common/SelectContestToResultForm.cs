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
    public partial class SelectContestToResultForm : Form
    {
        public SelectContestToResultForm()
        {
            InitializeComponent();

            using (var db = new DatabaseEntities())
            {
                foreach (var item in db.Contests)
                {
                    listBoxContests.Items.Add(item);
                }
            }

        }

        private void SelectContestToResultForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxContests_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contest = listBoxContests.SelectedItem as Contest;
            if (contest == null)
                return;
            ResultsForm form = new ResultsForm(contest);
            form.ShowDialog();
        }
    }
}
