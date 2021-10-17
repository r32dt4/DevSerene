using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<DevSerene.Default.CalendarRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = DevSerene.Default.CalendarRow;

namespace DevSerene.Default
{
    public interface ICalendarSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CalendarSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICalendarSaveHandler
    {
        public CalendarSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}