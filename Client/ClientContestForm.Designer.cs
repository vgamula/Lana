namespace Client
{
    partial class ClientContestForm
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
            this.tabControlTasks = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlTasks
            // 
            this.tabControlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTasks.Location = new System.Drawing.Point(0, 0);
            this.tabControlTasks.Name = "tabControlTasks";
            this.tabControlTasks.SelectedIndex = 0;
            this.tabControlTasks.Size = new System.Drawing.Size(570, 481);
            this.tabControlTasks.TabIndex = 0;
            this.tabControlTasks.SelectedIndexChanged += new System.EventHandler(this.tabControlTasks_SelectedIndexChanged);
            // 
            // ClientContestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 481);
            this.Controls.Add(this.tabControlTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientContestForm";
            this.Text = "ClientContestForm";
            this.Load += new System.EventHandler(this.ClientContestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTasks;
    }
}