using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P3P
{
    public class Order
    {
        string username;
        string Bestellingen;

        public Order(string username, string Bestellingen)
        {
            this.username = username;
            this.Bestellingen =Bestellingen;
        }

        public string getUsername()
        {
            return username;
        }

        public string getBestellingen()
        {
            return Bestellingen;
        }
    }
}