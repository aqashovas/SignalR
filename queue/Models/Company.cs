using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace queue.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TableNo> TableNos { get; set; }

    }
}