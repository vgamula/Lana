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
    public partial class AddContestForm : Form
    {
        private DatabaseEntities db = new DatabaseEntities();
        private Contest _contest = null;

        protected void FillFields()
        {
            if (_contest == null)
                return;
            richTextBoxTitle.Text = _contest.Title;
            richTextBoxDescription.Text = _contest.Description;
            dateTimePickerStart.Value = _contest.StartTime;
            dateTimePickerEnd.Value = _contest.EndTime;
        }
        
        public AddContestForm(Contest contest = null)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            _contest = contest;
            FillFields();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            richTextBoxTitle.Text = String.Empty;
            richTextBoxDescription.Text = String.Empty;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var tmp = _contest ?? new Contest();
            tmp.Title = richTextBoxTitle.Text;
            tmp.Description = richTextBoxDescription.Text;
            tmp.StartTime = dateTimePickerStart.Value;
            tmp.EndTime = dateTimePickerEnd.Value;

            if (_contest != null)
            {
                db.Contests.Attach(_contest);
                db.Entry(_contest).CurrentValues.SetValues(tmp);
                db.Entry(_contest).State = EntityState.Modified;
            }
            else
            {
                db.Contests.Add(tmp);
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
