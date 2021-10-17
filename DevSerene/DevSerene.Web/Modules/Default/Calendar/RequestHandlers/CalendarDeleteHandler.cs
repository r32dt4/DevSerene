using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = DevSerene.Default.CalendarRow;

namespace DevSerene.Default
{
    public interface ICalendarDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CalendarDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICalendarDeleteHandler
    {
        public CalendarDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}