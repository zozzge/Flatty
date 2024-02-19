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
        public static string UserNameValid = "Username valid";

        public static string UserAddFail = "User creation failed.";
        public static string UserDeleteFail = "User deletion failed.";
        public static string UserUpdateFail = "User update failed.";
        public static string UserNotFound = "User not found.";
        public static string UserNameInvalid = "Username invalid";
        public static string UserNameAlreadyExists = "Username already exists.";

        public static string GroupAddSuccess = "Group created successfully.";
        public static string GroupDeleteSuccess = "Group deleted successfully.";
        public static string GroupUpdateSuccess = "Group updated successfully.";
        public static string GroupListedSuccess = "Groups listed successfully.";


        public static string GroupAddFail = "Group creation failed.";
        public static string GroupDeleteFail = "Group deletion failed.";
        public static string GroupUpdateFail = "Group update failed.";
        public static string GroupListedFail = "Group list failed.";

        public static string ExpenseAddSuccess = "Expense added successfully.";
        public static string ExpenseDeleteSuccess = "Expense deleted successfully.";
        public static string ExpenseUpdateSuccess = "Expense updated successfully.";
        public static string ExpensesListedSuccess = "Expenses listed successfully.";

        public static string ExpenseAddFail = "Expense creation failed.";
        public static string ExpenseDeleteFail = "Expense deletion failed.";
        public static string ExpenseUpdateFail = "Expense update failed.";
        public static string ExpensesListedFailed = "Expense list failed.";

        public static string AuthorizationDenied = "You don't have authorization.";

        public static string BalanceUpdated = "Balance is updated due to expense adding.";








    }
}
