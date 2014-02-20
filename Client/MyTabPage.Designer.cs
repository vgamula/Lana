namespace Client
{
    partial class MyTabPage
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxCompilers = new System.Windows.Forms.ComboBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(17, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(49, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "labelTitle";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(221, 13);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(82, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "labelDescription";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(14, 133);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(45, 13);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "labelFile";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(17, 149);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(14, 77);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(84, 13);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Select language";
            // 
            // comboBoxCompilers
            // 
            this.comboBoxCompilers.FormattingEnabled = true;
            this.comboBoxCompilers.Location = new System.Drawing.Point(17, 94);
            this.comboBoxCompilers.Name = "comboBoxCompilers";
            this.comboBoxCompilers.Size = new System.Drawing.Size(120, 21);
            this.comboBoxCompilers.TabIndex = 5;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(17, 178);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(17, 40);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(53, 13);
            this.labelMark.TabIndex = 7;
            this.labelMark.Text = "labelMark";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(17, 216);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "labelTime";
            // 
            // MyTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.comboBoxCompilers);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Name = "MyTabPage";
            this.Size = new System.Drawing.Size(416, 242);
            this.Load += new System.EventHandler(this.MyTabPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxCompilers;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelMark;
        public System.Windows.Forms.Label labelTime;
    }
}
