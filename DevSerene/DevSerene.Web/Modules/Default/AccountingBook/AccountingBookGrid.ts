
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class AccountingBookGrid extends Serenity.EntityGrid<AccountingBookRow, any> {
        protected getColumnsKey() { return AccountingBookColumns.columnsKey; }
        protected getDialogType() { return AccountingBookDialog; }
        protected getIdProperty() { return AccountingBookRow.idProperty; }
        protected getInsertPermission() { return AccountingBookRow.insertPermission; }
        protected getLocalTextPrefix() { return AccountingBookRow.localTextPrefix; }
        protected getService() { return AccountingBookService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}