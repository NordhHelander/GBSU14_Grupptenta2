namespace Grupptenta2
{
	partial class CreateEventForm
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
			this.nameBox = new System.Windows.Forms.TextBox();
			this.noteList = new System.Windows.Forms.ListBox();
			this.nameLbl = new System.Windows.Forms.Label();
			this.noteBox = new System.Windows.Forms.TextBox();
			this.noteLbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.saveNoteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(70, 4);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(153, 20);
			this.nameBox.TabIndex = 0;
			// 
			// noteList
			// 
			this.noteList.FormattingEnabled = true;
			this.noteList.Location = new System.Drawing.Point(274, 31);
			this.noteList.Name = "noteList";
			this.noteList.Size = new System.Drawing.Size(153, 160);
			this.noteList.TabIndex = 1;
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(3, 10);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(27, 13);
			this.nameLbl.TabIndex = 2;
			this.nameLbl.Text = "Titel";
			// 
			// noteBox
			// 
			this.noteBox.Location = new System.Drawing.Point(70, 30);
			this.noteBox.Multiline = true;
			this.noteBox.Name = "noteBox";
			this.noteBox.Size = new System.Drawing.Size(153, 161);
			this.noteBox.TabIndex = 3;
			// 
			// noteLbl
			// 
			this.noteLbl.AutoSize = true;
			this.noteLbl.Location = new System.Drawing.Point(3, 38);
			this.noteLbl.Name = "noteLbl";
			this.noteLbl.Size = new System.Drawing.Size(61, 13);
			this.noteLbl.TabIndex = 4;
			this.noteLbl.Text = "Anteckning";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(271, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 18);
			this.label3.TabIndex = 32;
			this.label3.Text = "Anteckningar";
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(319, 197);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(108, 23);
			this.saveBtn.TabIndex = 33;
			this.saveBtn.Text = "Spara händelse";
			this.saveBtn.UseVisualStyleBackColor = true;
			// 
			// saveNoteBtn
			// 
			this.saveNoteBtn.Location = new System.Drawing.Point(114, 197);
			this.saveNoteBtn.Name = "saveNoteBtn";
			this.saveNoteBtn.Size = new System.Drawing.Size(109, 23);
			this.saveNoteBtn.TabIndex = 34;
			this.saveNoteBtn.Text = "Spara anteckning";
			this.saveNoteBtn.UseVisualStyleBackColor = true;
			// 
			// CreateEventForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(449, 347);
			this.Controls.Add(this.saveNoteBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.noteLbl);
			this.Controls.Add(this.noteBox);
			this.Controls.Add(this.nameLbl);
			this.Controls.Add(this.noteList);
			this.Controls.Add(this.nameBox);
			this.Name = "CreateEventForm";
			this.Text = "CreateEvent";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.ListBox noteList;
		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.TextBox noteBox;
		private System.Windows.Forms.Label noteLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button saveNoteBtn;
	}
}