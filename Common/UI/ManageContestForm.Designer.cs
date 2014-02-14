namespace Common
{
    partial class ManageContest
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
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.groupBoxTests = new System.Windows.Forms.GroupBox();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.panelTests = new System.Windows.Forms.Panel();
            this.buttonRemoveTest = new System.Windows.Forms.Button();
            this.buttonEditTest = new System.Windows.Forms.Button();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxInputData = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxOutputData = new System.Windows.Forms.RichTextBox();
            this.groupBoxTasks.SuspendLayout();
            this.groupBoxTests.SuspendLayout();
            this.panelTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Controls.Add(this.groupBoxTests);
            this.groupBoxTasks.Controls.Add(this.buttonRemoveTask);
            this.groupBoxTasks.Controls.Add(this.buttonEditTask);
            this.groupBoxTasks.Controls.Add(this.buttonAddTask);
            this.groupBoxTasks.Controls.Add(this.listBoxTasks);
            this.groupBoxTasks.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Size = new System.Drawing.Size(538, 267);
            this.groupBoxTasks.TabIndex = 0;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Tasks:";
            // 
            // groupBoxTests
            // 
            this.groupBoxTests.Controls.Add(this.panelTests);
            this.groupBoxTests.Location = new System.Drawing.Point(165, 8);
            this.groupBoxTests.Name = "groupBoxTests";
            this.groupBoxTests.Size = new System.Drawing.Size(367, 251);
            this.groupBoxTests.TabIndex = 7;
            this.groupBoxTests.TabStop = false;
            this.groupBoxTests.Text = "Tests:";
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Location = new System.Drawing.Point(6, 226);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(153, 23);
            this.buttonRemoveTask.TabIndex = 4;
            this.buttonRemoveTask.Text = "Remove";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(6, 197);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(153, 23);
            this.buttonEditTask.TabIndex = 3;
            this.buttonEditTask.Text = "Edit";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(6, 168);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(153, 23);
            this.buttonAddTask.TabIndex = 2;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(6, 14);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(153, 147);
            this.listBoxTasks.TabIndex = 1;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // panelTests
            // 
            this.panelTests.Controls.Add(this.richTextBoxOutputData);
            this.panelTests.Controls.Add(this.label2);
            this.panelTests.Controls.Add(this.richTextBoxInputData);
            this.panelTests.Controls.Add(this.label1);
            this.panelTests.Controls.Add(this.buttonRemoveTest);
            this.panelTests.Controls.Add(this.buttonEditTest);
            this.panelTests.Controls.Add(this.buttonAddTest);
            this.panelTests.Controls.Add(this.listBoxTests);
            this.panelTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTests.Location = new System.Drawing.Point(3, 16);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(361, 232);
            this.panelTests.TabIndex = 0;
            // 
            // buttonRemoveTest
            // 
            this.buttonRemoveTest.Location = new System.Drawing.Point(3, 202);
            this.buttonRemoveTest.Name = "buttonRemoveTest";
            this.buttonRemoveTest.Size = new System.Drawing.Size(163, 23);
            this.buttonRemoveTest.TabIndex = 12;
            this.buttonRemoveTest.Text = "Remove test";
            this.buttonRemoveTest.UseVisualStyleBackColor = true;
            this.buttonRemoveTest.Click += new System.EventHandler(this.buttonRemoveTest_Click);
            // 
            // buttonEditTest
            // 
            this.buttonEditTest.Location = new System.Drawing.Point(3, 173);
            this.buttonEditTest.Name = "buttonEditTest";
            this.buttonEditTest.Size = new System.Drawing.Size(163, 23);
            this.buttonEditTest.TabIndex = 11;
            this.buttonEditTest.Text = "Edit test";
            this.buttonEditTest.UseVisualStyleBackColor = true;
            this.buttonEditTest.Click += new System.EventHandler(this.buttonEditTest_Click);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(3, 144);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(163, 23);
            this.buttonAddTest.TabIndex = 10;
            this.buttonAddTest.Text = "Add test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // listBoxTests
            // 
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(3, 3);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(163, 134);
            this.listBoxTests.TabIndex = 9;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input data:";
            // 
            // richTextBoxInputData
            // 
            this.richTextBoxInputData.Location = new System.Drawing.Point(249, 4);
            this.richTextBoxInputData.Name = "richTextBoxInputData";
            this.richTextBoxInputData.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxInputData.TabIndex = 14;
            this.richTextBoxInputData.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Output data:";
            // 
            // richTextBoxOutputData
            // 
            this.richTextBoxOutputData.Location = new System.Drawing.Point(249, 106);
            this.richTextBoxOutputData.Name = "richTextBoxOutputData";
            this.richTextBoxOutputData.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxOutputData.TabIndex = 14;
            this.richTextBoxOutputData.Text = "";
            // 
            // ManageContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 438);
            this.Controls.Add(this.groupBoxTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageContest";
            this.Text = "Manage contest";
            this.Load += new System.EventHandler(this.ManageContest_Load);
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTests.ResumeLayout(false);
            this.panelTests.ResumeLayout(false);
            this.panelTests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.GroupBox groupBoxTests;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.RichTextBox richTextBoxOutputData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveTest;
        private System.Windows.Forms.Button buttonEditTest;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.ListBox listBoxTests;
    }
}