using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiidBoxOffice.Models
{
    public class TicketClassLiteViewModel
    {


        public int ID { get; set; }
        public string Code { get; set; }
        public int EventID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public Nullable<System.DateTime> DateTimeUpdated { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int RunningQuantity { get; set; }
     //   public int MaxOnlineSaleQuantity { get; set; }
     //   public int StatusID { get; set; }

        public string EventName { get; set; }

    }

    public class TicketPrintViewModel
    {
        public int ID { get; set; }
        public string TicketNumber { get; set; }
        public int TicketClassID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public System.DateTime StartDate { get; set; }
        public string EventName { get; set; }

        public TicketPrintViewModel(Ticket ticket, List<TicketClassLiteViewModel> ticketClassesLookup)
        {
            TicketClassLiteViewModel myTicketClass = new TicketClassLiteViewModel();
            myTicketClass = ticketClassesLookup.Where(x => x.ID == ticket.TicketClassID).First();

            this.ID = ticket.ID;
            this.TicketNumber = ticket.TicketNumber;
            this.Description = myTicketClass.Description;
            this.EventName = myTicketClass.EventName;
            this.Price = myTicketClass.Price;
            this.StartDate = myTicketClass.StartDate;
            this.Description = myTicketClass.Description;

        }

    }


    public class Ticket
    {
        public int ID { get; set; }
        public string TicketNumber { get; set; }
        public int EndUserID { get; set; }
        public int StatusID { get; set; }
        public int TicketPurchasePrice { get; set; }
        public int TicketClassID { get; set; }
        public Nullable<System.DateTime> DatetimePurchased { get; set; }
        public Nullable<System.DateTime> DatetimeReserved { get; set; }
        public Nullable<System.DateTime> DatetimeRedeemed { get; set; }
        public string Hash { get; set; }
        public Nullable<System.DateTime> DateTimeUpdated { get; set; }
        public string UniquePaymentID { get; set; }

     
      
    }

    public class TicketLiteViewModel
    {
        public int ID { get; set; }
        public string TicketNumber { get; set; }
        public int EndUserID { get; set; }
        public int StatusID { get; set; }
        public int TicketPurchasePrice { get; set; }
        public int TicketClassID { get; set; }
        public Nullable<System.DateTime> DatetimePurchased { get; set; }
        public Nullable<System.DateTime> DatetimeReserved { get; set; }
        public Nullable<System.DateTime> DatetimeRedeemed { get; set; }
        public string Hash { get; set; }
        public Nullable<System.DateTime> DateTimeUpdated { get; set; }
        public string UniquePaymentID { get; set; }


        public TicketLiteViewModel() { }
        public TicketLiteViewModel(Ticket t)
        {

            this.ID = t.ID;
            this.TicketNumber = t.TicketNumber;
            this.EndUserID = t.EndUserID;
            this.StatusID = t.StatusID ;
            this.TicketPurchasePrice = t.TicketPurchasePrice ;
            this.TicketClassID = t.TicketClassID ;
            this.DatetimePurchased = t.DatetimePurchased;
            this.Hash = t.Hash;
            this.UniquePaymentID = t.UniquePaymentID;



        }
    }


}
