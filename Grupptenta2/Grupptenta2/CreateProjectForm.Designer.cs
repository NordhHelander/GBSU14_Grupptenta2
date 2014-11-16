namespace Grupptenta2
{
    partial class CreateProjectForm
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
			this.personBox = new System.Windows.Forms.ListBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.projectDescLbl = new System.Windows.Forms.Label();
			this.projectCompanyLbl = new System.Windows.Forms.Label();
			this.projectNameBox = new System.Windows.Forms.TextBox();
			this.projectDescBox = new System.Windows.Forms.TextBox();
			this.companyBox = new System.Windows.Forms.ComboBox();
			this.namnLbl = new System.Windows.Forms.Label();
			this.participantBox = new System.Windows.Forms.ListBox();
			this.addPartBtn = new System.Windows.Forms.Button();
			this.removePartBtn = new System.Windows.Forms.Button();
			this.createProjectContainer = new System.Windows.Forms.SplitContainer();
			this.personsLbl = new System.Windows.Forms.Label();
			this.participantsLbl = new System.Windows.Forms.Label();
			this.saveParticipantsBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.createProjectContainer)).BeginInit();
			this.createProjectContainer.Panel1.SuspendLayout();
			this.createProjectContainer.Panel2.SuspendLayout();
			this.createProjectContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// personBox
			// 
			this.personBox.FormattingEnabled = true;
			this.personBox.Location = new System.Drawing.Point(3, 32);
			this.personBox.Name = "personBox";
			this.personBox.Size = new System.Drawing.Size(165, 121);
			this.personBox.TabIndex = 3;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(105, 314);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(100, 23);
			this.saveBtn.TabIndex = 11;
			this.saveBtn.Text = "Spara projekt";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// projectDescLbl
			// 
			this.projectDescLbl.AutoSize = true;
			this.projectDescLbl.Location = new System.Drawing.Point(3, 65);
			this.projectDescLbl.Name = "projectDescLbl";
			this.projectDescLbl.Size = new System.Drawing.Size(62, 13);
			this.projectDescLbl.TabIndex = 10;
			this.projectDescLbl.Text = "Beskrivning";
			// 
			// projectCompanyLbl
			// 
			this.projectCompanyLbl.AutoSize = true;
			this.projectCompanyLbl.Location = new System.Drawing.Point(3, 38);
			this.projectCompanyLbl.Name = "projectCompanyLbl";
			this.projectCompanyLbl.Size = new System.Drawing.Size(43, 13);
			this.projectCompanyLbl.TabIndex = 9;
			this.projectCompanyLbl.Text = "Företag";
			// 
			// projectNameBox
			// 
			this.projectNameBox.BackColor = System.Drawing.Color.White;
			this.projectNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.projectNameBox.Location = new System.Drawing.Point(75, 9);
			this.projectNameBox.Name = "projectNameBox";
			this.projectNameBox.Size = new System.Drawing.Size(130, 20);
			this.projectNameBox.TabIndex = 4;
			// 
			// projectDescBox
			// 
			this.projectDescBox.BackColor = System.Drawing.Color.White;
			this.projectDescBox.Location = new System.Drawing.Point(75, 62);
			this.projectDescBox.Multiline = true;
			this.projectDescBox.Name = "projectDescBox";
			this.projectDescBox.Size = new System.Drawing.Size(130, 105);
			this.projectDescBox.TabIndex = 7;
			// 
			// companyBox
			// 
			this.companyBox.FormattingEnabled = true;
			this.companyBox.Location = new System.Drawing.Point(75, 35);
			this.companyBox.Name = "companyBox";
			this.companyBox.Size = new System.Drawing.Size(130, 21);
			this.companyBox.TabIndex = 12;
			// 
			// namnLbl
			// 
			this.namnLbl.AutoSize = true;
			this.namnLbl.Location = new System.Drawing.Point(3, 12);
			this.namnLbl.Name = "namnLbl";
			this.namnLbl.Size = new System.Drawing.Size(66, 13);
			this.namnLbl.TabIndex = 13;
			this.namnLbl.Text = "Projektnamn";
			this.namnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// participantBox
			// 
			this.participantBox.FormattingEnabled = true;
			this.participantBox.Location = new System.Drawing.Point(3, 185);
			this.participantBox.Name = "participantBox";
			this.participantBox.Size = new System.Drawing.Size(165, 121);
			this.participantBox.TabIndex = 11;
			// 
			// addPartBtn
			// 
			this.addPartBtn.Location = new System.Drawing.Point(171, 32);
			this.addPartBtn.Name = "addPartBtn";
			this.addPartBtn.Size = new System.Drawing.Size(100, 23);
			this.addPartBtn.TabIndex = 14;
			this.addPartBtn.Text = "Lägg till deltagare";
			this.addPartBtn.UseVisualStyleBackColor = true;
			this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
			// 
			// removePartBtn
			// 
			this.removePartBtn.Location = new System.Drawing.Point(171, 185);
			this.removePartBtn.Name = "removePartBtn";
			this.removePartBtn.Size = new System.Drawing.Size(100, 23);
			this.removePartBtn.TabIndex = 33;
			this.removePartBtn.Text = "Ta bort deltagare";
			this.removePartBtn.UseVisualStyleBackColor = true;
			this.removePartBtn.Click += new System.EventHandler(this.removePartBtn_Click);
			// 
			// createProjectContainer
			// 
			this.createProjectContainer.Location = new System.Drawing.Point(12, 12);
			this.createProjectContainer.Name = "createProjectContainer";
			// 
			// createProjectContainer.Panel1
			// 
			this.createProjectContainer.Panel1.Controls.Add(this.saveBtn);
			this.createProjectContainer.Panel1.Controls.Add(this.companyBox);
			this.createProjectContainer.Panel1.Controls.Add(this.projectDescLbl);
			this.createProjectContainer.Panel1.Controls.Add(this.namnLbl);
			this.createProjectContainer.Panel1.Controls.Add(this.projectDescBox);
			this.createProjectContainer.Panel1.Controls.Add(this.projectCompanyLbl);
			this.createProjectContainer.Panel1.Controls.Add(this.projectNameBox);
			// 
			// createProjectContainer.Panel2
			// 
			this.createProjectContainer.Panel2.Controls.Add(this.personsLbl);
			this.createProjectContainer.Panel2.Controls.Add(this.participantsLbl);
			this.createProjectContainer.Panel2.Controls.Add(this.saveParticipantsBtn);
			this.createProjectContainer.Panel2.Controls.Add(this.addPartBtn);
			this.createProjectContainer.Panel2.Controls.Add(this.removePartBtn);
			this.createProjectContainer.Panel2.Controls.Add(this.participantBox);
			this.createProjectContainer.Panel2.Controls.Add(this.personBox);
			this.createProjectContainer.Size = new System.Drawing.Size(490, 340);
			this.createProjectContainer.SplitterDistance = 209;
			this.createProjectContainer.TabIndex = 34;
			// 
			// personsLbl
			// 
			this.personsLbl.AutoSize = true;
			this.personsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.personsLbl.Location = new System.Drawing.Point(3, 7);
			this.personsLbl.Name = "personsLbl";
			this.personsLbl.Size = new System.Drawing.Size(123, 18);
			this.personsLbl.TabIndex = 35;
			this.personsLbl.Text = "Valbara kontakter";
			// 
			// participantsLbl
			// 
			this.participantsLbl.AutoSize = true;
			this.participantsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.participantsLbl.Location = new System.Drawing.Point(3, 164);
			this.participantsLbl.Name = "participantsLbl";
			this.participantsLbl.Size = new System.Drawing.Size(89, 18);
			this.participantsLbl.TabIndex = 34;
			this.participantsLbl.Text = "Deltagarlista";
			// 
			// saveParticipantsBtn
			// 
			this.saveParticipantsBtn.Location = new System.Drawing.Point(171, 314);
			this.saveParticipantsBtn.Name = "saveParticipantsBtn";
			this.saveParticipantsBtn.Size = new System.Drawing.Size(100, 23);
			this.saveParticipantsBtn.TabIndex = 14;
			this.saveParticipantsBtn.Text = "Spara deltagare";
			this.saveParticipantsBtn.UseVisualStyleBackColor = true;
			this.saveParticipantsBtn.Click += new System.EventHandler(this.saveParticipantsBtn_Click);
			// 
			// CreateProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(514, 397);
			this.Controls.Add(this.createProjectContainer);
			this.Name = "CreateProjectForm";
			this.Text = "CreateProjectForm";
			this.Load += new System.EventHandler(this.CreateProjectForm_Load);
			this.createProjectContainer.Panel1.ResumeLayout(false);
			this.createProjectContainer.Panel1.PerformLayout();
			this.createProjectContainer.Panel2.ResumeLayout(false);
			this.createProjectContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.createProjectContainer)).EndInit();
			this.createProjectContainer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.ListBox personBox;
		private System.Windows.Forms.Label namnLbl;
		private System.Windows.Forms.ComboBox companyBox;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label projectDescLbl;
		private System.Windows.Forms.Label projectCompanyLbl;
		private System.Windows.Forms.TextBox projectNameBox;
		private System.Windows.Forms.TextBox projectDescBox;
		private System.Windows.Forms.ListBox participantBox;
		private System.Windows.Forms.Button addPartBtn;
		private System.Windows.Forms.Button removePartBtn;
		private System.Windows.Forms.SplitContainer createProjectContainer;
		private System.Windows.Forms.Button saveParticipantsBtn;
		private System.Windows.Forms.Label personsLbl;
		private System.Windows.Forms.Label participantsLbl;
    }
}