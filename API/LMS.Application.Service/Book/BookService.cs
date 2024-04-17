using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using LMS.Application.Service.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Service.Book
{
    public class BookService : IBookService
    {
        public string GetBook(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpBookSelCallAsQuery(ref Json))?.FirstOrDefault().Json;
        }

        public string BookTsk(string Json)
        {
            using (var adpater = DataAccessHelper.GetAdapter())
            {
                string param = Json;

                ActionProcedures.SpBookTsk(ref Json, adpater);
                adpater.CloseConnection();
            }
            return Json;
        }

        public string Issue(string json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                ActionProcedures.SpBookIssueTsk(ref json, adapter);
            }
            return json;
        }

        public string Return(string json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                ActionProcedures.SpBookReturnTsk(ref json, adapter);
            }
            return json;
        }

    }
}
