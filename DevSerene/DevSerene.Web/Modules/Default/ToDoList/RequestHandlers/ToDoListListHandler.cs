using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<DevSerene.Default.ToDoListRow>;
using MyRow = DevSerene.Default.ToDoListRow;

namespace DevSerene.Default
{
    public interface IToDoListListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ToDoListListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IToDoListListHandler
    {
        public ToDoListListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}