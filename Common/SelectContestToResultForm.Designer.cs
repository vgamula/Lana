namespace Common
{
    partial class SelectContestToResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxContests
            // 
            this.listBoxContests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContests.FormattingEnabled = true;
            this.listBoxContests.Location = new System.Drawing.Point(0, 0);
            this.listBoxContests.Name = "listBoxContests";
            this.listBoxContests.Size = new System.Drawing.Size(284, 261);
            this.listBoxContests.TabIndex = 0;
            this.listBoxContests.SelectedIndexChanged += new System.EventHandler(this.listBoxContests_SelectedIndexChanged);
            // 
            // SelectContestToResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxContests);
            this.MaximizeBox = false;
            this.Name = "SelectContestToResultForm";
            this.Text = "Select contest";
            this.Load += new System.EventHandler(this.SelectContestToResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContests;
    }
}