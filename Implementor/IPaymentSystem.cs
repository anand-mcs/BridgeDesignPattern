using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    //Implementor Interface
    public interface IPaymentSystem
    {
        void ProcessPayment(string PaymentSystem);
    }
}
