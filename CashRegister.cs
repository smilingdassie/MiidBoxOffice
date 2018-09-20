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
    public partial class CashRegister : Form
    {
        public int _UserID { get; set; }
        public class TicketPriceQty
        {
            public int TicketClassID { get; set; }
            public int Price { get; set; }
            public int Qty { get; set; }

            public int Subtotal { get; set; }

         

        }

      

        public List<TicketClassLiteViewModel> TicketClasses { get; set; }
        public CashRegister(List<TicketClassLiteViewModel> TicketClasses, int UserID)
        {
            InitializeComponent();
            NewMethod(TicketClasses, UserID);
        }

        private void NewMethod(List<TicketClassLiteViewModel> TicketClasses, int UserID)
        {
           
            _UserID = UserID;
            this.TicketClasses = TicketClasses;
            this.lblEventName.Text = TicketClasses.First().EventName;

            foreach (var t in TicketClasses)
            {
                AddDescriptionLabel(t.Description);
                AddDateLabel(t.Description, t.StartDate, t.EndDate);
                AddPriceLabel(t.ID, t.Price);
                AddQtyTextBox(t.ID, t.RunningQuantity > 0, t.RunningQuantity);
                AddRunningQtyLabel(t.ID, t.RunningQuantity);
            }
        }

        int A = 3; int B = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            List<TicketPriceQty> tickets = new List<TicketPriceQty>();
            foreach (var t in this.TicketClasses)
            {
                tickets.Add(new TicketPriceQty
                {
                    TicketClassID = t.ID,
                    Qty = 0,
                    Price = t.Price,
                    Subtotal = 0

                });

            }

            decimal TotalCost = 0.00M;
            
            foreach (Control c in this.Controls)
            {
                if (c is NumericUpDown)
                {
                    NumericUpDown TextBoxControl = (NumericUpDown)c;

                    if (!String.IsNullOrEmpty(c.Text))
                    {
                      
                        string[] parts = c.Name.Split('_');

                        var dog = tickets.FirstOrDefault(d => d.TicketClassID == int.Parse(parts[2]));

                        dog.Qty = int.Parse(c.Text);
                        
                    }
                 
                }
                if (c is Label)
                {
                    Label lbl = (Label)c;

                    if (c.Name.StartsWith("ticketClassPrice"))
                    {
                        string[] parts = c.Name.Split('_');

                        var dog = tickets.FirstOrDefault(d => d.TicketClassID == int.Parse(parts[2]));

                        dog.Price = int.Parse(c.Text.Replace("R ", ""));
                    }
                }
            }

            foreach (var t in tickets.Where(x=>x.Qty > 0))
            {
                TotalCost += (t.Qty * t.Price);

            }

            if (TotalCost <= 0)
            {
                lblError.Visible = true;
                lblError.Text = "No tickets selected!";
            }
            else
            {
                TakeCash open = new TakeCash(TotalCost, tickets.Where(x => x.Qty > 0).ToList(), _UserID);
                open.Show();
                this.Close();
            }
        }

     
        public System.Windows.Forms.Label AddDescriptionLabel(string ticketTypeName, bool removeMe = false)
        {
          
            System.Windows.Forms.Label txt = new Label();
            this.Controls.Add(txt);
            txt.Top = A * 28;
            txt.Left = 16;
            txt.Text = ticketTypeName;
            txt.Name = "lbl" + ticketTypeName.Replace(" ", "");



            return txt;
        }

        public System.Windows.Forms.Label AddDateLabel(string ticketTypeName, DateTime startDate, DateTime endDate, bool removeMe = false)
        {
          
            System.Windows.Forms.Label txt = new Label();
            this.Controls.Add(txt);
            txt.Top = A * 28;
            txt.Left = 200;
            txt.Width = 150;
            txt.Text = String.Format("{0} - {1}", startDate.ToString("yyyy-MM-dd HH:mm"), endDate.ToString("HH:mm"));

            txt.Name = "lblDate" + ticketTypeName.Replace(" ", "");

            return txt;
        }

        public System.Windows.Forms.Label AddPriceLabel(int ticketClassID, int price, bool removeMe = false)
        {
           
            System.Windows.Forms.Label txt = new Label();
            this.Controls.Add(txt);
            txt.Top = A * 28;
            txt.Left = 360;
          
            txt.Text = String.Format("R {0}", price);
            txt.Name = String.Format("ticketClassPrice_{0}_{1}", B, ticketClassID);
            return txt;
        }

     



        public System.Windows.Forms.NumericUpDown AddQtyTextBox(int ticketClassID, bool Enabled, int RunningQty, bool removeMe = false)
        {

            System.Windows.Forms.NumericUpDown txt = new NumericUpDown();


            // Set the Minimum, Maximum, and initial Value.
            txt.Value = 0;
            txt.Maximum = RunningQty;
            txt.Minimum = 1;


            this.Controls.Add(txt);
            txt.Top = A * 28;
            txt.Left = 460;
            txt.Text = "";
            A = A + 1;
            B = B + 1;
            txt.Name = String.Format("ticketClassQty_{0}_{1}", B, ticketClassID);
            txt.Enabled = Enabled;
            
            return txt;
        }

        public System.Windows.Forms.Label AddRunningQtyLabel(int ticketClassID, int runningQty, bool removeMe = false)
        {

            if (removeMe)
            {
               
            }

            System.Windows.Forms.Label txt = new Label();
            this.Controls.Add(txt);
            txt.Top = A * 28 - 28;
            txt.Left = 600;

            txt.Text = String.Format("({0})", runningQty);
            txt.Name = String.Format("ticketRunningQty_{0}_{1}", B, ticketClassID);
            return txt;
        }

     
    }
}
