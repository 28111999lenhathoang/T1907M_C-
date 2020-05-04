using System;
using System.Collections.Generic;

namespace T1907M.Assignment5
{
    public class PhoneBook : Phone
    {
        public static void Main(string[] args)
        {
            List<PhoneBook> PhoneList = new List<PhoneBook>();
            PhoneBook a = new PhoneBook();
            PhoneList.Add(new PhoneBook("le nhat hoang", "0394134127"));
            Console.WriteLine("danh sach");
            foreach (PhoneBook x in PhoneList)
            {
                x.Showlist();
            }

            a.InsertPhone("le thi quynh trang", "0968923122");
            a.RemovePhone("le nhat hoang");
            a.SearchPhone("le thi quynh trang");
            a.UpdatePhone("le thi quynh trang", "1999");
            Console.WriteLine("danh sach sau update");
            foreach (PhoneBook x in PhoneList)
            {
                x.Showlist();
            }
        }

        List<PhoneBook> PhoneList = new List<PhoneBook>();

        public List<PhoneBook> PhoneList1
        {
            get { return PhoneList; }
            set { PhoneList = value; }
        }

        public PhoneBook()
        {
        }

        public PhoneBook(string name, string phone) : base(name, phone)
        {
        }

        public PhoneBook(string phone) : base(phone)
        {
        }

        

        protected override void InsertPhone(string name, string phone)
        {
            foreach (PhoneBook x in PhoneList)
            {
                if (!x.Name.Equals(name))
                {
                    PhoneList.Add(new PhoneBook(name,phone));
                }
                else
                {
                    foreach (PhoneBook y in PhoneList)
                    {
                        if (!y.Phone1.Equals(phone))
                        {
                            PhoneList.Add(new PhoneBook(phone));
                        }
                    }
                }
            } 
        }

        protected override void RemovePhone(string name)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                foreach (PhoneBook x in PhoneList)
                {
                    if (x.Name.Equals(name))
                    {
                        PhoneList.RemoveAt(i);
                    }
                }
            }
        }

        protected override void UpdatePhone(string name, string newPhone)
        {
            foreach (PhoneBook x in PhoneList)
            {
                if (x.Name.Equals(name))
                {
                    x.Phone1 = newPhone;
                }
            }   
        }

        protected override void SearchPhone(string name)
        {
            foreach (PhoneBook x in PhoneList)
            {
                if (x.Name.Equals(name))
                {    
                    Console.WriteLine("name : " +x.Name );
                    Console.WriteLine("phone : " +x.Phone1);
                }
            }
        }
    }
}