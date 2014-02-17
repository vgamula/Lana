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
        public MyTabPage(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() != DialogResult.OK)
                return;
            labelFile.Text = od.FileName;
        }
    }
}
