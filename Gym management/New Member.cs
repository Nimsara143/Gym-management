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


namespace Gym_management
{
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            
            String fname = firstname.Text;
            String lname = lastname.Text;
            String gender = "";

            bool isChecked = rad1.Checked;
            if (isChecked)
            {
                gender= rad1.Text;

            }
            else
            {gender=rad2.Text;

            }
            String dob = dateofbirth.Text;
            Int64 mobile= Int64.Parse(mobileno.Text);
            String email = emailA.Text;
            String jdate = joindate.Text;
            String mcity = city.Text;
            String mweight = weight.Text;
            String mtime = time.Text;
            String address = maddress.Text;
            String membtime = memtime.Text;

            /* 
           SqlConnection con = new SqlConnection();
           //con.ConnectionString = "data sourse = DESKTOP-ORFTIO1\\SQLEXPRESS database  gym_management; intergrated security = True";
           con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anims\\OneDrive\\Documents\\Gym Manage.mdf;Integrated Security=True;Connect Timeout=30";

           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;

           cmd.CommandText = "Insert Into [Newmember](Fname,Lname,Gender,Dob,Mobile,Email,MWeight,JoinDate,City,Gtime,Maddress,MembershipTime) values ('" + firstname+ "','" + lastname + "','" + gender + "','" + dateofbirth + "'," + mobileno + ",'" + emailA + "','" + joindate + "','" + city + "','" + weight + "','" + time + "''" + maddress + "','" + memtime + "')";

           SqlDataAdapter DA = new SqlDataAdapter(cmd);
           DataSet DS = new DataSet();
           DA.Fill(DS,"Newmember");

           MessageBox.Show("Data Saved.");

            */
            SqlConnection con = new SqlConnection();
           con.ConnectionString = "Data Source=DESKTOP-ORFTIO1\\SQLEXPRESS;Initial Catalog=gym_management;Integrated Security=True;";



           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;

           cmd.CommandText = "Insert Into [Newmember](Fname,Lname,Gender,Dob,Mobile,Email,MWeight,JoinDate,City,Gtime,Maddress,MembershipTime) " +
                "VALUES ('" + firstname + "','" + lastname + "','" + gender + "','" + dateofbirth + "'," + mobileno + ",'" + emailA + "','" + joindate + "','" + city + "','" + weight + "','" + time + "''" + maddress + "','" + memtime + "')";

           try
           {
               con.Open();
               cmd.ExecuteNonQuery();
               MessageBox.Show("Data Saved.");
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error: " + ex.Message);
           }
           finally
           {
               con.Close();
           }
          
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void New_Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_managementDataSet1.Newmember' table. You can move, or remove it, as needed.
            this.newmemberTableAdapter1.Fill(this.gym_managementDataSet1.Newmember);
            // TODO: This line of code loads data into the 'gym_managementDataSet.Newmember' table. You can move, or remove it, as needed.
            this.newmemberTableAdapter.Fill(this.gym_managementDataSet.Newmember);

        }

        private void rest_Click(object sender, EventArgs e)
        {
            firstname.Clear();
            lastname.Clear();

            rad1.Checked = false;
            rad2.Checked= false;

            dateofbirth.Value = DateTime.Now;
            joindate.Value = DateTime.Now;
            mobileno.Clear();
            emailA.Clear();
            weight.Clear();
            maddress.Clear();
            memtime.ResetText();
            time.ResetText();
            city.Clear();
            
        }
    }
}
