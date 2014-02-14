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
    public partial class AddTestForm : Form
    {
        private DatabaseEntities db;
        private Task _task;
        private Test _test;

        public AddTestForm(Task task, Test test = null)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            this._task = task;
            this._test = test;
            this.Text = String.Format("{0} '{1}' task.", this.Text, this._task.Title);
            if (this._test != null)
            {
                richTextBoxInputData.Text = this._test.InputData;
                richTextBoxOutputData.Text = this._test.OutputData;
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            richTextBoxInputData.Text = String.Empty;
            richTextBoxOutputData.Text = String.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Test tmp = this._test ?? new Test();
            tmp.TaskId = this._task.Id;
            tmp.InputData = richTextBoxInputData.Text;
            tmp.OutputData = richTextBoxOutputData.Text;
            if (this._test != null)
            {
                db.Tests.Attach(_test);
                db.Entry(_test).CurrentValues.SetValues(tmp);
                db.Entry(_test).State = EntityState.Modified;
            }
            else
            {
                db.Tests.Add(tmp);
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
