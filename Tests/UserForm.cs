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

namespace Tests
{
    public partial class UserForm : Form
    {
        User CurrentUser;
        string cont;
        Auth parent;

        string[] SelectedString;
        

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(Auth parent, User currentUser, string cont)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            this.cont = cont;
            this.parent = parent;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnt = new SqlConnection(cont))
            {
                cnt.Open();
                string sql = "SELECT [test].[Name], [topics].[Name] FROM [test], [topics] WHERE [test].TopicID = [topics].ID;";

                SqlDataReader reader = (new SqlCommand(sql, cnt)).ExecuteReader();
                int rows = 0;
                string[] reads;

                for (; reader.HasRows && reader.Read(); rows++) ;
                reader.Close();

                reads = new string[rows];
                SelectedString = new string[rows];
                for (reader = (new SqlCommand(sql, cnt)).ExecuteReader(), rows = 0; reader.HasRows && reader.Read(); rows++)
                {
                    reads[rows] = reader.GetValue(0).ToString() + " (Тематика: "+ reader.GetValue(1).ToString() + ")";
                    SelectedString[rows] = reader.GetValue(0).ToString();
                }

                testChoice.DataSource = reads;
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void testOkButton_Click(object sender, EventArgs e)
        {
            TestStart ts = new TestStart(this, SelectedString[testChoice.SelectedIndex], cont);
            ts.Show();
            this.Hide();
        }
    }
}
