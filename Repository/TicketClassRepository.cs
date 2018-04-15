using MiidBoxOffice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiidBoxOffice.Repository
{
    public class TicketClassList
     {
        public List<TicketClassLiteViewModel> TicketClasses { get; set; }
    }
    public static class TicketClassRepository
    {

        

        public static List<TicketClassLiteViewModel> DeserialiseString(string JsonTicketClassList)
        {
            List<TicketClassLiteViewModel> list = new List<TicketClassLiteViewModel>();

            list =  JsonConvert.DeserializeObject<List<TicketClassLiteViewModel>>(JsonTicketClassList);
            return list;
        }


        public static List<Ticket> DeserialiseTicketString(string JsonTicketList)
        {
            List<Ticket> list = new List<Ticket>();

            list = JsonConvert.DeserializeObject<List<Ticket>>(JsonTicketList);
            return list;
        }

    }
}
