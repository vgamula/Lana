using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class MyTabPage : UserControl
    {
        User _user;
        Task _task;

        public MyTabPage(User user, Task task)
        {
            InitializeComponent();
            this._user = user;
            this._task = task;
            ShowInformation(this._task);
        }

        protected void ShowInformation(Task t)
        {
            labelTitle.Text = t.Title;
            labelDescription.Text = t.Description;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() != DialogResult.OK)
                return;
            labelFile.Text = od.FileName;
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {
            TabPage page = (TabPage)this.Parent;
            page.Text = String.Format("{0}-{1}", page.Text, "PASSED");
        }
    }
}
