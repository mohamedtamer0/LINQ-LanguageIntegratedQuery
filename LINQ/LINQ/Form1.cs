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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Employee[] employees = {
                new Employee() {Number = 1, Name="Mohamed",City="Giza", Salary = 3500, Child = new string[] { "omar","amr"} },
                new Employee() {Number = 2, Name="Ahmed",City="Cairo", Salary = 3500, Child = new string[] { "habiba","amr"} },
                new Employee() {Number = 3, Name="Ali",City="Giza", Salary = 3500, Child = new string[] { "omar","tamer"} },
                new Employee() {Number = 4, Name="Osama",City="Cairo", Salary = 8000},
                new Employee() {Number = 5, Name="Mohab",City="Giza", Salary = 7000, Child = new string[] { "joo","amr"} },
            };

        Phones[] phones =
        {
            new Phones() {Number =1 , Phone = "123456789" },
            new Phones() {Number =2 , Phone = "345345345" },
            new Phones() {Number =3 , Phone = "543453453" },
            new Phones() {Number =4 , Phone = "543452342" },
            new Phones() {Number =5 , Phone = "575675675" },
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
            //var all = from emps in employees select emps;
            //lbx.Items.Clear();

            //foreach (var x in all)
            //{
            //    lbx.Items.Add(x.Number + " ; " + x.Name + " ; " + x.City + " ; " + x.Salary);
            //}


            //var all = from emps in employees select emps.Name;
            //lbx.Items.Clear();

            //foreach (var x in all)
            //{
            //    lbx.Items.Add(x);
            //}

            //var r = from emps in employees select new { emps.Number , emps.Name};
            //lbx.Items.Clear();

            var r = employees.Select(emp => emp);

            foreach (var x in r)
            {
                lbx.Items.Add(x.Number + " - " + x.Name);
            }
        }


        private void btnWhere_Click(object sender, EventArgs e)
        {

            //var wer = from emps in employees where emps.Salary >= 5000 select emps;
            //lbx.Items.Clear();

            //foreach (var x in wer)
            //{
            //    lbx.Items.Add(x.Number + " - " + x.Name);
            //}



            //var wer = from emps in employees where emps.Salary >= 5000 && emps.City == "Cairo" select emps;
            //lbx.Items.Clear();

            //foreach (var x in wer)
            //{
            //    lbx.Items.Add(x.Number + " - " + x.Name);
            //}


            //var wer = from emps in employees where emps.Name.Contains("A") select emps;
            //lbx.Items.Clear();

            //var wer = employees.Where(emp => emp.Name.Contains("A")).Select(emp => emp);

            var wer = employees.Select(emp => emp).Where(emp => emp.Name.StartsWith("A"));

            foreach (var x in wer)
            {
                lbx.Items.Add(x.Number + " - " + x.Name);
            }

        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {

            //var order = from emps in employees orderby emps.Number descending select emps;
            //lbx.Items.Clear();

            //foreach (var x in order)
            //{
            //    lbx.Items.Add(x.Number + " - " + x.Name);
            //}


            var order = from emps in employees
                        where emps.Name.Contains("A")
                        orderby emps.Number descending select emps;
            lbx.Items.Clear();

            foreach (var x in order)
            {
                lbx.Items.Add(x.Number + " - " + x.Name);
            }

        }


        private void btnGroup_Click(object sender, EventArgs e)
        {
            var group = from emps in employees
                        group emps by emps.City;
            lbx.Items.Clear();

            foreach (var x in group)
            {
                lbx.Items.Add(x.Key);
                foreach (var y in x)
                {
                    lbx.Items.Add("   " + y.Name);
                }
            }
        }

        private void btnNestedQ_Click(object sender, EventArgs e)
        {
            //var nested = from emps in employees
            //             from childs in emps.Child
            //             select childs;


            //foreach (var x in nested)
            //{
            //    lbx.Items.Add(x);
            //}


            var nested = from emps in employees
                         where emps.Name == "Osama"
                         from childs in emps.Child
                         select childs;

            lbx.Items.Clear();
            foreach (var x in nested)
            {
                lbx.Items.Add(x);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var tel = from emps in employees
                      join tels in phones
                      on emps.Number equals tels.Number
                      select tels;
            lbx.Items.Clear();

            foreach (var x in tel)
            {
                lbx.Items.Add(x.Number + " >> " + x.Phone);
            }
        }

        private void btnJoin2_Click(object sender, EventArgs e)
        {
            var tel = from emps in employees
                      join tels in phones
                      on emps.Number equals tels.Number into phoneData
                      select new { emps , phoneData};
            lbx.Items.Clear();

            foreach (var x in tel)
            {
                lbx.Items.Add(x.emps.Name);
                foreach (var y in x.phoneData)
                {
                    lbx.Items.Add("     " + y.Phone);
                }
            }
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            var sal = from emp in employees
                      select emp.Salary;

            var salNoReapeat = sal.Distinct();

            lbx.Items.Clear();
            foreach (var s in salNoReapeat)
            {
                lbx.Items.Add(s);
            }
            label1.Text = lbx.Items.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAllSalary()
        {
            var sal = from emp in employees
                      select emp.Salary;

            lbx.Items.Clear();
            foreach(var s in sal)
            {
                lbx.Items.Add(s);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            ShowAllSalary();
            var SalSum = (from emp in employees select emp.Salary).Sum();
            label1.Text = SalSum + "";
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            ShowAllSalary();
            var SalSum = (from emp in employees select emp.Salary).Average();
            label1.Text = SalSum + "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            ShowAllSalary();
            var SalSum = (from emp in employees select emp.Salary).Min();
            label1.Text = SalSum + "";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            ShowAllSalary();
            var SalSum = (from emp in employees select emp.Salary).Max();
            label1.Text = SalSum + "";
        }

        private void btnAllAlias_Click(object sender, EventArgs e)
        {
            var r = from emps in employees
                    select new
                    {
                        EmpNO = emps.Number,
                        EmpName = emps.Name,
                        EmpCity = emps.City,
                        EmpSalary = emps.Salary
                    };
            lbx.Items.Clear();
            foreach(var x in r)
            {
                lbx.Items.Add(x.EmpNO + " ; " + x.EmpName + " ; " + x.EmpCity + " ; " + x.EmpSalary);
            }
        }

        private void btnFromDataSet_Click(object sender, EventArgs e)
        {
            DataTable tblEmp = new DataTable("emp");
            tblEmp.Columns.Add("number", typeof(int));
            tblEmp.Columns.Add("name");
            tblEmp.Columns.Add("city");
            tblEmp.Columns.Add("salary", typeof(int));

            tblEmp.Rows.Add(111,  "Mohamed",  "Giza",  3500);
            tblEmp.Rows.Add( 222,  "Ahmed",  "Cairo",  3500);
            tblEmp.Rows.Add(333, Name = "Ali", "Giza",  3500);
            tblEmp.Rows.Add(444, Name = "Osama","Cairo",8000);
            tblEmp.Rows.Add(555,"Mohab","Giza", 7000);

            DataSet ds = new DataSet("com");
            ds.Tables.Add(tblEmp);

            var r = from emp in ds.Tables[0].AsEnumerable()
                    select new
                    {
                        Number = emp[0],
                        Name = emp[1],
                        City = emp[2],
                        Salary = emp[3]
                    };


            //var r = from emp in ds.Tables[0].AsEnumerable()
            //        where emp[1].ToString().Contains("A")
            //        orderby emp[0] descending
            //        select new
            //        {
            //            Number = emp[0],
            //            Name = emp[1],
            //            City = emp[2],
            //            Salary = emp[3]
            //        };

            lbx.Items.Clear();
            foreach(var x in r)
            {
                lbx.Items.Add(x.Number + " ; " + x.Name + " ; " + x.City + " ; " + x.Salary);
            }
        }

        delegate void Hello();
        delegate void SayHello(string name);
        delegate int Calc(int num1, int num2);
        private void btnLambda_Click(object sender, EventArgs e)
        {
            Hello h1 = () => MessageBox.Show("Hello 1");
            //h1();

            Hello h2 = () =>
            {
                MessageBox.Show("Hello 1");
                MessageBox.Show("Hello 2");
                MessageBox.Show("Hello 3");
            };
            //h2();

            SayHello h3 = (myname) => MessageBox.Show("Hello " + myname);
            //h3("Mohamed");


            Calc cAdd = (num1, num2) => num1 + num2;

            int i1 = cAdd(5, 7);
            MessageBox.Show(i1+"");
        }

        private void btnSelectMany_Click(object sender, EventArgs e)
        {
            var r = employees.SelectMany(emp => emp.Child);
            lbx.Items.Clear();
            foreach(var x in r)
            {
                lbx.Items.Add(x);
            }
        }
    }
}
