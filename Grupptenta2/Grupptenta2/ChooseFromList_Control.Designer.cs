namespace Grupptenta2
{
	partial class ChooseFromList_Control
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.searchBox = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.filterBox = new System.Windows.Forms.ComboBox();
			this.filterBtn = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.chooseBtn = new System.Windows.Forms.Button();
			this.createBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(3, 3);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(198, 20);
			this.searchBox.TabIndex = 0;
			this.searchBox.Text = "Sökord";
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(207, 3);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "Sök";
			this.searchBtn.UseVisualStyleBackColor = true;
			// 
			// filterBox
			// 
			this.filterBox.FormattingEnabled = true;
			this.filterBox.Location = new System.Drawing.Point(3, 32);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(198, 21);
			this.filterBox.TabIndex = 2;
			// 
			// filterBtn
			// 
			this.filterBtn.Location = new System.Drawing.Point(207, 32);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Size = new System.Drawing.Size(75, 23);
			this.filterBtn.TabIndex = 3;
			this.filterBtn.Text = "Filtrera";
			this.filterBtn.UseVisualStyleBackColor = true;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(3, 61);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(198, 147);
			this.listBox.TabIndex = 4;
			// 
			// chooseBtn
			// 
			this.chooseBtn.Location = new System.Drawing.Point(207, 61);
			this.chooseBtn.Name = "chooseBtn";
			this.chooseBtn.Size = new System.Drawing.Size(75, 23);
			this.chooseBtn.TabIndex = 5;
			this.chooseBtn.Text = "Välj";
			this.chooseBtn.UseVisualStyleBackColor = true;
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(207, 90);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(75, 23);
			this.createBtn.TabIndex = 6;
			this.createBtn.Text = "Skapa";
			this.createBtn.UseVisualStyleBackColor = true;
			// 
			// ChooseFromList_Control
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.chooseBtn);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.filterBtn);
			this.Controls.Add(this.filterBox);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchBox);
			this.Name = "ChooseFromList_Control";
			this.Size = new System.Drawing.Size(286, 215);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ComboBox filterBox;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button chooseBtn;
		private System.Windows.Forms.Button createBtn;
	}
}
