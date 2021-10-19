using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppEntityFramework.GUI
{
    public partial class TestForm2 : Form
    {
        EmployeeProjectDBEntities dBEntities = new EmployeeProjectDBEntities();
        public TestForm2()
        {
            InitializeComponent();
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            //LINQ to Entities
            var listEmp = (from emp in dBEntities.Employees
                           select emp).ToList<Employee>();

            foreach (Employee emp in listEmp)
            {
                comboBoxEmployee.Items.Add(emp.EmployeeId);
            }

            var listProj = (from prj in dBEntities.Projects
                            select prj).ToList<Project>();

            foreach (Project prj in listProj)
            {
                comboBoxProject.Items.Add(prj.ProjectCode);
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            Employee emp = new Employee();
            //LINQ to Entities
            emp = dBEntities.Employees.Where(x => x.EmployeeId == searchId).FirstOrDefault();
            labelEmpInfo.Text = emp.EmployeeId.ToString() + "," + emp.FirstName + "," + emp.LastName;
        }

        

        private void comboBoxProject_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string searchCode = comboBoxProject.SelectedItem.ToString();
            Project prj = new Project();
            prj = dBEntities.Projects.Where(p => p.ProjectCode == searchCode).FirstOrDefault();
            labelProjInfo.Text = prj.ProjectCode.ToString() + "," + prj.ProjectTitle;
        }
    }
}
