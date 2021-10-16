﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevSerene.Default
{
    public partial class AccountingBook_Income_Category_EditorAttribute : CustomEditorAttribute
    {
        public const string Key = "DevSerene.Default.AccountingBook_Income_Category_Editor";

        public AccountingBook_Income_Category_EditorAttribute()
            : base(Key)
        {
        }
    }
}
