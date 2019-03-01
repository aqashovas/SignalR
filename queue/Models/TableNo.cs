using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace queue.Models
{
    public class TableNo
    {
        public int Id { get; set; }

        public int No { get; set; }

        public bool IsFree { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
        public User User { get; set; }

    }
}