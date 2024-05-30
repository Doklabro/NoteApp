namespace NoteAppUI
{
    partial class AddEditNoteForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modified:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Text:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(113, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(267, 26);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(6, 209);
            this.TextTextBox.Multiline = true;
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(782, 200);
            this.TextTextBox.TabIndex = 6;
            this.TextTextBox.TextChanged += new System.EventHandler(this.TextTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(113, 57);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(163, 28);
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(113, 139);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerCreated.TabIndex = 8;
            this.dateTimePickerCreated.ValueChanged += new System.EventHandler(this.dateTimePickerCreated_ValueChanged);
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Location = new System.Drawing.Point(552, 132);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerModified.TabIndex = 9;
            this.dateTimePickerModified.ValueChanged += new System.EventHandler(this.dateTimePickerModified_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(33, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 39);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.TextChanged += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(713, 415);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 39);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dateTimePickerModified);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditNoteForm";
            this.Text = "EditNoteForm";
            this.Load += new System.EventHandler(this.AddEditNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}