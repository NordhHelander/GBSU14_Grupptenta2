namespace Grupptenta2
{
	partial class EditParticipantListForm
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
			this.personsLbl = new System.Windows.Forms.Label();
			this.participantsLbl = new System.Windows.Forms.Label();
			this.saveParticipantsBtn = new System.Windows.Forms.Button();
			this.addPartBtn = new System.Windows.Forms.Button();
			this.removePartBtn = new System.Windows.Forms.Button();
			this.participantBox = new System.Windows.Forms.ListBox();
			this.personBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// personsLbl
			// 
			this.personsLbl.AutoSize = true;
			this.personsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.personsLbl.Location = new System.Drawing.Point(12, 9);
			this.personsLbl.Name = "personsLbl";
			this.personsLbl.Size = new System.Drawing.Size(123, 18);
			this.personsLbl.TabIndex = 35;
			this.personsLbl.Text = "Valbara kontakter";
			// 
			// participantsLbl
			// 
			this.participantsLbl.AutoSize = true;
			this.participantsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.participantsLbl.Location = new System.Drawing.Point(9, 169);
			this.participantsLbl.Name = "participantsLbl";
			this.participantsLbl.Size = new System.Drawing.Size(89, 18);
			this.participantsLbl.TabIndex = 34;
			this.participantsLbl.Text = "Deltagarlista";
			// 
			// saveParticipantsBtn
			// 
			this.saveParticipantsBtn.Location = new System.Drawing.Point(183, 343);
			this.saveParticipantsBtn.Name = "saveParticipantsBtn";
			this.saveParticipantsBtn.Size = new System.Drawing.Size(100, 23);
			this.saveParticipantsBtn.TabIndex = 14;
			this.saveParticipantsBtn.Text = "Spara ";
			this.saveParticipantsBtn.UseVisualStyleBackColor = true;
			this.saveParticipantsBtn.Click += new System.EventHandler(this.saveParticipantsBtn_Click);
			// 
			// addPartBtn
			// 
			this.addPartBtn.Location = new System.Drawing.Point(183, 30);
			this.addPartBtn.Name = "addPartBtn";
			this.addPartBtn.Size = new System.Drawing.Size(100, 23);
			this.addPartBtn.TabIndex = 14;
			this.addPartBtn.Text = "Lägg till deltagare";
			this.addPartBtn.UseVisualStyleBackColor = true;
			this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
			// 
			// removePartBtn
			// 
			this.removePartBtn.Location = new System.Drawing.Point(183, 190);
			this.removePartBtn.Name = "removePartBtn";
			this.removePartBtn.Size = new System.Drawing.Size(100, 23);
			this.removePartBtn.TabIndex = 33;
			this.removePartBtn.Text = "Ta bort deltagare";
			this.removePartBtn.UseVisualStyleBackColor = true;
			this.removePartBtn.Click += new System.EventHandler(this.removePartBtn_Click);
			// 
			// participantBox
			// 
			this.participantBox.FormattingEnabled = true;
			this.participantBox.Location = new System.Drawing.Point(12, 190);
			this.participantBox.Name = "participantBox";
			this.participantBox.Size = new System.Drawing.Size(165, 121);
			this.participantBox.TabIndex = 11;
			// 
			// personBox
			// 
			this.personBox.FormattingEnabled = true;
			this.personBox.Location = new System.Drawing.Point(12, 30);
			this.personBox.Name = "personBox";
			this.personBox.Size = new System.Drawing.Size(165, 121);
			this.personBox.TabIndex = 3;
			// 
			// AddParticipantForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(304, 378);
			this.Controls.Add(this.saveParticipantsBtn);
			this.Controls.Add(this.participantsLbl);
			this.Controls.Add(this.removePartBtn);
			this.Controls.Add(this.personsLbl);
			this.Controls.Add(this.participantBox);
			this.Controls.Add(this.addPartBtn);
			this.Controls.Add(this.personBox);
			this.Name = "AddParticipantForm";
			this.Text = "AddParticipantForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label personsLbl;
		private System.Windows.Forms.Label participantsLbl;
		private System.Windows.Forms.Button saveParticipantsBtn;
		private System.Windows.Forms.Button addPartBtn;
		private System.Windows.Forms.Button removePartBtn;
		private System.Windows.Forms.ListBox participantBox;
		private System.Windows.Forms.ListBox personBox;
	}
}