using AnimalHealth.Application.Models;
using ClientSideGrpc.Mappings;
using ClientSideGrpc.Views;
using Google.Protobuf.WellKnownTypes;
using System.Reflection;

namespace ClientSideGrpc
{
    public partial class ReportForm : Form
    {
        readonly ClientFacade _facade;
        RoleModel _role;

        bool watchStatus = true;
        Dictionary<string, MethodInfo> fuctions = new Dictionary<string, MethodInfo>();
        Dictionary<string, string> tags = new Dictionary<string, string>();
        Dictionary<string, (string, string)> columnNames = new Dictionary<string, (string, string)>();

        List<ReportView> reports = new List<ReportView>();

        IMapper<ReportValueModel, ReportValueView> _reportValueMapper;
        IMapper<UserModel, UserView> _userMapper;
        IMapper<ReportModel, ReportView> _reportMapper;

        public ReportForm(ClientFacade facade, RoleModel role)
        {
            _userMapper = new UserMapper();
            _reportValueMapper = new ReportValueMapper();
            _reportMapper = new ReportMapper(_userMapper, new ReportStateMapper(_userMapper), _reportValueMapper);
            InitializeComponent();
            _facade = facade;
            _role = role;
            dateTimePicker1.Text = DateTime.Parse("12-12-2009").ToString();
            var data = _facade.GetReportMetaData(new Empty());
            reportTypesComboBox.Items.AddRange(data.RusReportNames.ToArray());
            for (int i = 0; i < data.EngReportNames.Count; i++)
            {
                tags.Add(data.RusReportNames[i], data.EngReportNames[i]);
                fuctions.Add(data.EngReportNames[i], _facade.GetType().GetMethod("Get" + data.EngReportNames[i]));
                columnNames.Add(data.RusReportNames[i], (data.RusColumnNames[0], data.RusColumnNames[i + 1]));
            }
            dataGridView1.AutoSize = true;
            var users = _facade.GetUsers(new Empty()).Users.Select(x => _userMapper.Map(x)).ToArray();
            userComboBox.Items.AddRange(users);
            changeStateButton.Visible = false;
            changeStateButton.Click += changeReportStateButton_Click;
        }


        private void reportGenereteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            var reportType = reportTypesComboBox.Text;

            if (reportType != "")
            {
                var dateStart = DateTime.Parse(dateTimePicker1.Text).ToLocalTime().ToUniversalTime().ToTimestamp();
                var dateEnd = DateTime.Parse(dateTimePicker2.Text).ToLocalTime().ToUniversalTime().ToTimestamp();

                var request = new GetReport
                {
                    DateEnd = dateEnd,
                    DateStart = dateStart,
                    UserCreator = _role.User,
                };

                var report = new ReportModel();
                report = (ReportModel)fuctions[tags[reportType]].Invoke(_facade, new object[] { request });

                var column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "FirstFeature";
                column1.HeaderText = columnNames[reportType].Item1;
                var columnId = new DataGridViewTextBoxColumn();
                var column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "SecondFeature";
                column2.HeaderText = columnNames[reportType].Item2;
                var column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Count";
                column3.HeaderText = "Количество";

                dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3 });

                var views = report.Values.Select(x => _reportValueMapper.Map(x)).ToList();

                dataGridView1.DataSource = views;
                dataGridView1.Columns["Id"].Visible = false;

