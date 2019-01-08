using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation.BusinessLogic
{
    class ExpenseRepo
    {
        public List<Expense> expenseList { get; set; }
        public ExpenseRepo()
        {
            expenseList = new List<Expense>();
        }
        public List<Expense> GetExpense()
        {
            expenseList.Clear();
            DataTable dt = Program.sqlHelper.GetData("Select * From Expenses");
            foreach (DataRow item in dt.Rows)
            {
                Expense expense = new Expense();
                expense.Amount = (decimal)item["Amount"];
                expense.Date = (DateTime)item["Date"];
                expense.ExpenceName = (ExpenseType)item["ExpenseTypeID"];
                expense.ExpenseID = (int)item["ExpenseID"];

                expenseList.Add(expense);
            }

            return expenseList;
        }

        public void SaveToDatabase(Expense expense)
        {
            SqlParameter p1 = new SqlParameter("expenseTypeID", (int)expense.ExpenceName);
            SqlParameter p2 = new SqlParameter("date", expense.Date);
            SqlParameter p3 = new SqlParameter("amount", expense.Amount);
            SqlParameter p4 = new SqlParameter("expenseID", expense.ExpenseID);

            Program.sqlHelper.ExecuteProcedure("SaveExpenseData", p1, p2, p3, p4);
        }
    }
}
