using project;
using System.Text;
using System;
using System.Collections.Generic;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<T> listname = new List<T>();
            List<Ticket> Ticketlist = new List<Ticket>();
            List<Ticket> Alumni = new List<Ticket>();


            int ticketid = 2000;
            Console.WriteLine("Please enter 1 for staff help desk ");
            int role = Convert.ToInt32(Console.ReadLine());
            if (role == 1)
            {

                string running = "yes";
                while (running == "yes") ;
                {

                    Console.WriteLine("Print tickets: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your staff ID");
                    string f_staff_id = Console.ReadLine();
                    Console.WriteLine("Please enter the ticket creator name");
                    string f_ticket_creator_name = Console.ReadLine();
                    Console.WriteLine("Please enter your email");
                    string f_contact_email = Console.ReadLine();
                    Console.WriteLine("Please enter if you have any issue");
                    string f_issue = Console.ReadLine();
                    Console.WriteLine("Do you want to continue (yes or no)");
                    running = Console.ReadLine();
                    Console.WriteLine("Ticket status:");
                    string f_status = Console.ReadLine();
                    if (f_ticket_creator_name + f_contact_email == "")
                    {
                        Ticketlist.Add(new Ticket(f_staff_id, "not Specified", "not Specified", f_issue));

                    }
                    else
                    {
                        Ticketlist.Add(new Ticket(f_staff_id, f_ticket_creator_name, f_contact_email, f_issue));
                    }

                    Console.WriteLine("Do you want to continue (yes or no) ");
                    running = Console.ReadLine();
                }
            }

            Console.WriteLine("Please enter 2 for admin desk");
            int role1 = Convert.ToInt32(Console.ReadLine());
            if (role1 != 2)


            {
                return;                Console.WriteLine("Welcome to admin desk");
            int list_count = Ticketlist.Count;
            for (int i = 0; i < list_count; i++)
            {
                Console.WriteLine("Ticket Status");
                Console.WriteLine("**********************************");
                Console.WriteLine("Do you want to change password - Alumni (yes or not) ");
                string role2 = Console.ReadLine();
                if (role2 != "yes")
                {
                }
                else
                {
                    string running = "yes";
                    while (running == "yes")
                    {
                        Console.WriteLine("Please enter staff ID ( current -> Alumni)");
                        int to_change_id = Convert.ToInt32(Console.ReadLine());
                        for (int a = 0; i < list_count; i++)
                        {
                            Ticket tempobj = Ticketlist[i];
                            if (tempobj.nid == to_change_id)
                            {

                                System.Console.WriteLine(tempobj.nid);
                                Alumni.Add(tempobj);
                                Ticketlist.Remove(tempobj);
                                list_count--;
                                i--;
                            }
                        }
                        Console.WriteLine("Do you want to cotunue( yes or not)");
                        running = Console.ReadLine();
                    }
                }

                int list_count1 = Ticketlist.Count;
                for (int a = 0; i < list_count1; i++)

                {
                    Ticketlist[i].show_info();
                }
                Console.WriteLine("Do you want to update your status?");
                Console.WriteLine("*******************************");
                int alumni_list_count = Alumni.Count;
                for (int a = 0; i < alumni_list_count; i++)
                {
                    Alumni[i].show_info();
                }
                Console.WriteLine("Close tickekt");
                Console.WriteLine("*********************************");

                Console.WriteLine("Open ticket");
                Console.WriteLine("**************");

                Console.WriteLine("Do you want to change you password? -> current (yes or no)");
                string role3 = Console.ReadLine();
                if (role3 == "yes")
                {
                    string running = "yes";
                    while (running == "yes")
                    {
                        Console.WriteLine("Please enter the staff ID (Alumni -> current)");
                        int to_chnage_id = Convert.ToInt32(Console.ReadLine());
                        for (int a = 0; i < alumni_list_count; i++)
                        {
                            Ticket tempobj = "current";
                            Ticketlist.Add(tempobj);
                            Alumni.Remove(tempobj);
                            alumni_list_count--;
                            i--;
                        }
                    }
                    Console.WriteLine("Do you want to continue (yes or no)");
                    running = Console.ReadLine();
                }
            }
            int list_count2 = Ticketlist.Count;
                for (int i = 0; i < list_count2; i++)
                {
                    Ticketlist[i].show_info();

                    Console.WriteLine("Open ticket ");
                    Console.WriteLine("************************************");
                    int alumin_list_count1 = Alumni.Count;
                    for (int i = 0; i < alumin_list_count1; i++)

                    {
                        Alumni[i].show_info();
                        Console.WriteLine("closed ticket");
                        Console.WriteLine("****************************");

                    }
                }   
                    
                









        /*
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Ticketlist.Add (new Ticket(ticketid, name, "melissa", "melissa@.com", "no issue"));
            ticketid++;
            Ticketlist.Add (new Ticket(ticketid, "zhen", "zhen", "zhen@.com", "no isse"));
            ticketid++;
            Ticketlist.Add (new Ticket(ticketid, "hello", "hello", "hello@.com", "no issue"));
            ticketid++;
            Ticketlist.Add (new Ticket(ticketid, "hi", "hi", "hi@.com", "change password"));
            ticketid++;

        
            Ticketlist[1].show_info();

         
            int list_count = Ticketlist.Count;
            for (int i = 0; i < list_count; i ++)
            {
                Ticketlist[i].show_info();
   
            }
            list_count = 4;
      */
