using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PartTimeEmployee partTime = new PartTimeEmployee(firstname.Text, lastname.Text, department.Text,jobtitle.Text);
            double hour = Convert.ToDouble(rateperhour.Text);
            int totalHour = Convert.ToInt32(totalhours.Text);
            partTime.computeSalary(totalHour, hour);

            string firstName = firstname.Text;
            label6.Text = firstName;
            string lastName = lastname.Text;    
            label7.Text = lastName;
            double salary = Convert.ToDouble(partTime.getSalary());
            label8.Text = salary.ToString();

        }
    }
}
