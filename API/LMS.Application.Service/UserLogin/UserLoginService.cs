using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using LMS.Application.Service.DataAccess;
using LMS.Application.Service.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.UserLogin
{
    public class UserLoginService : IUserLoginService
    {
        public string GetUserLogin(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserLoginSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }

    }
}
