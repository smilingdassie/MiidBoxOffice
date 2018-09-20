using MiidBoxOffice.Models;
using MiidBoxOffice.Repository;
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
    public partial class EventSetup : Form
    {
    
        
        public EventSetup()
        {
            InitializeComponent();
            this.txtEventCode.Text = Global.EventID.ToString();
        }

        private void btnGetTicketClassesForEvent_Click(object sender, EventArgs e)
        {
            try
            {
                //Get ticket classes from Webservice
                ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
                bool IsBoxOffice = true;
                Global.TicketClasses = TicketClassRepository.DeserialiseString(client.GetTicketClassesForEvent(txtEventCode.Text, IsBoxOffice));

                dataGridView1.DataSource = Global.TicketClasses;
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "Web service offline: " + ex.Message;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.UserID = int.Parse(txtUserID.Text);
                Global.PosID = int.Parse(txtPOSID.Text);
                CashRegister form = new CashRegister(Global.TicketClasses, Global.UserID);
                form.Show();
                this.Hide();
            }
            catch (Exception e2)
            {
                if(String.IsNullOrEmpty(txtPOSID.Text))
                {

                    lblError.Visible = true;
                    lblError.Text = "Pos ID Required.";
                }

            }
        }

		private void lblError_Click(object sender, EventArgs e)
		{

		}

		private void txtPOSID_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtUserID_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
