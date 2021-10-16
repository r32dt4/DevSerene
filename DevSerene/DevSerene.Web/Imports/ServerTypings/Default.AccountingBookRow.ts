namespace DevSerene.Default {
    export interface AccountingBookRow {
        Id?: number;
        Date?: string;
        Type?: string;
        Amount?: number;
        Category?: string;
        Account?: string;
        Description?: string;
        UpdateUser?: string;
        UpdateDate?: string;
    }

    export namespace AccountingBookRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Type';
        export const localTextPrefix = 'Default.AccountingBook';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Date = "Date",
            Type = "Type",
            Amount = "Amount",
            Category = "Category",
            Account = "Account",
            Description = "Description",
            UpdateUser = "UpdateUser",
            UpdateDate = "UpdateDate"
        }
    }
}
