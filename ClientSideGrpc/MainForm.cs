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
        /// ����������� ������� �����
        /// </summary>
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

        /// <summary>
        /// ����������� � ����������, �������� �� ���������������� ����������
        /// </summary>
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


        /// <summary>
        /// ������� ������� �� ������ ���������� �����������
        /// </summary>
        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������.. �����������..");
        }

        /// <summary>
        /// ������� ������� �� ������ �������� �����������
        /// </summary>
        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");

            //if (dataGrid.CurrentRow != null)
            //{
            //    var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
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
            //    MessageBox.Show("�� ������ ��������� �������!");
            //}
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� �����������
        /// </summary>
        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� �����������.
        /// ��������� �� ���� ����� ������ �����������.
        /// </summary>
        private bool IsCorrectOrganisation(OrganizationModel model)
        {
            return true;
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ������ �����������
        /// </summary>
        public void ClickButtonGetOrganisations(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ���������
        /// </summary>
        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������. �����������.");
        }

        /// <summary>
        /// ������� ������� �� ������ �������� ���������
        /// </summary>
        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");

            //if (dataGrid.CurrentRow != null)
            //{
            //    var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
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
            //    MessageBox.Show("�� ������ ��������� �������!");
            //}
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ���������
        /// </summary>
        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� �����������.
        /// ��������� �� ���� ����� ������ �����������.
        /// </summary>
        public bool IsCorrectContract(ContractModel model)
        {
            return true;
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ������ ����������
        /// </summary>
        public void ClickButtonGetContracts(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ����������
        /// </summary>
        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "���������� ����������";
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
        /// ������� ������� �� ������ �������� ����������
        /// </summary>
        public void ClickButtonRemoveVaccination(object sender, EventArgs e)
        {
            var selected = dataGrid.CurrentRow;
            var index = selected.Index;
            if (selected != null && index != -1)
            {
                var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
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
                MessageBox.Show("�� ������ ��������� �������!");
            }

        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ����������
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
                currentProccedure.Text = "��������� ����������";
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
                MessageBox.Show("������� �������� ������� ��� ���������!");
            }
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� �����������.
        /// ��������� �� ���� ����� ������ �����������.
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
        /// ������� ������� �� ������ ��������� ������ ����������
        /// </summary>
        public void ClickButtonGetVaccinations(object sender, EventArgs e)
        {
            var vaccinationList = clientFacade.GetVaccinations(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = vaccinationList.Vaccinations;
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� �������
        /// </summary>
        public void ClickButtonAddInspection(object sender, EventArgs e)
        {
            HideAll();
            currentProccedure.Text = "���������� �������";
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
        /// ������� ������� �� ������ �������� �������
        /// </summary>
        public void ClickButtonRemoveInspection(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
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
                MessageBox.Show("�� ������ ��������� �������!");
            }
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� �������
        /// </summary>
        public void ClickButtonEditInspection(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
            //clientFacade.EditInspection(new AnimalHealth.Application.Models.InspectionAddModel());
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� �����������.
        /// ��������� �� ���� ����� ������ �����������.
        /// </summary>
        public bool isCorrectInspection(string Inspection)
        {
            return true;
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ������ ��������
        /// </summary>
        public void ClickButtonGetInspections(object sender, EventArgs e)
        {
            var inspectionList = clientFacade.GetInspections(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = inspectionList.Inspections;
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ������������ �����������
        /// </summary>
        public void ClickButtonShowOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ������������ ���������
        /// </summary>
        public void ClickButtonShowContract(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ������������ ����������
        /// </summary>
        public void ClickButtonShowVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ������ ���������� ������������ �������
        /// </summary>
        public void ClickButtonShowInspection(object sender, EventArgs e)
        {
            MessageBox.Show("�� �����������");
        }

        /// <summary>
        /// ������� ������� �� ����� ���� "���������"
        /// ��������� ����������� �������������� � �����������
        /// </summary>
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

        /// <summary>
        /// ������� ������� �� ����� ���� "�����������"
        /// ��������� ����������� �������������� � �������������
        /// </summary>
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

        /// <summary>
        /// ������� ������� �� ����� ���� "����������"
        /// ��������� ����������� �������������� � ������������
        /// </summary>
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

        /// <summary>
        /// ������� ������� �� ����� ���� "�������"
        /// ��������� ����������� �������������� � ���������
        /// </summary>
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

        /// <summary>
        /// ����� ���������� ��� �������� �� ������, ����� ����
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
        /// ����� ����������� ����� ��� �������������� � ��������
        /// </summary>
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("������� ����������� ������!");
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
                    MessageBox.Show("������� ����������� ������!");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var registry = currentProccedure.Text;
            HideAll();
            switch(registry.Split(' ')[1])
            {
                case "����������":
                    ClickVaccinationShow(null, null);
                    break;
                case "�������":
                    ClickInspectionShow(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
