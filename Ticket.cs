using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class Ticket
    {
       
        public int nid;
        private string unique_id;
        private string staff_id;
        private string ticket_creator_name;
        private string contact_email;
        private string issue;
        private string f_staff_id;
        private string f_ticket_creator_name;
        private string f_contact_email;
        private string f_issue;
        private string f_status; 

        public Ticket(int unique_id, string f_staff_id, string f_ticket_creator_name, string f_contact_email, string f_issue)
        {
            this.staff_id = f_staff_id;
            this.ticket_creator_name = f_ticket_creator_name;
            this.contact_email = f_contact_email;
            this.issue = f_issue;
            this.nid = unique_id;

        }

        public Ticket(string f_staff_id, string f_ticket_creator_name, string f_contact_email, string f_issue)
        {
            this.f_staff_id = f_staff_id;
            this.f_ticket_creator_name = f_ticket_creator_name;
            this.f_contact_email = f_contact_email;
            this.f_issue = f_issue;
        }

        public void Ticketnote(string f_staff_id, string f_issue)
        {
            staff_id = f_staff_id;
            ticket_creator_name = "Not Specified";
            contact_email = "Not Specified";
            issue = f_issue;
        }

        public string password_change(string id)
        {
            int pin = 12345;
            string new_id = id.Substring(0, 3) + pin.ToString("x");
            return new_id;

        }
        
        public void show_info()
        {
            Console.WriteLine("Ticket Number : " + nid);
            Console.WriteLine("Enter the staff id : " + staff_id);
            Console.WriteLine("Ticket creator name : " + ticket_creator_name);
            Console.WriteLine("Contact email :" + contact_email);
            Console.WriteLine("Issue :" + issue);
            if(issue.Contains("Password change"))
            {
                string new_id = password_change(staff_id);
                Console.WriteLine("New Generated is: " + new_id);
            }
            Console.WriteLine("*******************8");
            /*
            Console.WriteLine("Current students");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Do you want to change password -> Alumni  (yes or no)");
            string role2 = Console.ReadLine();
            for (int i = 0; i < staff_id; i++) ;
            {
                for (int i = 0; i < list_count; i++)
                {
                    Ticket tempoj = ticketlist[i];
                    if (tempoj.nid == 2003)
                    {
                        tempoj.status = "Alumni";
                    }
                }
                    Ticket tempobj = Ticketlist[i];
                if (tempobj.nid == 2002)
                {
                    Alumni.Add(tempobj);
                    Ticketlist;
                }
            }*/
        }

        
           
        }
    }

