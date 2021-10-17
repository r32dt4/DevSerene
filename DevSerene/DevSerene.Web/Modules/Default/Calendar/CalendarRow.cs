using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace DevSerene.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Calendar]")]
    [DisplayName("Calendar"), InstanceName("Calendar")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CalendarRow : Row<CalendarRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Title"), Size(100), NotNull, QuickSearch, NameProperty]
        public String Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Username"), Size(20)]
        public String Username
        {
            get => fields.Username[this];
            set => fields.Username[this] = value;
        }

        [DisplayName("Event"), Size(100)]
        public String Event
        {
            get => fields.Event[this];
            set => fields.Event[this] = value;
        }

        [DisplayName("Note"), Size(100)]
        public String Note
        {
            get => fields.Note[this];
            set => fields.Note[this] = value;
        }

        [DisplayName("Description")]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("All Day")]
        public Boolean? AllDay
        {
            get => fields.AllDay[this];
            set => fields.AllDay[this] = value;
        }

        [DisplayName("Start Date")]
        public DateTime? StartDate
        {
            get => fields.StartDate[this];
            set => fields.StartDate[this] = value;
        }

        [DisplayName("End Date")]
        public DateTime? EndDate
        {
            get => fields.EndDate[this];
            set => fields.EndDate[this] = value;
        }

        [DisplayName("Back Ground Color"), Size(20)]
        public String BackGroundColor
        {
            get => fields.BackGroundColor[this];
            set => fields.BackGroundColor[this] = value;
        }

        [DisplayName("Border Color"), Size(20)]
        public String BorderColor
        {
            get => fields.BorderColor[this];
            set => fields.BorderColor[this] = value;
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

        public CalendarRow()
            : base()
        {
        }

        public CalendarRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Title;
            public StringField Username;
            public StringField Event;
            public StringField Note;
            public StringField Description;
            public BooleanField AllDay;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public StringField BackGroundColor;
            public StringField BorderColor;
            public StringField UpdateUser;
            public DateTimeField UpdateDate;
        }
    }
}
