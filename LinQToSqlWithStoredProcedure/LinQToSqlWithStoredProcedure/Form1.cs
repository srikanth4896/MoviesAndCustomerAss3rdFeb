using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQToSqlWithStoredProcedure
{
    
    public partial class Form1 : Form
    {
        EmployeeTableLinqDataContext dbml = new EmployeeTableLinqDataContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowEmployee()
        {
            var emptab = from e1 in dbml.EmployeeTabs
                         select e1;
            dataGridView1.DataSource = emptab;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delEmp = dbml.sp_DeleteEmployee(Convert.ToInt32(txtEmployeeId.Text));
            //dbml.EmployeeTabs.DeleteOnSubmit(delEmp);
            dbml.SubmitChanges();
            ShowEmployee();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var empDetails = dbml.sp_InsertEmployee(Convert.ToString(txtEmployeeNAme.Text), Convert.ToDouble(txtEmployeeSalary.Text), Convert.ToInt32(txtDeptNo.Text));

           
            dbml.SubmitChanges();
            ShowEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           var updateDetails =  dbml.sp_UpdateEmployee(Convert.ToInt32(txtEmployeeId.Text), Convert.ToString(txtEmployeeNAme.Text), Convert.ToDouble(txtEmployeeSalary.Text), Convert.ToInt32(txtDeptNo.Text));
            dbml.SubmitChanges();
            MessageBox.Show("Suucessfully Updated");
            ShowEmployee();
        
                }
    }
}
