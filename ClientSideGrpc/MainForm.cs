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

        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано.. реализовать..");
        }

        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        private bool IsCorrectOrganisation(string organisation)
        {
            return true;
        }

        public void ClickButtonGetOrganisations(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано. реализовать.");
        }

        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public bool IsCorrectContract(string contract)
        {
            return true;
        }

        public void ClickButtonGetContracts(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("Не реализовано");
        }


        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано... реализовать...");
            //clientFacade.AddVaccination(new AnimalHealth.Application.Models.VaccinationAddModel());
        }

        public void ClickButtonRemoveVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
            //clientFacade.DeleteVaccination(new AnimalHealth.Application.Models.VaccinationLookout());
        }

        public void ClickButtonEditVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
            //clientFacade.EditVaccination(new AnimalHealth.Application.Models.VaccinationModel());
        }

        public bool isCorrectVaccination(string Vaccination)
        {
            return true;
            /*
             *  if
             *  else
             */
        }

        public void ClickButtonGetVaccinations(object sender, EventArgs e)
        {
            var vaccinationList = clientFacade.GetVaccinations(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = vaccinationList.Vaccinations;
        }

        public void ClickButtonAddInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано.... реализовать....");
            //clientFacade.AddInspection(new AnimalHealth.Application.Models.InspectionAddModel());
        }

        public void ClickButtonRemoveInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
            //clientFacade.DeleteInspection(new AnimalHealth.Application.Models.InspectionLookout());
        }

        public void ClickButtonEditInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
            //clientFacade.EditInspection(new AnimalHealth.Application.Models.InspectionAddModel());
        }

        public bool isCorrectInspection(string Inspection)
        {
            return true;
            /*
             *  if
             *  else
             */
        }

        public void ClickButtonGetInspections(object sender, EventArgs e)
        {
            var inspectionList = clientFacade.GetInspections(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = inspectionList.Inspections;
        }

        public void ClickButtonShowOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

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
        }

        private void отчётОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reports = new ReportForm();
            reports.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
