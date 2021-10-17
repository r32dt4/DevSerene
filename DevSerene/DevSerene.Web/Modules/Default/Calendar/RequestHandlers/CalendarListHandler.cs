using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<DevSerene.Default.CalendarRow>;
using MyRow = DevSerene.Default.CalendarRow;

namespace DevSerene.Default
{
    public interface ICalendarListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CalendarListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICalendarListHandler
    {
        public CalendarListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}