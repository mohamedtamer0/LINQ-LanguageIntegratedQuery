using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class frmLinqTest : Form
    {
        public frmLinqTest()
        {
            InitializeComponent();
        }

        Employee[] employees =
{
                new Employee() {Number = 1, Name="Mohamed",City="Giza", Salary = 3500 },
                new Employee() {Number = 1, Name="Ahmed",City="Cairo", Salary = 3500 },
                new Employee() {Number = 1, Name="Ali",City="Giza", Salary = 3500 },
                new Employee() {Number = 1, Name="Osama",City="Cairo", Salary = 3500 },
                new Employee() {Number = 1, Name="Mohab",City="Giza", Salary = 3500 },
            };




        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            //foreach (Employee emp in employees)
            //{
            //    lbx.Items.Add(emp.Number + " ; " + emp.Name + " ; " + emp.City + " ; " + emp.Salary);
            //}
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            var all = from emps in employees select emps;
            lbx.Items.Clear();

            foreach (var x in all)
            {
                lbx.Items.Add(x.Number + " ; " + x.Name + " ; " + x.City + " ; " + x.Salary);
            }
        }
    }
}
