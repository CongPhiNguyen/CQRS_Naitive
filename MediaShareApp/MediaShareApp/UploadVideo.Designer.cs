
namespace MediaShareApp
{
	partial class UploadVideo
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btUpload = new System.Windows.Forms.Button();
			this.btBrowse = new System.Windows.Forms.Button();
			this.pbPic = new System.Windows.Forms.PictureBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lbName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
			this.SuspendLayout();
			// 
			// btUpload
			// 
			this.btUpload.Location = new System.Drawing.Point(166, 311);
			this.btUpload.Name = "btUpload";
			this.btUpload.Size = new System.Drawing.Size(75, 23);
			this.btUpload.TabIndex = 0;
			this.btUpload.Text = "Upload";
			this.btUpload.UseVisualStyleBackColor = true;
			this.btUpload.Click += new System.EventHandler(this.btUpload_Click_1);
			// 
			// btBrowse
			// 
			this.btBrowse.Location = new System.Drawing.Point(12, 311);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new System.Drawing.Size(75, 23);
			this.btBrowse.TabIndex = 0;
			this.btBrowse.Text = "Browse";
			this.btBrowse.UseVisualStyleBackColor = true;
			this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
			// 
			// pbPic
			// 
			this.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPic.Location = new System.Drawing.Point(12, 68);
			this.pbPic.Name = "pbPic";
			this.pbPic.Size = new System.Drawing.Size(229, 237);
			this.pbPic.TabIndex = 1;
			this.pbPic.TabStop = false;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(58, 39);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(183, 23);
			this.tbName.TabIndex = 2;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(12, 47);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(39, 15);
			this.lbName.TabIndex = 3;
			this.lbName.Text = "Name";
			// 
			// UploadVideo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 346);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.pbPic);
			this.Controls.Add(this.btBrowse);
			this.Controls.Add(this.btUpload);
			this.Name = "UploadVideo";
			this.Text = "Upload Form";
			((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btUpload;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.PictureBox pbPic;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lbName;
	}
}

