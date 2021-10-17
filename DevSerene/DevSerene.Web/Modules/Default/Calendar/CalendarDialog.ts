
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class CalendarDialog extends Serenity.EntityDialog<CalendarRow, any> {
        protected getFormKey() { return CalendarForm.formKey; }
        protected getIdProperty() { return CalendarRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarRow.localTextPrefix; }
        protected getNameProperty() { return CalendarRow.nameProperty; }
        protected getService() { return CalendarService.baseUrl; }
        protected getDeletePermission() { return CalendarRow.deletePermission; }
        protected getInsertPermission() { return CalendarRow.insertPermission; }
        protected getUpdatePermission() { return CalendarRow.updatePermission; }

        protected form = new CalendarForm(this.idPrefix);

    }
}