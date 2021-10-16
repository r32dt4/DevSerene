using Serenity.Navigation;
using MyPages = DevSerene.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/To Do List", typeof(MyPages.ToDoListController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Accounting Book", typeof(MyPages.AccountingBookController), icon: null)]