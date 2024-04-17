using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Borrow
{
    public interface IBorrowService
    {
        public string GetBorrow(string Json);

        public string BorrowTsk(string Json);
    }
}
