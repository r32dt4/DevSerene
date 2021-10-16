using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace DevSerene.Default.Forms
{
    [FormScript("Default.AccountingBook")]
    [BasedOnRow(typeof(AccountingBookRow), CheckNames = true)]
    public class AccountingBookForm
    {
        [DefaultValue("now"), DateTimeEditor]
        public DateTime Date { get; set; }
        [DefaultValue("支出")]
        public String Type { get; set; }
        [DefaultValue("0")]
        public Int32 Amount { get; set; }
        [DefaultValue("飲食")]
        public String Category { get; set; }
        [DefaultValue("現金")]
        public String Account { get; set; }
        [TextAreaEditor]
        public String Description { get; set; }

        // hidden
        [Hidden]
        public String UpdateUser { get; set; }
        [Hidden]
        public DateTime UpdateDate { get; set; }
    }
}