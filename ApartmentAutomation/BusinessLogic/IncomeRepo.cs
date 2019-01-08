using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    class IncomeRepo
    {
        public List<Income> incomeList { get; set; }
        public IncomeRepo()
        {
            incomeList = new List<Income>();
        }
        public List<Income> GetIncome()
        {
            DataTable dt = Program.sqlHelper.GetData("Select * From Incomes");
            foreach (DataRow item in dt.Rows)
            {
                Income income = new Income();
                income.Amount = (decimal)item["Amount"];
                income.Date = (DateTime)item["Date"];
                income.FlatNo = (int)item["FlatNo"];

                incomeList.Add(income);
            }

            return incomeList;
        }

        public void SaveToDatabase(Income income)
        {
            SqlParameter p1 = new SqlParameter("flatNo", income.FlatNo);
            SqlParameter p2 = new SqlParameter("amount", income.Amount);
            SqlParameter p3 = new SqlParameter("date", income.Date);

            Program.sqlHelper.ExecuteProcedure("SaveIncomeData", p1, p2, p3);
        }
    }
}
