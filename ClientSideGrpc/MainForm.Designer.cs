namespace ClientSideGrpc
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
            menuStrip1 = new MenuStrip();
            контрактыToolStripMenuItem = new ToolStripMenuItem();
            организацииToolStripMenuItem = new ToolStripMenuItem();
            вакцинацииToolStripMenuItem = new ToolStripMenuItem();
            осмотрыToolStripMenuItem = new ToolStripMenuItem();
            отчётОToolStripMenuItem = new ToolStripMenuItem();
            dataGrid = new DataGridView();
            ContractAdd = new Button();
            ContractRemove = new Button();
            ContractsGet = new Button();
            ContractEdit = new Button();
            OrganisationAdd = new Button();
            OrganisationRemove = new Button();
            OrganisationEdit = new Button();
            OrganisationsGet = new Button();
            VaccinationAdd = new Button();
            VaccinationRemove = new Button();
            VaccinationEdit = new Button();
            VaccinationsGet = new Button();
            InspectionAdd = new Button();
            InspectionRemove = new Button();
            InspectionEdit = new Button();
            InspectionsGet = new Button();
            labelLogin = new Label();
            labelPassword = new Label();
            textLogin = new TextBox();
            textPassword = new TextBox();
            buttonAuth = new Button();
            labelAuth = new Label();
            firstAtributeLabel = new Label();
            secondAtributeLabel = new Label();
            firstDate = new DateTimePicker();
            secondDate = new DateTimePicker();
            userSelection = new ComboBox();
            animalSelection = new ComboBox();
            contractSelection = new ComboBox();
            vaccineSelection = new ComboBox();
            thirdAtributeLabel = new Label();
            fourthAtributeLabel = new Label();
            fifthAtributeLabel = new Label();
            sixthAtributeLabel = new Label();
            currentProccedure = new Label();
            buttonOk = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { контрактыToolStripMenuItem, организацииToolStripMenuItem, вакцинацииToolStripMenuItem, осмотрыToolStripMenuItem, отчётОToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // контрактыToolStripMenuItem
            // 
            контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            контрактыToolStripMenuItem.Size = new Size(78, 20);
            контрактыToolStripMenuItem.Text = "Контракты";
            контрактыToolStripMenuItem.Click += ClickContractsShow;
            // 
            // организацииToolStripMenuItem
            // 
            организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            организацииToolStripMenuItem.Size = new Size(92, 20);
            организацииToolStripMenuItem.Text = "Организации";
            организацииToolStripMenuItem.Click += ClickOrganisationShow;
            // 
            // вакцинацииToolStripMenuItem
            // 
            вакцинацииToolStripMenuItem.Name = "вакцинацииToolStripMenuItem";
            вакцинацииToolStripMenuItem.Size = new Size(86, 20);
            вакцинацииToolStripMenuItem.Text = "Вакцинации";
            вакцинацииToolStripMenuItem.Click += ClickVaccinationShow;
            // 
            // осмотрыToolStripMenuItem
            // 
            осмотрыToolStripMenuItem.Name = "осмотрыToolStripMenuItem";
            осмотрыToolStripMenuItem.Size = new Size(71, 20);
            осмотрыToolStripMenuItem.Text = "Осмотры";
            осмотрыToolStripMenuItem.Click += ClickInspectionShow;
            // 
            // отчётОToolStripMenuItem
            // 
            отчётОToolStripMenuItem.Name = "отчётОToolStripMenuItem";
            отчётОToolStripMenuItem.Size = new Size(60, 20);
            отчётОToolStripMenuItem.Text = "Отчёты";
            отчётОToolStripMenuItem.Click += отчётОToolStripMenuItem_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Top;
            dataGrid.Location = new Point(0, 24);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.Size = new Size(800, 376);
            dataGrid.TabIndex = 1;
            dataGrid.Visible = false;
            // 
            // ContractAdd
            // 
            ContractAdd.Location = new Point(12, 406);
            ContractAdd.Name = "ContractAdd";
            ContractAdd.Size = new Size(145, 32);
            ContractAdd.TabIndex = 2;
            ContractAdd.Text = "Добавить";
            ContractAdd.UseVisualStyleBackColor = true;
            ContractAdd.Visible = false;
            ContractAdd.Click += ClickButtonAddContract;
            // 
            // ContractRemove
            // 
            ContractRemove.Location = new Point(163, 406);
            ContractRemove.Name = "ContractRemove";
            ContractRemove.Size = new Size(145, 32);
            ContractRemove.TabIndex = 3;
            ContractRemove.Text = "Удалить";
            ContractRemove.UseVisualStyleBackColor = true;
            ContractRemove.Visible = false;
            ContractRemove.Click += ClickButtonRemoveContract;
            // 
            // ContractsGet
            // 
            ContractsGet.Location = new Point(465, 406);
            ContractsGet.Name = "ContractsGet";
            ContractsGet.Size = new Size(145, 32);
            ContractsGet.TabIndex = 4;
            ContractsGet.Text = "Заполнить";
            ContractsGet.UseVisualStyleBackColor = true;
            ContractsGet.Visible = false;
            ContractsGet.Click += ClickButtonGetContracts;
            // 
            // ContractEdit
            // 
            ContractEdit.Location = new Point(314, 406);
            ContractEdit.Name = "ContractEdit";
            ContractEdit.Size = new Size(145, 32);
            ContractEdit.TabIndex = 5;
            ContractEdit.Text = "Изменить";
            ContractEdit.UseVisualStyleBackColor = true;
            ContractEdit.Visible = false;
            ContractEdit.Click += ClickButtonEditContract;
            // 
            // OrganisationAdd
            // 
            OrganisationAdd.Location = new Point(12, 406);
            OrganisationAdd.Name = "OrganisationAdd";
            OrganisationAdd.Size = new Size(145, 32);
            OrganisationAdd.TabIndex = 6;
            OrganisationAdd.Text = "Добавить";
            OrganisationAdd.UseVisualStyleBackColor = true;
            OrganisationAdd.Visible = false;
            OrganisationAdd.Click += ClickButtonAddOrganisation;
            // 
            // OrganisationRemove
            // 
            OrganisationRemove.Location = new Point(163, 406);
            OrganisationRemove.Name = "OrganisationRemove";
            OrganisationRemove.Size = new Size(145, 32);
            OrganisationRemove.TabIndex = 7;
            OrganisationRemove.Text = "Удалить";
            OrganisationRemove.UseVisualStyleBackColor = true;
            OrganisationRemove.Visible = false;
            OrganisationRemove.Click += ClickButtonRemoveOrganisation;
            // 
            // OrganisationEdit
            // 
            OrganisationEdit.Location = new Point(314, 406);
            OrganisationEdit.Name = "OrganisationEdit";
            OrganisationEdit.Size = new Size(145, 32);
            OrganisationEdit.TabIndex = 8;
            OrganisationEdit.Text = "Изменить";
            OrganisationEdit.UseVisualStyleBackColor = true;
            OrganisationEdit.Visible = false;
            OrganisationEdit.Click += ClickButtonEditOrganisation;
            // 
            // OrganisationsGet
            // 
            OrganisationsGet.Location = new Point(465, 406);
            OrganisationsGet.Name = "OrganisationsGet";
            OrganisationsGet.Size = new Size(145, 32);
            OrganisationsGet.TabIndex = 9;
            OrganisationsGet.Text = "Заполнить";
            OrganisationsGet.UseVisualStyleBackColor = true;
            OrganisationsGet.Visible = false;
            // 
            // VaccinationAdd
            // 
            VaccinationAdd.Location = new Point(12, 406);
            VaccinationAdd.Name = "VaccinationAdd";
            VaccinationAdd.Size = new Size(145, 32);
            VaccinationAdd.TabIndex = 10;
            VaccinationAdd.Text = "Добавить";
            VaccinationAdd.UseVisualStyleBackColor = true;
            VaccinationAdd.Visible = false;
            VaccinationAdd.Click += ClickButtonAddVaccination;
            // 
            // VaccinationRemove
            // 
            VaccinationRemove.Location = new Point(163, 406);
            VaccinationRemove.Name = "VaccinationRemove";
            VaccinationRemove.Size = new Size(145, 32);
            VaccinationRemove.TabIndex = 11;
            VaccinationRemove.Text = "Удалить";
            VaccinationRemove.UseVisualStyleBackColor = true;
            VaccinationRemove.Visible = false;
            VaccinationRemove.Click += ClickButtonRemoveVaccination;
            // 
            // VaccinationEdit
            // 
            VaccinationEdit.Location = new Point(314, 406);
            VaccinationEdit.Name = "VaccinationEdit";
            VaccinationEdit.Size = new Size(145, 32);
            VaccinationEdit.TabIndex = 12;
            VaccinationEdit.Text = "Изменить";
            VaccinationEdit.UseVisualStyleBackColor = true;
            VaccinationEdit.Visible = false;
            VaccinationEdit.Click += ClickButtonEditVaccination;
            // 
            // VaccinationsGet
            // 
            VaccinationsGet.Location = new Point(465, 406);
            VaccinationsGet.Name = "VaccinationsGet";
            VaccinationsGet.Size = new Size(145, 32);
            VaccinationsGet.TabIndex = 13;
            VaccinationsGet.Text = "Заполнить";
            VaccinationsGet.UseVisualStyleBackColor = true;
            VaccinationsGet.Visible = false;
            VaccinationsGet.Click += ClickButtonGetVaccinations;
            // 
            // InspectionAdd
            // 
            InspectionAdd.Location = new Point(12, 406);
            InspectionAdd.Name = "InspectionAdd";
            InspectionAdd.Size = new Size(145, 32);
            InspectionAdd.TabIndex = 14;
            InspectionAdd.Text = "Добавить";
            InspectionAdd.UseVisualStyleBackColor = true;
            InspectionAdd.Visible = false;
            InspectionAdd.Click += ClickButtonAddInspection;
            // 
            // InspectionRemove
            // 
            InspectionRemove.Location = new Point(163, 406);
            InspectionRemove.Name = "InspectionRemove";
            InspectionRemove.Size = new Size(145, 32);
            InspectionRemove.TabIndex = 15;
            InspectionRemove.Text = "Удалить";
            InspectionRemove.UseVisualStyleBackColor = true;
            InspectionRemove.Visible = false;
            InspectionRemove.Click += ClickButtonRemoveInspection;
            // 
            // InspectionEdit
            // 
            InspectionEdit.Location = new Point(314, 406);
            InspectionEdit.Name = "InspectionEdit";
            InspectionEdit.Size = new Size(145, 32);
            InspectionEdit.TabIndex = 16;
            InspectionEdit.Text = "Изменить";
            InspectionEdit.UseVisualStyleBackColor = true;
            InspectionEdit.Visible = false;
            InspectionEdit.Click += ClickButtonEditInspection;
            // 
            // InspectionsGet
            // 
            InspectionsGet.Location = new Point(465, 406);
            InspectionsGet.Name = "InspectionsGet";
            InspectionsGet.Size = new Size(145, 32);
            InspectionsGet.TabIndex = 17;
            InspectionsGet.Text = "Заполнить";
            InspectionsGet.UseVisualStyleBackColor = true;
            InspectionsGet.Visible = false;
            InspectionsGet.Click += ClickButtonGetInspections;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(31, 64);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(44, 15);
            labelLogin.TabIndex = 18;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(31, 87);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(52, 15);
            labelPassword.TabIndex = 19;
            labelPassword.Text = "Пароль:";
            // 
            // textLogin
            // 
            textLogin.Location = new Point(84, 61);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(100, 23);
            textLogin.TabIndex = 20;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(84, 84);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 21;
            // 
            // buttonAuth
            // 
            buttonAuth.Location = new Point(34, 110);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(141, 23);
            buttonAuth.TabIndex = 22;
            buttonAuth.Text = "Войти";
            buttonAuth.UseVisualStyleBackColor = true;
            buttonAuth.Click += Authorize;
            // 
            // labelAuth
            // 
            labelAuth.AutoSize = true;
            labelAuth.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAuth.Location = new Point(46, 24);
            labelAuth.Name = "labelAuth";
            labelAuth.Size = new Size(129, 24);
            labelAuth.TabIndex = 23;
            labelAuth.Text = "Авторизация";
            // 
            // firstAtributeLabel
            // 
            firstAtributeLabel.AutoSize = true;
            firstAtributeLabel.Location = new Point(237, 79);
            firstAtributeLabel.Name = "firstAtributeLabel";
            firstAtributeLabel.Size = new Size(104, 15);
            firstAtributeLabel.TabIndex = 26;
            firstAtributeLabel.Text = "Дата вакцинации:";
            firstAtributeLabel.Visible = false;
            // 
            // secondAtributeLabel
            // 
            secondAtributeLabel.AutoSize = true;
            secondAtributeLabel.Location = new Point(224, 108);
            secondAtributeLabel.Name = "secondAtributeLabel";
            secondAtributeLabel.Size = new Size(117, 15);
            secondAtributeLabel.TabIndex = 27;
            secondAtributeLabel.Text = "Дата ревакцинации:";
            secondAtributeLabel.Visible = false;
            // 
            // firstDate
            // 
            firstDate.Location = new Point(347, 79);
            firstDate.Name = "firstDate";
            firstDate.Size = new Size(200, 23);
            firstDate.TabIndex = 30;
            firstDate.Visible = false;
            // 
            // secondDate
            // 
            secondDate.Location = new Point(347, 108);
            secondDate.Name = "secondDate";
            secondDate.Size = new Size(200, 23);
            secondDate.TabIndex = 31;
            secondDate.Visible = false;
            // 
            // userSelection
            // 
            userSelection.FormattingEnabled = true;
            userSelection.Location = new Point(347, 137);
            userSelection.Name = "userSelection";
            userSelection.Size = new Size(200, 23);
            userSelection.TabIndex = 32;
            userSelection.Visible = false;
            // 
            // animalSelection
            // 
            animalSelection.FormattingEnabled = true;
            animalSelection.Location = new Point(347, 166);
            animalSelection.Name = "animalSelection";
            animalSelection.Size = new Size(200, 23);
            animalSelection.TabIndex = 33;
            animalSelection.Visible = false;
            // 
            // contractSelection
            // 
            contractSelection.FormattingEnabled = true;
            contractSelection.Location = new Point(347, 195);
            contractSelection.Name = "contractSelection";
            contractSelection.Size = new Size(200, 23);
            contractSelection.TabIndex = 34;
            contractSelection.Visible = false;
            // 
            // vaccineSelection
            // 
            vaccineSelection.FormattingEnabled = true;
            vaccineSelection.Location = new Point(347, 224);
            vaccineSelection.Name = "vaccineSelection";
            vaccineSelection.Size = new Size(200, 23);
            vaccineSelection.TabIndex = 35;
            vaccineSelection.Visible = false;
            // 
            // thirdAtributeLabel
            // 
            thirdAtributeLabel.AutoSize = true;
            thirdAtributeLabel.Location = new Point(287, 137);
            thirdAtributeLabel.Name = "thirdAtributeLabel";
            thirdAtributeLabel.Size = new Size(54, 15);
            thirdAtributeLabel.TabIndex = 36;
            thirdAtributeLabel.Text = "Ветврач:";
            thirdAtributeLabel.Visible = false;
            // 
            // fourthAtributeLabel
            // 
            fourthAtributeLabel.AutoSize = true;
            fourthAtributeLabel.Location = new Point(275, 166);
            fourthAtributeLabel.Name = "fourthAtributeLabel";
            fourthAtributeLabel.Size = new Size(66, 15);
            fourthAtributeLabel.TabIndex = 37;
            fourthAtributeLabel.Text = "Животное:";
            fourthAtributeLabel.Visible = false;
            // 
            // fifthAtributeLabel
            // 
            fifthAtributeLabel.AutoSize = true;
            fifthAtributeLabel.Location = new Point(281, 195);
            fifthAtributeLabel.Name = "fifthAtributeLabel";
            fifthAtributeLabel.Size = new Size(60, 15);
            fifthAtributeLabel.TabIndex = 38;
            fifthAtributeLabel.Text = "Контракт:";
            fifthAtributeLabel.Visible = false;
            // 
            // sixthAtributeLabel
            // 
            sixthAtributeLabel.AutoSize = true;
            sixthAtributeLabel.Location = new Point(285, 224);
            sixthAtributeLabel.Name = "sixthAtributeLabel";
            sixthAtributeLabel.Size = new Size(56, 15);
            sixthAtributeLabel.TabIndex = 39;
            sixthAtributeLabel.Text = "Вакцина:";
            sixthAtributeLabel.Visible = false;
            // 
            // currentProccedure
            // 
            currentProccedure.AutoSize = true;
            currentProccedure.Font = new Font("Segoe UI", 16F);
            currentProccedure.Location = new Point(314, 37);
            currentProccedure.Name = "currentProccedure";
            currentProccedure.Size = new Size(139, 30);
            currentProccedure.TabIndex = 40;
            currentProccedure.Text = "Добавление";
            currentProccedure.Visible = false;
            // 
            // buttonOk
            // 
            buttonOk.Font = new Font("Segoe UI", 12F);
            buttonOk.Location = new Point(347, 253);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(200, 32);
            buttonOk.TabIndex = 41;
            buttonOk.Text = "Подтвердить";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Visible = false;
            buttonOk.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk);
            Controls.Add(currentProccedure);
            Controls.Add(sixthAtributeLabel);
            Controls.Add(fifthAtributeLabel);
            Controls.Add(fourthAtributeLabel);
            Controls.Add(thirdAtributeLabel);
            Controls.Add(vaccineSelection);
            Controls.Add(contractSelection);
            Controls.Add(animalSelection);
            Controls.Add(userSelection);
            Controls.Add(secondDate);
            Controls.Add(firstDate);
            Controls.Add(secondAtributeLabel);
            Controls.Add(firstAtributeLabel);
            Controls.Add(labelAuth);
            Controls.Add(buttonAuth);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(InspectionsGet);
            Controls.Add(InspectionEdit);
            Controls.Add(InspectionRemove);
            Controls.Add(InspectionAdd);
            Controls.Add(VaccinationsGet);
            Controls.Add(VaccinationEdit);
            Controls.Add(VaccinationRemove);
            Controls.Add(VaccinationAdd);
            Controls.Add(OrganisationsGet);
            Controls.Add(OrganisationEdit);
            Controls.Add(OrganisationRemove);
            Controls.Add(OrganisationAdd);
            Controls.Add(ContractEdit);
            Controls.Add(ContractsGet);
            Controls.Add(ContractRemove);
            Controls.Add(ContractAdd);
            Controls.Add(dataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Главная форма";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label firstAtributeLabel;
        private Label secondAtributeLabel;
        private DateTimePicker firstDate;
        private DateTimePicker secondDate;
        private ComboBox userSelection;
        private ComboBox animalSelection;
        private ComboBox contractSelection;
        private ComboBox vaccineSelection;
        private Label thirdAtributeLabel;
        private Label fourthAtributeLabel;
        private Label fifthAtributeLabel;
        private Label sixthAtributeLabel;
        private Label currentProccedure;
        private Button buttonOk;
    }
}