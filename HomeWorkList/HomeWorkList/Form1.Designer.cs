namespace HomeWorkList
{
    partial class NameListUI
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
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showAllSaveButton = new System.Windows.Forms.Button();
            this.showAllNameListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(179, 36);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.enterNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(349, 86);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAllSaveButton
            // 
            this.showAllSaveButton.Location = new System.Drawing.Point(318, 132);
            this.showAllSaveButton.Name = "showAllSaveButton";
            this.showAllSaveButton.Size = new System.Drawing.Size(106, 23);
            this.showAllSaveButton.TabIndex = 3;
            this.showAllSaveButton.Text = "Show All Name";
            this.showAllSaveButton.UseVisualStyleBackColor = true;
            this.showAllSaveButton.Click += new System.EventHandler(this.showAllSaveButton_Click);
            // 
            // showAllNameListBox
            // 
            this.showAllNameListBox.FormattingEnabled = true;
            this.showAllNameListBox.Location = new System.Drawing.Point(211, 181);
            this.showAllNameListBox.Name = "showAllNameListBox";
            this.showAllNameListBox.Size = new System.Drawing.Size(120, 95);
            this.showAllNameListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Counter";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(61, 221);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(54, 13);
            this.counterLabel.TabIndex = 6;
            this.counterLabel.Text = "Increment";
            // 
            // NameListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 334);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showAllNameListBox);
            this.Controls.Add(this.showAllSaveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NameListUI";
            this.Text = "NameListUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showAllSaveButton;
        private System.Windows.Forms.ListBox showAllNameListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counterLabel;
    }
}

