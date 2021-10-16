using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = DevSerene.Default.AccountingBookRow;

namespace DevSerene.Default
{
    public interface IAccountingBookDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class AccountingBookDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAccountingBookDeleteHandler
    {
        public AccountingBookDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}