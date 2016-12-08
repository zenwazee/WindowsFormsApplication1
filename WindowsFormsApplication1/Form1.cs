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



namespace WindowsFormsApplication1
{
    public partial class btnRef : Form
    {
        public btnRef()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Module' table. You can move, or remove it, as needed.
            moduleTableAdapter.Fill(database1DataSet.Module);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::WindowsFormsApplication1.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                //Here I created a line of code inorder to add into our Database "Module" the fields ModuleCode, Module Tutor Etc 
                string sql = "INSERT INTO Module (ModuleCode , ModuleName , ModuleTutor , CourseworkNo , CourseworkTitle, IssueDate , DueDateandtime , Modulemark , AssessmentGrouporIndividual) values ( '"+txtmodule.Text +"', '"+moduletxt.Text+"', '"+tutortxt.Text+"', '"+cwknoTxt.Text+"', '"+textBox6.Text+"', '"+textBox3.Text+"', '"+textBox5.Text+"', '"+textBox4.Text+"', '"+textBox7.Text+"' )";
                SqlCommand exeSql = new SqlCommand(sql , cn);  
                cn.Open();
                exeSql.ExecuteNonQuery();
                // Below i inserted a line of code that would display whenever a record was inputed into the Database
                MessageBox.Show("Added Record Inputed!", "Message Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.moduleTableAdapter.Fill(this.database1DataSet.Module);  
                // Below I just added a line of code to display "Error" when the wrong parameters have been inputed into the database     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            // Line of code to close connection
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.moduleTableAdapter.Fill(this.database1DataSet.Module);
        }
    }
}
