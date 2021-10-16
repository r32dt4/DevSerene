using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace DevSerene.Default.Forms
{
    [FormScript("Default.ToDoList")]
    [BasedOnRow(typeof(ToDoListRow), CheckNames = true)]
    public class ToDoListForm
    {
        public String EventName { get; set; }
        [TextAreaEditor]
        public String Description { get; set; }
        [DefaultValue("now")]
        public DateTime StartDate { get; set; }
        [DefaultValue("now")]
        public DateTime EndDate { get; set; }
        public Boolean IsFinished { get; set; }

        // hidden
        [Hidden, DefaultValue("now")]
        public DateTime CreateDate { get; set; }
        [Hidden]
        public String UpdateUser { get; set; }
        [Hidden]
        public DateTime UpdateDate { get; set; }
    }
}