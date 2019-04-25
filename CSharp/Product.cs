using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Product
    {
        public int id;
        public String name;
        public double price;
        public int qty;
        public String image;
        public String desc;
        public List<String> gallery;

        public Product(int id, string name, double price, int qty, string image, string desc, List<String> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public Product(int x)
        {

        }

        public void getInfo()
        {
            Console.WriteLine("Nhập id: ");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập giá: ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng: ");
            qty = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập image: ");
            image = Console.ReadLine();
            Console.WriteLine("Desc: ");
            desc = Console.ReadLine();
            Console.WriteLine("Gallery: ");
            gallery.Add(Console.ReadLine());
        }

        public void printInfo()
        {
            Console.WriteLine("ID: " + id + "Tên: " + name + "Giá: " + price + "Số lượng: " + qty + "Image: " + image + "Gallery: " + gallery);
        }

        public void checkQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang");
            }
            Console.WriteLine("Het hang");
        }

        public void addGallery(String image)
        {
            
            
        }

        public void delGallery(String image)
        {

        }
    }
}
