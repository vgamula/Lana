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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            ShowContests();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new AddContestForm()).ShowDialog();
            ShowContests();
        }

        protected void ShowContests()
        {
            using (var db = new DatabaseEntities())
            {
                listBoxContests.Items.Clear();
                foreach (var item in db.Contests)
                {
                    listBoxContests.Items.Add(item);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxContests.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            (new AddContestForm((Contest)listBoxContests.SelectedItem)).ShowDialog();
            ShowContests();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxContests.SelectedItem == null)
            {
                MessageBox.Show("You need to select contest!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete current record?","Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new DatabaseEntities()) 
                {
                    Contest contest = (Contest)listBoxContests.SelectedItem;
                    var item = db.Contests.FirstOrDefault(t => t.Id == contest.Id);
                    if (item != null)
                    {
                        db.Contests.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            ShowContests();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ManageUsersForm()).ShowDialog();
        }

        private void listBoxContests_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxContests.SelectedItem == null)
                return;
            Contest contest = (Contest)listBoxContests.SelectedItem;
            (new ManageContest(contest)).ShowDialog();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
