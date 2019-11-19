using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=chenna;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SMS values('" + txtStudentId.Text + "','" + txtStudentName.Text + "','" + txtStudentAddress.Text + "','" + txtStudentClass.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Inserted");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update SMS set Student_Id='" + txtStudentName.Text + "',Student_Address='" + txtStudentAddress.Text + "',Student_Class='" + txtStudentClass.Text + "' where Student_Id='"+txtStudentId.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Updated");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete SMS where Student_Id='" + txtStudentId.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Deleted");
            con.Close();
        }
    }
}
