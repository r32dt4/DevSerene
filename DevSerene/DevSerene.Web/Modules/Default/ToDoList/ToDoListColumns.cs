using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace DevSerene.Default.Columns
{
    [ColumnsScript("Default.ToDoList")]
    [BasedOnRow(typeof(ToDoListRow), CheckNames = true)]
    public class ToDoListColumns
    {
        [EditLink, QuickFilter]
        public Boolean IsFinished { get; set; }
        [EditLink]
        public String EventName { get; set; }
        [EditLink]
        public String Description { get; set; }
        [EditLink, QuickFilter]
        public DateTime StartDate { get; set; }
        [EditLink, QuickFilter]
        public DateTime EndDate { get; set; }
        [EditLink, QuickFilter]
        public DateTime CreateDate { get; set; }
    }
}