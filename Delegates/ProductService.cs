using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public class ProductService
    {

        public delegate void deliverycheckEventHandler(Object obj,EventArgs args);
        public event deliverycheckEventHandler deliverycheck;

        public void Delivery(Factory factoryProuct) {
            Console.WriteLine("Product ready for delivery.....");
            Thread.Sleep(3000);

            onDeliveryCheck();
        }

        protected virtual void onDeliveryCheck() {
            if (deliverycheck!=null) {
                deliverycheck(this,EventArgs.Empty);
            }
        }
    }
}
