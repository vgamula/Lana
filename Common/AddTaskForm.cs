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
    public partial class AddTaskForm : Form
    {
        public DatabaseEntities db;
        private Contest _contest;
        private Task _task;

        public AddTaskForm(Contest contest, Task task = null)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            this._contest = contest;
            this._task = task;
            if (this._task != null)
            {
                textBoxTitle.Text = this._task.Title;
                richTextBoxDescription.Text = this._task.Description;
                textBoxMark.Text = this._task.Mark.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Task tmp = this._task ?? new Task();
            tmp.ContestId = this._contest.Id;
            tmp.Title = textBoxTitle.Text;
            tmp.Description = richTextBoxDescription.Text;
            tmp.Mark = Convert.ToInt32(textBoxMark.Text);
            if (_task != null)
            {
                db.Tasks.Attach(_task);
                db.Entry(_task).CurrentValues.SetValues(tmp);
                db.Entry(_task).State = EntityState.Modified;
            }
            else
            {
                db.Tasks.Add(tmp);
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
