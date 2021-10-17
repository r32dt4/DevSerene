
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class CalendarGrid extends Serenity.EntityGrid<CalendarRow, any> {
        protected getColumnsKey() { return CalendarColumns.columnsKey; }
        protected getDialogType() { return CalendarDialog; }
        protected getIdProperty() { return CalendarRow.idProperty; }
        protected getInsertPermission() { return CalendarRow.insertPermission; }
        protected getLocalTextPrefix() { return CalendarRow.localTextPrefix; }
        protected getService() { return CalendarService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}