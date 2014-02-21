using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class LanguageForm : Form
    {
        private Type _type;
        public LanguageForm(Type type)
        {
            InitializeComponent();
            this._type = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(radioButtonEnglish.Checked?"en-US":"uk-UA");
            Form form = (Form)Activator.CreateInstance(this._type);
            this.Hide();
            form.Show();

        }
    }
}
