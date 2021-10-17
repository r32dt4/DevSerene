
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

        //public type: string;
        //accountingBook_Category_Editor: AccountingBook_Category_Editor;

        constructor(container: JQuery) {
            super(container);

        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            //var thisform = this.form;

            // 最後更新人員為登入人員
            this.form.UpdateUser.value = this.username;

            //// 收入支出切換功能
            //this.form.Type.change(e => {
            //    this.type = this.form.Type.value;
            //    // 如果category有item的話就先清除
            //    this.form.Category.clearItems();
            //    this.accountingBook_Category_Editor = new AccountingBook_Category_Editor(thisform.Category.element, this.type);
            //    this.accountingBook_Category_Editor.element.change();
            //});


        }
    }
}