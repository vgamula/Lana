namespace Common
{
    partial class AddTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxInputData = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutputData = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output data:";
            // 
            // richTextBoxInputData
            // 
            this.richTextBoxInputData.Location = new System.Drawing.Point(85, 10);
            this.richTextBoxInputData.Name = "richTextBoxInputData";
            this.richTextBoxInputData.Size = new System.Drawing.Size(252, 76);
            this.richTextBoxInputData.TabIndex = 1;
            this.richTextBoxInputData.Text = "";
            // 
            // richTextBoxOutputData
            // 
            this.richTextBoxOutputData.Location = new System.Drawing.Point(85, 93);
            this.richTextBoxOutputData.Name = "richTextBoxOutputData";
            this.richTextBoxOutputData.Size = new System.Drawing.Size(252, 76);
            this.richTextBoxOutputData.TabIndex = 1;
            this.richTextBoxOutputData.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(262, 175);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(12, 175);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFields.TabIndex = 3;
            this.buttonClearFields.Text = "Clear fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 207);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxOutputData);
            this.Controls.Add(this.richTextBoxInputData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTestForm";
            this.Text = "Add test to";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxInputData;
        private System.Windows.Forms.RichTextBox richTextBoxOutputData;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClearFields;
    }
}