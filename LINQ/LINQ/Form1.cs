﻿using System;
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

            var r = from emps in employees select new { emps.Number , emps.Name};
            lbx.Items.Clear();

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


            var wer = from emps in employees where emps.Name.Contains("A") select emps;
            lbx.Items.Clear();

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
                         where emps.Name == "Mohamed"
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
    }
}
