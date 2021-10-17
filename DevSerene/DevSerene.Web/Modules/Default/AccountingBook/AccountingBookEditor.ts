
namespace DevSerene.Default {

    @Serenity.Decorators.registerEditor()
    export class AccountingBook_Expenditure_Category_Editor extends Serenity.SelectEditor {

        constructor(input: JQuery) {
            super(input, null);
            input.addClass("s-SelectEditor");
            this.addOption("飲食", "飲食");
            this.addOption("日常支出", "日常支出");
            this.addOption("固定繳費", "固定繳費");
            this.addOption("其他", "其他");
        }
    }

    @Serenity.Decorators.registerEditor()
    export class AccountingBook_Income_Category_Editor extends Serenity.SelectEditor {

        constructor(input: JQuery) {
            super(input, null);
            input.addClass("s-SelectEditor");
            this.addOption("工作收入", "工作收入");
            this.addOption("被動收入", "被動收入");
            this.addOption("其他", "其他");
        }
    }

    //@Serenity.Decorators.registerEditor()
    //export class AccountingBook_Category_Editor extends Serenity.SelectEditor {

    //    constructor(container: JQuery, type: string) {
    //        super(container);
    //        container.addClass("s-SelectEditor");

    //        if (type == "收入") {
    //            this.addOption("工作收入", "工作收入");
    //            this.addOption("被動收入", "被動收入");
    //            this.addOption("其他", "其他");
    //        } else {
    //            this.addOption("飲食", "飲食");
    //            this.addOption("日常支出", "日常支出");
    //            this.addOption("固定繳費", "固定繳費");
    //            this.addOption("其他", "其他");
    //        }


    //    }
    //}

    @Serenity.Decorators.registerEditor()
    export class AccountingBook_Category_Editor extends Serenity.SelectEditor {

        constructor(input: JQuery) {
            super(input, null);
            input.addClass("s-SelectEditor");
            this.addOption("工作收入", "收入 - 工作收入");
            this.addOption("被動收入", "收入 - 被動收入");
            this.addOption("飲食", "支出 - 飲食");
            this.addOption("日常支出", "支出 - 日常支出");
            this.addOption("固定繳費", "支出 - 固定繳費");
            this.addOption("其他", "其他");
        }
    }

    @Serenity.Decorators.registerEditor()
    export class AccountingBook_Account_Editor extends Serenity.SelectEditor {

        constructor(input: JQuery) {
            super(input, null);
            input.addClass("s-SelectEditor");
            this.addOption("現金", "現金");
            this.addOption("銀行帳戶", "銀行帳戶");
            this.addOption("其他", "其他");
        }
    }

    @Serenity.Decorators.registerEditor()
    export class AccountingBook_Type_Editor extends Serenity.SelectEditor {

        constructor(input: JQuery) {
            super(input, null);
            input.addClass("s-SelectEditor");
            this.addOption("支出", "支出");
            this.addOption("收入", "收入");
        }
    }
}