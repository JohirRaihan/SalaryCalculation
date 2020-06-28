using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalSalaryButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            aSalary.houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double totalSalary = aSalary.CalculateTotalSalary();
            totalSalaryTextBox.Text = totalSalary.ToString();
        }
    }
}
