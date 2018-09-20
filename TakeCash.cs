using MiidBoxOffice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiidBoxOffice.CashRegister;
using MiidBoxOffice.Repository;
using Newtonsoft.Json;

namespace MiidBoxOffice
{




    public partial class TakeCash : Form
    {
        decimal TotalDue = 0.0M;
        decimal Tendered = 0.0M;
        decimal Change = 0.0M;
        int UserID;

        List<CashRegister.TicketPriceQty> ChosenTicketClasses;
        List<Ticket> PurchasedTickets;

        public TakeCash(decimal _TotalDue, List<TicketPriceQty> chosenticketclasses, int userID)
        {
            InitializeComponent();
            lblTotalDue.Text = _TotalDue.ToString("0.00");
            TotalDue = _TotalDue;
            UserID = userID;

            this.ChosenTicketClasses = chosenticketclasses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tendered = decimal.Parse(txtTendered.Text);
            Change = Tendered - TotalDue;
            lblChange.Text = Change.ToString("0.00");

        }

        public class TicketClassTuple
        {
            public int ID { get; set; }
            public string TicketClassName { get; set; }
            public int Count { get; set; }
            public bool Available { get; set; }
        }


        private void GetTickets(List<TicketPriceQty> tickets, int UserID)
        {
            List<TicketClassTuple> FailedResult = new List<TicketClassTuple>();

            try
            {
                StringBuilder sb = new StringBuilder();
                ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
                bool IsBoxOffice = true;


                foreach (var ticket in tickets)
                {
                    int x = 0;
                    while (x < ticket.Qty)
                    {
                        sb.Append(String.Format("{0};", ticket.TicketClassID));
                        x++;
                    }

                }
                //Send a string of ticketclassIDs of the exact qty required
                try
                {
                    string purchaseResult = client.PurchaseBoxOfficeTickets(sb.ToString(), UserID, Global.PosID);

                    if (purchaseResult.ToLower().Contains("error"))
                    {
                        lblError.Visible = true;
                        

                        string error = purchaseResult.Split('|')[0];
                        StringBuilder sv = new StringBuilder();
                        

                        FailedResult = JsonConvert.DeserializeObject<List<TicketClassTuple>>(purchaseResult.Split('|')[1]);
                        foreach (var f in FailedResult)
                        {
                            sv.Append(String.Format("{0} - ({1}) ,", f.TicketClassName, f.Count));
                        }

                        lblError.Text = "Entire Purchase cancelled. Not enough tickets available \n at time of purchase for these types: " + sv.ToString();

                    }
                    else
                    {
                        PurchasedTickets = TicketClassRepository.DeserialiseTicketString(purchaseResult);
                    }
                }
                catch (Exception e)
                {
                    lblError.Visible = true;
                    lblError.Text = "Web service offline: " + e.Message;

                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "Web service offline: " + ex.Message;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Change >= 0)
            {
                GetTickets(this.ChosenTicketClasses, UserID);
                if (PurchasedTickets != null)
                {
                    PrintTicket form = new PrintTicket(PurchasedTickets);
                    form.Show();
                    this.Close();
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Insufficient Cash Tendered!";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
            Global.TicketClasses = TicketClassRepository.DeserialiseString(client.GetTicketClassesForEvent(Global.EventID.ToString(), true));

            CashRegister form = new CashRegister(Global.TicketClasses, Global.UserID);
            form.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }
    }


}
