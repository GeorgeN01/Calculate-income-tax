using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_income_tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
            //George Njubi
            //04/26/2020
            //Exercise 5-3 Calculate Income Tax
        {
            decimal TaxableIncome = Convert.ToDecimal(txtIncome.Text);
            decimal IncomeTaxOwed = 0m;


            if (TaxableIncome <= 9225)
                IncomeTaxOwed = (int)(TaxableIncome * .1m);

            //$9225 - $37450
            else if (TaxableIncome > 9225 && TaxableIncome <= 37450)
                IncomeTaxOwed = 922.50m + (int)((TaxableIncome - 9225) * .15m);

            //37450 - 90750
            else if (TaxableIncome > 37450 && TaxableIncome <= 90750)
                IncomeTaxOwed = 5156.25m + (int)((TaxableIncome - 37450) * .25m);

            //90750 - 189300
            else if (TaxableIncome > 90750 && TaxableIncome <= 189300)
                IncomeTaxOwed = 18481.25m + (int)((TaxableIncome - 90750) * .28m);

            //189300 - 411500
            else if (TaxableIncome > 189300 && TaxableIncome <= 411500)
                IncomeTaxOwed = 46075.25m + (int)((TaxableIncome - 189300) * .33m);

            //411500 - 413200
            else if (TaxableIncome > 411500 && TaxableIncome <= 413200)
                IncomeTaxOwed = 119401.25m + (int)((TaxableIncome - 411500) * .35m);

            //413200 and above
            else
                IncomeTaxOwed = 119996.25m + (int)((TaxableIncome - 413200) * .396m);

            //Writing calculated tax to form  
            txtTax.Text = IncomeTaxOwed.ToString();

        }
    }
}
