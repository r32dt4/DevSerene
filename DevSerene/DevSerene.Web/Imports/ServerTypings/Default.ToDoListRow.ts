namespace DevSerene.Default {
    export interface ToDoListRow {
        Id?: number;
        EventName?: string;
        Description?: string;
        CreateDate?: string;
        StartDate?: string;
        EndDate?: string;
        IsFinished?: boolean;
        UpdateUser?: string;
        UpdateDate?: string;
    }

    export namespace ToDoListRow {
        export const idProperty = 'Id';
        export const nameProperty = 'EventName';
        export const localTextPrefix = 'Default.ToDoList';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            EventName = "EventName",
            Description = "Description",
            CreateDate = "CreateDate",
            StartDate = "StartDate",
            EndDate = "EndDate",
            IsFinished = "IsFinished",
            UpdateUser = "UpdateUser",
            UpdateDate = "UpdateDate"
        }
    }
}
