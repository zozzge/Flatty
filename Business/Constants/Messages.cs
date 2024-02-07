using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static: don't need to new
    public static class Messages
    {
        public static string UserAddSuccess = "User added successfully.";
        public static string UserDeleteSuccess = "User deleted successfully.";
        public static string UserUpdateSuccess = "User updated successfully.";
        public static string UserFound = "User found.";


        public static string UserAddFail = "User creation failed.";
        public static string UserDeleteFail = "User deletion failed.";
        public static string UserUpdateFail = "User update failed.";
        public static string UserNotFound = "User not found.";

        public static string GroupAddSuccess = "Group created successfully.";
        public static string GroupDeleteSuccess = "Group deleted successfully.";
        public static string GroupUpdateSuccess = "Group updated successfully.";
        public static string GroupListedSuccess = "Groups listed successfully.";


        public static string GroupAddFail = "Group creation failed.";
        public static string GroupDeleteFail = "Group deletion failed.";
        public static string GroupUpdateFail = "Group update failed.";
        public static string GroupListedFail = "Group list failed.";

        public const string ExpenseAddSuccess = "Expense added successfully.";
        public const string ExpenseDeleteSuccess = "Expense deleted successfully.";
        public const string ExpenseUpdateSuccess = "Expense updated successfully.";
        public static string ExpensesListedSuccess = "Expenses listed successfully.";

        public const string ExpenseAddFail = "Expense creation failed.";
        public const string ExpenseDeleteFail = "Expense deletion failed.";
        public const string ExpenseUpdateFail = "Expense update failed.";
        public static string ExpensesListedFailed = "Expense list failed.";







    }
}
