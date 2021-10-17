namespace DevSerene.Default {
    export interface CalendarRow {
        Id?: number;
        Title?: string;
        Username?: string;
        Event?: string;
        Note?: string;
        Description?: string;
        AllDay?: boolean;
        StartDate?: string;
        EndDate?: string;
        BackGroundColor?: string;
        BorderColor?: string;
        UpdateUser?: string;
        UpdateDate?: string;
    }

    export namespace CalendarRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Calendar';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Title = "Title",
            Username = "Username",
            Event = "Event",
            Note = "Note",
            Description = "Description",
            AllDay = "AllDay",
            StartDate = "StartDate",
            EndDate = "EndDate",
            BackGroundColor = "BackGroundColor",
            BorderColor = "BorderColor",
            UpdateUser = "UpdateUser",
            UpdateDate = "UpdateDate"
        }
    }
}
