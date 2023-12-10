using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;
using System.Linq.Expressions;
using System.Reflection;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClientSideGrpc
{
    public partial class ReportForm : Form
    {
        readonly ClientFacade _facade;
        RoleModel _role;
        bool watchStatus = true;
        Dictionary<string, MethodInfo> fuctions
            = new Dictionary<string, MethodInfo>();
        Dictionary<string, string> tags
            = new Dictionary<string, string>();
        Dictionary<string, (string, string)> columnNames
            = new Dictionary<string, (string, string)>();

        List<ReportModel> reports = new List<ReportModel>();

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
            var userName = "Вова";
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
            creatorUserLabel.Text = userName;
        }

        private void reportGenereteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            this.reports.Clear();
            var reportType = reportTypesComboBox.Text;
            if (reportType != "")
            {
                var dateStart = DateTime.Parse(dateTimePicker1.Text).ToUniversalTime();
                var dateEnd = DateTime.Parse(dateTimePicker2.Text).ToUniversalTime();
                //var userName = _role.User.Name;
                var userName = "Вова";
                var getReport = new GetReport
                {
                    DateStart = dateStart.ToTimestamp(),
                    DateEnd = dateEnd.ToTimestamp(),
                    UserCreator = userName,
                };
                var report = new ReportModel();
                report = (ReportModel)fuctions[tags[reportType]].Invoke(_facade, new object[] { getReport });
                this.reports.Add(report);

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

                dataGridView1.DataSource = report.Values;
                dataGridView1.Columns.RemoveAt(0);
                creatorUserLabel.Text = userName;
                label4.Text = "Создатель отчёта";

                watchStatus = true;
            }
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            var request = new ReportStateModel()
            {
                State = "Approved",
            };
                       
            try
            {
                if (!watchStatus)
                {
                    var report = reports.Where(x => x.CreateDate == ((Timestamp)dataGridView1.CurrentRow.Cells[0].Value)).First();
                    request.Id = report.Id;
                    _facade.ChangeReportState(request);
                    openReportsButton.PerformClick();
                }
                else
                {
                    if (reports.Count != 0)
                    {
                        checkBox1.Checked = true;
                        var report = reports.First();
                        request.Id = report.Id;
                        _facade.ChangeReportState(request);
                    }
                }
            }
            catch (Exception sd)
            {
                MessageBox.Show(sd.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var request = new ReportStateModel()
            {
                State = "Sent",
            };
            try
            {
                if (!watchStatus)
                {
                    var report = reports.Where(x => x.CreateDate == ((Timestamp)dataGridView1.CurrentRow.Cells[0].Value)).First();
                    request.Id = report.Id;
                    _facade.ChangeReportState(request);
                    openReportsButton.PerformClick();
                }
                else
                {
                    if (reports.Count != 0)
                    {
                        checkBox1.Checked = true;
                        var report = reports.First();
                        request.Id = report.Id;
                        _facade.ChangeReportState(request);
                    }
                }
            }      
            catch (Exception sd)
            {
                MessageBox.Show(sd.Message);
            }
        }

        private void openReportsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            this.reports.Clear();
            //var userName = _role.User.Name;
            var userName = "Вова";
            var request = new ReportUserName();
            request.User = userName;

            var reports = _facade.GetReportList(request).Reports;
            this.reports = reports.ToList();


            var column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "CreateDate";
            column1.HeaderText = "Дата создания";
            var column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Type";
            column2.HeaderText = "Тип";
            var column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "State";
            column3.HeaderText = "Состояние";

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3 });

            dataGridView1.DataSource = reports;
            var columns = dataGridView1.Columns.Cast<DataGridViewColumn>();
            var wrongcolumn = columns.Where(x => x.HeaderText == "Id").First();
            var wrongcolumn2 = columns.Where(x => x.HeaderText == "UserCreator").First();
            dataGridView1.Columns.Remove(wrongcolumn);
            dataGridView1.Columns.Remove(wrongcolumn2);

            dataGridView1.AutoSize = true;
            creatorUserLabel.Text = userName;
            label4.Text = "Создатель отчётов";
            checkBox1.Checked = false;
            watchStatus = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!watchStatus)
            {
                var report = reports.Where(x => x.CreateDate == ((Timestamp)dataGridView1.CurrentRow.Cells[0].Value)).First();
                var requset = new ReportLookup()
                {
                    Id = report.Id,
                };
                _facade.DeleteReport(requset);
                openReportsButton.PerformClick();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
                checkBox1.CheckState = CheckState.Checked;
            else checkBox1.CheckState = CheckState.Unchecked;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {  
            var report = reports.Where(x => x.CreateDate == ((Timestamp)dataGridView1.CurrentRow.Cells[0].Value)).First();   

            var column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "FirstFeature";
            column1.HeaderText = columnNames[report.Type].Item1;
            var columnId = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "SecondFeature";
            column2.HeaderText = columnNames[report.Type].Item2;
            var column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Count";
            column3.HeaderText = "Количество";


            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3 });
            dataGridView1.DataSource = report.Values;
            dataGridView1.Columns.RemoveAt(0);

            label4.Text = "Создатель отчёта";
            creatorUserLabel.Text = report.UserCreator;
            watchStatus = true;
        }
    }
}
