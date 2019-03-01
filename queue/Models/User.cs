using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace queue.Models
{
    public class User
    {
        public int Id { get; set; }
        public int TicketNo { get; set; }
        public int TableNoId { get; set; }

        public List<TableNo> TableNos { get; set;}




    }
}