﻿using System;
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
            ShowUsers();
            labelStartTime.Text = this._contest.StartTime.ToString();
            labelEndTime.Text = this._contest.EndTime.ToString();
            labelTitle.Text = this._contest.Title;
        }

        private void ShowUsers()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxUsersInCompetition.Items.Clear();
                foreach (var item in db.UsersContests.Where(t=>t.ContestId == this._contest.Id).ToList())
                {
                    listBoxUsersInCompetition.Items.Add(item.User);
                }
                listBoxUsers.Items.Clear();
                foreach (var item in db.Users.Where(t=>t.UsersContests.Count==0).ToList())
                {
                    listBoxUsers.Items.Add(item);
                }
            }
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
                var result = db.Tests.Where(t => t.TaskId == CurrentTask.Id);
                if (result != null)
                foreach (var item in result.ToList())
                {
                    listBoxTests.Items.Add(item);
                }
            }
        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTests.SelectedItem == null)
                return;
            Test test = (Test)listBoxTests.SelectedItem;
            richTextBoxInputData.Text = test.InputData;
            richTextBoxOutputData.Text = test.OutputData;
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTests();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null)
                return;
            UsersContest uc = new UsersContest();
            uc.UserId = ((User)listBoxUsers.SelectedItem).Id;
            uc.ContestId = this._contest.Id;
            using (var db = new DatabaseEntities())
            {
                db.UsersContests.Add(uc);
                db.SaveChanges();
            }
            ShowUsers();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsersInCompetition.SelectedItem == null)
                return;
            User user = (User)listBoxUsersInCompetition.SelectedItem;
            using (var db = new DatabaseEntities())
            {
                UsersContest uc = db.UsersContests.FirstOrDefault(t => t.ContestId == this._contest.Id && t.UserId == user.Id);
                if (uc != null)
                {
                    db.UsersContests.Remove(uc);
                    db.SaveChanges();
                }
                
            }
            ShowUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ResultsForm(this._contest)).ShowDialog();
        }

    }
}
