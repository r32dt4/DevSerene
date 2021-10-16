namespace DevSerene.Default {
    export interface AccountingBookForm {
        Date: Serenity.DateTimeEditor;
        Type: AccountingBook_Type_Editor;
        Amount: Serenity.IntegerEditor;
        Category: AccountingBook_Expenditure_Category_Editor;
        Account: AccountingBook_Account_Editor;
        Description: Serenity.TextAreaEditor;
        UpdateUser: Serenity.StringEditor;
        UpdateDate: Serenity.DateEditor;
    }

    export class AccountingBookForm extends Serenity.PrefixedContext {
        static formKey = 'Default.AccountingBook';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AccountingBookForm.init)  {
                AccountingBookForm.init = true;

                var s = Serenity;
                var w0 = s.DateTimeEditor;
                var w1 = AccountingBook_Type_Editor;
                var w2 = s.IntegerEditor;
                var w3 = AccountingBook_Expenditure_Category_Editor;
                var w4 = AccountingBook_Account_Editor;
                var w5 = s.TextAreaEditor;
                var w6 = s.StringEditor;
                var w7 = s.DateEditor;

                Q.initFormType(AccountingBookForm, [
                    'Date', w0,
                    'Type', w1,
                    'Amount', w2,
                    'Category', w3,
                    'Account', w4,
                    'Description', w5,
                    'UpdateUser', w6,
                    'UpdateDate', w7
                ]);
            }
        }
    }
}
