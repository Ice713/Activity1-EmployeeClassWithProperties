using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1___Employee_Class_with_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee(textBoxName.Text, int.Parse(textBoxID.Text), double.Parse(numericUpDownSalary.Text));

                labelEmployeeDetails.Text = emp.DisplayInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
    }
}
