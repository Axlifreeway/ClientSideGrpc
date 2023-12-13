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
        UserModel user = new UserModel
        {
            Id = 1,
            Name = "Вова",
        };


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
            InitializeComponent();
            _facade = facade;
            _role = role;
        }

        public ReportForm(ClientFacade facade)
        {
            _userMapper = new UserMapper();
            _reportValueMapper = new ReportValueMapper();
            _reportMapper = new ReportMapper(_userMapper, new ReportStateMapper(_userMapper), _reportValueMapper);
            InitializeComponent();
            _facade = facade;
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
                    UserCreator = user,
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

        private void approveButton_Click(object sender, EventArgs e)
        {
            ChangetState((changeReportState) => _facade.ApproveReport(changeReportState));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ChangetState((changeReportState) => _facade.SendReport(changeReportState));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ChangetState((changeReportState) => _facade.CancelReport(changeReportState));
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

        private void ChangetState(Action<ChangeReportState> action)
        {
            try
            {
                if (!watchStatus)
                {
                    var id = getIdFromDataGridRow();
                    if (id != -1)
                    {
                        var request = new ChangeReportState
                        {
                            ReportId = id,
                            Changer = user,
                            DateChange = DateTime.Now.ToLocalTime().ToUniversalTime().ToTimestamp(),
                            Receiver = null,
                        };
                        action(request);
                        UpdateRowDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Выберите отчёт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                return int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            return -1;
        }
    }
}