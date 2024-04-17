
using LMS.Application.Service.DataAccess;
using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.UserPerson
{
    public class UserPersonService : IUserPersonService
    {
        public string GetUserPerson(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserPersonSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }

        public string UserPersonTsk(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpUserPersonTsk(ref Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }


    }
}