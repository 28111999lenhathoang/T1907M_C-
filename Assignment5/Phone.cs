using System;
using System.Collections.Generic;

namespace T1907M.Assignment5
{
    public abstract class Phone
    {
        protected string name;
        protected string phone;

        public Phone()
        {
            
        }
        public Phone(string phone)
        {
            this.phone = phone;
        }
        public Phone(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone1
        {
            get { return phone; }
            set { phone = value; }
        }

        protected abstract void InsertPhone(string name, string phone);
        protected abstract void RemovePhone(string name);
        protected abstract void UpdatePhone(string name, string newPhone);
        protected abstract void SearchPhone(string name);

        public void Showlist()
        {
            Console.WriteLine("name : " +name);
            Console.WriteLine("phone : " +phone);
        }
    }
}