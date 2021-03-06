using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace DevSerene.Default.Forms
{
    [FormScript("Default.Calendar")]
    [BasedOnRow(typeof(CalendarRow), CheckNames = true)]
    public class CalendarForm
    {
        public String Title { get; set; }
        public String Username { get; set; }
        public String Event { get; set; }
        public String Note { get; set; }
        public String Description { get; set; }
        public Boolean AllDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String BackGroundColor { get; set; }
        public String BorderColor { get; set; }
        public String UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}