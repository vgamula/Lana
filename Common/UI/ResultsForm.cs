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
    public partial class ResultsForm : Form
    {
        private Contest _contest;

        public ResultsForm(Contest contest)
        {
            InitializeComponent();
            this._contest = contest;
            ShowResults(this._contest);
            this.Text = String.Format("Results by {0}", this._contest.Title);
        }

        private void ShowResults(Contest contest)
        {
            using (var db = new DatabaseEntities())
            {
                var tasks = db.Tasks.Where(t => t.ContestId == this._contest.Id);
                if (tasks == null)
                {
                    MessageBox.Show("There are no result by this contest.");
                    return;
                }
                var Tasks = tasks.Select(t => t.Id).ToList();
                var tests = db.Tests.Where(t => Tasks.Contains(t.TaskId)).Select(t=>t.Id).ToList();

                var results = db.Results.Where(t => tests.Contains(t.TaskId)).ToList();

                
                foreach (var item in results)
                {
                    
                }


            }
        }


        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
