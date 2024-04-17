using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Common
{
    public interface ICommonService
    {
        public string GetTotal(string Json);

        public string GetRecent(string Json);

        public string GetUserBooks(string Json);

        public string GetUserPayments(string Json);
    }
}
