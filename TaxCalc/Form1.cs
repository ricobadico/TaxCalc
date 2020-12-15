using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    /*
     * Gets total income from user,
     * runs calculation based on variable tax rates,
     * and outputs it to a read-only text box
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Initialize variables
            decimal baseTax;
            decimal excessTaxRate;
            decimal totalTax;
            decimal threshold;

            // Get income value from user input
            decimal income = Convert.ToDecimal(txtIncome.Text);

            // Assign tax values based on income
            if (income < 15000)
            {
                threshold = 0m;
                baseTax = 0m;
                excessTaxRate = .15m;
            }
            else if (income < 30000)
            {
                threshold = 15000m;
                baseTax = 2250m;
                excessTaxRate = 0.18m;
            }
            else if (income < 50000)
            {
                threshold = 30000m;
                baseTax = 4950m;
                excessTaxRate = 0.22m;
            }
            else if (income < 80000)
            {
                threshold = 50000m;
                baseTax = 9350m;
                excessTaxRate = 0.27m;
            }
            else
            {
                threshold = 80000m;
                baseTax = 17450m;
                excessTaxRate = 0.33m;
            }

            // Run calc
            totalTax = baseTax + (income - threshold) * excessTaxRate;

            // Return calculated value
            txtTotalTax.Text = totalTax.ToString("c");
        }

    }
}
