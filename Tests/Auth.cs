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
using System.Configuration;

namespace Tests
{
    public partial class Auth : Form
    {
        private User CurrentUser; // Текущий пользователь
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; // Строка для подключения

        // Конструктор формы
        public Auth()
        {
            InitializeComponent();
        }

        /* ------------------------------------------------- АВТОРИЗАЦИЯ -------------------------------------------------*/

        // Обработка авторизации
        private void okButton_Click(object sender, EventArgs e)
        {
            loginBox.Text = loginBox.Text.ToLower();

            if (loginBox.Text.Trim()=="" || passBox.Text.Trim()=="")
            {
                MessageBox.Show("Заполните все поля.");
            } else
            {
                using (SqlConnection cnt = new SqlConnection(connectionString))
                {
                    cnt.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[user]", cnt);
                    SqlDataReader reader = command.ExecuteReader();

                    bool logged = false;
                    for (; reader.Read() && !logged; )
                    {
                        if (loginBox.Text == reader.GetString(0) && passBox.Text == reader.GetString(1))
                        {
                            CurrentUser = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                    reader.GetString(4), reader.GetString(0)=="admin" ? User.Rights.Admin : User.Rights.User);
                            logged = true;
                        }
                    }
                    if (!logged) MessageBox.Show("Неправильный логин или пароль.");
                    else
                    {
                        MessageBox.Show("Добро пожаловать, " + CurrentUser.GetLogin() + "! Ваши права: " + CurrentUser.GetRights());
                        cnt.Close();
                        UserForm UF = new UserForm(this, CurrentUser, cnt.ConnectionString);
                        UF.Show();
                        this.Hide();

                        loginBox.Text = "";
                    }

                    reader.Close();
                    passBox.Text = "";
                }
            }
        }

        // Показать/скрыть пароль
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passBox.PasswordChar = passBox.PasswordChar=='*' ?'\0':'*';
        }

        // Отмена регистрации
        private void cancelButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            clearButton_Click(this, e);
        }

        // Переход на вкладку с регистрацией
        private void registerButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        /* ------------------------------------------ РЕГИСТРАЦИЯ ------------------------------------------------- */

        // Очистка полей в форме регистрации
        private void clearButton_Click(object sender, EventArgs e)
        {
            regLogBox.Text = "";
            regPassBox.Text = "";
            regPassConfirmBox.Text = "";
            lNameBox.Text = "";
            fNameBox.Text = "";
            faNameBox.Text = "";
        }

        // Обработка регистрации
        private void regOK_Click(object sender, EventArgs e)
        {
            regLogBox.Text = regLogBox.Text.Trim().ToLower();
            regPassBox.Text = regPassBox.Text.Trim();
            regPassConfirmBox.Text = regPassConfirmBox.Text.Trim();
            lNameBox.Text = lNameBox.Text.Trim();
            fNameBox.Text = fNameBox.Text.Trim();
            faNameBox.Text = faNameBox.Text.Trim();

            if (regLogBox.Text == "" || regPassBox.Text == "" || regPassConfirmBox.Text == "" || lNameBox.Text == "" || fNameBox.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля!");
            }
            else if (regPassBox.Text.Trim() != regPassConfirmBox.Text.Trim())
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                if (regLogBox.Text.Length < 4 || regLogBox.Text.Length > 25) MessageBox.Show("Логин должен быть длиной не менее 5 и не более 25 символов.");
                else if (!Match(regLogBox.Text)) MessageBox.Show("Логин должен состоять только из латинских букв, цифр, нижнего подчёркивания и точки!");
                else if (regPassBox.Text.Length < 8 || regLogBox.Text.Length > 50) MessageBox.Show("Пароль должен быть длиной не менее 8 и не более 50 символов в длину.");
                else if (Match(regLogBox.Text) && PassMatch(regPassBox.Text))
                {
                    using (SqlConnection cnt = new SqlConnection(GetConnect()))
                    {
                        cnt.Open();

                        SqlCommand command = new SqlCommand("SELECT Login FROM [dbo].[user];", cnt);
                        SqlDataReader reader = command.ExecuteReader();

                        bool match = false;
                        for (; reader.Read() && !match;)
                        {
                            if (regLogBox.Text == reader.GetString(0))
                            {
                                match = true;
                            }
                        }
                        if (match) MessageBox.Show("Логин уже занят. Выберите другой логин.");
                        else
                        {
                            if (faNameBox.Text == "") faNameBox.Text = "NULL";
                            command = new SqlCommand($"INSERT INTO [dbo].[user] (Login, Password, LName, FName, FaName) VALUES ('{regLogBox.Text}', '{regPassBox.Text}', '{lNameBox.Text}', '{fNameBox.Text}', '{faNameBox.Text}');", cnt);

                            reader.Close();

                            int number = command.ExecuteNonQuery();
                            MessageBox.Show($"Регистрация успешна. Время авторизоваться!");

                            cancelButton_Click(this, e);
                        }

                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль содержат недопустимые символы!");
                }
            }
        }

        // Проверка логина и пароля на соответствие стандарту
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

        /* ----------------------------------------------- СЕРВИС ------------------------------------------------ */

        // Получает строку для подключения SQLConnect
        public string GetConnect()
        {
            return connectionString;
        }
              
    }
}
