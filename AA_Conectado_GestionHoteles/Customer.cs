using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_Conectado_GestionHoteles
{
    public class Customer
    {
        private int CustomerID;
        private String FirstName;
        private String LastName;
        private String Address;
        private String Email;

        public Customer()
        {
        }

        public Customer(int customerid, string firstName, string lastName, string address, string email)
        {
            CustomerID1 = customerid;
            FirstName1 = firstName;
            LastName1 = lastName;
            Address1 = address;
            Email1 = email;
        }

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int CustomerID1 { get => CustomerID; set => CustomerID = value; }
    }
}
