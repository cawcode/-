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
    public partial class mainForm : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1;database=triod_db;uid=root;pwd=;";
        public int userId = 0;

        public mainForm()
        {
            InitializeComponent();
            dgvRequestsList.CellEndEdit += DgvRequestsList_CellEndEdit;
            dgvCashRegisterRecords.CellEndEdit += new DataGridViewCellEventHandler(dgvCashRegisterRecords_CellEndEdit);
            LoadDataIntoComboBoxes();
            LoadDataIntoDataGridView();
            LoadMasters();
            LoadSecretaries();

            //panelAddCrRecord.Click += new EventHandler(panelAddCrRecord_Click);
            //panelDeleteCrRecord.Click += new EventHandler(panelDeleteCrRecord_Click);

            // Загрузка данных при инициализации
            LoadComboBoxes();
            LoadCashRegisterRecords();

            InitializeDataGridView();
            //this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT 
                                        r.request_id, r.request_acc_date, r.device_type_id, r.device_fabricator, r.device_model, r.device_serial_num, 
                                        r.client_name, r.client_address, r.client_phone, r.request_status_id, r.master_id 
                                     FROM requests r";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvRequestsList.Rows.Add(
                                    reader["request_id"],
                                    reader["request_acc_date"],
                                    reader["device_type_id"],
                                    reader["device_fabricator"],
                                    reader["device_model"],
                                    reader["device_serial_num"],
                                    reader["client_name"],
                                    reader["client_address"],
                                    reader["client_phone"],
                                    reader["request_status_id"],
                                    reader["master_id"]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных в DataGridView: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataIntoComboBoxes()
        {
            LoadDataIntoComboBox("masters", "master_id", "master_name", "master_id");
            LoadDataIntoComboBox("request_status", "request_status_id", "request_status_name", "request_status_id");
            LoadDataIntoComboBox("device_type", "device_type_id", "device_type_name", "device_type_id");
        }

        private void LoadDataIntoComboBox(string tableName, string idColumnName, string valueColumnName, string comboBoxColumnName)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT {idColumnName}, {valueColumnName} FROM {tableName}";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvRequestsList.Columns[comboBoxColumnName];
                            comboBoxColumn.DisplayMember = valueColumnName;
                            comboBoxColumn.ValueMember = idColumnName;
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            comboBoxColumn.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных в комбо-бокс из таблицы {tableName}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load stock_record_purpose_id combo box
                string query = "SELECT stock_record_purpose_id, stock_record_purpose_name FROM stock_record_purpose";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var comboBoxColumn = (DataGridViewComboBoxColumn)dgvCashRegisterRecords.Columns["stock_record_purpose_id"];
                        comboBoxColumn.DisplayMember = "Value";
                        comboBoxColumn.ValueMember = "Key";

                        var items = new List<KeyValuePair<int, string>>();
                        while (reader.Read())
                        {
                            items.Add(new KeyValuePair<int, string>(
                                (int)reader["stock_record_purpose_id"],
                                reader["stock_record_purpose_name"].ToString()
                            ));
                        }
                        comboBoxColumn.DataSource = items;
                    }
                }

                // Load stock_record_operation_id combo box
                query = "SELECT stock_record_operation_id, stock_record_operation_name FROM stock_record_operation";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var comboBoxColumn = (DataGridViewComboBoxColumn)dgvCashRegisterRecords.Columns["stock_record_operation_id"];
                        comboBoxColumn.DisplayMember = "Value";
                        comboBoxColumn.ValueMember = "Key";

                        var items = new List<KeyValuePair<int, string>>();
                        while (reader.Read())
                        {
                            items.Add(new KeyValuePair<int, string>(
                                (int)reader["stock_record_operation_id"],
                                reader["stock_record_operation_name"].ToString()
                            ));
                        }
                        comboBoxColumn.DataSource = items;
                    }
                }
            }
        }

        private void DgvRequestsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRequestsList.Rows.Count)
            {
                DataGridViewRow row = dgvRequestsList.Rows[e.RowIndex];
                string requestId = row.Cells["request_id"].Value?.ToString();
                string accDate = row.Cells["request_acc_date"].Value?.ToString();
                string deviceTypeId = row.Cells["device_type_id"].Value?.ToString();
                string fabricator = row.Cells["device_fabricator"].Value?.ToString();
                string model = row.Cells["device_model"].Value?.ToString();
                string serialNum = row.Cells["device_serial_num"].Value?.ToString();
                string clientName = row.Cells["client_name"].Value?.ToString();
                string clientAddress = row.Cells["client_address"].Value?.ToString();
                string clientPhone = row.Cells["client_phone"].Value?.ToString();
                string statusId = row.Cells["request_status_id"].Value?.ToString();
                string masterId = row.Cells["master_id"].Value?.ToString();

                if (string.IsNullOrEmpty(requestId))
                {
                    InsertDataIntoDatabase(accDate, deviceTypeId, fabricator, model, serialNum, clientName, clientAddress, clientPhone, statusId, masterId);
                }
                else
                {
                    UpdateDataInDatabase(requestId, deviceTypeId, fabricator, model, serialNum, clientName, clientAddress, clientPhone, statusId, masterId);
                }
            }
        }

        private void InsertDataIntoDatabase(string accDate, string deviceTypeId, string fabricator, string model, string serialNum, string clientName, string clientAddress, string clientPhone, string statusId, string masterId)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO requests 
                                        (request_acc_date, device_type_id, device_fabricator, device_model, device_serial_num, client_name, client_address, client_phone, request_status_id, master_id, user_id) 
                                     VALUES 
                                        (@accDate, @deviceTypeId, @fabricator, @model, @serialNum, @clientName, @clientAddress, @clientPhone, @statusId, @masterId, @userId)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@accDate", accDate);
                        command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                        command.Parameters.AddWithValue("@fabricator", fabricator);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@serialNum", serialNum);
                        command.Parameters.AddWithValue("@clientName", clientName);
                        command.Parameters.AddWithValue("@clientAddress", clientAddress);
                        command.Parameters.AddWithValue("@clientPhone", clientPhone);
                        command.Parameters.AddWithValue("@statusId", statusId);
                        command.Parameters.AddWithValue("@masterId", masterId);
                        command.Parameters.AddWithValue("@userId", userId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления новой записи в базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataInDatabase(string requestId, string deviceTypeId, string fabricator, string model, string serialNum, string clientName, string clientAddress, string clientPhone, string statusId, string masterId)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE requests 
                                     SET 
                                        device_type_id = @deviceTypeId, device_fabricator = @fabricator, 
                                        device_model = @model, device_serial_num = @serialNum, client_name = @clientName, client_address = @clientAddress, 
                                        client_phone = @clientPhone, request_status_id = @statusId, master_id = @masterId 
                                     WHERE request_id = @requestId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@requestId", requestId);
                        command.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                        command.Parameters.AddWithValue("@fabricator", fabricator);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@serialNum", serialNum);
                        command.Parameters.AddWithValue("@clientName", clientName);
                        command.Parameters.AddWithValue("@clientAddress", clientAddress);
                        command.Parameters.AddWithValue("@clientPhone", clientPhone);
                        command.Parameters.AddWithValue("@statusId", statusId);
                        command.Parameters.AddWithValue("@masterId", masterId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления данных в базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO requests 
                                (request_acc_date, request_status_id, user_id) 
                             VALUES 
                                (@accDate, @statusId, @userId);
                             SELECT LAST_INSERT_ID();";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@accDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@statusId", 1);
                        command.Parameters.AddWithValue("@userId", userId);

                        // Выполняем запрос и получаем последний вставленный ID
                        int requestId = Convert.ToInt32(command.ExecuteScalar());

                        // Добавляем новую строку в DataGridView
                        int rowIndex = dgvRequestsList.Rows.Add();
                        dgvRequestsList.Rows[rowIndex].Cells["request_id"].Value = requestId;
                        dgvRequestsList.Rows[rowIndex].Cells["request_acc_date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dgvRequestsList.Rows[rowIndex].Cells["request_status_id"].Value = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления новой записи в базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else 
            {
                Application.Exit(); 
            }
        }

        private void panelDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvRequestsList.SelectedRows.Count > 0)
                {
                    // Получаем id выбранной записи
                    string requestId = dgvRequestsList.SelectedRows[0].Cells["request_id"].Value?.ToString();

                    // Убеждаемся, что requestId не пустой
                    if (!string.IsNullOrEmpty(requestId))
                    {
                        try
                        {
                            using (connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM requests WHERE request_id = @requestId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@requestId", requestId);
                                    command.ExecuteNonQuery();
                                }
                            }

                            // Удаление строки из DataGridView
                            dgvRequestsList.Rows.RemoveAt(dgvRequestsList.SelectedRows[0].Index);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка удаления записи из базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбранная запись не содержит идентификатора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadCashRegisterRecords()
        {
            dgvCashRegisterRecords.Rows.Clear();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT stock_record_id, stock_record_date, stock_record_sum, stock_record_purpose_id, stock_record_operation_id, stock_record_note, request_id 
                         FROM stock_records";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvCashRegisterRecords.Rows.Add();
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_id"].Value = reader["stock_record_id"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_date"].Value = reader["stock_record_date"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_sum"].Value = reader["stock_record_sum"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_purpose_id"].Value = reader["stock_record_purpose_id"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_operation_id"].Value = reader["stock_record_operation_id"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_note"].Value = reader["stock_record_note"];
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["cr_request_id"].Value = reader["request_id"];
                        }
                    }
                }
            }
        }

        private void panelAddCrRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO stock_records 
                                (stock_record_date, stock_record_sum, stock_record_purpose_id, stock_record_operation_id, stock_record_note) 
                             VALUES 
                                (@recordDate, @recordSum, @recordPurposeId, @recordOperationId, @recordNote);
                             SELECT LAST_INSERT_ID();";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@recordDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@recordSum", 0); // или любое другое начальное значение
                        command.Parameters.AddWithValue("@recordPurposeId", 1); // или любое другое начальное значение
                        command.Parameters.AddWithValue("@recordOperationId", 1); // или любое другое начальное значение
                        command.Parameters.AddWithValue("@recordNote", "");

                        int stockRecordId = Convert.ToInt32(command.ExecuteScalar());

                        // Добавляем строку в DataGridView один раз
                        int rowIndex = dgvCashRegisterRecords.Rows.Add();

                        // Обновляем ячейки в DataGridView
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_id"].Value = stockRecordId;
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_sum"].Value = 0;
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_purpose_id"].Value = 1; // или любое другое начальное значение
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_operation_id"].Value = 1; // или любое другое начальное значение
                        dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_note"].Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления новой записи в базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelDeleteCrRecord_Click(object sender, EventArgs e)
        {
            if (dgvCashRegisterRecords.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvCashRegisterRecords.SelectedRows)
                        {
                            int stockRecordId = Convert.ToInt32(row.Cells["stock_record_id"].Value);

                            using (var connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM stock_records WHERE stock_record_id = @stockRecordId";
                                using (var command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@stockRecordId", stockRecordId);
                                    command.ExecuteNonQuery();
                                }
                            }

                            dgvCashRegisterRecords.Rows.Remove(row);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка удаления записи из базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCashRegisterRecords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Убедимся, что индекс строки корректный
            {
                try
                {
                    int stockRecordId = Convert.ToInt32(dgvCashRegisterRecords.Rows[e.RowIndex].Cells["stock_record_id"].Value);

                    // Считываем обновленные значения
                    var recordSum = Convert.ToDecimal(dgvCashRegisterRecords.Rows[e.RowIndex].Cells["stock_record_sum"].Value);
                    var recordPurposeId = Convert.ToInt32(dgvCashRegisterRecords.Rows[e.RowIndex].Cells["stock_record_purpose_id"].Value);
                    var recordOperationId = Convert.ToInt32(dgvCashRegisterRecords.Rows[e.RowIndex].Cells["stock_record_operation_id"].Value);
                    var recordNote = dgvCashRegisterRecords.Rows[e.RowIndex].Cells["stock_record_note"].Value.ToString();

                    // Обновляем запись в базе данных
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE stock_records 
                                 SET stock_record_sum = @recordSum, 
                                     stock_record_purpose_id = @recordPurposeId, 
                                     stock_record_operation_id = @recordOperationId, 
                                     stock_record_note = @recordNote
                                 WHERE stock_record_id = @stockRecordId";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@recordSum", recordSum);
                            command.Parameters.AddWithValue("@recordPurposeId", recordPurposeId);
                            command.Parameters.AddWithValue("@recordOperationId", recordOperationId);
                            command.Parameters.AddWithValue("@recordNote", recordNote);
                            command.Parameters.AddWithValue("@stockRecordId", stockRecordId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления записи в базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            string role = cmbBoxRole.SelectedItem.ToString();
            string name = txtBoxName.Text;

            if (role == "Мастер")
            {
                AddMaster(name);
            }
            else if (role == "Приемщик")
            {
                string login = txtBoxLogin.Text;
                string password = txtBoxPassword.Text;
                AddSecretary(name, login, password);
            }
        }

        private void InitializeDataGridView()
        {
            // Инициализация других столбцов...

            // Добавление столбца с кнопкой
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "AddToCashRegister";
            buttonColumn.HeaderText = "Добавить в кассовые записи";
            buttonColumn.Text = "Добавить";
            buttonColumn.UseColumnTextForButtonValue = true;

            dgvRequestsList.Columns.Add(buttonColumn);
        }

        private void dgvRequestsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка
            if (dgvRequestsList.Columns[e.ColumnIndex].Name == "AddToCashRegister" && e.RowIndex >= 0)
            {
                // Получаем значение request_id из строки, в которой нажата кнопка
                int requestId = Convert.ToInt32(dgvRequestsList.Rows[e.RowIndex].Cells["request_id"].Value);

                tabControl1.SelectedIndex = 3;

                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"INSERT INTO stock_records 
                                (stock_record_date, stock_record_sum, stock_record_purpose_id, stock_record_operation_id, stock_record_note, request_id) 
                             VALUES 
                                (@recordDate, @recordSum, @recordPurposeId, @recordOperationId, @recordNote, @requestId);
                             SELECT LAST_INSERT_ID();";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@recordDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            command.Parameters.AddWithValue("@recordSum", 0); // или любое другое начальное значение
                            command.Parameters.AddWithValue("@recordPurposeId", 1); // или любое другое начальное значение
                            command.Parameters.AddWithValue("@recordOperationId", 1); // или любое другое начальное значение
                            command.Parameters.AddWithValue("@recordNote", "");
                            command.Parameters.AddWithValue("@requestId", requestId);

                            int stockRecordId = Convert.ToInt32(command.ExecuteScalar());

                            // Добавляем строку в DataGridView один раз
                            int rowIndex = dgvCashRegisterRecords.Rows.Add();

                            // Обновляем ячейки в DataGridView
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_id"].Value = stockRecordId;
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_sum"].Value = 0;
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_purpose_id"].Value = 1; // или любое другое начальное значение
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_operation_id"].Value = 1; // или любое другое начальное значение
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["stock_record_note"].Value = "";
                            dgvCashRegisterRecords.Rows[rowIndex].Cells["cr_request_id"].Value = requestId;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления новой записи в базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, что активная вкладка - та, на которой находится DataGridView
            if (tabControl1.SelectedTab == cashRegisterPage) // Предполагается, что tabPage4 - это ваша вкладка с DataGridView
            {
                if (dgvCashRegisterRecords.Rows.Count > 0)
                {
                    // Устанавливаем текущую ячейку на последнюю строку и первый столбец
                    dgvCashRegisterRecords.CurrentCell = dgvCashRegisterRecords.Rows[dgvCashRegisterRecords.Rows.Count - 1].Cells[0];
                    dgvCashRegisterRecords.BeginEdit(true); // Начинаем редактирование ячейки
                }
            }
        }

        private void AddMaster(string name)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO masters (master_name) VALUES (@name)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.ExecuteNonQuery();
                    }
                }
                LoadMasters(); // обновление DataGridView с мастерами
                MessageBox.Show("Сотрудник успешно добавлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления мастера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddSecretary(string name, string login, string password)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    string query = "INSERT INTO users (user_login, user_password, user_name) VALUES (@login, @password, @name)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@name", name);
                        command.ExecuteNonQuery();
                    }
                }
                LoadSecretaries(); // обновление DataGridView с приемщиками
                MessageBox.Show("Сотрудник успешно добавлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления приемщика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            if (dgvMasters.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить мастера?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int masterId = Convert.ToInt32(dgvMasters.SelectedRows[0].Cells["workers_master_id"].Value);
                    DeleteMaster(masterId);
                }
            }
        }

        private void DeleteMaster(int masterId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM masters WHERE master_id = @masterId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@masterId", masterId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadMasters(); // обновление DataGridView с мастерами
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления мастера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSecretary_Click(object sender, EventArgs e)
        {
            if (dgvSecretaries.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить приемщика?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(dgvSecretaries.SelectedRows[0].Cells["workers_user_id"].Value);
                    DeleteSecretary(userId);
                }
            }
        }

        private void DeleteSecretary(int userId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM users WHERE user_id = @userId";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadSecretaries(); // обновление DataGridView с приемщиками
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления приемщика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadMasters()
        {
            try
            {
                dgvMasters.Rows.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM masters";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvMasters.Rows.Add(reader["master_id"], reader["master_name"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки мастеров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSecretaries()
        {
            try
            {
                dgvSecretaries.Rows.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvSecretaries.Rows.Add(reader["user_id"], reader["user_login"], reader["user_password"], reader["user_name"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки приемщиков: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbBoxRole.SelectedItem.ToString();

            // Если выбрана роль "Мастер", то устанавливаем редактирование полей txtBoxLogin и txtBoxPassword в false
            if (selectedRole == "Мастер")
            {
                txtBoxLogin.Enabled = false;
                txtBoxPassword.Enabled = false;
            }
            // Если выбрана роль "Приемщик", то устанавливаем редактирование полей txtBoxLogin и txtBoxPassword в true
            else if (selectedRole == "Приемщик")
            {
                txtBoxLogin.Enabled = true;
                txtBoxPassword.Enabled = true;
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            int totalDays = (int)(endDate - startDate).TotalDays;
            int secretaryId = Int32.Parse(dgvSecretaries.SelectedRows[0].Cells["workers_user_id"].Value.ToString());
            int workingDays = GetWorkingDays(startDate, endDate, secretaryId);
            decimal salaryPerDay = 300; 
            decimal totalSalary = workingDays * salaryPerDay;
            MessageBox.Show($"Зарплата за выбранный период: {totalSalary} руб.", "Расчет зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetWorkingDays(DateTime startDate, DateTime endDate, int secretaryId)
        {
            int workingDays = 0;

            // Подключаемся к базе данных и выполняем запрос к таблице requests
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT DATE(request_acc_date) AS acc_date " +
                               "FROM requests " +
                               "WHERE user_id = @secretaryId AND " +
                               "      DATE(request_acc_date) BETWEEN @startDate AND @endDate";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@secretaryId", secretaryId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workingDays++;
                        }
                    }
                }
            }

            return workingDays;
        }

    }
}
