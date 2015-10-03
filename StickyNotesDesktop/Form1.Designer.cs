namespace StickyNotesDesktop
{
    partial class Form1
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
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.SaveNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteText
            // 
            this.NoteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NoteText.Location = new System.Drawing.Point(8, 34);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(269, 216);
            this.NoteText.TabIndex = 0;
            this.NoteText.Text = "";
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(8, 7);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(269, 21);
            this.NameBox.TabIndex = 1;
            // 
            // SaveNote
            // 
            this.SaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNote.Location = new System.Drawing.Point(8, 256);
            this.SaveNote.Name = "SaveNote";
            this.SaveNote.Size = new System.Drawing.Size(269, 24);
            this.SaveNote.TabIndex = 2;
            this.SaveNote.Text = "Save";
            this.SaveNote.UseVisualStyleBackColor = true;
            this.SaveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.SaveNote);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NoteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.Button SaveNote;
    }
}

