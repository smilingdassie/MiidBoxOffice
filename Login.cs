using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiidBoxOffice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
                Global.UserID = client.LoginEventOrganiserBoxOffice(txtUserName.Text, txtPassword.Text, int.Parse(txtEventID.Text));


                if (Global.UserID > 0)
                {
                    Global.EventID = int.Parse(txtEventID.Text);
                    EventSetup form = new EventSetup();
                    form.Show();


                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Invalid Credentials. Please check and try again.";

                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "Web service offline: " + ex.Message;

            }

        }

		private void ButtonExit_Click(object sender, EventArgs e)
		{

		}

		private void SignIn_Enter(object sender, EventArgs e)
		{

		}
	}
}
