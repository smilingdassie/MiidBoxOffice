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

        private void GetTickets(List<TicketPriceQty> tickets, int UserID)
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
                PurchasedTickets = TicketClassRepository.DeserialiseTicketString(client.PurchaseBoxOfficeTickets(sb.ToString(), UserID, Global.PosID));
            }
            catch (Exception e)
            {
                // lblError

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Change > 0)
            {
                GetTickets(this.ChosenTicketClasses, UserID);
                PrintTicket form = new PrintTicket(PurchasedTickets);
                form.Show();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Insufficient Cash Tendered!";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CashRegister form = new CashRegister(Global.TicketClasses, Global.UserID);
            form.Show();
            this.Close();
        }
    }


}
