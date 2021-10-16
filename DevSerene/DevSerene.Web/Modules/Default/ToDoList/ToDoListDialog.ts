
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class ToDoListDialog extends Serenity.EntityDialog<ToDoListRow, any> {
        protected getFormKey() { return ToDoListForm.formKey; }
        protected getIdProperty() { return ToDoListRow.idProperty; }
        protected getLocalTextPrefix() { return ToDoListRow.localTextPrefix; }
        protected getNameProperty() { return ToDoListRow.nameProperty; }
        protected getService() { return ToDoListService.baseUrl; }
        protected getDeletePermission() { return ToDoListRow.deletePermission; }
        protected getInsertPermission() { return ToDoListRow.insertPermission; }
        protected getUpdatePermission() { return ToDoListRow.updatePermission; }

        protected form = new ToDoListForm(this.idPrefix);

        protected username = Authorization.userDefinition.Username;

        constructor(container: JQuery) {
            super(container);

        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            this.form.UpdateUser.value = this.username;
        }
    }
}