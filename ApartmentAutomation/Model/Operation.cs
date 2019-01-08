using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    class Operation
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    class Income : Operation
    {
        public int FlatNo { get; set; }
    }

    class Expense : Operation
    {
        public ExpenseType ExpenceName { get; set; }
        public int ExpenseID { get; set; }
    }

    public enum ExpenseType {
        Electric,
        Water,
        Elevator,
        Cleanliness
    }

    public enum Mounths
    {
        Ocak,
        Şubat,
        Mart,
        Nisan,
        Mayıs,
        Haziran,
        Temmuz,
        Ağustos,
        Eylül,
        Ekim,
        Kasım,
        Aralık
    }
}
