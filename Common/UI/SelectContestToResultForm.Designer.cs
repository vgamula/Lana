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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectContestToResultForm));
            this.listBoxContests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxContests
            // 
            resources.ApplyResources(this.listBoxContests, "listBoxContests");
            this.listBoxContests.FormattingEnabled = true;
            this.listBoxContests.Name = "listBoxContests";
            this.listBoxContests.SelectedIndexChanged += new System.EventHandler(this.listBoxContests_SelectedIndexChanged);
            // 
            // SelectContestToResultForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxContests);
            this.MaximizeBox = false;
            this.Name = "SelectContestToResultForm";
            this.Load += new System.EventHandler(this.SelectContestToResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContests;
    }
}