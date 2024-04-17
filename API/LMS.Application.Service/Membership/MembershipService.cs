using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using LMS.Application.Service.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Membership
{
    public class MembershipService : IMembershipService
    {
        public string GetMembership(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpMemberSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }
    }
}
