using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace DevSerene.Default.Columns
{
    [ColumnsScript("Default.AccountingBook")]
    [BasedOnRow(typeof(AccountingBookRow), CheckNames = true)]
    public class AccountingBookColumns
    {
        [EditLink, QuickFilter]
        public DateTime Date { get; set; }
        [EditLink, QuickFilter]
        public String Type { get; set; }
        [EditLink]
        public Int32 Amount { get; set; }
        [EditLink, QuickFilter]
        public String Category { get; set; }
        [EditLink]
        public String Account { get; set; }
        [EditLink]
        public String Description { get; set; }
    }
}