namespace testTree
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            this.loadButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlTreeView.Location = new System.Drawing.Point(12, 12);
            this.xmlTreeView.MinimumSize = new System.Drawing.Size(300, 400);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(300, 400);
            this.xmlTreeView.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(12, 418);
            this.loadButton.MaximumSize = new System.Drawing.Size(125, 40);
            this.loadButton.MinimumSize = new System.Drawing.Size(125, 40);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(125, 40);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load XML File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.controlButton.Location = new System.Drawing.Point(188, 418);
            this.controlButton.MaximumSize = new System.Drawing.Size(125, 40);
            this.controlButton.MinimumSize = new System.Drawing.Size(125, 40);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(125, 40);
            this.controlButton.TabIndex = 2;
            this.controlButton.Text = "Expand/Collapse";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(325, 463);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.xmlTreeView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(343, 510);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView xmlTreeView;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button controlButton;
    }
}

