
namespace DevSerene.Default {

    @Serenity.Decorators.registerClass()
    export class AccountingBookDialog extends Serenity.EntityDialog<AccountingBookRow, any> {
        protected getFormKey() { return AccountingBookForm.formKey; }
        protected getIdProperty() { return AccountingBookRow.idProperty; }
        protected getLocalTextPrefix() { return AccountingBookRow.localTextPrefix; }
        protected getNameProperty() { return AccountingBookRow.nameProperty; }
        protected getService() { return AccountingBookService.baseUrl; }
        protected getDeletePermission() { return AccountingBookRow.deletePermission; }
        protected getInsertPermission() { return AccountingBookRow.insertPermission; }
        protected getUpdatePermission() { return AccountingBookRow.updatePermission; }

        protected form = new AccountingBookForm(this.idPrefix);

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