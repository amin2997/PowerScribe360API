using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerScribe360SampleApp
{
	public partial class Form1 : Form
	{
		PowerScribe360Api.Powerscribe _ps360;
		
		public Form1()
		{
			InitializeComponent();

			//disable all data sending controls
			EnableDataSending(false);
			btnConnect.Text = "&Connect";

			//When you close the sample application logout from PS360 server.
			FormClosing += delegate (object sender, FormClosingEventArgs e) { PS360Disconnect(); };
		}

		private void BtnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				btnConnect.Enabled = false;

				if (btnConnect.Text == "&Connect")
				{
					if (PS360Connect())
					{
						EnableDataSending();
						btnConnect.Text = "&Disconnect";
						MessageBox.Show("You have successfuly connected to PS360 Server", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else //Disconnect
				{
					if (PS360Disconnect())
					{
						EnableDataSending(false);
						btnConnect.Text = "&Connect";
					}
				}
			}
			finally
			{
				btnConnect.Enabled = true;
			}			
		}
		private bool PS360Connect()
		{
			bool validUserInput = string.IsNullOrWhiteSpace(txtPS360Url.Text) == false &&
					   string.IsNullOrWhiteSpace(txtPS360UserName.Text) == false &&
					   string.IsNullOrWhiteSpace(txtPS360Password.Text) == false &&
					   Uri.IsWellFormedUriString(txtPS360Url.Text.Trim(), UriKind.RelativeOrAbsolute);
			if (validUserInput)
			{
				// if user input is valid then login into PS360 Server
				_ps360 = new PowerScribe360Api.Powerscribe(txtPS360Url.Text.Trim());
				if (_ps360.SignIn(txtPS360UserName.Text.Trim(), txtPS360Password.Text.Trim()))
				{					
					return true;
				}
			}
			else
			{
				MessageBox.Show( "Please enter a valid URL, user name, and password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		private bool PS360Disconnect()
		{
			if (_ps360 != null)
			{
				if (_ps360.IsSignIn)
				{
					return _ps360.SignOut();
				}
			}
			return false;
		}	
		private void BtnSend_Click(object sender, EventArgs e)
		{
			try
			{
				btnSend.Enabled = false;

				bool validUserInput = string.IsNullOrWhiteSpace(txtAccessionNumber.Text) == false &&
								   string.IsNullOrWhiteSpace(txtCustomFieldName.Text) == false &&
								   string.IsNullOrWhiteSpace(txtCustomFieldValue.Text) == false &&
								   IsNumeric(txtAccessionNumber.Text.Trim());

				if (validUserInput)
				{
					if (_ps360.SetCustomField(txtAccessionNumber.Text.Trim(), txtCustomFieldName.Text.Trim(), txtCustomFieldValue.Text.Trim()))
					{
						MessageBox.Show($"The following data was sent successfully:\nAccession: {txtAccessionNumber.Text}\nCustom Field:{txtCustomFieldName.Text}\nField Value:{txtCustomFieldValue.Text}\n", "Data Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show($"There is a problem sending the following data point:\nAccession: {txtAccessionNumber.Text}\nCustom Field:{txtCustomFieldName.Text}\nField Value:{txtCustomFieldValue.Text}\n", "Problem sending", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Please enter a valid accession number, PowerScribe 360 custom field name and value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			finally
			{
				btnSend.Enabled = true;
			}

		}
		private static bool IsNumeric(string num) =>int.TryParse(num, out int result);
		private void EnableDataSending(bool enable = true)
		{
			foreach (Control cnt in groupBox2.Controls)
			{
				cnt.Enabled = enable;
			}
		}
	}
}
