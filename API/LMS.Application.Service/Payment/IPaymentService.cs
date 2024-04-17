using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Payment
{
    public interface IPaymentService
    {
        public string GetPayment(string Json);

        public string PaymentTsk(string Json);
    }
}
