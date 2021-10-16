using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<DevSerene.Default.ToDoListRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = DevSerene.Default.ToDoListRow;

namespace DevSerene.Default
{
    public interface IToDoListSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ToDoListSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IToDoListSaveHandler
    {
        public ToDoListSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}