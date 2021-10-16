using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<DevSerene.Default.AccountingBookRow>;
using MyRow = DevSerene.Default.AccountingBookRow;

namespace DevSerene.Default
{
    public interface IAccountingBookListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class AccountingBookListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAccountingBookListHandler
    {
        public AccountingBookListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}