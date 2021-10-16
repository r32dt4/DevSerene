namespace DevSerene.Default {
    export interface ToDoListForm {
        EventName: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        IsFinished: Serenity.BooleanEditor;
        CreateDate: Serenity.DateEditor;
        UpdateUser: Serenity.StringEditor;
        UpdateDate: Serenity.DateEditor;
    }

    export class ToDoListForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ToDoList';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ToDoListForm.init)  {
                ToDoListForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(ToDoListForm, [
                    'EventName', w0,
                    'Description', w1,
                    'StartDate', w2,
                    'EndDate', w2,
                    'IsFinished', w3,
                    'CreateDate', w2,
                    'UpdateUser', w0,
                    'UpdateDate', w2
                ]);
            }
        }
    }
}
