using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<DevSerene.Default.AccountingBookRow>;
using MyRow = DevSerene.Default.AccountingBookRow;

namespace DevSerene.Default
{
    public interface IAccountingBookRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class AccountingBookRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAccountingBookRetrieveHandler
    {
        public AccountingBookRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}