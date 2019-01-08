using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.expenseRepo.GetExpense();
            
        }

        private void btn_AddExpense_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            exp.Amount = Convert.ToDecimal(tb_Amount.Text);
            exp.Date = Convert.ToDateTime(dateTimePicker1.Text);
            exp.ExpenceName = ChooseExpenseType();
            exp.ExpenseID = (int)ChooseExpenseType();

            Program.expenseRepo.SaveToDatabase(exp);

            Expenses_Load(sender, e);
        }

        private ExpenseType ChooseExpenseType()
        {
            if (radio_Electric.Checked == true)
                return ExpenseType.Electric;
            if (radio_Water.Checked == true)
                return ExpenseType.Water;
            if (radio_Cleanliness.Checked == true)
                return ExpenseType.Cleanliness;
            else
                return ExpenseType.Elevator;
        }

        private void Expenses_Shown(object sender, EventArgs e)
        {
            AddMountToCombobox();
        }

        private void AddMountToCombobox()
        {
            foreach (string item in Enum.GetNames(typeof(Mounths)))
                cbox_Mounths.Items.Add(item);
        }

        private void cbox_Mounths_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Expense> expList = Program.expenseRepo.GetExpense();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = expList.Where(x => x.Date.ToString("MMMM") == cbox_Mounths.SelectedText).ToList();
        }
    }
}
