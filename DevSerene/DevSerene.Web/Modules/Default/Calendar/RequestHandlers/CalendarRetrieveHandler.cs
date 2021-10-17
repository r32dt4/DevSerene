using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<DevSerene.Default.CalendarRow>;
using MyRow = DevSerene.Default.CalendarRow;

namespace DevSerene.Default
{
    public interface ICalendarRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CalendarRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICalendarRetrieveHandler
    {
        public CalendarRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}