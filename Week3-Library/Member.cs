using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Library
{
    internal class Member
    {

        private int memberId; 
        private string name;
        private string address;
        private string phone; //String for leading zeros

        //Public properties

        public int MemberId
        {
            get { return memberId; }
            private set
            {

                if (value > 0)
                {

                    memberId = value; //Private makes it read-only
                }
                else {

                    Console.WriteLine("Error: Member ID must be greater than zero");

                }

            }
        
        }

        public string Name
        {
            get { return name; } //Get method
            set
            {

                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value; //Set method
                }
                else
                {

                    Console.WriteLine("Error: Name cannot contain numbers or be blank");

                }

            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //Constructor

        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; //Assigns the camelCase parameter to the pascalcase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine();
        }
    }
}
