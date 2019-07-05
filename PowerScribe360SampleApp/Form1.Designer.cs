namespace PowerScribe360SampleApp
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPS360Url = new System.Windows.Forms.TextBox();
			this.txtPS360UserName = new System.Windows.Forms.TextBox();
			this.txtPS360Password = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtCustomFieldName = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtCustomFieldValue = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAccessionNumber = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "PowerScribe 360 Server URL";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "PowerScribe 360 User";
			// 
			// txtPS360Url
			// 
			this.txtPS360Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPS360Url.Location = new System.Drawing.Point(238, 25);
			this.txtPS360Url.Name = "txtPS360Url";
			this.txtPS360Url.Size = new System.Drawing.Size(476, 26);
			this.txtPS360Url.TabIndex = 1;
			// 
			// txtPS360UserName
			// 
			this.txtPS360UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPS360UserName.Location = new System.Drawing.Point(238, 57);
			this.txtPS360UserName.Name = "txtPS360UserName";
			this.txtPS360UserName.Size = new System.Drawing.Size(256, 26);
			this.txtPS360UserName.TabIndex = 1;
			// 
			// txtPS360Password
			// 
			this.txtPS360Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPS360Password.Location = new System.Drawing.Point(238, 89);
			this.txtPS360Password.Name = "txtPS360Password";
			this.txtPS360Password.Size = new System.Drawing.Size(256, 26);
			this.txtPS360Password.TabIndex = 1;
			// 
			// btnConnect
			// 
			this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(591, 57);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(123, 58);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "&Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnConnect);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtPS360Password);
			this.groupBox1.Controls.Add(this.txtPS360Url);
			this.groupBox1.Controls.Add(this.txtPS360UserName);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(735, 149);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "1. Connect to Server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "PowerScribe 360 Password";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtCustomFieldName);
			this.groupBox2.Controls.Add(this.btnSend);
			this.groupBox2.Controls.Add(this.txtCustomFieldValue);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtAccessionNumber);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 187);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(735, 174);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "2. Send data points into prebuilt PS360 custom fields";
			// 
			// txtCustomFieldName
			// 
			this.txtCustomFieldName.Enabled = false;
			this.txtCustomFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomFieldName.Location = new System.Drawing.Point(238, 72);
			this.txtCustomFieldName.Name = "txtCustomFieldName";
			this.txtCustomFieldName.Size = new System.Drawing.Size(256, 26);
			this.txtCustomFieldName.TabIndex = 1;
			this.txtCustomFieldName.Text = "CTRAD";
			// 
			// btnSend
			// 
			this.btnSend.Enabled = false;
			this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.Location = new System.Drawing.Point(591, 56);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(123, 58);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "&Send Data";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// txtCustomFieldValue
			// 
			this.txtCustomFieldValue.Enabled = false;
			this.txtCustomFieldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomFieldValue.Location = new System.Drawing.Point(238, 104);
			this.txtCustomFieldValue.Name = "txtCustomFieldValue";
			this.txtCustomFieldValue.Size = new System.Drawing.Size(256, 26);
			this.txtCustomFieldValue.TabIndex = 1;
			this.txtCustomFieldValue.Text = "512";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(222, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Radiology Report Accession #";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Custom Field Data";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(207, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "PreBuilt Custom Field Name";
			// 
			// txtAccessionNumber
			// 
			this.txtAccessionNumber.Enabled = false;
			this.txtAccessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccessionNumber.Location = new System.Drawing.Point(238, 40);
			this.txtAccessionNumber.Name = "txtAccessionNumber";
			this.txtAccessionNumber.Size = new System.Drawing.Size(256, 26);
			this.txtAccessionNumber.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 373);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Sample Application";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPS360Url;
		private System.Windows.Forms.TextBox txtPS360UserName;
		private System.Windows.Forms.TextBox txtPS360Password;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtCustomFieldName;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtCustomFieldValue;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAccessionNumber;
	}
}

