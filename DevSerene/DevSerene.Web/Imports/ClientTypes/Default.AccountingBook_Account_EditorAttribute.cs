using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevSerene.Default
{
    public partial class AccountingBook_Account_EditorAttribute : CustomEditorAttribute
    {
        public const string Key = "DevSerene.Default.AccountingBook_Account_Editor";

        public AccountingBook_Account_EditorAttribute()
            : base(Key)
        {
        }
    }
}
