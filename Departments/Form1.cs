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
                dGrdViewEmployees.MultiSelect = false;

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
        private void DGrdViewEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dGrdViewEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dGrdViewEmployees.CurrentRow.Selected = true;
                Delete_Update_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["emp_ID"].FormattedValue.ToString();
                dpt_Id_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["dpt_ID"].FormattedValue.ToString();
                Name_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["emp_FirstName"].FormattedValue.ToString();
                SurName_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["emp_LastName"].FormattedValue.ToString();
                Patro_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["emp_Patronymic"].FormattedValue.ToString();
                Birt_TextBox.Text = dGrdViewEmployees.Rows[e.RowIndex].Cells["emp_BirdtDay"].FormattedValue.ToString();
            }

        }
        private void Delete()
        {
            if (MessageBox.Show("Sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int index = dGrdViewEmployees.SelectedRows[0].Index;
                dGrdViewEmployees.Rows.RemoveAt(index);
                ClearTxt();
                
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        { 
            Delete();
        }
        private void ClearTxt()
        {
            Delete_Update_TextBox.Text = "";
            dpt_Id_TextBox.Text = "";
            Name_TextBox.Text = "";
            SurName_TextBox.Text = "";
            Patro_TextBox.Text = "";
            Birt_TextBox.Text = "";

        }
        private void Add()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                var command = new SqlCommand($"INSERT INTO Employees (emp_FirstName,emp_LastName, emp_Patronymic,emp_BirdtDay,dpt_ID) " +
                  $"VALUES (@emp_FirstName,@emp_LastName,@emp_Patronymic,@emp_BirdtDay,@dpt_ID)", connection);
                command.Parameters.AddWithValue("emp_FirstName", Name_TextBox.Text);
                command.Parameters.AddWithValue("emp_LastName", SurName_TextBox.Text);
                command.Parameters.AddWithValue("emp_Patronymic", Patro_TextBox.Text);
                command.Parameters.AddWithValue("emp_BirdtDay", Birt_TextBox.Text);
                command.Parameters.AddWithValue("dpt_ID", dpt_Id_TextBox.Text);

                command.ExecuteNonQuery();
                MessageBox.Show($"Added objects");
                dGrdViewEmployees();
            }
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            UpdateElments();
        }
        private void UpdateElments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                if (connection.State != ConnectionState.Open)
                    connection.Open();
                var command = new SqlCommand($"Update Employees Set [emp_FirstName] =@emp_FirstName ,[emp_LastName] = @emp_LastName, [emp_Patronymic]=@emp_Patronymic,[emp_BirdtDay]=@emp_BirdtDay," +
                                             $"[dpt_ID]=@dpt_ID Where [emp_ID]=@emp_ID ", connection);
                command.Parameters.AddWithValue("emp_FirstName", Name_TextBox.Text);
                command.Parameters.AddWithValue("emp_LastName", SurName_TextBox.Text);
                command.Parameters.AddWithValue("emp_Patronymic", Patro_TextBox.Text);
                command.Parameters.AddWithValue("emp_BirdtDay", Birt_TextBox.Text);
                command.Parameters.AddWithValue("dpt_ID", dpt_Id_TextBox.Text);
                command.Parameters.AddWithValue("emp_ID", Delete_Update_TextBox.Text);


                command.ExecuteNonQuery();
                MessageBox.Show($"Added objects");
            }

        }
    }
}
