using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace DevSerene.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[AccountingBook]")]
    [DisplayName("Accounting Book"), InstanceName("Accounting Book")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AccountingBookRow : Row<AccountingBookRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Date"), NotNull]
        public DateTime? Date
        {
            get => fields.Date[this];
            set => fields.Date[this] = value;
        }

        [AccountingBook_Type_Editor]
        [DisplayName("Type"), Size(20), QuickSearch, NameProperty]
        public String Type
        {
            get => fields.Type[this];
            set => fields.Type[this] = value;
        }

        [DisplayName("Amount")]
        public Int32? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }

        [AccountingBook_Expenditure_Category_Editor]
        [DisplayName("Category"), Size(25)]
        public String Category
        {
            get => fields.Category[this];
            set => fields.Category[this] = value;
        }

        [AccountingBook_Account_Editor]
        [DisplayName("Account"), Size(25)]
        public String Account
        {
            get => fields.Account[this];
            set => fields.Account[this] = value;
        }

        [DisplayName("Description")]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
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

        public AccountingBookRow()
            : base()
        {
        }

        public AccountingBookRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public DateTimeField Date;
            public StringField Type;
            public Int32Field Amount;
            public StringField Category;
            public StringField Account;
            public StringField Description;
            public StringField UpdateUser;
            public DateTimeField UpdateDate;
        }
    }
}
