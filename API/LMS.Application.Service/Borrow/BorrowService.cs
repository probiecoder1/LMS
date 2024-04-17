using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using LMS.Application.Service.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Borrow
{
    public class BorrowService : IBorrowService
    {
        public string GetBorrow(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpBorrowSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }

        public string BorrowTsk(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpBorrowTsk(Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }
    }
}
