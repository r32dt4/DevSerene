namespace DevSerene.Default {
    export interface CalendarForm {
        Title: Serenity.StringEditor;
        Username: Serenity.StringEditor;
        Event: Serenity.StringEditor;
        Note: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        AllDay: Serenity.BooleanEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        BackGroundColor: Serenity.StringEditor;
        BorderColor: Serenity.StringEditor;
        UpdateUser: Serenity.StringEditor;
        UpdateDate: Serenity.DateEditor;
    }

    export class CalendarForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Calendar';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CalendarForm.init)  {
                CalendarForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;
                var w2 = s.DateEditor;

                Q.initFormType(CalendarForm, [
                    'Title', w0,
                    'Username', w0,
                    'Event', w0,
                    'Note', w0,
                    'Description', w0,
                    'AllDay', w1,
                    'StartDate', w2,
                    'EndDate', w2,
                    'BackGroundColor', w0,
                    'BorderColor', w0,
                    'UpdateUser', w0,
                    'UpdateDate', w2
                ]);
            }
        }
    }
}
