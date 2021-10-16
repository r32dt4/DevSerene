using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = DevSerene.Default.ToDoListRow;

namespace DevSerene.Default
{
    public interface IToDoListDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ToDoListDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IToDoListDeleteHandler
    {
        public ToDoListDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}