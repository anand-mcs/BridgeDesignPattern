using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    //Concrete Implementor
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string PaymentSystem)
        {
            Console.WriteLine("This is IDBI payment gateway. " + PaymentSystem);
        }
    }
}
