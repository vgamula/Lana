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
    public partial class ManageContest : Form
    {
        private Contest _contest;

        public Task CurrentTask
        {
            get
            {
                return (Task)listBoxTasks.SelectedItem;
            }
        }


        public ManageContest(Contest contest)
        {
            InitializeComponent();
            this._contest = contest;
            this.Text = String.Format("{0}: {1}", this.Text, contest.Title);
            ShowTasks();
        }

        private void ManageContest_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            (new AddTaskForm(this._contest)).ShowDialog();
            ShowTasks();
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("You need to select test!");
                return;
            }
            (new AddTaskForm(this._contest, (Task) listBoxTasks.SelectedItem)).ShowDialog();
            ShowTasks();
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete current record?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new DatabaseEntities())
                {
                    Task task = (Task)listBoxTasks.SelectedItem;
                    var item = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                    if (item != null)
                    {
                        db.Tasks.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            ShowTasks();
        }

        private void ShowTasks()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxTasks.Items.Clear();
                foreach (var item in db.Tasks.Where(t => t.ContestId == this._contest.Id).ToList())
                {
                    listBoxTasks.Items.Add(item);
                }
                
            }
        }

        private void ClearFields()
        {
            richTextBoxInputData.Text = String.Empty;
            richTextBoxOutputData.Text = String.Empty;
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            (new AddTestForm(CurrentTask)).ShowDialog();
            ShowTests();
        }

        private void buttonEditTest_Click(object sender, EventArgs e)
        {
            if (listBoxTests.SelectedItem == null)
            {
                MessageBox.Show("You need to select test!");
                return;
            }
            (new AddTestForm(CurrentTask, (Test)(listBoxTests.SelectedItem))).ShowDialog();
            ShowTests();
        }

        private void buttonRemoveTest_Click(object sender, EventArgs e)
        {
            if (listBoxTests.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete current record?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new DatabaseEntities())
                {
                    Test test = (Test)listBoxTests.SelectedItem;
                    var item = db.Tests.FirstOrDefault(t => t.Id == test.Id);
                    if (item != null)
                    {
                        db.Tests.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            ShowTests();
        }

        private void ShowTests()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxTests.Items.Clear();
                foreach (var item in db.Tests.Where(t => t.TaskId == CurrentTask.Id).ToList())
                {
                    listBoxTests.Items.Add(item);
                }
            }
        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test test = (Test)listBoxTests.SelectedItem;
            richTextBoxInputData.Text = test.InputData;
            richTextBoxOutputData.Text = test.OutputData;
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTests();
        }

    }
}
