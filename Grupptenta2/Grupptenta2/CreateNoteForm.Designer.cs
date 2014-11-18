namespace Grupptenta2
{
	partial class CreateNoteForm
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
            this.noteBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.isPublicCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.White;
            this.noteBox.Location = new System.Drawing.Point(12, 12);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(239, 161);
            this.noteBox.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(176, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Spara";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // isPublicCheckBox
            // 
            this.isPublicCheckBox.AutoSize = true;
            this.isPublicCheckBox.Location = new System.Drawing.Point(142, 179);
            this.isPublicCheckBox.Name = "isPublicCheckBox";
            this.isPublicCheckBox.Size = new System.Drawing.Size(111, 17);
            this.isPublicCheckBox.TabIndex = 2;
            this.isPublicCheckBox.Text = "Publik anteckning";
            this.isPublicCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(13, 209);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CreateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 244);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.isPublicCheckBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.noteBox);
            this.Name = "CreateNoteForm";
            this.Text = "CreateNote";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox noteBox;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.CheckBox isPublicCheckBox;
        private System.Windows.Forms.Button deleteBtn;
	}
}