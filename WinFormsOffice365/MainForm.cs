using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office365.Exchange;
using Microsoft.Office365.OAuth;

namespace WinFormsOffice365
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Office365Contact office365Contact = null;

        private IEnumerable<IContact> _dataCollection;

        private IEnumerable<IContact> DataCollection
        {
            get
            {
                return _dataCollection;
            }
            set
            {
                _dataCollection = value;
                ShowData();
            }
        }

        private async void btnReadContacts_Click(object sender, EventArgs e)
        {
            this.rtxtResults.Text = String.Empty;
            InitilizeControls(false);
            this.lblInformation.Text = "Loading data from Office 365...";
            DataCollection = await office365Contact.GetAll();
            this.lblInformation.Text = String.Empty;
        }

        private void ShowData()
        {
            foreach (var contact in DataCollection)
            {
                if (this.rtxtResults.Text != String.Empty)
                    AppendText(Color.Black, Environment.NewLine + Environment.NewLine);
                AppendText(Color.Black, "The email of ");
                AppendText(Color.Blue, contact.DisplayName);
                AppendText(Color.Black, " is ");
                AppendText(Color.Blue, contact.EmailAddress1);
                if (contact.BusinessPhone1 != null)
                {
                    AppendText(Color.Black, Environment.NewLine + "Telephone number: ");
                    AppendText(Color.Blue, contact.BusinessPhone1);
                }
            }
            InitilizeControls(true);
        }

        private void AppendText(Color color, string text)
        {
            int start = this.rtxtResults.TextLength;
            this.rtxtResults.AppendText(text);
            int end = this.rtxtResults.TextLength;
            this.rtxtResults.Select(start, end - start);
            {
                this.rtxtResults.SelectionColor = color;
            }
            this.rtxtResults.SelectionLength = 0;
        }

        private async void lnklblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (office365Contact != null &&
                    office365Contact.IsAuthenticated)
                {
                    this.rtxtResults.Text = String.Empty;
                    this.lblUserLogged.Text = String.Empty;
                    InitilizeControls(false);
                    InitilizeSignInformation(false);
                    await office365Contact.SignOut();
                    this.office365Contact = null;
                }
                else
                {
                    office365Contact = new Office365Contact();
                    await office365Contact.EnsureExchangeClient();
                    this.lblInformation.Text = "The user is logged correctly";
                    InitilizeControls(true);
                    InitilizeSignInformation(true);
                    this.lblUserLogged.Text = String.Format("{0} {1} - ( {2} )", 
                                                            office365Contact.AuthenticationInfo.IdToken.GivenName,
                                                            office365Contact.AuthenticationInfo.IdToken.FamilyName,
                                                            office365Contact.AuthenticationInfo.IdToken.Email);
                }
            }
            catch (AuthenticationFailedException ex)
            {
                this.lblInformation.Text = "Authentication failed :: " + ex.Message;
            }
            catch (Exception ex)
            {
                this.lblInformation.Text = "General Error :: " + ex.Message;
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            this.lblInformation.Text = "I'm creating a new contact...";
            var contact = PrepareContact();
            await office365Contact.Create(contact);
            this.lblInformation.Text = "The contact has been created";
            InitializeCreateControls();
            btnReadContacts_Click(null, null);
        }

        private Contact PrepareContact()
        {
            var contact = new Contact();
            contact.GivenName = this.txtCreateGivenName.Text;
            contact.Surname = this.txtCreateFamilyName.Text;
            contact.DisplayName = String.Format("{0} {1}", this.txtCreateGivenName.Text, this.txtCreateFamilyName.Text);
            contact.EmailAddress1 = this.txtCreateEmail.Text;
            contact.BusinessPhone1 = this.txtCreatePhone.Text == String.Empty ? null : this.txtCreatePhone.Text;
            return contact;
        }

        private void InitializeCreateControls()
        {
            this.txtCreateGivenName.Text = String.Empty;
            this.txtCreateFamilyName.Text = String.Empty;
            this.txtCreateEmail.Text = String.Empty;
            this.txtCreatePhone.Text = String.Empty;
        }

        private void InitilizeControls(bool value)
        {
            this.btnReadContacts.Enabled = value;
            this.btnCreate.Enabled = value;
        }

        private void InitilizeSignInformation(bool value)
        {
            if (value)
            {
                this.lnklblLog.Text = "Sign out";
                this.imageProfile.Visible = true;
            }
            else
            {
                this.lnklblLog.Text = "Sign in";
                this.imageProfile.Visible = false;
            }
        }

    }

}
