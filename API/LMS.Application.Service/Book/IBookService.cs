using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Book
{
    public interface IBookService
    {
        public string GetBook(string Json);

        public string BookTsk(string Json);

        public string Issue(string json);

        public string Return(string json);
    }
}
