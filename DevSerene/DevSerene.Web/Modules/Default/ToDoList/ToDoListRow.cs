using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace DevSerene.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[ToDoList]")]
    [DisplayName("To Do List"), InstanceName("To Do List")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ToDoListRow : Row<ToDoListRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Event Name"), Column("Event_Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public String EventName
        {
            get => fields.EventName[this];
            set => fields.EventName[this] = value;
        }

        [DisplayName("Description")]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Create Date"), Column("Create_Date")]
        public DateTime? CreateDate
        {
            get => fields.CreateDate[this];
            set => fields.CreateDate[this] = value;
        }

        [DisplayName("Start Date"), Column("Start_Date")]
        public DateTime? StartDate
        {
            get => fields.StartDate[this];
            set => fields.StartDate[this] = value;
        }

        [DisplayName("End Date"), Column("End_Date")]
        public DateTime? EndDate
        {
            get => fields.EndDate[this];
            set => fields.EndDate[this] = value;
        }

        [DisplayName("Is Finished"), Column("Is_Finished")]
        public Boolean? IsFinished
        {
            get => fields.IsFinished[this];
            set => fields.IsFinished[this] = value;
        }

        [DisplayName("Update User"), Column("Update_User"), Size(20), NotNull]
        public String UpdateUser
        {
            get => fields.UpdateUser[this];
            set => fields.UpdateUser[this] = value;
        }

        [DisplayName("Update Date"), Column("Update_Date"), NotNull]
        public DateTime? UpdateDate
        {
            get => fields.UpdateDate[this];
            set => fields.UpdateDate[this] = value;
        }

        public ToDoListRow()
            : base()
        {
        }

        public ToDoListRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField EventName;
            public StringField Description;
            public DateTimeField CreateDate;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public BooleanField IsFinished;
            public StringField UpdateUser;
            public DateTimeField UpdateDate;
        }
    }
}
