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
    public partial class TestStart : Form
    {
        UserForm parent;
        string connectionstring;
        public TestStart()
        {
            InitializeComponent();
        }
        public TestStart(UserForm parent, string TestName, string connectionstring)
        {
            InitializeComponent();
            this.parent = parent;
            testNameLabel.Text = "Тест: \"" + TestName + "\"";
            this.connectionstring = connectionstring;
        }

        private void TestStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Открыть форму с тестом
            TestBody tb = new TestBody(this, testNameLabel.Text.Replace("Тест: \"", "").Replace("\"", ""), connectionstring);
            tb.Show();
            this.Hide();
        }
    }
}
