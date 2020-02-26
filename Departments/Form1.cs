using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source=DESKTOP-2JCI7CD;Initial Catalog=CompanyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDepartments();
        }
        private void FillDepartments()
        {
            using (SqlConnection dptConnection = new SqlConnection())
            {

                dptConnection.ConnectionString = connectionString;
                dptConnection.Open();
                string strSQL = "Select * From Departments ORDER BY dpt_ID";
                SqlDataAdapter dAdapt = new SqlDataAdapter(strSQL, dptConnection);
                DataSet dptDS = new DataSet("Departments");
                dAdapt.Fill(dptDS, "Departments");
                cmb_Departments.DisplayMember = "dpt_Name";
                cmb_Departments.ValueMember = "dpt_ID";
                cmb_Departments.DataSource = dptDS.Tables["Departments"];
            }
        }

        private void cmb_Departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Departments.SelectedIndex < 0)
                return;
            string dpt_ID = cmb_Departments.SelectedValue.ToString();
            string strSQL = "Select * From Employees Where dpt_ID = " + dpt_ID;




            SqlConnection empConnection = new SqlConnection();
            empConnection.ConnectionString = connectionString;
            empConnection.Open();
            SqlDataAdapter dAdapt = new SqlDataAdapter(strSQL, empConnection);
            DataTable table = new DataTable();
            dAdapt.Fill(table);
            dGrdViewEmployees.DataSource = table;
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection dptConnection = new SqlConnection())
            {
                dptConnection.ConnectionString = connectionString;
                dptConnection.Open();
                var comand = new SqlCommand("Insert Into  Employees (dpt_ID,emp_FirstName,emp_LastName,emp_Patronymic,emp_BirdtDay) " +
                  $"VALUES (@dpt_ID,@emp_FirstName,@emp_LastName,@emp_Patronymic,@emp_BirdtDay)", dptConnection);
                comand.Parameters.AddWithValue("dpt_ID", ID_TextBox.Text);
                comand.Parameters.AddWithValue("emp_FirstName", Name_TextBox.Text);
                comand.Parameters.AddWithValue("emp_LastName", SurName_TextBox.Text);
                comand.Parameters.AddWithValue("emp_Patronymic", Patro_TextBox.Text);
                comand.Parameters.AddWithValue("emp_BirdtDay", Birt_TextBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show($"Added objects");
            }

        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection dptConnection = new SqlConnection())
            {
                dptConnection.ConnectionString = connectionString;
                dptConnection.Open();
                var comand = new SqlCommand($"DELETE Employees  WHERE [emp_ID]=@emp_ID", dptConnection);
                comand.Parameters.AddWithValue("emp_ID", Delete_Update_TextBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show($"Deleted objects");
            }

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection dptConnection = new SqlConnection())
            {
                dptConnection.ConnectionString = connectionString;
                dptConnection.Open();
                var comand = new SqlCommand("Update Employees Set[dpt_ID]=@dpt_ID,[emp_FirstName]=@emp_FirstName," +
                    "[emp_LastName]=@emp_LastName,[emp_Patronymic]=@emp_Patronymic,[emp_BirdtDay]=@emp_BirdtDay Where[emp_ID]=@emp_ID ", dptConnection);
                comand.Parameters.AddWithValue("dpt_ID", ID_TextBox.Text);
                comand.Parameters.AddWithValue("emp_FirstName", Name_TextBox.Text);
                comand.Parameters.AddWithValue("emp_LastName", SurName_TextBox.Text);
                comand.Parameters.AddWithValue("emp_Patronymic", Patro_TextBox.Text);
                comand.Parameters.AddWithValue("emp_BirdtDay", Birt_TextBox.Text);
                comand.Parameters.AddWithValue("emp_ID", Delete_Update_TextBox.Text);
                comand.ExecuteNonQuery();
                MessageBox.Show($"Updated objects");
            }

        }
    }
}
