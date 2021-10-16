using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<DevSerene.Default.ToDoListRow>;
using MyRow = DevSerene.Default.ToDoListRow;

namespace DevSerene.Default
{
    public interface IToDoListRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ToDoListRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IToDoListRetrieveHandler
    {
        public ToDoListRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}