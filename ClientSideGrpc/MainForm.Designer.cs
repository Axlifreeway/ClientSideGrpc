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
            buttonSubmitVaccination = new Button();
            buttonCancel = new Button();
            labelIndex = new Label();
            featureBehavior = new TextBox();
            AnimalCondition = new TextBox();
            Temperature = new TextBox();
            NeedOperations = new RadioButton();
            Skin = new TextBox();
            Fur = new TextBox();
            Manipulations = new TextBox();
            Treatment = new TextBox();
            InspectionDate = new DateTimePicker();
            Injuries = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            OrganTin = new TextBox();
            OrganTrc = new TextBox();
            OrgName = new TextBox();
            OrgType = new TextBox();
            OrgFeature = new TextBox();
            OrgLoclity = new ComboBox();
            buttonSubmitOrganisaiton = new Button();
            ButtonSubmitContract = new Button();
            buttonSumbitInsection = new Button();
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
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Top;
            dataGrid.Location = new Point(0, 24);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            OrganisationsGet.Click += ClickButtonGetOrganisations;
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
            firstAtributeLabel.Location = new Point(34, 79);
            firstAtributeLabel.Name = "firstAtributeLabel";
            firstAtributeLabel.Size = new Size(159, 15);
            firstAtributeLabel.TabIndex = 26;
            firstAtributeLabel.Text = "Дата вакцинации:";
            firstAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            firstAtributeLabel.Visible = false;
            // 
            // secondAtributeLabel
            // 
            secondAtributeLabel.Location = new Point(31, 108);
            secondAtributeLabel.Name = "secondAtributeLabel";
            secondAtributeLabel.Size = new Size(162, 15);
            secondAtributeLabel.TabIndex = 27;
            secondAtributeLabel.Text = "Дата ревакцинации:";
            secondAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            secondAtributeLabel.Visible = false;
            // 
            // firstDate
            // 
            firstDate.Location = new Point(199, 79);
            firstDate.Name = "firstDate";
            firstDate.Size = new Size(200, 23);
            firstDate.TabIndex = 30;
            firstDate.Visible = false;
            // 
            // secondDate
            // 
            secondDate.Location = new Point(199, 108);
            secondDate.Name = "secondDate";
            secondDate.Size = new Size(200, 23);
            secondDate.TabIndex = 31;
            secondDate.Visible = false;
            // 
            // userSelection
            // 
            userSelection.FormattingEnabled = true;
            userSelection.Location = new Point(199, 137);
            userSelection.Name = "userSelection";
            userSelection.Size = new Size(200, 23);
            userSelection.TabIndex = 32;
            userSelection.Visible = false;
            // 
            // animalSelection
            // 
            animalSelection.FormattingEnabled = true;
            animalSelection.Location = new Point(199, 166);
            animalSelection.Name = "animalSelection";
            animalSelection.Size = new Size(200, 23);
            animalSelection.TabIndex = 33;
            animalSelection.Visible = false;
            // 
            // contractSelection
            // 
            contractSelection.FormattingEnabled = true;
            contractSelection.Location = new Point(199, 195);
            contractSelection.Name = "contractSelection";
            contractSelection.Size = new Size(200, 23);
            contractSelection.TabIndex = 34;
            contractSelection.Visible = false;
            // 
            // vaccineSelection
            // 
            vaccineSelection.FormattingEnabled = true;
            vaccineSelection.Location = new Point(199, 224);
            vaccineSelection.Name = "vaccineSelection";
            vaccineSelection.Size = new Size(200, 23);
            vaccineSelection.TabIndex = 35;
            vaccineSelection.Visible = false;
            // 
            // thirdAtributeLabel
            // 
            thirdAtributeLabel.Location = new Point(31, 136);
            thirdAtributeLabel.Name = "thirdAtributeLabel";
            thirdAtributeLabel.Size = new Size(162, 15);
            thirdAtributeLabel.TabIndex = 36;
            thirdAtributeLabel.Text = "Ветврач:";
            thirdAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            thirdAtributeLabel.Visible = false;
            // 
            // fourthAtributeLabel
            // 
            fourthAtributeLabel.Location = new Point(31, 166);
            fourthAtributeLabel.Name = "fourthAtributeLabel";
            fourthAtributeLabel.Size = new Size(162, 15);
            fourthAtributeLabel.TabIndex = 37;
            fourthAtributeLabel.Text = "Животное:";
            fourthAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            fourthAtributeLabel.Visible = false;
            // 
            // fifthAtributeLabel
            // 
            fifthAtributeLabel.Location = new Point(34, 195);
            fifthAtributeLabel.Name = "fifthAtributeLabel";
            fifthAtributeLabel.Size = new Size(159, 15);
            fifthAtributeLabel.TabIndex = 38;
            fifthAtributeLabel.Text = "Контракт:";
            fifthAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            fifthAtributeLabel.Visible = false;
            // 
            // sixthAtributeLabel
            // 
            sixthAtributeLabel.Location = new Point(34, 224);
            sixthAtributeLabel.Name = "sixthAtributeLabel";
            sixthAtributeLabel.Size = new Size(161, 15);
            sixthAtributeLabel.TabIndex = 39;
            sixthAtributeLabel.Text = "Вакцина:";
            sixthAtributeLabel.TextAlign = ContentAlignment.MiddleRight;
            sixthAtributeLabel.Visible = false;
            // 
            // currentProccedure
            // 
            currentProccedure.AutoSize = true;
            currentProccedure.Font = new Font("Segoe UI", 16F);
            currentProccedure.Location = new Point(251, 37);
            currentProccedure.Name = "currentProccedure";
            currentProccedure.Size = new Size(268, 30);
            currentProccedure.TabIndex = 40;
            currentProccedure.Text = "Добавление вакцинации";
            currentProccedure.Visible = false;
            // 
            // buttonSubmitVaccination
            // 
            buttonSubmitVaccination.Font = new Font("Segoe UI", 12F);
            buttonSubmitVaccination.Location = new Point(199, 253);
            buttonSubmitVaccination.Name = "buttonSubmitVaccination";
            buttonSubmitVaccination.Size = new Size(200, 32);
            buttonSubmitVaccination.TabIndex = 41;
            buttonSubmitVaccination.Text = "Подтвердить";
            buttonSubmitVaccination.UseVisualStyleBackColor = true;
            buttonSubmitVaccination.Visible = false;
            buttonSubmitVaccination.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(81, 253);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 32);
            buttonCancel.TabIndex = 42;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(199, 79);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(17, 15);
            labelIndex.TabIndex = 43;
            labelIndex.Text = "Id";
            labelIndex.Visible = false;
            // 
            // featureBehavior
            // 
            featureBehavior.Location = new Point(199, 79);
            featureBehavior.Name = "featureBehavior";
            featureBehavior.Size = new Size(200, 23);
            featureBehavior.TabIndex = 44;
            featureBehavior.Visible = false;
            // 
            // AnimalCondition
            // 
            AnimalCondition.Location = new Point(199, 108);
            AnimalCondition.Name = "AnimalCondition";
            AnimalCondition.Size = new Size(200, 23);
            AnimalCondition.TabIndex = 45;
            AnimalCondition.Visible = false;
            // 
            // Temperature
            // 
            Temperature.Location = new Point(588, 79);
            Temperature.Name = "Temperature";
            Temperature.Size = new Size(200, 23);
            Temperature.TabIndex = 46;
            Temperature.Visible = false;
            // 
            // NeedOperations
            // 
            NeedOperations.AutoSize = true;
            NeedOperations.Location = new Point(636, 166);
            NeedOperations.Name = "NeedOperations";
            NeedOperations.Size = new Size(112, 19);
            NeedOperations.TabIndex = 47;
            NeedOperations.TabStop = true;
            NeedOperations.Text = "Нужно лечение";
            NeedOperations.UseVisualStyleBackColor = true;
            NeedOperations.Visible = false;
            // 
            // Skin
            // 
            Skin.Location = new Point(588, 108);
            Skin.Name = "Skin";
            Skin.Size = new Size(200, 23);
            Skin.TabIndex = 48;
            Skin.Visible = false;
            // 
            // Fur
            // 
            Fur.Location = new Point(588, 137);
            Fur.Name = "Fur";
            Fur.Size = new Size(200, 23);
            Fur.TabIndex = 49;
            Fur.Visible = false;
            // 
            // Manipulations
            // 
            Manipulations.Location = new Point(588, 191);
            Manipulations.Name = "Manipulations";
            Manipulations.Size = new Size(200, 23);
            Manipulations.TabIndex = 50;
            Manipulations.Visible = false;
            // 
            // Treatment
            // 
            Treatment.Location = new Point(588, 221);
            Treatment.Name = "Treatment";
            Treatment.Size = new Size(200, 23);
            Treatment.TabIndex = 51;
            Treatment.Visible = false;
            // 
            // InspectionDate
            // 
            InspectionDate.Location = new Point(588, 250);
            InspectionDate.Name = "InspectionDate";
            InspectionDate.Size = new Size(200, 23);
            InspectionDate.TabIndex = 52;
            InspectionDate.Visible = false;
            // 
            // Injuries
            // 
            Injuries.Location = new Point(588, 279);
            Injuries.Name = "Injuries";
            Injuries.Size = new Size(200, 23);
            Injuries.TabIndex = 53;
            Injuries.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 79);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 54;
            label1.Text = "Состояние животного:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 108);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 55;
            label2.Text = "Состояние кожы:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 137);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 56;
            label3.Text = "Состояние меха:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 163);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 57;
            label4.Text = "Нужно лечение:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 191);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 58;
            label5.Text = "Манипуляции:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 221);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 59;
            label6.Text = "Лечение:";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(500, 250);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 60;
            label7.Text = "Дата осмотра:";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 279);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 61;
            label8.Text = "Повреждение:";
            label8.Visible = false;
            // 
            // OrganTin
            // 
            OrganTin.Location = new Point(199, 79);
            OrganTin.Name = "OrganTin";
            OrganTin.Size = new Size(200, 23);
            OrganTin.TabIndex = 62;
            OrganTin.Visible = false;
            // 
            // OrganTrc
            // 
            OrganTrc.Location = new Point(199, 108);
            OrganTrc.Name = "OrganTrc";
            OrganTrc.Size = new Size(200, 23);
            OrganTrc.TabIndex = 63;
            OrganTrc.Visible = false;
            // 
            // OrgName
            // 
            OrgName.Location = new Point(199, 137);
            OrgName.Name = "OrgName";
            OrgName.Size = new Size(200, 23);
            OrgName.TabIndex = 64;
            OrgName.Visible = false;
            // 
            // OrgType
            // 
            OrgType.Location = new Point(199, 166);
            OrgType.Name = "OrgType";
            OrgType.Size = new Size(200, 23);
            OrgType.TabIndex = 65;
            OrgType.Visible = false;
            // 
            // OrgFeature
            // 
            OrgFeature.Location = new Point(199, 195);
            OrgFeature.Name = "OrgFeature";
            OrgFeature.Size = new Size(200, 23);
            OrgFeature.TabIndex = 66;
            OrgFeature.Visible = false;
            // 
            // OrgLoclity
            // 
            OrgLoclity.FormattingEnabled = true;
            OrgLoclity.Location = new Point(199, 224);
            OrgLoclity.Name = "OrgLoclity";
            OrgLoclity.Size = new Size(200, 23);
            OrgLoclity.TabIndex = 67;
            OrgLoclity.Visible = false;
            // 
            // buttonSubmitOrganisaiton
            // 
            buttonSubmitOrganisaiton.Font = new Font("Segoe UI", 12F);
            buttonSubmitOrganisaiton.Location = new Point(199, 253);
            buttonSubmitOrganisaiton.Name = "buttonSubmitOrganisaiton";
            buttonSubmitOrganisaiton.Size = new Size(200, 32);
            buttonSubmitOrganisaiton.TabIndex = 68;
            buttonSubmitOrganisaiton.Text = "Подтвердить";
            buttonSubmitOrganisaiton.UseVisualStyleBackColor = true;
            buttonSubmitOrganisaiton.Visible = false;
            buttonSubmitOrganisaiton.Click += buttonSubmitOrganisaiton_Click;
            // 
            // ButtonSubmitContract
            // 
            ButtonSubmitContract.Font = new Font("Segoe UI", 12F);
            ButtonSubmitContract.Location = new Point(199, 253);
            ButtonSubmitContract.Name = "ButtonSubmitContract";
            ButtonSubmitContract.Size = new Size(200, 32);
            ButtonSubmitContract.TabIndex = 69;
            ButtonSubmitContract.Text = "Подтвердить";
            ButtonSubmitContract.UseVisualStyleBackColor = true;
            ButtonSubmitContract.Visible = false;
            ButtonSubmitContract.Click += ButtonSubmitContract_Click;
            // 
            // buttonSumbitInsection
            // 
            buttonSumbitInsection.Font = new Font("Segoe UI", 12F);
            buttonSumbitInsection.Location = new Point(199, 250);
            buttonSumbitInsection.Name = "buttonSumbitInsection";
            buttonSumbitInsection.Size = new Size(200, 35);
            buttonSumbitInsection.TabIndex = 70;
            buttonSumbitInsection.Text = "Подтвердить";
            buttonSumbitInsection.UseVisualStyleBackColor = true;
            buttonSumbitInsection.Visible = false;
            buttonSumbitInsection.Click += buttonSumbitInsection_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSumbitInsection);
            Controls.Add(ButtonSubmitContract);
            Controls.Add(buttonSubmitOrganisaiton);
            Controls.Add(OrgLoclity);
            Controls.Add(OrgFeature);
            Controls.Add(OrgType);
            Controls.Add(OrgName);
            Controls.Add(OrganTrc);
            Controls.Add(OrganTin);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Injuries);
            Controls.Add(InspectionDate);
            Controls.Add(Treatment);
            Controls.Add(Manipulations);
            Controls.Add(Fur);
            Controls.Add(Skin);
            Controls.Add(NeedOperations);
            Controls.Add(Temperature);
            Controls.Add(AnimalCondition);
            Controls.Add(featureBehavior);
            Controls.Add(labelIndex);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSubmitVaccination);
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
        private Button buttonSubmitVaccination;
        private Button buttonCancel;
        private Label labelIndex;
        private TextBox featureBehavior;
        private TextBox AnimalCondition;
        private TextBox Temperature;
        private RadioButton NeedOperations;
        private TextBox Skin;
        private TextBox Fur;
        private TextBox Manipulations;
        private TextBox Treatment;
        private DateTimePicker InspectionDate;
        private TextBox Injuries;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox OrganTin;
        private TextBox OrganTrc;
        private TextBox OrgName;
        private TextBox OrgType;
        private TextBox OrgFeature;
        private ComboBox OrgLoclity;
        private Button buttonSubmitOrganisaiton;
        private Button ButtonSubmitContract;
        private Button buttonSumbitInsection;
    }
}