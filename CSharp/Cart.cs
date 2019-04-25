using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Cart
    {
        public int id;
        public String customer;
        public int grandTotal;
        public List<String> productList;
        public String city;
        public String country;

        public void nhapThongTin()
        {
            Console.WriteLine("Id: ");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Customer: ");
            customer = Console.ReadLine();
            Console.WriteLine("Grandtotal: ");
            grandTotal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("City: ");
            city = Console.ReadLine();
            Console.WriteLine("Country: ");
            country = Console.ReadLine();
            Console.WriteLine("ProductList: ");
            productList.Add(Console.ReadLine());
        }

        public void inThongTin()
        {
            Console.WriteLine("ID: " + id + "Customer: " + customer + "GrandTotal: " + grandTotal + "City: " + city + "Country:  " + country);
        }

        public void addProduct()
        {

        }

        public void delProduct()
        {

        }

        public void Grandtotal()
        {

        }

    }
}