                watchStatus = true;
            }
        }

        private void changeReportStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!watchStatus && userComboBox.SelectedItem != null)
                {
                    var id = getIdFromDataGridRow();
                    if (id != -1)
                    {
                        var currentReport = reports.Where(x => x.Id == id).First();
                        var request = getRequestForChangeState(currentReport);
                        _facade.GoNextState(request);
                        UpdateRowDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openReportsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            reports.Clear();

            var dateStart = DateTime.Parse(dateTimePicker1.Text).ToUniversalTime().ToTimestamp();
            var dateEnd = DateTime.Parse(dateTimePicker2.Text).ToUniversalTime().ToTimestamp();

            var dates = new DatesPeriod
            {
                DateStart = dateStart,
                DateEnd = dateEnd,
            };

            var reportList = _facade.GetReportsByPeriod(dates);
            this.reports = reportList.Reports.Select(x => _reportMapper.Map(x)).ToList();

            dataGridView1.DataSource = this.reports;
            dataGridView1.Columns["Id"].Visible = false;

            watchStatus = false;

            changeStateButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!watchStatus)
            {
                var id = getIdFromDataGridRow();
                if (id != -1)
                {
                    var report = reports.Where(x => x.Id == id).First();
                    var requset = new ReportLookup()
                    {
                        Id = report.Id,
                    };
                    _facade.DeleteReport(requset);
                    reports.Remove(report);
                    UpdateDataSource();
                }
            }
        }

        private ChangeReportState getRequestForChangeState(ReportView report)
        {
            var request = new ChangeReportState
            {
                ReportId = report.Id,
                Changer = _userMapper.Map(report.Creator),
                DateChange = DateTime.Now.ToLocalTime().ToUniversalTime().ToTimestamp(),
                Receiver = null,
                SecondApprover = null,
            };
            switch (report.State.Name)
            {
                case "Черновик":
                    request.SecondApprover = _userMapper.Map((UserView)userComboBox.SelectedItem);
                    return request;
                case "Одобрен":
                    request.Receiver = _userMapper.Map((UserView)userComboBox.SelectedItem);
                    return request;
                case "Отправлен":
                    return request;
            }
            return request;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!watchStatus)
            {
                int id = getIdFromDataGridRow();
                if (id != -1)
                {
                    var reportView = reports.Where(x => x.Id == id).First();

                    var column1 = new DataGridViewTextBoxColumn();
                    column1.DataPropertyName = "FirstFeature";
                    column1.HeaderText = columnNames[reportView.Type].Item1;
                    var columnId = new DataGridViewTextBoxColumn();
                    var column2 = new DataGridViewTextBoxColumn();
                    column2.DataPropertyName = "SecondFeature";
                    column2.HeaderText = columnNames[reportView.Type].Item2;
                    var column3 = new DataGridViewTextBoxColumn();
                    column3.DataPropertyName = "Count";
                    column3.HeaderText = "Количество";
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3 });

                    var request = new ReportLookup
                    {
                        Id = id,
                    };
                    var report = _facade.GetReport(request);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = report.Values.Select(x => _reportValueMapper.Map(x)).ToList();
                    dataGridView1.Columns["Id"].Visible = false;
                    watchStatus = true;
                }
            }
        }

        private void UpdateRowDataGridView()
        {
            var id = getIdFromDataGridRow();
            if (id != -1)
            {
                var getReport = new ReportLookup
                {
                    Id = id,
                };
                var newReport = _facade.GetReport(getReport);
                var oldReport = reports.Find(pr => pr.Id == newReport.Id);
                UpdateReport(oldReport, newReport);
                UpdateDataSource();
            }
        }

        private void UpdateDataSource()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reports;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void UpdateReport(ReportView report, ReportModel newReportModel)
        {
            var newReport = _reportMapper.Map(newReportModel);
            report.Id = newReport.Id;
            report.CreateDate = newReport.CreateDate;
            report.State = newReport.State;
            report.Creator = newReport.Creator;
            report.Type = newReport.Type;
            report.Values.Clear();
            report.Values = newReport.Values;
        }

        private int getIdFromDataGridRow()
        {
            if (dataGridView1.CurrentCell == null)
                MessageBox.Show("Выберите отчёт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                return int.Parse(dataGridView1.CurrentCell.OwningRow.Cells["Id"].Value.ToString());
            return -1;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!watchStatus)
            {
                var id = getIdFromDataGridRow();
                if(id != -1)
                {
                    var currentReport = reports.Where(x => x.Id == id).First();
                    var name = currentReport.State.Name;
                    switch (name)
                    {
                        case "Черновик":
                            changeStateButton.Text = "Утвердить";
                            changeStateButton.Visible = true;
                            break;
                        case "Одобрен":
                            changeStateButton.Text = "Отправить";
                            changeStateButton.Visible = true;
                            break;
                        case "Отправлен":
                            changeStateButton.Visible = false;
                            break;
                    }
                }
            }
        }
    }
}