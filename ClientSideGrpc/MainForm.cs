using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClientSideGrpc
{
    public partial class MainForm : Form
    {
        private readonly ClientFacade clientFacade;
        public RoleModel? role;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Text = "Авторизация";
            Size = new System.Drawing.Size(250, 200);
            контрактыToolStripMenuItem.Visible = false;
            организацииToolStripMenuItem.Visible = false;
            вакцинацииToolStripMenuItem.Visible = false;
            осмотрыToolStripMenuItem.Visible = false;
            отчётОToolStripMenuItem.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
            clientFacade = new ClientFacade();
        }

        /// <summary>
        /// Авторизация в приложении, работает на пользовательском интерфейсе
        /// </summary>
        public void Authorize(object sender, EventArgs e)
        {
            var client = new UserLoginModel()
            {
                Login = textLogin.Text,
                Password = textPassword.Text,
            };
            try
            {
                role = clientFacade.Authorize(client);
                MessageBox.Show("Вы успешно авторизовались!");
                Text = "Главная форма";
                Size = new Size(816, 489);
                labelAuth.Visible = false;
                labelLogin.Visible = false;
                labelPassword.Visible = false;
                textLogin.Visible = false;
                textPassword.Visible = false;
                buttonAuth.Visible = false;
                контрактыToolStripMenuItem.Visible = true;
                организацииToolStripMenuItem.Visible = true;
                вакцинацииToolStripMenuItem.Visible = true;
                осмотрыToolStripMenuItem.Visible = true;
                отчётОToolStripMenuItem.Visible = true;
                WindowState = FormWindowState.Maximized;
            }
            catch(RpcException)
            {
                MessageBox.Show("Не верный логин или пароль!");
            }
        }


        /// <summary>
        /// Событие нажатия на кнопку добавления организации
        /// </summary>
        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "Добавление организации";
            currentProccedure.Visible = true;
            firstAtributeLabel.Text = "ИНН:";
            firstAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "КПП:";
            secondAtributeLabel.Visible = true;
            thirdAtributeLabel.Text = "Название:";
            thirdAtributeLabel.Visible = true;
            fourthAtributeLabel.Text = "Тип организации:";
            fourthAtributeLabel.Visible = true;
            fifthAtributeLabel.Text = "Особенность:";
            fifthAtributeLabel.Visible = true;
            sixthAtributeLabel.Text = "Населённый пункт:";
            sixthAtributeLabel.Visible = true;

            buttonSubmitOrganisaiton.Visible = true;
            buttonCancel.Visible = true;

            var localities = clientFacade.GetLocalities(new Empty()).Localities;
            OrgLoclity.Items.Clear();
            OrgLoclity.Items.AddRange((from l in localities select l.Name).ToArray());

            OrganTin.Visible = true;
            OrganTin.ReadOnly = false;
            OrganTrc.Visible = true;
            OrgName.Visible = true;
            OrgType.Visible = true;
            OrgFeature.Visible = true;
            OrgLoclity.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления организации :D
        /// </summary>
        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            var selected = dataGrid.CurrentRow;
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (string)selected.Cells[0].Value;
                    var deletemodel = new OrganizationLookup()
                    {
                        Tin = deletedindex
                    };
                    clientFacade.DeleteOrganisation(deletemodel);

                    ClickButtonGetOrganisations(sender, e);

                    dataGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Не выбран удаляемый элемент!");
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку изменения организации
        /// </summary>
        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                var selected = dataGrid.CurrentRow;
                OrganTin.Text = selected.Cells[0].Value.ToString();
                OrganTrc.Text = selected.Cells[1].Value.ToString();
                OrgName.Text = selected.Cells[2].Value.ToString();
                OrgType.Text = selected.Cells[3].Value.ToString();
                OrgFeature.Text = selected.Cells[4].Value.ToString();
                OrgLoclity.Text = ((LocalityModel)(selected.Cells[5].Value)).Name;
                HideAll();
                currentProccedure.Text = "Добавление организации";
                currentProccedure.Visible = true;
                firstAtributeLabel.Text = "ИНН:";
                firstAtributeLabel.Visible = true;
                secondAtributeLabel.Text = "КПП:";
                secondAtributeLabel.Visible = true;
                thirdAtributeLabel.Text = "Название:";
                thirdAtributeLabel.Visible = true;
                fourthAtributeLabel.Text = "Тип организации:";
                fourthAtributeLabel.Visible = true;
                fifthAtributeLabel.Text = "Особенность:";
                fifthAtributeLabel.Visible = true;
                sixthAtributeLabel.Text = "Населённый пункт:";
                sixthAtributeLabel.Visible = true;

                var localities = clientFacade.GetLocalities(new Empty()).Localities;
                OrgLoclity.Items.Clear();
                OrgLoclity.Items.AddRange((from l in localities select l.Name).ToArray());

                OrganTin.Visible = true;
                OrganTin.ReadOnly = true;
                OrganTrc.Visible = true;
                OrgName.Visible = true;
                OrgType.Visible = true;
                OrgFeature.Visible = true;
                OrgLoclity.Visible = true;
                buttonSubmitOrganisaiton.Visible = true;
                buttonCancel.Visible = true;
            }
            else
            {
                MessageBox.Show("Не выбран объект для изменения!");
            }
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении организации.
        /// принимает на вход новую модель организации.
        /// </summary>
        private bool IsCorrectOrganisation(OrganizationModel model)
        {
            return (OrganTin.Text != "" && OrganTrc.Text != ""
                && OrgName.Text != "" && OrgType.Text != ""
                && OrgFeature.Text != "" && OrgLoclity.Text != "");
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка организаций
        /// </summary>
        public void ClickButtonGetOrganisations(object sender, EventArgs e)
        {
            var organisationsList = clientFacade.GetOrganisations(new Empty());
            dataGrid.DataSource = organisationsList.Organizations;
            dataGrid.Columns[0].DataPropertyName = "Tin";
            dataGrid.Columns[0].HeaderText = "ИНН";
            dataGrid.Columns[1].DataPropertyName = "Trc";
            dataGrid.Columns[1].HeaderText = "КПП";
            dataGrid.Columns[2].DataPropertyName = "Name";
            dataGrid.Columns[2].HeaderText = "Название";
            dataGrid.Columns[3].DataPropertyName = "Type";
            dataGrid.Columns[3].HeaderText = "Тип";
            dataGrid.Columns[4].DataPropertyName = "Feature";
            dataGrid.Columns[4].HeaderText = "Особенность";
            dataGrid.Columns[5].DataPropertyName = "Locality";
            dataGrid.Columns[5].HeaderText = "Населённый пункт";
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления контракта
        /// </summary>
        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "Добавление контракта";
            currentProccedure.Visible = true;
            firstAtributeLabel.Text = "Дата заключения:";
            firstAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "Дата завершения:";
            secondAtributeLabel.Visible = true;
            thirdAtributeLabel.Text = "Исполнитель:";
            thirdAtributeLabel.Visible = true;
            fourthAtributeLabel.Text = "Заказчик:";
            fourthAtributeLabel.Visible = true;
            fifthAtributeLabel.Text = "Номер договора:";
            fifthAtributeLabel.Visible = true;

            firstDate.Visible = true;
            secondDate.Visible = true;
            userSelection.Visible = true;
            animalSelection.Visible = true;
            OrgFeature.Visible = true;
            OrgFeature.Text = "";
            ButtonSubmitContract.Visible = true;
            buttonCancel.Visible = true;


            var org = clientFacade.GetOrganisations(new Empty()).Organizations;
            userSelection.Items.Clear();
            animalSelection.Items.Clear();
            userSelection.Items.AddRange((from c in org select c.Name.ToString()).ToArray());
            animalSelection.Items.AddRange((from c in org select c.Name.ToString()).ToArray());
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления контракта
        /// </summary>
        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            var selected = dataGrid.CurrentRow;
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (int)selected.Cells[0].Value;
                    var deletemodel = new ContractLookup()
                    { 
                        Id = deletedindex
                    };
                    clientFacade.DeleteContract(deletemodel);

                    ClickButtonGetContracts(sender, e);

                    dataGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Не выбран удаляемый элемент!");
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку изменения контракта
        /// </summary>
        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                var selected = dataGrid.CurrentRow;
                labelIndex.Text = selected.Cells[0].Value.ToString();
                OrgFeature.Text = selected.Cells[1].Value.ToString();
                firstDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[2].Value).Seconds).ToLocalTime();
                secondDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[3].Value).Seconds).ToLocalTime();
                userSelection.Text = ((OrganizationModel)selected.Cells[4].Value).Name;
                animalSelection.Text = ((OrganizationModel)selected.Cells[5].Value).Name;
                HideAll();
                currentProccedure.Text = "Изменение контракта";
                currentProccedure.Visible = true;
                firstAtributeLabel.Text = "Дата заключения:";
                firstAtributeLabel.Visible = true;
                secondAtributeLabel.Text = "Дата завершения:";
                secondAtributeLabel.Visible = true;
                thirdAtributeLabel.Text = "Исполнитель:";
                thirdAtributeLabel.Visible = true;
                fourthAtributeLabel.Text = "Заказчик:";
                fourthAtributeLabel.Visible = true;
                fifthAtributeLabel.Text = "Номер договора:";
                fifthAtributeLabel.Visible = true;

                firstDate.Visible = true;
                secondDate.Visible = true;
                userSelection.Visible = true;
                animalSelection.Visible = true;
                OrgFeature.Visible = true;
                OrgFeature.ReadOnly = true;
                ButtonSubmitContract.Visible = true;
                buttonCancel.Visible = true;

                var org = clientFacade.GetOrganisations(new Empty()).Organizations;
                userSelection.Items.Clear();
                animalSelection.Items.Clear();
                userSelection.Items.AddRange((from c in org select c.Name.ToString()).ToArray());
                animalSelection.Items.AddRange((from c in org select c.Name.ToString()).ToArray());
            }
            else
            {
                MessageBox.Show("Не выбран объект для изменения!");
            }
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении организации.
        /// принимает на вход новую модель организации.
        /// </summary>
        public bool IsCorrectContract(ContractModel model)
        {
            return (firstDate.Value <= secondDate.Value
                && OrgFeature.Text != ""
                && userSelection.Text != "" && animalSelection.Text != "");
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка контрактов
        /// </summary>
        public void ClickButtonGetContracts(object sender, EventArgs e)
        {
            var contractsList = clientFacade.GetContracts(new Empty());
            dataGrid.DataSource = contractsList.Contracts;
            dataGrid.Columns[0].DataPropertyName = "Id";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].DataPropertyName = "Number";
            dataGrid.Columns[1].HeaderText = "Номер";
            dataGrid.Columns[2].DataPropertyName = "ConclusionDate";
            dataGrid.Columns[2].HeaderText = "Дата заключения";
            dataGrid.Columns[3].DataPropertyName = "EndDate";
            dataGrid.Columns[3].HeaderText = "Дата окончания";
            dataGrid.Columns[4].DataPropertyName = "Executor";
            dataGrid.Columns[4].HeaderText = "Исполнитель";
            dataGrid.Columns[5].DataPropertyName = "Customer";
            dataGrid.Columns[5].HeaderText = "Заказчик";
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления вакцинации
        /// </summary>
        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            VaccineForm();
            userSelection.Items.Clear();
            animalSelection.Items.Clear();
            contractSelection.Items.Clear();
            vaccineSelection.Items.Clear();
            var users = clientFacade.GetUsers(new Empty()).Users;
            userSelection.Items.AddRange((from u in users select u.Name).ToArray());          
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            animalSelection.Items.AddRange((from a in animals select a.Name).ToArray());        
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            contractSelection.Items.AddRange((from c in contracts select c.Number.ToString()).ToArray());            
            var vaccines = clientFacade.GetVaccines(new Empty()).Vaccines;
            vaccineSelection.Items.AddRange((from v in vaccines select v.Name).ToArray());            
        }

        private void VaccineForm()
        {
            HideAll();
            currentProccedure.Text = "Добавление вакцинации";
            currentProccedure.Visible = true;
            fifthAtributeLabel.Visible = true;
            fifthAtributeLabel.Text = "Контракт:";
            secondAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "Дата окончания:";
            firstAtributeLabel.Visible = true;
            firstAtributeLabel.Text = "Дата вакцинирования:";
            thirdAtributeLabel.Visible = true;
            thirdAtributeLabel.Text = "Ветврач:";
            fourthAtributeLabel.Visible = true;
            fourthAtributeLabel.Text = "Животное:";
            sixthAtributeLabel.Visible = true;
            sixthAtributeLabel.Text = "Вакцина:";
            firstDate.Visible = true;
            secondDate.Visible = true;
            userSelection.Visible = true;
            animalSelection.Visible = true;
            contractSelection.Visible = true;
            vaccineSelection.Visible = true;
            buttonSubmitVaccination.Visible = true;
            buttonCancel.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления вакцинации
        /// </summary>
        public void ClickButtonRemoveVaccination(object sender, EventArgs e)
        {
            var selected = dataGrid.CurrentRow;
            var index = selected.Index;
            if (selected != null && index != -1)
            {
                var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (int)selected.Cells[0].Value;
                    var deletemodel = new VaccinationLookup()
                    {
                        Id = deletedindex
                    };
                    clientFacade.DeleteVaccination(deletemodel);

                    ClickButtonGetVaccinations(sender, e);

                    dataGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Не выбран удаляемый элемент!");
            }

        }

        /// <summary>
        /// Событие нажатия на кнопку изменения вакцинации
        /// </summary>
        public void ClickButtonEditVaccination(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                userSelection.Items.Clear();
                animalSelection.Items.Clear();
                contractSelection.Items.Clear();
                vaccineSelection.Items.Clear();
                var users = clientFacade.GetUsers(new Empty()).Users;
                userSelection.Items.AddRange((from u in users select u.Name).ToArray());
                var animals = clientFacade.GetAnimals(new Empty()).Animals;
                animalSelection.Items.AddRange((from a in animals select a.Name).ToArray());
                var contracts = clientFacade.GetContracts(new Empty()).Contracts;
                contractSelection.Items.AddRange((from c in contracts select c.Number.ToString()).ToArray());
                var vaccines = clientFacade.GetVaccines(new Empty()).Vaccines;
                vaccineSelection.Items.AddRange((from v in vaccines select v.Name).ToArray());
                var selected = dataGrid.CurrentRow;
                labelIndex.Text = Convert.ToString(selected.Cells[0].Value);
                firstDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[1].Value).Seconds).ToLocalTime();
                secondDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[2].Value).Seconds).ToLocalTime();
                userSelection.Text = ((UserModel)selected.Cells[3].Value).Name;
                animalSelection.Text = ((AnimalModel)selected.Cells[4].Value).Name;
                contractSelection.Text = ((ContractModel)selected.Cells[5].Value).Number.ToString();
                vaccineSelection.Text = ((VaccineModel)selected.Cells[6].Value).Name;
                VaccineForm();
            }
            else
            {
                MessageBox.Show("Сначала выберите строчку для изменения!");
            }
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении вакцинации.
        /// принимает на вход новую модель вакцинации.
        /// </summary>
        public bool isCorrectVaccination(VaccinationModel model)
        {
            return firstDate.Value != DateTime.Today
                && secondDate.Value != DateTime.Today
                && userSelection.Text != ""
                && animalSelection.Text != ""
                && contractSelection.Text != ""
                && vaccineSelection.Text != "";
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка вакцинаций
        /// </summary>
        public void ClickButtonGetVaccinations(object sender, EventArgs e)
        {
            var vaccinationList = clientFacade.GetVaccinations(new Empty());
            dataGrid.DataSource = vaccinationList.Vaccinations;
            dataGrid.Columns[0].DataPropertyName = "Id";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].DataPropertyName = "Date";
            dataGrid.Columns[1].HeaderText = "Дата вакцинирования";
            dataGrid.Columns[2].DataPropertyName = "ExpirationDate";
            dataGrid.Columns[2].HeaderText = "Дата окончания";
            dataGrid.Columns[3].DataPropertyName = "User";
            dataGrid.Columns[3].HeaderText = "Ветврач";
            dataGrid.Columns[4].DataPropertyName = "Animal";
            dataGrid.Columns[4].HeaderText = "Животное";
            dataGrid.Columns[5].DataPropertyName = "Contract";
            dataGrid.Columns[5].HeaderText = "Контракт";
            dataGrid.Columns[6].DataPropertyName = "Vaccine";
            dataGrid.Columns[6].HeaderText = "Вакцина";
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления осмотра
        /// </summary>
        public void ClickButtonAddInspection(object sender, EventArgs e)
        {
            InspectionForm();
            userSelection.Items.Clear();
            animalSelection.Items.Clear();
            contractSelection.Items.Clear();
            vaccineSelection.Items.Clear();
            var users = clientFacade.GetUsers(new Empty()).Users;
            userSelection.Items.AddRange((from u in users select u.Name).ToArray());
            animalSelection.Visible = true;
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            animalSelection.Items.AddRange((from a in animals select a.Name).ToArray());
            contractSelection.Visible = true;
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            contractSelection.Items.AddRange((from c in contracts select c.Number.ToString()).ToArray());
            vaccineSelection.Visible = true;
            var vaccines = clientFacade.GetDiseases(new Empty()).Diseases;
            vaccineSelection.Items.AddRange((from v in vaccines select v.Name).ToArray());
            buttonSubmitVaccination.Visible = true;
            buttonCancel.Visible = true;
        }

        private void InspectionForm()
        {
            HideAll();
            currentProccedure.Text = "Добавление осмотра";
            currentProccedure.Visible = true;
            firstAtributeLabel.Visible = true;
            firstAtributeLabel.Text = "Поведение:";
            secondAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "Состояние:";
            thirdAtributeLabel.Visible = true;
            thirdAtributeLabel.Text = "Ветврач:";
            fifthAtributeLabel.Visible = true;
            fifthAtributeLabel.Text = "Контракт:";
            fourthAtributeLabel.Visible = true;
            fourthAtributeLabel.Text = "Животное:";
            sixthAtributeLabel.Visible = true;
            sixthAtributeLabel.Text = "Болезнь";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            AnimalCondition.Visible = true;
            featureBehavior.Visible = true;
            userSelection.Visible = true;
            animalSelection.Visible = true;
            contractSelection.Visible = true;
            vaccineSelection.Visible = true;
            Temperature.Visible = true;
            Skin.Visible = true;
            Fur.Visible = true;
            NeedOperations.Visible = true;
            Manipulations.Visible = true;
            Treatment.Visible = true;
            InspectionDate.Visible = true;
            Injuries.Visible = true;
            buttonSumbitInsection.Visible = true;
            buttonCancel.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления осмотра
        /// </summary>
        public void ClickButtonRemoveInspection(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (int)dataGrid.CurrentRow.Cells[0].Value;
                    var deletemodel = new InspectionLookup()
                    {
                        Id = deletedindex
                    };
                    clientFacade.DeleteInspection(deletemodel);

                    ClickButtonGetInspections(sender, e);

                    dataGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Не выбран удаляемый элемент!");
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку изменения осмотра
        /// </summary>
        public void ClickButtonEditInspection(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                userSelection.Items.Clear();
                animalSelection.Items.Clear();
                contractSelection.Items.Clear();
                vaccineSelection.Items.Clear();
                var users = clientFacade.GetUsers(new Empty()).Users;
                userSelection.Items.AddRange((from u in users select u.Name).ToArray());
                animalSelection.Visible = true;
                var animals = clientFacade.GetAnimals(new Empty()).Animals;
                animalSelection.Items.AddRange((from a in animals select a.Name).ToArray());
                contractSelection.Visible = true;
                var contracts = clientFacade.GetContracts(new Empty()).Contracts;
                contractSelection.Items.AddRange((from c in contracts select c.Number.ToString()).ToArray());
                vaccineSelection.Visible = true;
                var disease = clientFacade.GetDiseases(new Empty()).Diseases;
                vaccineSelection.Items.AddRange((from v in disease select v.Name).ToArray());
                var selected = dataGrid.CurrentRow;
                labelIndex.Text = Convert.ToString(selected.Cells[0].Value);
                featureBehavior.Text = Convert.ToString(selected.Cells[1].Value);
                AnimalCondition.Text = Convert.ToString(selected.Cells[2].Value);
                Temperature.Text = Convert.ToString(selected.Cells[3].Value);
                NeedOperations.Checked = (bool)selected.Cells[4].Value;
                Manipulations.Text = Convert.ToString(selected.Cells[5].Value);
                Treatment.Text = Convert.ToString(selected.Cells[6].Value);
                InspectionDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[7].Value).Seconds).ToLocalTime();
                userSelection.Text = (string)selected.Cells[8].Value;
                animalSelection.Text = (string)selected.Cells[9].Value;
                contractSelection.Text = (string)selected.Cells[10].Value;
                vaccineSelection.Text = (string)selected.Cells[11].Value;
                Injuries.Text = Convert.ToString(selected.Cells[12].Value);
                InspectionForm();
            }
            else
            {
                MessageBox.Show("Сначала выберите строчку для изменения!");
            }
        }

        /// <summary>
            /// Проверка на пустые поля при добавлении или изменении организации.
            /// принимает на вход новую модель организации.
            /// </summary>
        public bool isCorrectInspection(InspectionModel model)
        {
            return userSelection.Text != "" && animalSelection.Text != ""
                && contractSelection.Text != "" && vaccineSelection.Text != ""
                && Temperature.Text != "" && Skin.Text != ""
                && Skin.Text != "" && Manipulations.Text != ""
                && Injuries.Text != "" && Treatment.Text != "";
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка осмотров
        /// </summary>
        public void ClickButtonGetInspections(object sender, EventArgs e)
        {
            var inspectionList = clientFacade.GetInspections(new Empty());
            dataGrid.DataSource = inspectionList.Inspections;
            dataGrid.Columns[0].DataPropertyName = "Id";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].DataPropertyName = "FeatureBehaviour";
            dataGrid.Columns[1].HeaderText = "Поведение";
            dataGrid.Columns[2].DataPropertyName = "AnimalCondition";
            dataGrid.Columns[2].HeaderText = "Состояние";
            dataGrid.Columns[3].DataPropertyName = "Temperature";
            dataGrid.Columns[3].HeaderText = "Температура";
            dataGrid.Columns[4].DataPropertyName = "SkinCover";
            dataGrid.Columns[4].HeaderText = "Кожный покров";
            dataGrid.Columns[5].DataPropertyName = "FurCondition";
            dataGrid.Columns[5].HeaderText = "Состояние меха";
            dataGrid.Columns[6].DataPropertyName = "IsNeedOperations";
            dataGrid.Columns[6].HeaderText = "Нужно вмешательство";
            dataGrid.Columns[7].DataPropertyName = "Manipulations";
            dataGrid.Columns[7].HeaderText = "Манипуляции";
            dataGrid.Columns[8].DataPropertyName = "Treatment";
            dataGrid.Columns[8].HeaderText = "Лечение";
            dataGrid.Columns[9].DataPropertyName = "Date";
            dataGrid.Columns[9].HeaderText = "Дата осмотра";
            dataGrid.Columns[10].DataPropertyName = "User";
            dataGrid.Columns[10].HeaderText = "Ветврач";
            dataGrid.Columns[11].DataPropertyName = "Animal";
            dataGrid.Columns[11].HeaderText = "Животное";
            dataGrid.Columns[12].DataPropertyName = "Contract";
            dataGrid.Columns[12].HeaderText = "Контракт";
            dataGrid.Columns[13].DataPropertyName = "Disease";
            dataGrid.Columns[13].HeaderText = "Болезнь";
            dataGrid.Columns[14].DataPropertyName = "Injures";
            dataGrid.Columns[14].HeaderText = "Повреждения";
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Контракты"
        /// Открывает возможность взаимодействия с контрактами
        /// </summary>
        private void ClickContractsShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "Контракты";
            ContractAdd.Visible = true;
            ContractRemove.Visible = true;
            ContractEdit.Visible = true;
            ContractsGet.Visible = true;
            dataGrid.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Организации"
        /// Открывает возможность взаимодействия с организациями
        /// </summary>
        private void ClickOrganisationShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "Организации";
            OrganisationAdd.Visible = true;
            OrganisationRemove.Visible = true;
            OrganisationEdit.Visible = true;
            OrganisationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Вакцинации"
        /// Открывает возможность взаимодействия с вакцинациями
        /// </summary>
        private void ClickVaccinationShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "Вакцинации";
            VaccinationAdd.Visible = true;
            VaccinationRemove.Visible = true;
            VaccinationEdit.Visible = true;
            VaccinationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        /// <summary>
        /// Событие нажатия на пункт меню "Осмотры"
        /// Открывает возможность взаимодействия с осмотрами
        /// </summary>
        private void ClickInspectionShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "Осмотры";
            InspectionAdd.Visible = true;
            InspectionRemove.Visible = true;
            InspectionEdit.Visible = true;
            InspectionsGet.Visible = true;
            dataGrid.Visible = true;
        }

        /// <summary>
        /// Метод скрывающий все элементы на экране, кроме меню
        /// </summary>
        private void HideAll()
        {
            dataGrid.DataSource = null;

            ContractAdd.Visible = false;
            ContractRemove.Visible = false;
            ContractEdit.Visible = false;
            ContractsGet.Visible = false;
            dataGrid.Visible = false;

            OrganisationAdd.Visible = false;
            OrganisationRemove.Visible = false;
            OrganisationEdit.Visible = false;
            OrganisationsGet.Visible = false;

            AnimalCondition.Visible = false;
            featureBehavior.Visible = false;

            VaccinationAdd.Visible = false;
            VaccinationRemove.Visible = false;
            VaccinationEdit.Visible = false;
            VaccinationsGet.Visible = false;

            InspectionAdd.Visible = false;
            InspectionRemove.Visible = false;
            InspectionEdit.Visible = false;
            InspectionsGet.Visible = false;

            currentProccedure.Visible = false;
            fifthAtributeLabel.Visible = false;
            secondAtributeLabel.Visible = false;
            firstAtributeLabel.Visible = false;
            thirdAtributeLabel.Visible = false;
            fourthAtributeLabel.Visible = false;
            sixthAtributeLabel.Visible = false;

            firstDate.Visible = false;
            secondDate.Visible = false;
            userSelection.Visible = false;
            userSelection.Text = "";
            animalSelection.Visible = false;
            animalSelection.Text = "";
            contractSelection.Visible = false;
            contractSelection.Text = "";
            vaccineSelection.Visible = false;
            vaccineSelection.Text = "";

            buttonSubmitVaccination.Visible = false;
            buttonCancel.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            Temperature.Visible = false;
            Skin.Visible = false;
            Fur.Visible = false;
            NeedOperations.Visible = false;
            Manipulations.Visible = false;
            Treatment.Visible = false;
            InspectionDate.Visible = false;
            Injuries.Visible = false;

            OrganTin.Visible = false;
            OrganTrc.Visible = false;
            OrgName.Visible = false;
            OrgType.Visible = false;
            OrgFeature.Visible = false;
            OrgFeature.ReadOnly = false;
            OrgLoclity.Visible = false;
            buttonSubmitOrganisaiton.Visible = false;
            ButtonSubmitContract.Visible = false;
            buttonSumbitInsection.Visible = false;
        }

        /// <summary>
        /// Метод открывающий форму для взаимодействия с отчётами
        /// </summary>
        private void отчётОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reports = new ReportForm(clientFacade, role);
            reports.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = clientFacade.GetUsers(new Empty()).Users;
            var user = (from u in users where u.Name == Convert.ToString(userSelection.Text) select u).First();
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            var animal = (from u in animals where u.Name == Convert.ToString(animalSelection.Text) select u).First();
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            var contract = (from u in contracts where u.Number == Convert.ToInt32(contractSelection.Text) select u).First();
            var vaccines = clientFacade.GetVaccines(new Empty()).Vaccines;
            var vaccine = (from u in vaccines where u.Name == Convert.ToString(vaccineSelection.Text) select u).First();
            if (labelIndex.Text != "Id")
            {
                var model = new VaccinationModel()
                {
                    Id = Convert.ToInt32(labelIndex.Text),
                    Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    ExpirationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc)),
                    User = user,
                    Animal = animal,
                    Contract = contract,
                    Vaccine = vaccine
                };
                
                if (isCorrectVaccination(model))
                {
                    clientFacade.GetVaccinations(new Empty());
                    clientFacade.EditVaccination(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
            else
            {
                var model = new VaccinationAddModel()
                {
                    Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    ExpirationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc)),
                    User = user,
                    Animal = animal,
                    Contract = contract,
                    Vaccine = vaccine
                };
                
                if (isCorrectVaccination(new VaccinationModel()))
                {
                    clientFacade.GetVaccinations(new Empty());
                    clientFacade.AddVaccination(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var registry = currentProccedure.Text;
            HideAll();
            switch (registry.Split(' ')[1])
            {
                case "вакцинации":
                    ClickVaccinationShow(sender, e);
                    ClickButtonGetVaccinations(sender, e);
                    break;
                case "осмотра":
                    ClickInspectionShow(sender, e);
                    ClickButtonGetInspections(sender, e);
                    break;
                case "контракта":
                    ClickContractsShow(sender, e);
                    ClickButtonGetContracts(sender, e);
                    break;
                case "организации":
                    ClickOrganisationShow(sender, e);
                    ClickButtonGetOrganisations(sender, e);
                    break;
                default:
                    MessageBox.Show("Возникла пробелма!");
                    break;
            }
        }

        private void buttonSubmitOrganisaiton_Click(object sender, EventArgs e)
        {
            var locals = clientFacade.GetLocalities(new Empty()).Localities;
            var local = (from l in locals where l.Name == Convert.ToString(OrgLoclity.Text) select l).First();

            if (OrganTin.ReadOnly)
            {
                var model = new OrganizationModel()
                {
                    Tin = OrganTin.Text,
                    Trc = OrganTrc.Text,
                    Name = OrgName.Text,
                    Type = OrgType.Text,
                    Feature = OrgFeature.Text,
                    Locality = local
                };
                
                if (IsCorrectOrganisation(model))
                {
                    clientFacade.GetOrganisations(new Empty());
                    clientFacade.EditOrganisation(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
            else
            {
                var model = new OrganizationAddModel()
                {
                    Tin = OrganTin.Text,
                    Trc = OrganTrc.Text,
                    Name = OrgName.Text,
                    Type = OrgType.Text,
                    Feature = OrgFeature.Text,
                    Locality = local
                };
                
                if (IsCorrectOrganisation(new OrganizationModel()))
                {
                    clientFacade.AddOrganisation(model);
                    clientFacade.GetOrganisations(new Empty());
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
        }

        private void ButtonSubmitContract_Click(object sender, EventArgs e)
        {
            var organ = clientFacade.GetOrganisations(new Empty()).Organizations;
            var exec = (from l in organ where l.Name == Convert.ToString(userSelection.Text) select l).First();
            var contr = (from l in organ where l.Name == Convert.ToString(animalSelection.Text) select l).First();

            if (labelIndex.Text != "Id")
            {
                var model = new ContractModel()
                {
                    Id = Convert.ToInt32(labelIndex.Text),
                    ConclusionDate = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc)),
                    Executor = exec,
                    Customer = contr,
                    Number = Convert.ToInt32(OrgFeature.Text),
                };
                if (IsCorrectContract(model))
                {
                    clientFacade.GetContracts(new Empty());
                    clientFacade.EditContract(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
            else
            {
                var model = new ContractAddModel()
                {
                    ConclusionDate = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc)),
                    Executor = exec,
                    Customer = contr,
                    Number = Convert.ToInt32(OrgFeature.Text)
                };
                
                if (IsCorrectContract(new ContractModel()))
                {
                    clientFacade.GetContracts(new Empty());
                    clientFacade.AddContract(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
        }

        private void buttonSumbitInsection_Click(object sender, EventArgs e)
        {
            var users = clientFacade.GetUsers(new Empty()).Users;
            var user = (from u in users where u.Name == Convert.ToString(userSelection.Text) select u).First();
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            var animal = (from u in animals where u.Name == Convert.ToString(animalSelection.Text) select u).First();
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            var contract = (from u in contracts where u.Number == Convert.ToInt32(contractSelection.Text) select u).First();
            var diseases = clientFacade.GetDiseases(new Empty()).Diseases;
            var disease = (from u in diseases where u.Name == Convert.ToString(vaccineSelection.Text) select u).First();
            if (labelIndex.Text != "Id")
            {
                var model = new InspectionModel()
                {
                    Id = Convert.ToInt32(labelIndex.Text),
                    FeatureBehaviour = Convert.ToString(featureBehavior.Text),
                    AnimalCondition = Convert.ToString(AnimalCondition.Text),
                    Temperature = float.Parse(Temperature.Text),
                    IsNeedOperations = Convert.ToBoolean(NeedOperations.Checked),
                    Manipulations = Convert.ToString(Manipulations.Text),
                    Treatment = Convert.ToString(Treatment.Text),
                    Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    User = user,
                    Animal = animal,
                    Contract = contract,
                    Disease = disease,
                    Injures = Convert.ToString(Injuries.Text)
                };

                if (isCorrectInspection(model))
                {
                    clientFacade.GetInspections(new Empty());
                    clientFacade.EditInspection(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
            else
            {
                var model = new InspectionAddModel()
                {
                    FeatureBehaviour = Convert.ToString(featureBehavior.Text),
                    AnimalCondition = Convert.ToString(AnimalCondition.Text),
                    Temperature = float.Parse(Temperature.Text),
                    IsNeedOperations = Convert.ToBoolean(NeedOperations.Checked),
                    Manipulations = Convert.ToString(Manipulations.Text),
                    Treatment = Convert.ToString(Treatment.Text),
                    Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc)),
                    User = user,
                    Animal = animal,
                    Contract = contract,
                    Disease = disease,
                    Injures = Convert.ToString(Injuries.Text)
                };  
                
                if (isCorrectVaccination(new VaccinationModel()))
                {
                    clientFacade.GetInspections(new Empty());
                    clientFacade.AddInspection(model);
                    buttonCancel_Click(sender, e);
                }
                else MessageBox.Show("Введите недостающие данные!");
            }
        }
    }
}
