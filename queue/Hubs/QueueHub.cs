using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using queue.Models;

namespace queue.Hubs
{
    public class QueueHub : Hub
    {
        private readonly QueueContext db = new QueueContext();
        
        public void ChooseCompany()
        {
            int no = db.Users.Count() + 1;
            User user = new User
            {
                TicketNo = no,
                TableNoId = db.TableNos.FirstOrDefault(t => t.IsFree == true).Id

            };
            db.Users.Add(user);
            db.SaveChanges();
            string ticketNo = db.Users.FirstOrDefault(u=>u.Id==user.Id).TicketNo.ToString();
            //string tableno = db.TableNos.Include("Users").FirstOrDefault(t=>t.Id=user.Id).



            Clients.Client(user.Id.ToString()).Choose(ticketNo);
        }
    }
}