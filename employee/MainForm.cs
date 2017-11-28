using EmployeeBusiness;
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {

            EmployeeModelClass obj = new EmployeeModelClass()
            {
                namep = nametextBox.Text,
                fathernamep = fathernametextBox.Text
            };

            CombineBusinessAndModelClass.combineData(obj);

            MessageBox.Show("Enter Data Successfully");
        }
    }
}
