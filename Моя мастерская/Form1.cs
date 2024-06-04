using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using BCrypt.Net;

namespace Моя_мастерская
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "server=127.0.0.1;database=triod_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT user_id, user_password FROM users WHERE user_login = @login";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader["user_password"].ToString();
                                int userId = Convert.ToInt32(reader["user_id"]);

                                if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                                {
                                    MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Переход на другую форму или выполнение других действий после успешной авторизации
                                    mainForm mainForm = new mainForm();
                                    this.Hide();
                                    mainForm.userId = userId;
                                    if (login != "AblaevRA") { mainForm.tabControl1.TabPages.Remove(mainForm.tabControl1.TabPages["workersPage"]); }
                                    mainForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Неправильный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неправильный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
