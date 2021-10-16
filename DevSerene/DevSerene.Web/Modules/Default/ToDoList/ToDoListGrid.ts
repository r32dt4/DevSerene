
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class ToDoListGrid extends Serenity.EntityGrid<ToDoListRow, any> {
        protected getColumnsKey() { return ToDoListColumns.columnsKey; }
        protected getDialogType() { return ToDoListDialog; }
        protected getIdProperty() { return ToDoListRow.idProperty; }
        protected getInsertPermission() { return ToDoListRow.insertPermission; }
        protected getLocalTextPrefix() { return ToDoListRow.localTextPrefix; }
        protected getService() { return ToDoListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}