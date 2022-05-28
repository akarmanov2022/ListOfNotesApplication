using ListOfNotesApplication.Properties;

namespace ListOfNotesApplication.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.SelectedNoteGroupBox = new System.Windows.Forms.GroupBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.DeleteFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NotePictureBox = new System.Windows.Forms.PictureBox();
            this.ExceptionNameLabel = new System.Windows.Forms.Label();
            this.MultiLineTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectedNoteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(12, 12);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(267, 576);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = global::ListOfNotesApplication.Resources.note_add_24x24_uncolor;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 599);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(40, 40);
            this.AddNoteButton.TabIndex = 19;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            this.AddNoteButton.MouseEnter += new System.EventHandler(this.AddNoteButton_MouseEnter);
            this.AddNoteButton.MouseLeave += new System.EventHandler(this.AddNoteButton_MouseLeave);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.Enabled = false;
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = global::ListOfNotesApplication.Resources.note_edit_24x24_uncolor;
            this.EditNoteButton.Location = new System.Drawing.Point(58, 599);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(40, 40);
            this.EditNoteButton.TabIndex = 20;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            this.EditNoteButton.MouseEnter += new System.EventHandler(this.EditNoteButton_MouseEnter);
            this.EditNoteButton.MouseLeave += new System.EventHandler(this.EditNoteButton_MouseLeave);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.Enabled = false;
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = global::ListOfNotesApplication.Resources.note_remove_24x24_uncolor;
            this.RemoveNoteButton.Location = new System.Drawing.Point(104, 599);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(40, 40);
            this.RemoveNoteButton.TabIndex = 21;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            this.RemoveNoteButton.MouseEnter += new System.EventHandler(this.RemoveNoteButton_MouseEnter);
            this.RemoveNoteButton.MouseLeave += new System.EventHandler(this.RemoveNoteButton_MouseLeave);
            // 
            // SelectedNoteGroupBox
            // 
            this.SelectedNoteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedNoteGroupBox.Controls.Add(this.ImageLabel);
            this.SelectedNoteGroupBox.Controls.Add(this.DeleteFileButton);
            this.SelectedNoteGroupBox.Controls.Add(this.OpenFileButton);
            this.SelectedNoteGroupBox.Controls.Add(this.NotePictureBox);
            this.SelectedNoteGroupBox.Controls.Add(this.ExceptionNameLabel);
            this.SelectedNoteGroupBox.Controls.Add(this.MultiLineTextBox);
            this.SelectedNoteGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedNoteGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedNoteGroupBox.Controls.Add(this.TextLabel);
            this.SelectedNoteGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedNoteGroupBox.Controls.Add(this.NameLabel);
            this.SelectedNoteGroupBox.Location = new System.Drawing.Point(285, 52);
            this.SelectedNoteGroupBox.Name = "SelectedNoteGroupBox";
            this.SelectedNoteGroupBox.Size = new System.Drawing.Size(785, 302);
            this.SelectedNoteGroupBox.TabIndex = 22;
            this.SelectedNoteGroupBox.TabStop = false;
            this.SelectedNoteGroupBox.Text = "Selected Note";
            // 
            // ImageLabel
            // 
            this.ImageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLabel.Location = new System.Drawing.Point(520, 29);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(42, 40);
            this.ImageLabel.TabIndex = 10;
            this.ImageLabel.Text = "Image:";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFileButton.Enabled = false;
            this.DeleteFileButton.Location = new System.Drawing.Point(703, 38);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(76, 23);
            this.DeleteFileButton.TabIndex = 9;
            this.DeleteFileButton.Text = "Delete";
            this.DeleteFileButton.UseVisualStyleBackColor = true;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.Enabled = false;
            this.OpenFileButton.Location = new System.Drawing.Point(621, 38);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(76, 23);
            this.OpenFileButton.TabIndex = 8;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NotePictureBox
            // 
            this.NotePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NotePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotePictureBox.Location = new System.Drawing.Point(520, 72);
            this.NotePictureBox.Name = "NotePictureBox";
            this.NotePictureBox.Size = new System.Drawing.Size(259, 224);
            this.NotePictureBox.TabIndex = 7;
            this.NotePictureBox.TabStop = false;
            // 
            // ExceptionNameLabel
            // 
            this.ExceptionNameLabel.Location = new System.Drawing.Point(112, 63);
            this.ExceptionNameLabel.Name = "ExceptionNameLabel";
            this.ExceptionNameLabel.Size = new System.Drawing.Size(385, 14);
            this.ExceptionNameLabel.TabIndex = 6;
            this.ExceptionNameLabel.Visible = false;
            // 
            // MultiLineTextBox
            // 
            this.MultiLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiLineTextBox.Location = new System.Drawing.Point(79, 120);
            this.MultiLineTextBox.Multiline = true;
            this.MultiLineTextBox.Name = "MultiLineTextBox";
            this.MultiLineTextBox.Size = new System.Drawing.Size(418, 176);
            this.MultiLineTextBox.TabIndex = 5;
            this.MultiLineTextBox.TextChanged += new System.EventHandler(this.MultiLineTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.CategoryComboBox.Location = new System.Drawing.Point(79, 80);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(210, 21);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(79, 40);
            this.NameTextBox.MaxLength = 100;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(418, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // TextLabel
            // 
            this.TextLabel.Location = new System.Drawing.Point(6, 109);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(67, 40);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Text:";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Location = new System.Drawing.Point(6, 69);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(67, 40);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(6, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(67, 40);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(291, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(67, 23);
            this.SearchLabel.TabIndex = 23;
            this.SearchLabel.Text = "Search:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(364, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(418, 20);
            this.SearchTextBox.TabIndex = 24;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 651);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SelectedNoteGroupBox);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.NotesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "List of Notes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SelectedNoteGroupBox.ResumeLayout(false);
            this.SelectedNoteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ImageLabel;

        private System.Windows.Forms.Button DeleteFileButton;

        private System.Windows.Forms.Button OpenFileButton;

        private System.Windows.Forms.TextBox SearchTextBox;

        private System.Windows.Forms.Label SearchLabel;

        private System.Windows.Forms.PictureBox NotePictureBox;

        private System.Windows.Forms.Label ExceptionNameLabel;

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox MultiLineTextBox;

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TextLabel;

        private System.Windows.Forms.GroupBox SelectedNoteGroupBox;
        private System.Windows.Forms.Label NameLabel;

        private System.Windows.Forms.Button RemoveNoteButton;

        private System.Windows.Forms.Button EditNoteButton;

        private System.Windows.Forms.Button AddNoteButton;

        private System.Windows.Forms.ListBox NotesListBox;

        #endregion
    }
}