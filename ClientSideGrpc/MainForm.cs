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
            Text = "�����������";
            Size = new System.Drawing.Size(250, 200);
            ���������ToolStripMenuItem.Visible = false;
            �����������ToolStripMenuItem.Visible = false;
            ����������ToolStripMenuItem.Visible = false;
            �������ToolStripMenuItem.Visible = false;
            ������ToolStripMenuItem.Visible = false;
            clientFacade = new ClientFacade();
        }

        public void Authorize(object sender, EventArgs e)
        {
            if (textLogin.Text != "" && textPassword.Text != "")
            {
                MessageBox.Show("���� � �������");
                Text = "������� �����";
                Size = new System.Drawing.Size(816, 489);
                labelAuth.Visible = false;
                labelLogin.Visible = false;
                labelPassword.Visible = false;
                textLogin.Visible = false;
                textPassword.Visible = false;
                buttonAuth.Visible = false;
                ���������ToolStripMenuItem.Visible = true;
                �����������ToolStripMenuItem.Visible = true;
                ����������ToolStripMenuItem.Visible = true;
                �������ToolStripMenuItem.Visible = true;
                ������ToolStripMenuItem.Visible = true;
            }
            else
            {
                MessageBox.Show("�� ������ ����� ��� ������!");
            }
        }

        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������.. �����������..");
        }

        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        private bool IsCorrectOrganisation(string organisation)
        {
            return true;
        }

        public void ClickButtonGetOrganisations(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������. �����������.");
        }

        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        public bool IsCorrectContract(string contract)
        {
            return true;
        }

        public void ClickButtonGetContracts(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("�� �����������");
        }


        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������... �����������...");
            //clientFacade.AddVaccination(new AnimalHealth.Application.Models.VaccinationAddModel());
        }

        public void ClickButtonRemoveVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
            //clientFacade.DeleteVaccination(new AnimalHealth.Application.Models.VaccinationLookout());
        }

        public void ClickButtonEditVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
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
            MessageBox.Show("�� �����������.... �����������....");
            //clientFacade.AddInspection(new AnimalHealth.Application.Models.InspectionAddModel());
        }

        public void ClickButtonRemoveInspection(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
            //clientFacade.DeleteInspection(new AnimalHealth.Application.Models.InspectionLookout());
        }

        public void ClickButtonEditInspection(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
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
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonShowContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonShowVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        public void ClickButtonShowInspection(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        private void ClickContractsShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "���������";
            ContractAdd.Visible = true;
            ContractRemove.Visible = true;
            ContractEdit.Visible = true;
            ContractsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickOrganisationShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "�����������";
            OrganisationAdd.Visible = true;
            OrganisationRemove.Visible = true;
            OrganisationEdit.Visible = true;
            OrganisationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickVaccinationShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "����������";
            VaccinationAdd.Visible = true;
            VaccinationRemove.Visible = true;
            VaccinationEdit.Visible = true;
            VaccinationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickInspectionShow(object sender, EventArgs e)
        {
            HideAll();
            Text = "�������";
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

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reports = new ReportForm();
            reports.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
