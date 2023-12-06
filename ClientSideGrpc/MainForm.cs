using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSideGrpc
{
    public partial class MainForm : Form
    {
        private ClientFacade clientFacade;

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
            clientFacade = new ClientFacade();
        }

        /// <summary>
        /// Авторизация в приложении, работает на пользовательском интерфейсе
        /// </summary>
        public void Authorize(object sender, EventArgs e)
        {
            if (textLogin.Text != "" && textPassword.Text != "")
            {
                MessageBox.Show("Вход в систему");
                Text = "Главная форма";
                Size = new System.Drawing.Size(816, 489);
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
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль!");
            }
        }


        /// <summary>
        /// Событие нажатия на кнопку добавления организации
        /// </summary>
        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано.. реализовать..");
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления организации
        /// </summary>
        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");

            //if (dataGrid.CurrentRow != null)
            //{
            //    var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
            //    if (message == DialogResult.Yes)
            //    {
            //        var deletedindex = (int)dataGrid.CurrentRow.Cells[0].Value;
            //        var deletemodel = new VaccinationLookup();
            //        deletemodel.Id = deletedindex;
            //        clientFacade.DeleteVaccination(deletemodel);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Не выбран удаляемый элемент!");
            //}
        }

        /// <summary>
        /// Событие нажатия на кнопку изменения организации
        /// </summary>
        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении организации.
        /// принимает на вход новую модель организации.
        /// </summary>
        private bool IsCorrectOrganisation(OrganizationModel model)
        {
            return true;
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка организаций
        /// </summary>
        public void ClickButtonGetOrganisations(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления контракта
        /// </summary>
        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано. реализовать.");
        }

        /// <summary>
        /// Событие нажатия на кнопку удаления контракта
        /// </summary>
        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");

            //if (dataGrid.CurrentRow != null)
            //{
            //    var message = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo);
            //    if (message == DialogResult.Yes)
            //    {
            //        var deletedindex = (int)dataGrid.CurrentRow.Cells[0].Value;
            //        var deletemodel = new VaccinationLookup();
            //        deletemodel.Id = deletedindex;
            //        clientFacade.DeleteVaccination(deletemodel);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Не выбран удаляемый элемент!");
            //}
        }

        /// <summary>
        /// Событие нажатия на кнопку изменения контракта
        /// </summary>
        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении организации.
        /// принимает на вход новую модель организации.
        /// </summary>
        public bool IsCorrectContract(ContractModel model)
        {
            return true;
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка контрактов
        /// </summary>
        public void ClickButtonGetContracts(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления вакцинации
        /// </summary>
        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "Добавление вакцинации";
            currentProccedure.Visible = true;
            fifthAtributeLabel.Visible = true;
            secondAtributeLabel.Visible = true;
            firstAtributeLabel.Visible = true;
            thirdAtributeLabel.Visible = true;
            fourthAtributeLabel.Visible = true;
            sixthAtributeLabel.Visible = true;
            firstDate.Visible = true;
            secondDate.Visible = true;
            userSelection.Visible = true;
            animalSelection.Visible = true;
            contractSelection.Visible = true;
            vaccineSelection.Visible = true;
            buttonOk.Visible = true;
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
                    var deletemodel = new VaccinationLookup();
                    deletemodel.Id = deletedindex;
                    clientFacade.DeleteVaccination(deletemodel);

                    var newdata = (Google.Protobuf.Collections.RepeatedField<VaccinationModel>)dataGrid.DataSource;
                    dataGrid.DataSource = null;
                    newdata.RemoveAt(index);
                    dataGrid.DataSource = newdata;

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
                var selected = dataGrid.CurrentRow;
                labelIndex.Text = Convert.ToString(selected.Cells[0].Value);
                firstDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[1].Value).Seconds).ToLocalTime();
                secondDate.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((Timestamp)selected.Cells[2].Value).Seconds).ToLocalTime();
                userSelection.Text = (string)selected.Cells[3].Value;
                animalSelection.Text = (string)selected.Cells[4].Value;
                contractSelection.Text = (string)selected.Cells[5].Value;
                vaccineSelection.Text = (string)selected.Cells[6].Value;
                HideAll();
                currentProccedure.Text = "Изменение вакцинации";
                currentProccedure.Visible = true;
                fifthAtributeLabel.Visible = true;
                secondAtributeLabel.Visible = true;
                firstAtributeLabel.Visible = true;
                thirdAtributeLabel.Visible = true;
                fourthAtributeLabel.Visible = true;
                sixthAtributeLabel.Visible = true;
                firstDate.Visible = true;
                secondDate.Visible = true;
                userSelection.Visible = true;
                animalSelection.Visible = true;
                contractSelection.Visible = true;
                vaccineSelection.Visible = true;
                buttonOk.Visible = true;
                buttonCancel.Visible = true;
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
            var vaccinationList = clientFacade.GetVaccinations(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = vaccinationList.Vaccinations;
        }

        /// <summary>
        /// Событие нажатия на кнопку добавления осмотра
        /// </summary>
        public void ClickButtonAddInspection(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "Добавление осмотра";
            currentProccedure.Visible = true;
            fifthAtributeLabel.Visible = true;
            secondAtributeLabel.Visible = true;
            firstAtributeLabel.Visible = true;
            thirdAtributeLabel.Visible = true;
            fourthAtributeLabel.Visible = true;
            sixthAtributeLabel.Visible = true;
            firstDate.Visible = true;
            secondDate.Visible = true;
            userSelection.Visible = true;
            animalSelection.Visible = true;
            contractSelection.Visible = true;
            vaccineSelection.Visible = true;
            buttonOk.Visible = true;

            //clientFacade.AddInspection(new AnimalHealth.Application.Models.InspectionAddModel());
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
                    var deletemodel = new InspectionLookup();
                    deletemodel.Id = deletedindex;
                    clientFacade.DeleteInspection(deletemodel);
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
            MessageBox.Show("Не реализовано");
            //clientFacade.EditInspection(new AnimalHealth.Application.Models.InspectionAddModel());
        }

        /// <summary>
        /// Проверка на пустые поля при добавлении или изменении организации.
        /// принимает на вход новую модель организации.
        /// </summary>
        public bool isCorrectInspection(string Inspection)
        {
            return true;
        }

        /// <summary>
        /// Событие нажатия на кнопку получения списка осмотров
        /// </summary>
        public void ClickButtonGetInspections(object sender, EventArgs e)
        {
            var inspectionList = clientFacade.GetInspections(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = inspectionList.Inspections;
        }

        /// <summary>
        /// Событие нажатия на кнопку детального рассмотрения организации
        /// </summary>
        public void ClickButtonShowOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Событие нажатия на кнопку детального рассмотрения контракта
        /// </summary>
        public void ClickButtonShowContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Событие нажатия на кнопку детального рассмотрения вакцинации
        /// </summary>
        public void ClickButtonShowVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        /// <summary>
        /// Событие нажатия на кнопку детального рассмотрения осмотра
        /// </summary>
        public void ClickButtonShowInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
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
            animalSelection.Visible = false;
            contractSelection.Visible = false;
            vaccineSelection.Visible = false;
            buttonOk.Visible = false;
            buttonCancel.Visible = false;
        }

        /// <summary>
        /// Метод открывающий форму для взаимодействия с отчётами
        /// </summary>
        private void отчётОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reports = new ReportForm();
            reports.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelIndex.Text != "Id")
            {
                var model = new VaccinationModel();
                model.Id = Convert.ToInt32(labelIndex.Text);
                model.Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc));
                model.ExpirationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc));
                model.User = (UserModel)userSelection.SelectedItem;
                model.Animal = (AnimalModel)animalSelection.SelectedItem;
                model.Contract = (ContractModel)contractSelection.SelectedItem;
                model.Vaccine = (VaccineModel)vaccineSelection.SelectedItem;
                if (isCorrectVaccination(model))
                {
                    clientFacade.EditVaccination(model);
                }
                else
                {
                    MessageBox.Show("Введите недостающие данные!");
                }
            }
            else
            {
                var model = new VaccinationAddModel();
                model.Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc));
                model.ExpirationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc));
                model.User = (UserModel)userSelection.SelectedItem;
                model.Animal = (AnimalModel)animalSelection.SelectedItem;
                model.Contract = (ContractModel)contractSelection.SelectedItem;
                model.Vaccine = (VaccineModel)vaccineSelection.SelectedItem;
                if (isCorrectVaccination(new VaccinationModel()))
                {
                    clientFacade.AddVaccination(model);
                }
                else
                {
                    MessageBox.Show("Введите недостающие данные!");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var registry = currentProccedure.Text;
            HideAll();
            switch(registry.Split(' ')[1])
            {
                case "вакцинации":
                    ClickVaccinationShow(null, null);
                    break;
                case "осмотра":
                    ClickInspectionShow(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
