namespace ClietnSide
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вакцинацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осмотрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ContractAdd = new System.Windows.Forms.Button();
            this.ContractRemove = new System.Windows.Forms.Button();
            this.ContractsGet = new System.Windows.Forms.Button();
            this.ContractEdit = new System.Windows.Forms.Button();
            this.OrganisationAdd = new System.Windows.Forms.Button();
            this.OrganisationRemove = new System.Windows.Forms.Button();
            this.OrganisationEdit = new System.Windows.Forms.Button();
            this.OrganisationsGet = new System.Windows.Forms.Button();
            this.VaccinationAdd = new System.Windows.Forms.Button();
            this.VaccinationRemove = new System.Windows.Forms.Button();
            this.VaccinationEdit = new System.Windows.Forms.Button();
            this.VaccinationsGet = new System.Windows.Forms.Button();
            this.InspectionAdd = new System.Windows.Forms.Button();
            this.InspectionRemove = new System.Windows.Forms.Button();
            this.InspectionEdit = new System.Windows.Forms.Button();
            this.InspectionsGet = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрактыToolStripMenuItem,
            this.организацииToolStripMenuItem,
            this.вакцинацииToolStripMenuItem,
            this.осмотрыToolStripMenuItem,
            this.отчётОToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            this.контрактыToolStripMenuItem.Click += new System.EventHandler(this.ClickContractsShow);
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.организацииToolStripMenuItem.Text = "Организации";
            this.организацииToolStripMenuItem.Click += new System.EventHandler(this.ClickOrganisationShow);
            // 
            // вакцинацииToolStripMenuItem
            // 
            this.вакцинацииToolStripMenuItem.Name = "вакцинацииToolStripMenuItem";
            this.вакцинацииToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.вакцинацииToolStripMenuItem.Text = "Вакцинации";
            this.вакцинацииToolStripMenuItem.Click += new System.EventHandler(this.ClickVaccinationShow);
            // 
            // осмотрыToolStripMenuItem
            // 
            this.осмотрыToolStripMenuItem.Name = "осмотрыToolStripMenuItem";
            this.осмотрыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.осмотрыToolStripMenuItem.Text = "Осмотры";
            this.осмотрыToolStripMenuItem.Click += new System.EventHandler(this.ClickInspectionShow);
            // 
            // отчётОToolStripMenuItem
            // 
            this.отчётОToolStripMenuItem.Name = "отчётОToolStripMenuItem";
            this.отчётОToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётОToolStripMenuItem.Text = "Отчёты";
            this.отчётОToolStripMenuItem.Click += new System.EventHandler(this.отчётОToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(800, 376);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.Visible = false;
            // 
            // ContractAdd
            // 
            this.ContractAdd.Location = new System.Drawing.Point(12, 406);
            this.ContractAdd.Name = "ContractAdd";
            this.ContractAdd.Size = new System.Drawing.Size(145, 32);
            this.ContractAdd.TabIndex = 2;
            this.ContractAdd.Text = "Добавить";
            this.ContractAdd.UseVisualStyleBackColor = true;
            this.ContractAdd.Visible = false;
            this.ContractAdd.Click += new System.EventHandler(this.ClickButtonAddContract);
            // 
            // ContractRemove
            // 
            this.ContractRemove.Location = new System.Drawing.Point(163, 406);
            this.ContractRemove.Name = "ContractRemove";
            this.ContractRemove.Size = new System.Drawing.Size(145, 32);
            this.ContractRemove.TabIndex = 3;
            this.ContractRemove.Text = "Удалить";
            this.ContractRemove.UseVisualStyleBackColor = true;
            this.ContractRemove.Visible = false;
            this.ContractRemove.Click += new System.EventHandler(this.ClickButtonRemoveContract);
            // 
            // ContractsGet
            // 
            this.ContractsGet.Location = new System.Drawing.Point(465, 406);
            this.ContractsGet.Name = "ContractsGet";
            this.ContractsGet.Size = new System.Drawing.Size(145, 32);
            this.ContractsGet.TabIndex = 4;
            this.ContractsGet.Text = "Заполнить";
            this.ContractsGet.UseVisualStyleBackColor = true;
            this.ContractsGet.Visible = false;
            this.ContractsGet.Click += new System.EventHandler(this.ClickButtonGetContracts);
            // 
            // ContractEdit
            // 
            this.ContractEdit.Location = new System.Drawing.Point(314, 406);
            this.ContractEdit.Name = "ContractEdit";
            this.ContractEdit.Size = new System.Drawing.Size(145, 32);
            this.ContractEdit.TabIndex = 5;
            this.ContractEdit.Text = "Изменить";
            this.ContractEdit.UseVisualStyleBackColor = true;
            this.ContractEdit.Visible = false;
            this.ContractEdit.Click += new System.EventHandler(this.ClickButtonEditContract);
            // 
            // OrganisationAdd
            // 
            this.OrganisationAdd.Location = new System.Drawing.Point(12, 406);
            this.OrganisationAdd.Name = "OrganisationAdd";
            this.OrganisationAdd.Size = new System.Drawing.Size(145, 32);
            this.OrganisationAdd.TabIndex = 6;
            this.OrganisationAdd.Text = "Добавить";
            this.OrganisationAdd.UseVisualStyleBackColor = true;
            this.OrganisationAdd.Visible = false;
            this.OrganisationAdd.Click += new System.EventHandler(this.ClickButtonAddOrganisation);
            // 
            // OrganisationRemove
            // 
            this.OrganisationRemove.Location = new System.Drawing.Point(163, 406);
            this.OrganisationRemove.Name = "OrganisationRemove";
            this.OrganisationRemove.Size = new System.Drawing.Size(145, 32);
            this.OrganisationRemove.TabIndex = 7;
            this.OrganisationRemove.Text = "Удалить";
            this.OrganisationRemove.UseVisualStyleBackColor = true;
            this.OrganisationRemove.Visible = false;
            this.OrganisationRemove.Click += new System.EventHandler(this.ClickButtonRemoveOrganisation);
            // 
            // OrganisationEdit
            // 
            this.OrganisationEdit.Location = new System.Drawing.Point(314, 406);
            this.OrganisationEdit.Name = "OrganisationEdit";
            this.OrganisationEdit.Size = new System.Drawing.Size(145, 32);
            this.OrganisationEdit.TabIndex = 8;
            this.OrganisationEdit.Text = "Изменить";
            this.OrganisationEdit.UseVisualStyleBackColor = true;
            this.OrganisationEdit.Visible = false;
            this.OrganisationEdit.Click += new System.EventHandler(this.ClickButtonEditOrganisation);
            // 
            // OrganisationsGet
            // 
            this.OrganisationsGet.Location = new System.Drawing.Point(465, 406);
            this.OrganisationsGet.Name = "OrganisationsGet";
            this.OrganisationsGet.Size = new System.Drawing.Size(145, 32);
            this.OrganisationsGet.TabIndex = 9;
            this.OrganisationsGet.Text = "Заполнить";
            this.OrganisationsGet.UseVisualStyleBackColor = true;
            this.OrganisationsGet.Visible = false;
            // 
            // VaccinationAdd
            // 
            this.VaccinationAdd.Location = new System.Drawing.Point(12, 406);
            this.VaccinationAdd.Name = "VaccinationAdd";
            this.VaccinationAdd.Size = new System.Drawing.Size(145, 32);
            this.VaccinationAdd.TabIndex = 10;
            this.VaccinationAdd.Text = "Добавить";
            this.VaccinationAdd.UseVisualStyleBackColor = true;
            this.VaccinationAdd.Visible = false;
            this.VaccinationAdd.Click += new System.EventHandler(this.ClickButtonAddVaccination);
            // 
            // VaccinationRemove
            // 
            this.VaccinationRemove.Location = new System.Drawing.Point(163, 406);
            this.VaccinationRemove.Name = "VaccinationRemove";
            this.VaccinationRemove.Size = new System.Drawing.Size(145, 32);
            this.VaccinationRemove.TabIndex = 11;
            this.VaccinationRemove.Text = "Удалить";
            this.VaccinationRemove.UseVisualStyleBackColor = true;
            this.VaccinationRemove.Visible = false;
            this.VaccinationRemove.Click += new System.EventHandler(this.ClickButtonRemoveVaccination);
            // 
            // VaccinationEdit
            // 
            this.VaccinationEdit.Location = new System.Drawing.Point(314, 406);
            this.VaccinationEdit.Name = "VaccinationEdit";
            this.VaccinationEdit.Size = new System.Drawing.Size(145, 32);
            this.VaccinationEdit.TabIndex = 12;
            this.VaccinationEdit.Text = "Изменить";
            this.VaccinationEdit.UseVisualStyleBackColor = true;
            this.VaccinationEdit.Visible = false;
            this.VaccinationEdit.Click += new System.EventHandler(this.ClickButtonEditVaccination);
            // 
            // VaccinationsGet
            // 
            this.VaccinationsGet.Location = new System.Drawing.Point(465, 406);
            this.VaccinationsGet.Name = "VaccinationsGet";
            this.VaccinationsGet.Size = new System.Drawing.Size(145, 32);
            this.VaccinationsGet.TabIndex = 13;
            this.VaccinationsGet.Text = "Заполнить";
            this.VaccinationsGet.UseVisualStyleBackColor = true;
            this.VaccinationsGet.Visible = false;
            this.VaccinationsGet.Click += new System.EventHandler(this.ClickButtonGetVaccinations);
            // 
            // InspectionAdd
            // 
            this.InspectionAdd.Location = new System.Drawing.Point(12, 406);
            this.InspectionAdd.Name = "InspectionAdd";
            this.InspectionAdd.Size = new System.Drawing.Size(145, 32);
            this.InspectionAdd.TabIndex = 14;
            this.InspectionAdd.Text = "Добавить";
            this.InspectionAdd.UseVisualStyleBackColor = true;
            this.InspectionAdd.Visible = false;
            this.InspectionAdd.Click += new System.EventHandler(this.ClickButtonAddInspection);
            // 
            // InspectionRemove
            // 
            this.InspectionRemove.Location = new System.Drawing.Point(163, 406);
            this.InspectionRemove.Name = "InspectionRemove";
            this.InspectionRemove.Size = new System.Drawing.Size(145, 32);
            this.InspectionRemove.TabIndex = 15;
            this.InspectionRemove.Text = "Удалить";
            this.InspectionRemove.UseVisualStyleBackColor = true;
            this.InspectionRemove.Visible = false;
            this.InspectionRemove.Click += new System.EventHandler(this.ClickButtonRemoveInspection);
            // 
            // InspectionEdit
            // 
            this.InspectionEdit.Location = new System.Drawing.Point(314, 406);
            this.InspectionEdit.Name = "InspectionEdit";
            this.InspectionEdit.Size = new System.Drawing.Size(145, 32);
            this.InspectionEdit.TabIndex = 16;
            this.InspectionEdit.Text = "Изменить";
            this.InspectionEdit.UseVisualStyleBackColor = true;
            this.InspectionEdit.Visible = false;
            this.InspectionEdit.Click += new System.EventHandler(this.ClickButtonEditInspection);
            // 
            // InspectionsGet
            // 
            this.InspectionsGet.Location = new System.Drawing.Point(465, 406);
            this.InspectionsGet.Name = "InspectionsGet";
            this.InspectionsGet.Size = new System.Drawing.Size(145, 32);
            this.InspectionsGet.TabIndex = 17;
            this.InspectionsGet.Text = "Заполнить";
            this.InspectionsGet.UseVisualStyleBackColor = true;
            this.InspectionsGet.Visible = false;
            this.InspectionsGet.Click += new System.EventHandler(this.ClickButtonGetInspections);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(31, 64);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(31, 87);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Пароль:";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(84, 61);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 20;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(84, 84);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 21;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(34, 110);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(141, 23);
            this.buttonAuth.TabIndex = 22;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.Authorize);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(46, 24);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(129, 24);
            this.labelAuth.TabIndex = 23;
            this.labelAuth.Text = "Авторизация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.InspectionsGet);
            this.Controls.Add(this.InspectionEdit);
            this.Controls.Add(this.InspectionRemove);
            this.Controls.Add(this.InspectionAdd);
            this.Controls.Add(this.VaccinationsGet);
            this.Controls.Add(this.VaccinationEdit);
            this.Controls.Add(this.VaccinationRemove);
            this.Controls.Add(this.VaccinationAdd);
            this.Controls.Add(this.OrganisationsGet);
            this.Controls.Add(this.OrganisationEdit);
            this.Controls.Add(this.OrganisationRemove);
            this.Controls.Add(this.OrganisationAdd);
            this.Controls.Add(this.ContractEdit);
            this.Controls.Add(this.ContractsGet);
            this.Controls.Add(this.ContractRemove);
            this.Controls.Add(this.ContractAdd);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вакцинацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осмотрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётОToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button ContractAdd;
        private System.Windows.Forms.Button ContractRemove;
        private System.Windows.Forms.Button ContractsGet;
        private System.Windows.Forms.Button ContractEdit;
        private System.Windows.Forms.Button OrganisationAdd;
        private System.Windows.Forms.Button OrganisationRemove;
        private System.Windows.Forms.Button OrganisationEdit;
        private System.Windows.Forms.Button OrganisationsGet;
        private System.Windows.Forms.Button VaccinationAdd;
        private System.Windows.Forms.Button VaccinationRemove;
        private System.Windows.Forms.Button VaccinationEdit;
        private System.Windows.Forms.Button VaccinationsGet;
        private System.Windows.Forms.Button InspectionAdd;
        private System.Windows.Forms.Button InspectionRemove;
        private System.Windows.Forms.Button InspectionEdit;
        private System.Windows.Forms.Button InspectionsGet;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Label labelAuth;
    }
}