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
using System.Configuration;
using MiidBoxOffice.Repository;

namespace MiidBoxOffice
{
    public partial class PrintTicket : Form
    {

       
        public List<Ticket> myTicketsSb { get; set; }
        public PrintTicket(List<Ticket> sb)
        {
            InitializeComponent();
            myTicketsSb = sb;
        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
           
          

            try
            {
                bpac.DocumentClass doc = new bpac.DocumentClass();

               
                    foreach (Ticket s1 in myTicketsSb)
                    {
                        TicketPrintViewModel s = new TicketPrintViewModel(s1, Global.TicketClasses);
                        richTextBox1.AppendText("TIC" + s.TicketNumber);
                        richTextBox1.AppendText("\n");
                       

                    }
           
        

            }
            catch (Exception e2)
            {
                this.lblError.Visible = true;
                this.lblError.Text = e2.Message;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string templatePath = "";
            string templateFolder = ConfigurationManager.AppSettings["TEMPLATE_DIRECTORY"].ToString();// TEMPLATE_DIRECTORY;
            string templateFrame = ConfigurationManager.AppSettings["TEMPLATE_FRAME"].ToString();// TEMPLATE_FRAME;

            string applicationDirectory = Application.ExecutablePath;

            


            templatePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(applicationDirectory), @"LabelTemplates\TicketBarcode.lbx");

            try
            {
                bpac.DocumentClass doc = new bpac.DocumentClass();

                if (doc.Open(templatePath) != false)
                {
                    foreach (Ticket s1 in myTicketsSb)
                    {
                        TicketPrintViewModel s = new TicketPrintViewModel(s1, Global.TicketClasses);
                      
                        doc.GetObject("objBarCode").Text = "TIC" + s.TicketNumber;
                        doc.GetObject("objEventName").Text = s.EventName;
                        doc.GetObject("objTicketClass").Text = s.Description;
                        doc.GetObject("objPrice").Text = String.Format("R {0}.00", s.Price);
                        doc.GetObject("objStartDateTime").Text = s.StartDate.ToString("dd MMM yyyy HH:mm");
                        doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                        doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
                        doc.EndPrint();
                     
                    }
                    doc.Close();

                }
                else
                {
                    // MsgBox("Open() Error: " + doc.ErrorCode);
                }
                //clear tickets
                myTicketsSb = null;
                this.richTextBox1.Clear();

                ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
                Global.TicketClasses = TicketClassRepository.DeserialiseString(client.GetTicketClassesForEvent(Global.EventID.ToString(), true));

                CashRegister form1 = new CashRegister(Global.TicketClasses, Global.UserID);
                form1.Show();
                this.Close();

            }
            catch (Exception e2)
            {
                this.lblError.Visible = true;
                this.lblError.Text = e2.Message;

            }

        }

		private void button2_Click(object sender, EventArgs e)
		{
            ServiceReference1.MiidWebServiceSoapClient client = new ServiceReference1.MiidWebServiceSoapClient();
            Global.TicketClasses = TicketClassRepository.DeserialiseString(client.GetTicketClassesForEvent(Global.EventID.ToString(), true));

            CashRegister form = new CashRegister(Global.TicketClasses, Global.UserID);
			form.Show();
			this.Close();
		}
	}
}
