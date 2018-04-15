using MiidBoxOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiidBoxOffice
{
    public static class Global
    {
        private static string _globalVar = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

        private static List<TicketClassLiteViewModel> _TicketClasses { get; set; }

        public static List<TicketClassLiteViewModel> TicketClasses
        {
            get { return _TicketClasses; }
            set { _TicketClasses = value; }
        }

        private static int _UserID = 0;
        public static int UserID 
         {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private static int _PosID = 0;
        public static int PosID
        {
            get { return _PosID; }
            set { _PosID = value; }
        }
        private static int _EventID = 0;
        public static int EventID
        {
            get { return _EventID; }
            set { _EventID = value; }
        }


    }
}
