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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.incomeRepo.GetIncome();
        }

        private void btn_AddIncome_Click(object sender, EventArgs e)
        {
            Income inc = new Income();
            inc.Amount = Convert.ToDecimal(tb_Amount.Text);
            inc.Date = Convert.ToDateTime(dateTimePicker1.Text);
            inc.FlatNo = (int)numeric_FlatNo.Value;
            Program.incomeRepo.SaveToDatabase(inc);

            Incomes_Load(sender, e);
        }
    }
}
