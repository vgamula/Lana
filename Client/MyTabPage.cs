using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using System.Reflection;
using System.IO;
using Thread = System.Threading.Thread;

namespace Client
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
            //compilers
            var compilersList = Assembly.
                GetExecutingAssembly().
                GetTypes().
                ToList().
                Where(t => t.Namespace == "Client" &&
                    t.Name.Contains("Compiler") &&
                    t.Name != "BaseCompiler" &&
                    t.Name != "CompilersFactory").
                ToList();
            comboBoxCompilers.Items.Clear();
            foreach (var item in compilersList)
            {
                comboBoxCompilers.Items.Add(item.Name.Replace("Compiler", String.Empty));
            }
        }

        protected void ShowInformation(Task t)
        {
            labelTitle.Text = String.Format("Title: {0}", t.Title);
            labelDescription.Text = String.Format("Description: {0}", t.Description);
            labelMark.Text = String.Format("Mark: {0}", t.Mark.ToString());
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
            BaseCompiler compiler = CompilersFactory.GetCompiler(comboBoxCompilers.Text);
            String destination = String.Format("../../Files/{0}/{1}/{2}/", this._task.ContestId.ToString(), this._user.Id, this._task.Id);

            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }
            String tempName = destination + "main.exe";
            if (File.Exists(tempName))
            {
                File.Delete(tempName);
            }
            if (compiler.Compile(labelFile.Text, destination))
            {
                Thread thread = new Thread(()=>{
                    bool passed = Utils.MakeTests(tempName, this._user, this._task);
                    if (passed)
                    {
                        MessageBox.Show("Tests are passed!");
                    }
                    else
                    {
                        MessageBox.Show("Tests are not passed! Write code better!");
                    }
                });
                thread.Start();
            } else {
                MessageBox.Show("Compiling error!");
            }
        }



        private void MyTabPage_Load(object sender, EventArgs e)
        {

        }
    }
}
