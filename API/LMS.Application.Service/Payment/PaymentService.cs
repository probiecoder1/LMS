using LMS.Application.Service.DataAccess;
using LMS.Application.LLBL.DatabaseSpecific;
using LMS.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS.Application.Service.Payment
{
    public class PaymentService : IPaymentService
    {
        public string GetPayment(string Json)
        {
            return DataAccessHelper.FetchDerivedModel<MvJson>(RetrievalProcedures.GetSpPaymentSelCallAsQuery(Json))
                ?.FirstOrDefault().Json;
        }

        public string PaymentTsk(string json)
        {
            using (var adapter = DataAccessHelper.GetAdapter())
            {
                string parameter = json;

                ActionProcedures.SpPaymentTsk(json, adapter);
                adapter.CloseConnection();
            }

            return json;
        }


    }
}
