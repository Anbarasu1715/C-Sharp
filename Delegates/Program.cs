using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factoryProduct = new Factory() { prodId=1,prodName="Steels"};
            ProductService prod = new ProductService();
            deliveryService ds = new deliveryService();
            NewdeliveryService nds = new NewdeliveryService();


            prod.deliverycheck += nds.onDeliveryCheck;
            prod.deliverycheck += ds.onDeliveryCheck;
            prod.Delivery(factoryProduct);
            Console.WriteLine("Press any key to exit.....!");
            Console.ReadKey();
        }


    }

    public class deliveryService {
        public void onDeliveryCheck(object src, EventArgs args) {
            Console.WriteLine("Product delivered successfully.....!");
            Console.WriteLine(args.GetType());
        }
    }

    public class NewdeliveryService
    {
        public void onDeliveryCheck(object src, EventArgs args)
        {
            Console.WriteLine("Product delivered successfully by New Delivery System.....!");
            Console.WriteLine(args.GetType());
        }
    }

}
