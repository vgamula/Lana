namespace Client
{
    partial class ClientForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.labelText = new System.Windows.Forms.Label();
            this.listBoxContests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelText
            // 
            resources.ApplyResources(this.labelText, "labelText");
            this.labelText.Name = "labelText";
            // 
            // listBoxContests
            // 
            resources.ApplyResources(this.listBoxContests, "listBoxContests");
            this.listBoxContests.FormattingEnabled = true;
            this.listBoxContests.Name = "listBoxContests";
            this.listBoxContests.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContests_MouseDoubleClick);
            // 
            // ClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxContests);
            this.Controls.Add(this.labelText);
            this.Name = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ListBox listBoxContests;
    }
}

