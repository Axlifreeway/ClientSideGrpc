using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;

namespace ClientSideGrpc
{
    public partial class ReportForm : Form
    {
        readonly ClientFacade _facade;
        RoleModel _role;
        bool watchStatus = true;
        public ReportForm(ClientFacade facade, RoleModel role)
        {
            InitializeComponent();
            _facade = facade;
            _role = role;
            /*
            if(role.Ro == "")
            {

            }         
            */
        }

        public ReportForm(ClientFacade facade)
        {
            InitializeComponent();
            _facade = facade;

            reportTypesComboBox.Items.AddRange(new object[]
            {
                "По нас. пункту и болезням",
                "По нас. пункту и вакцинам",
                "По нас. пункту и типам животных",
            });
            reportTypesComboBox.Text = "По нас. пункту и болезням";
            dateTimePicker1.Text = DateTime.Parse("12-12-2009").ToString();
        }


        private void reportGenereteButton_Click(object sender, EventArgs e)
        {
            var reportType = reportTypesComboBox.Text;
            var dateStart = DateTime.Parse(dateTimePicker1.Text).ToUniversalTime();
            var dateEnd = DateTime.Parse(dateTimePicker2.Text).ToUniversalTime();
            //var userName = _role.User.Name;
            var userName = "Володька Иванов";
            var getReport = new GetReport
            {
                DateStart = dateStart.ToTimestamp(),
                DateEnd = dateEnd.ToTimestamp(),
                UserCreator = userName,
            };
            var report = new ReportModel();
            switch (reportType)
            {
                case "По нас. пункту и болезням":
                    report = _facade.GetDiseaseReport(getReport);
                    break;
                case "По нас. пункту и вакцинам":
                    report = _facade.GetVaccinationReport(getReport);
                    break;
                case "По нас. пункту и типам животных":
                    report = _facade.GetAnimalTypeReport(getReport);
                    break;
            }
            creatorUserLabel.Text = userName;
            dataGridView1.DataSource = report.Values;
            watchStatus = true;
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void openReportsButton_Click(object sender, EventArgs e)
        {
            //var userName = _role.User.Name;
            var userName = "Володька Иванов";
            var request = new ReportUserName();
            request.User = userName;

            var reports = _facade.GetReportList(request);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reports;

            checkBox1.Checked = false;
            watchStatus = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;

        }
    }
}
