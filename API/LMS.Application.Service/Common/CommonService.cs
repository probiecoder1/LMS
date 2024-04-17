using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using LMS.Application.Service.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Common
{
    public class CommonService: ICommonService
    {
        public string GetTotal(string Json) 
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpTotalSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }

        public string GetRecent(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpRecentBookSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }

        public string GetUserBooks(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserDataSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }

        public string GetUserPayments(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpUserPaymentDetailsSelCallAsQuery(Json))?.FirstOrDefault().Json;
        }
    }
}
