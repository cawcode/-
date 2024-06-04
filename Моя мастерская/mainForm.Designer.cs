namespace Моя_мастерская
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.requestListPage = new System.Windows.Forms.TabPage();
            this.dgvRequestsList = new System.Windows.Forms.DataGridView();
            this.request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_acc_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.device_fabricator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_serial_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_status_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.master_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.workersPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMaster = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSecretaries = new System.Windows.Forms.GroupBox();
            this.dgvSecretaries = new System.Windows.Forms.DataGridView();
            this.gbMasters = new System.Windows.Forms.GroupBox();
            this.dgvMasters = new System.Windows.Forms.DataGridView();
            this.workers_master_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workers_master_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashRegisterPage = new System.Windows.Forms.TabPage();
            this.lblSum = new System.Windows.Forms.Label();
            this.dgvCashRegisterRecords = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDeleteRequest = new System.Windows.Forms.Panel();
            this.panelAddRequest = new System.Windows.Forms.Panel();
            this.panelDeleteCrRecord = new System.Windows.Forms.Panel();
            this.panelAddCrRecord = new System.Windows.Forms.Panel();
            this.stock_record_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_record_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_record_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_record_purpose_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stock_record_operation_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stock_record_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr_request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalarySecretary = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteSecretary = new System.Windows.Forms.Button();
            this.workers_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.requestListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestsList)).BeginInit();
            this.workersPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSecretaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretaries)).BeginInit();
            this.gbMasters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasters)).BeginInit();
            this.cashRegisterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashRegisterRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.requestListPage);
            this.tabControl1.Controls.Add(this.stockPage);
            this.tabControl1.Controls.Add(this.workersPage);
            this.tabControl1.Controls.Add(this.cashRegisterPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 565);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // requestListPage
            // 
            this.requestListPage.Controls.Add(this.panel2);
            this.requestListPage.Controls.Add(this.panelDeleteRequest);
            this.requestListPage.Controls.Add(this.panelAddRequest);
            this.requestListPage.Controls.Add(this.dgvRequestsList);
            this.requestListPage.Location = new System.Drawing.Point(4, 26);
            this.requestListPage.Name = "requestListPage";
            this.requestListPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestListPage.Size = new System.Drawing.Size(906, 535);
            this.requestListPage.TabIndex = 0;
            this.requestListPage.Text = "Заявки";
            this.requestListPage.UseVisualStyleBackColor = true;
            // 
            // dgvRequestsList
            // 
            this.dgvRequestsList.AllowUserToAddRows = false;
            this.dgvRequestsList.AllowUserToDeleteRows = false;
            this.dgvRequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.request_id,
            this.request_acc_date,
            this.device_type_id,
            this.device_fabricator,
            this.device_model,
            this.device_serial_num,
            this.client_name,
            this.client_address,
            this.client_phone,
            this.request_status_id,
            this.master_id});
            this.dgvRequestsList.Location = new System.Drawing.Point(9, 32);
            this.dgvRequestsList.MultiSelect = false;
            this.dgvRequestsList.Name = "dgvRequestsList";
            this.dgvRequestsList.RowHeadersWidth = 51;
            this.dgvRequestsList.RowTemplate.Height = 24;
            this.dgvRequestsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestsList.Size = new System.Drawing.Size(891, 497);
            this.dgvRequestsList.TabIndex = 0;
            this.dgvRequestsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestsList_CellContentClick);
            this.dgvRequestsList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequestsList_CellEndEdit);
            // 
            // request_id
            // 
            this.request_id.HeaderText = "ID";
            this.request_id.MinimumWidth = 30;
            this.request_id.Name = "request_id";
            this.request_id.ReadOnly = true;
            this.request_id.Width = 30;
            // 
            // request_acc_date
            // 
            this.request_acc_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.request_acc_date.FillWeight = 40.84396F;
            this.request_acc_date.HeaderText = "Дата";
            this.request_acc_date.MinimumWidth = 6;
            this.request_acc_date.Name = "request_acc_date";
            this.request_acc_date.ReadOnly = true;
            // 
            // device_type_id
            // 
            this.device_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.device_type_id.FillWeight = 40.84396F;
            this.device_type_id.HeaderText = "Тип";
            this.device_type_id.MinimumWidth = 150;
            this.device_type_id.Name = "device_type_id";
            this.device_type_id.Width = 150;
            // 
            // device_fabricator
            // 
            this.device_fabricator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.device_fabricator.FillWeight = 573.2484F;
            this.device_fabricator.HeaderText = "Производитель";
            this.device_fabricator.MinimumWidth = 150;
            this.device_fabricator.Name = "device_fabricator";
            this.device_fabricator.Width = 150;
            // 
            // device_model
            // 
            this.device_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.device_model.FillWeight = 40.84396F;
            this.device_model.HeaderText = "Модель";
            this.device_model.MinimumWidth = 6;
            this.device_model.Name = "device_model";
            // 
            // device_serial_num
            // 
            this.device_serial_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.device_serial_num.FillWeight = 40.84396F;
            this.device_serial_num.HeaderText = "Сер. №";
            this.device_serial_num.MinimumWidth = 6;
            this.device_serial_num.Name = "device_serial_num";
            // 
            // client_name
            // 
            this.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_name.FillWeight = 40.84396F;
            this.client_name.HeaderText = "ФИО клиента";
            this.client_name.MinimumWidth = 6;
            this.client_name.Name = "client_name";
            // 
            // client_address
            // 
            this.client_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_address.HeaderText = "Адрес";
            this.client_address.MinimumWidth = 6;
            this.client_address.Name = "client_address";
            this.client_address.Visible = false;
            // 
            // client_phone
            // 
            this.client_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_phone.FillWeight = 40.84396F;
            this.client_phone.HeaderText = "Тел.";
            this.client_phone.MinimumWidth = 6;
            this.client_phone.Name = "client_phone";
            // 
            // request_status_id
            // 
            this.request_status_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.request_status_id.FillWeight = 40.84396F;
            this.request_status_id.HeaderText = "Статус";
            this.request_status_id.MinimumWidth = 6;
            this.request_status_id.Name = "request_status_id";
            // 
            // master_id
            // 
            this.master_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.master_id.FillWeight = 40.84396F;
            this.master_id.HeaderText = "Мастер";
            this.master_id.MinimumWidth = 6;
            this.master_id.Name = "master_id";
            // 
            // stockPage
            // 
            this.stockPage.Location = new System.Drawing.Point(4, 26);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(906, 535);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "Склад";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // workersPage
            // 
            this.workersPage.Controls.Add(this.groupBox1);
            this.workersPage.Controls.Add(this.gbSecretaries);
            this.workersPage.Controls.Add(this.gbMasters);
            this.workersPage.Location = new System.Drawing.Point(4, 26);
            this.workersPage.Name = "workersPage";
            this.workersPage.Size = new System.Drawing.Size(906, 535);
            this.workersPage.TabIndex = 2;
            this.workersPage.Text = "Сотрудники";
            this.workersPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSecretary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnSalarySecretary);
            this.groupBox1.Controls.Add(this.btnDeleteMaster);
            this.groupBox1.Controls.Add(this.btnAddWorker);
            this.groupBox1.Controls.Add(this.txtBoxPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBoxRole);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(550, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения";
            // 
            // btnDeleteMaster
            // 
            this.btnDeleteMaster.Location = new System.Drawing.Point(10, 277);
            this.btnDeleteMaster.Name = "btnDeleteMaster";
            this.btnDeleteMaster.Size = new System.Drawing.Size(337, 32);
            this.btnDeleteMaster.TabIndex = 10;
            this.btnDeleteMaster.Text = "Удалить мастера";
            this.btnDeleteMaster.UseVisualStyleBackColor = true;
            this.btnDeleteMaster.Click += new System.EventHandler(this.btnDeleteMaster_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(10, 236);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(337, 32);
            this.btnAddWorker.TabIndex = 8;
            this.btnAddWorker.Text = "Добавить";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Enabled = false;
            this.txtBoxPassword.Location = new System.Drawing.Point(10, 205);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(337, 25);
            this.txtBoxPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль:";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Enabled = false;
            this.txtBoxLogin.Location = new System.Drawing.Point(10, 152);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(337, 25);
            this.txtBoxLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин:";
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Мастер",
            "Приемщик"});
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Items.AddRange(new object[] {
            "Мастер",
            "Приемщик"});
            this.cmbBoxRole.Location = new System.Drawing.Point(10, 46);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(337, 25);
            this.cmbBoxRole.TabIndex = 3;
            this.cmbBoxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Роль:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(10, 97);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(337, 25);
            this.txtBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО сотрудника:";
            // 
            // gbSecretaries
            // 
            this.gbSecretaries.Controls.Add(this.dgvSecretaries);
            this.gbSecretaries.Location = new System.Drawing.Point(3, 245);
            this.gbSecretaries.Name = "gbSecretaries";
            this.gbSecretaries.Size = new System.Drawing.Size(541, 287);
            this.gbSecretaries.TabIndex = 2;
            this.gbSecretaries.TabStop = false;
            this.gbSecretaries.Text = "Приемщики";
            // 
            // dgvSecretaries
            // 
            this.dgvSecretaries.AllowUserToAddRows = false;
            this.dgvSecretaries.AllowUserToDeleteRows = false;
            this.dgvSecretaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecretaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workers_user_id,
            this.user_login,
            this.user_password,
            this.user_name});
            this.dgvSecretaries.Location = new System.Drawing.Point(6, 24);
            this.dgvSecretaries.Name = "dgvSecretaries";
            this.dgvSecretaries.ReadOnly = true;
            this.dgvSecretaries.RowHeadersWidth = 51;
            this.dgvSecretaries.RowTemplate.Height = 24;
            this.dgvSecretaries.Size = new System.Drawing.Size(529, 257);
            this.dgvSecretaries.TabIndex = 0;
            // 
            // gbMasters
            // 
            this.gbMasters.Controls.Add(this.dgvMasters);
            this.gbMasters.Location = new System.Drawing.Point(3, 3);
            this.gbMasters.Name = "gbMasters";
            this.gbMasters.Size = new System.Drawing.Size(541, 236);
            this.gbMasters.TabIndex = 1;
            this.gbMasters.TabStop = false;
            this.gbMasters.Text = "Мастера";
            // 
            // dgvMasters
            // 
            this.dgvMasters.AllowUserToAddRows = false;
            this.dgvMasters.AllowUserToDeleteRows = false;
            this.dgvMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workers_master_id,
            this.workers_master_name});
            this.dgvMasters.Location = new System.Drawing.Point(6, 24);
            this.dgvMasters.Name = "dgvMasters";
            this.dgvMasters.ReadOnly = true;
            this.dgvMasters.RowHeadersWidth = 51;
            this.dgvMasters.RowTemplate.Height = 24;
            this.dgvMasters.Size = new System.Drawing.Size(529, 206);
            this.dgvMasters.TabIndex = 0;
            // 
            // workers_master_id
            // 
            this.workers_master_id.HeaderText = "ID";
            this.workers_master_id.MinimumWidth = 6;
            this.workers_master_id.Name = "workers_master_id";
            this.workers_master_id.ReadOnly = true;
            this.workers_master_id.Width = 50;
            // 
            // workers_master_name
            // 
            this.workers_master_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workers_master_name.HeaderText = "ФИО";
            this.workers_master_name.MinimumWidth = 6;
            this.workers_master_name.Name = "workers_master_name";
            this.workers_master_name.ReadOnly = true;
            // 
            // cashRegisterPage
            // 
            this.cashRegisterPage.Controls.Add(this.lblSum);
            this.cashRegisterPage.Controls.Add(this.dgvCashRegisterRecords);
            this.cashRegisterPage.Controls.Add(this.panelDeleteCrRecord);
            this.cashRegisterPage.Controls.Add(this.panelAddCrRecord);
            this.cashRegisterPage.Location = new System.Drawing.Point(4, 26);
            this.cashRegisterPage.Name = "cashRegisterPage";
            this.cashRegisterPage.Size = new System.Drawing.Size(906, 535);
            this.cashRegisterPage.TabIndex = 3;
            this.cashRegisterPage.Text = "Касса";
            this.cashRegisterPage.UseVisualStyleBackColor = true;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(4, 510);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(55, 19);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "Сумма:";
            // 
            // dgvCashRegisterRecords
            // 
            this.dgvCashRegisterRecords.AllowUserToAddRows = false;
            this.dgvCashRegisterRecords.AllowUserToDeleteRows = false;
            this.dgvCashRegisterRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashRegisterRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_record_id,
            this.stock_record_date,
            this.stock_record_sum,
            this.stock_record_purpose_id,
            this.stock_record_operation_id,
            this.stock_record_note,
            this.cr_request_id});
            this.dgvCashRegisterRecords.Location = new System.Drawing.Point(8, 32);
            this.dgvCashRegisterRecords.MultiSelect = false;
            this.dgvCashRegisterRecords.Name = "dgvCashRegisterRecords";
            this.dgvCashRegisterRecords.RowHeadersWidth = 51;
            this.dgvCashRegisterRecords.RowTemplate.Height = 24;
            this.dgvCashRegisterRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashRegisterRecords.Size = new System.Drawing.Size(891, 475);
            this.dgvCashRegisterRecords.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Моя_мастерская.Properties.Resources.ellipsis_10337196;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(61, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 3;
            // 
            // panelDeleteRequest
            // 
            this.panelDeleteRequest.BackgroundImage = global::Моя_мастерская.Properties.Resources.delete_10337516;
            this.panelDeleteRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDeleteRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDeleteRequest.Location = new System.Drawing.Point(35, 6);
            this.panelDeleteRequest.Name = "panelDeleteRequest";
            this.panelDeleteRequest.Size = new System.Drawing.Size(20, 20);
            this.panelDeleteRequest.TabIndex = 2;
            this.panelDeleteRequest.Click += new System.EventHandler(this.panelDelete_Click);
            // 
            // panelAddRequest
            // 
            this.panelAddRequest.BackgroundImage = global::Моя_мастерская.Properties.Resources.add_10337420;
            this.panelAddRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAddRequest.Location = new System.Drawing.Point(9, 6);
            this.panelAddRequest.Name = "panelAddRequest";
            this.panelAddRequest.Size = new System.Drawing.Size(20, 20);
            this.panelAddRequest.TabIndex = 1;
            this.panelAddRequest.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panelDeleteCrRecord
            // 
            this.panelDeleteCrRecord.BackgroundImage = global::Моя_мастерская.Properties.Resources.delete_10337516;
            this.panelDeleteCrRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDeleteCrRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDeleteCrRecord.Location = new System.Drawing.Point(34, 6);
            this.panelDeleteCrRecord.Name = "panelDeleteCrRecord";
            this.panelDeleteCrRecord.Size = new System.Drawing.Size(20, 20);
            this.panelDeleteCrRecord.TabIndex = 5;
            this.panelDeleteCrRecord.Click += new System.EventHandler(this.panelDeleteCrRecord_Click);
            // 
            // panelAddCrRecord
            // 
            this.panelAddCrRecord.BackgroundImage = global::Моя_мастерская.Properties.Resources.add_10337420;
            this.panelAddCrRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddCrRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAddCrRecord.Location = new System.Drawing.Point(8, 6);
            this.panelAddCrRecord.Name = "panelAddCrRecord";
            this.panelAddCrRecord.Size = new System.Drawing.Size(20, 20);
            this.panelAddCrRecord.TabIndex = 4;
            this.panelAddCrRecord.Click += new System.EventHandler(this.panelAddCrRecord_Click);
            // 
            // stock_record_id
            // 
            this.stock_record_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock_record_id.HeaderText = "ID";
            this.stock_record_id.MinimumWidth = 6;
            this.stock_record_id.Name = "stock_record_id";
            this.stock_record_id.ReadOnly = true;
            this.stock_record_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_record_id.Width = 50;
            // 
            // stock_record_date
            // 
            this.stock_record_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_record_date.FillWeight = 26.27737F;
            this.stock_record_date.HeaderText = "Дата";
            this.stock_record_date.MinimumWidth = 6;
            this.stock_record_date.Name = "stock_record_date";
            this.stock_record_date.ReadOnly = true;
            // 
            // stock_record_sum
            // 
            this.stock_record_sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_record_sum.FillWeight = 26.27737F;
            this.stock_record_sum.HeaderText = "Сумма, руб.";
            this.stock_record_sum.MinimumWidth = 6;
            this.stock_record_sum.Name = "stock_record_sum";
            // 
            // stock_record_purpose_id
            // 
            this.stock_record_purpose_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_record_purpose_id.FillWeight = 26.27737F;
            this.stock_record_purpose_id.HeaderText = "Назначение";
            this.stock_record_purpose_id.MinimumWidth = 6;
            this.stock_record_purpose_id.Name = "stock_record_purpose_id";
            // 
            // stock_record_operation_id
            // 
            this.stock_record_operation_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_record_operation_id.FillWeight = 26.27737F;
            this.stock_record_operation_id.HeaderText = "Операция";
            this.stock_record_operation_id.MinimumWidth = 6;
            this.stock_record_operation_id.Name = "stock_record_operation_id";
            // 
            // stock_record_note
            // 
            this.stock_record_note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock_record_note.FillWeight = 468.6131F;
            this.stock_record_note.HeaderText = "Примечание";
            this.stock_record_note.MinimumWidth = 250;
            this.stock_record_note.Name = "stock_record_note";
            this.stock_record_note.Width = 300;
            // 
            // cr_request_id
            // 
            this.cr_request_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cr_request_id.FillWeight = 26.27737F;
            this.cr_request_id.HeaderText = "ID заявки";
            this.cr_request_id.MinimumWidth = 50;
            this.cr_request_id.Name = "cr_request_id";
            this.cr_request_id.ReadOnly = true;
            this.cr_request_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cr_request_id.Width = 50;
            // 
            // btnSalarySecretary
            // 
            this.btnSalarySecretary.Location = new System.Drawing.Point(10, 442);
            this.btnSalarySecretary.Name = "btnSalarySecretary";
            this.btnSalarySecretary.Size = new System.Drawing.Size(337, 32);
            this.btnSalarySecretary.TabIndex = 11;
            this.btnSalarySecretary.Text = "Приемщику";
            this.btnSalarySecretary.UseVisualStyleBackColor = true;
            this.btnSalarySecretary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 25);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(37, 411);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(310, 25);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "с";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "по";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Рассчитать зарплату";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteSecretary
            // 
            this.btnDeleteSecretary.Location = new System.Drawing.Point(10, 317);
            this.btnDeleteSecretary.Name = "btnDeleteSecretary";
            this.btnDeleteSecretary.Size = new System.Drawing.Size(337, 32);
            this.btnDeleteSecretary.TabIndex = 17;
            this.btnDeleteSecretary.Text = "Удалить приемщика";
            this.btnDeleteSecretary.UseVisualStyleBackColor = true;
            this.btnDeleteSecretary.Click += new System.EventHandler(this.btnDeleteSecretary_Click);
            // 
            // workers_user_id
            // 
            this.workers_user_id.HeaderText = "ID";
            this.workers_user_id.MinimumWidth = 6;
            this.workers_user_id.Name = "workers_user_id";
            this.workers_user_id.ReadOnly = true;
            this.workers_user_id.Width = 50;
            // 
            // user_login
            // 
            this.user_login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_login.HeaderText = "Логин";
            this.user_login.MinimumWidth = 6;
            this.user_login.Name = "user_login";
            this.user_login.ReadOnly = true;
            // 
            // user_password
            // 
            this.user_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_password.HeaderText = "Пароль";
            this.user_password.MinimumWidth = 6;
            this.user_password.Name = "user_password";
            this.user_password.ReadOnly = true;
            this.user_password.Visible = false;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "ФИО";
            this.user_name.MinimumWidth = 6;
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 250;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 589);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Моя мастерская";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.requestListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestsList)).EndInit();
            this.workersPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSecretaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretaries)).EndInit();
            this.gbMasters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasters)).EndInit();
            this.cashRegisterPage.ResumeLayout(false);
            this.cashRegisterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashRegisterRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage requestListPage;
        private System.Windows.Forms.DataGridView dgvRequestsList;
        public System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Panel panelAddRequest;
        private System.Windows.Forms.Panel panelDeleteRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage workersPage;
        private System.Windows.Forms.TabPage cashRegisterPage;
        private System.Windows.Forms.Panel panelDeleteCrRecord;
        private System.Windows.Forms.Panel panelAddCrRecord;
        private System.Windows.Forms.DataGridView dgvCashRegisterRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSecretaries;
        private System.Windows.Forms.DataGridView dgvSecretaries;
        private System.Windows.Forms.GroupBox gbMasters;
        private System.Windows.Forms.DataGridView dgvMasters;
        private System.Windows.Forms.Button btnDeleteMaster;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_acc_date;
        private System.Windows.Forms.DataGridViewComboBoxColumn device_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_fabricator;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_serial_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_phone;
        private System.Windows.Forms.DataGridViewComboBoxColumn request_status_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn master_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn workers_master_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn workers_master_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_record_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_record_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_record_sum;
        private System.Windows.Forms.DataGridViewComboBoxColumn stock_record_purpose_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn stock_record_operation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_record_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr_request_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSalarySecretary;
        private System.Windows.Forms.Button btnDeleteSecretary;
        private System.Windows.Forms.DataGridViewTextBoxColumn workers_user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
    }
}