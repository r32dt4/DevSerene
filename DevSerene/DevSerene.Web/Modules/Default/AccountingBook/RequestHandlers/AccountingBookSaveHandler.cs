using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<DevSerene.Default.AccountingBookRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = DevSerene.Default.AccountingBookRow;

namespace DevSerene.Default
{
    public interface IAccountingBookSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class AccountingBookSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAccountingBookSaveHandler
    {
        public AccountingBookSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}