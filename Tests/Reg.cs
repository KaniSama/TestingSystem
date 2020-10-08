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
using System.Text.RegularExpressions;

namespace Tests
{
    public partial class Reg : Form
    {
        Auth parent;
        public Reg()
        {
            InitializeComponent();
        }
        public Reg(Auth parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            loginBox.Text = loginBox.Text.Trim();
            passBox.Text = passBox.Text.Trim();
            passConfirmBox.Text = passConfirmBox.Text.Trim();
            lNameBox.Text = lNameBox.Text.Trim();
            fNameBox.Text = fNameBox.Text.Trim();
            faNameBox.Text = faNameBox.Text.Trim();

            if (loginBox.Text == "" || passBox.Text == "" || passConfirmBox.Text == "" || lNameBox.Text == "" || fNameBox.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля!");
            }
            else if (passBox.Text.Trim() != passConfirmBox.Text.Trim()) {
                MessageBox.Show("Пароли не совпадают!");
            }
            else 
            {
                if (loginBox.Text.Length < 4 || loginBox.Text.Length > 25) MessageBox.Show("Логин должен быть длиной не менее 5 и не более 25 символов.");
                else if (!Match(loginBox.Text)) MessageBox.Show("Логин должен состоять только из латинских букв, цифр, нижнего подчёркивания и точки!");
                else if (passBox.Text.Length < 8 || loginBox.Text.Length > 50) MessageBox.Show("Пароль должен быть длиной не менее 8 и не более 50 символов в длину.");
                else if (Match(loginBox.Text) && PassMatch(passBox.Text))
                {
                    using (SqlConnection cnt = new SqlConnection(parent.GetConnect()))
                    {
                        cnt.Open();

                        SqlCommand command = new SqlCommand("SELECT Login FROM [dbo].[user];", cnt);
                        SqlDataReader reader = command.ExecuteReader();

                        bool match = false;
                        for (; reader.Read() && !match;)
                        {
                            if (loginBox.Text == reader.GetString(0))
                            {
                                match = true;
                            }
                        }
                        if (match) MessageBox.Show("Логин уже занят. Выберите другой логин.");
                        else {
                            MessageBox.Show("Success!");
                            if (faNameBox.Text == "") faNameBox.Text = "NULL";
                            command = new SqlCommand($"INSERT INTO [dbo].[user] (Login, Password, LName, FName, FaName) VALUES ('{loginBox.Text}', '{passBox.Text}', '{lNameBox.Text}', '{fNameBox.Text}', '{faNameBox.Text}');", cnt);

                            reader.Close();

                            int number = command.ExecuteNonQuery();
                            MessageBox.Show($"Записано {number} строк.");
                            this.Close();
                        }

                        reader.Close();
                    }
                } else
                {
                    MessageBox.Show("Логин или пароль содержат недопустимые символы!");
                }
            }
        }

        private void Clear()
        {
            loginBox.Text = "";
            passBox.Text = "";
            passConfirmBox.Text = "";
            lNameBox.Text = "";
            fNameBox.Text = "";
            faNameBox.Text = "";
        }
        
        private bool Match(string str)
        {
            string checker = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            checker += checker.ToLower() + "1234567890_.";

            int i; bool match = true;
            for (i = 0; i < str.Length && match; i++)
            {
                if (!checker.Contains(str.Substring(i, 1))) match = false;
            }
            return match;
        }
        private bool PassMatch(string str)
        {
            string checker = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            checker += checker.ToLower() + "1234567890_.@$%&!-";

            int i; bool match = true;
            for (i = 0; i < str.Length && match; i++)
            {
                if (!checker.Contains(str.Substring(i, 1))) match = false;
            }
            return match;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
