using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.UserPerson
{
    public interface IUserPersonService
    {
        public string GetUserPerson(string Json);

        public string UserPersonTsk(string Json);
    }
}