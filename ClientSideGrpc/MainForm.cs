using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;

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
            HideAll();
            currentProccedure.Text = "���������� �����������";
            currentProccedure.Visible = true;
            firstAtributeLabel.Text = "���:";
            firstAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "���:";
            secondAtributeLabel.Visible = true;
            thirdAtributeLabel.Text = "��������:";
            thirdAtributeLabel.Visible = true;
            fourthAtributeLabel.Text = "��� �����������:";
            fourthAtributeLabel.Visible = true;
            fifthAtributeLabel.Text = "�����������:";
            fifthAtributeLabel.Visible = true;
            sixthAtributeLabel.Text = "��������� �����:";
            sixthAtributeLabel.Visible = true;

            var localities = clientFacade.GetLocalities(new Empty()).Localities;
            OrgLoclity.Items.AddRange((from l in localities select l.Name).ToArray());

            OrganTin.Visible = true;
            OrganTin.ReadOnly =false;
            OrganTrc.Visible = true;
            OrgName.Visible = true;
            OrgType.Visible = true;
            OrgFeature.Visible = true;
            OrgLoclity.Visible = true;
        }

        /// <summary>
        /// ������� ������� �� ������ �������� �����������
        /// </summary>
        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            var selected = dataGrid.CurrentRow;
            var index = selected.Index;
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (string)selected.Cells[0].Value;
                    var deletemodel = new OrganizationLookup();
                    deletemodel.Tin = deletedindex;
                    clientFacade.DeleteOrganisation(deletemodel);

                    var newdata = (Google.Protobuf.Collections.RepeatedField<OrganizationModel>)dataGrid.DataSource;
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
        /// ������� ������� �� ������ ��������� �����������
        /// </summary>
        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow != null)
            {
                var selected = dataGrid.CurrentRow;
                HideAll();
                currentProccedure.Text = "���������� �����������";
                currentProccedure.Visible = true;
                firstAtributeLabel.Text = "���:";
                firstAtributeLabel.Visible = true;
                secondAtributeLabel.Text = "���:";
                secondAtributeLabel.Visible = true;
                thirdAtributeLabel.Text = "��������:";
                thirdAtributeLabel.Visible = true;
                fourthAtributeLabel.Text = "��� �����������:";
                fourthAtributeLabel.Visible = true;
                fifthAtributeLabel.Text = "�����������:";
                fifthAtributeLabel.Visible = true;
                sixthAtributeLabel.Text = "��������� �����:";
                sixthAtributeLabel.Visible = true;

                var localities = clientFacade.GetLocalities(new Empty()).Localities;
                OrgLoclity.Items.AddRange((from l in localities select l.Name).ToArray());

                OrganTin.Visible = true;
                OrganTin.ReadOnly = true;
                OrganTin.Text = selected.Cells[0].Value.ToString();
                OrganTrc.Visible = true;
                OrganTrc.Text = selected.Cells[1].Value.ToString();
                OrgName.Visible = true;
                OrgName.Text = selected.Cells[2].Value.ToString();
                OrgType.Visible = true;
                OrgType.Text = selected.Cells[3].Value.ToString();
                OrgFeature.Visible = true;
                OrgFeature.Text = selected.Cells[4].Value.ToString();
                OrgLoclity.Visible = true;
                OrgLoclity.Text = ((UserModel)(selected.Cells[5].Value)).Name;
            }
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� �����������.
        /// ��������� �� ���� ����� ������ �����������.
        /// </summary>
        private bool IsCorrectOrganisation(OrganizationModel model)
        {
            return (OrganTin.Text != "" && OrganTrc.Text != ""
                && OrgName.Text != "" && OrgType.Text != ""
                && OrgFeature.Text != "" && OrgLoclity.Text != "");
        }

        /// <summary>
        /// ������� ������� �� ������ ��������� ������ �����������
        /// </summary>
        public void ClickButtonGetOrganisations(object sender, EventArgs e)
        {
            var organisationsList = clientFacade.GetOrganisations(new Empty());
            dataGrid.DataSource = organisationsList.Organizations;
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
            var selected = dataGrid.CurrentRow;
            var index = selected.Index;
            if (dataGrid.CurrentRow != null)
            {
                var message = MessageBox.Show("�� �������?", "��������", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var deletedindex = (int)selected.Cells[0].Value;
                    var deletemodel = new VaccinationLookup();
                    deletemodel.Id = deletedindex;
                    clientFacade.DeleteVaccination(deletemodel);

                    var newdata = (Google.Protobuf.Collections.RepeatedField<ContractModel>)dataGrid.DataSource;
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
            var contractsList = clientFacade.GetContracts(new Google.Protobuf.WellKnownTypes.Empty());
            dataGrid.DataSource = contractsList.Contracts;
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
            var users = clientFacade.GetUsers(new Empty()).Users;
            userSelection.Items.AddRange((from u in users select u.Name).ToArray());
            animalSelection.Visible = true;
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            animalSelection.Items.AddRange((from a in animals select a.Name).ToArray());
            contractSelection.Visible = true;
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            contractSelection.Items.AddRange((from c in contracts select c.Number.ToString()).ToArray());
            vaccineSelection.Visible = true;
            var vaccines = clientFacade.GetVaccines(new Empty()).Vaccines;
            vaccineSelection.Items.AddRange((from v in vaccines select v.Name).ToArray());
            buttonSubmitVaccination.Visible = true;
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
                buttonSubmitVaccination.Visible = true;
                buttonCancel.Visible = true;
            }
            else
            {
                MessageBox.Show("������� �������� ������� ��� ���������!");
            }
        }

        /// <summary>
        /// �������� �� ������ ���� ��� ���������� ��� ��������� ����������.
        /// ��������� �� ���� ����� ������ ����������.
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
            firstAtributeLabel.Visible = true;
            firstAtributeLabel.Text = "���������:";
            secondAtributeLabel.Visible = true;
            secondAtributeLabel.Text = "���������:";
            thirdAtributeLabel.Visible = true;
            fifthAtributeLabel.Visible = true;
            firstAtributeLabel.Visible = true;
            fourthAtributeLabel.Visible = true;
            sixthAtributeLabel.Visible = true;
            sixthAtributeLabel.Text = "�������";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            firstDate.Visible = true;
            secondDate.Visible = true;
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
            buttonSubmitVaccination.Visible = true;
            buttonCancel.Visible = true;

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
            OrgLoclity.Visible = false;
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
            var users = clientFacade.GetUsers(new Empty()).Users;
            var user = (from u in users where u.Name == Convert.ToString(userSelection.SelectedItem) select u).First();
            var animals = clientFacade.GetAnimals(new Empty()).Animals;
            var animal = (from u in animals where u.Name == Convert.ToString(animalSelection.SelectedItem) select u).First();
            var contracts = clientFacade.GetContracts(new Empty()).Contracts;
            var contract = (from u in contracts where u.Number == Convert.ToInt32(contractSelection.SelectedItem) select u).First();
            var vaccines = clientFacade.GetVaccines(new Empty()).Vaccines;
            var vaccine = (from u in vaccines where u.Name == Convert.ToString(vaccineSelection.SelectedItem) select u).First();
            if (labelIndex.Text != "Id")
            {
                var model = new VaccinationModel();
                model.Id = Convert.ToInt32(labelIndex.Text);
                model.Date = Timestamp.FromDateTime(DateTime.SpecifyKind(firstDate.Value.Date, DateTimeKind.Utc));
                model.ExpirationDate = Timestamp.FromDateTime(DateTime.SpecifyKind(secondDate.Value.Date, DateTimeKind.Utc));
                model.User = user;
                model.Animal = animal;
                model.Contract = contract;
                model.Vaccine = vaccine;
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
                model.User = user;
                model.Animal = animal;
                model.Contract = contract;
                model.Vaccine = vaccine;
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
            switch (registry.Split(' ')[1])
            {
                case "����������":
                    ClickVaccinationShow(sender, e);
                    break;
                case "�������":
                    ClickInspectionShow(sender, e);
                    break;
                case "���������":
                    ClickContractsShow(sender, e);
                    break;
                case "�����������":
                    ClickOrganisationShow(sender, e);
                    break;
                default:
                    MessageBox.Show("�������� ��������!");
                    break;
            }
        }

        private void buttonSubmitOrganisaiton_Click(object sender, EventArgs e)
        {
            var locals = clientFacade.GetLocalities(new Empty()).Localities;
            var local = (from l in locals where l.Name == Convert.ToString(OrgLoclity.SelectedItem) select l).First();

            if (labelIndex.Text != "Id")
            {
                var model = new OrganizationModel();
                model.Tin = labelIndex.Text;
                model.Trc = OrganTrc.Text;
                model.Name = OrgName.Text;
                model.Type = OrgType.Text;
                model.Feature = OrgFeature.Text;
                model.Locality = local;
                if (IsCorrectOrganisation(model))
                {
                    clientFacade.EditOrganisation(model);
                }
                else
                {
                    MessageBox.Show("������� ����������� ������!");
                }
            }
            else
            {
                var model = new OrganizationAddModel();
                model.Tin = OrganTin.Text;
                model.Trc = OrganTrc.Text;
                model.Name = OrgName.Text;
                model.Type = OrgType.Text;
                model.Feature = OrgFeature.Text;
                model.Locality = local;
                if (IsCorrectOrganisation(new OrganizationModel()))
                {
                    clientFacade.AddOrganisation(model);
                }
                else
                {
                    MessageBox.Show("������� ����������� ������!");
                }
            }
        }
    }
}
