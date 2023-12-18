namespace ClientSideGrpc
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            отчётToolStripMenuItem = new ToolStripMenuItem();
            сформироватьToolStripMenuItem = new ToolStripMenuItem();
            подтвердитьToolStripMenuItem = new ToolStripMenuItem();
            отправитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker2 = new DateTimePicker();
            reportTypesComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            reportGenereteButton = new Button();
            openReportsButton = new Button();
            changeStateButton = new Button();
            userComboBox = new ComboBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { отчётToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1322, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // отчётToolStripMenuItem
            // 
            отчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сформироватьToolStripMenuItem, подтвердитьToolStripMenuItem, отправитьToolStripMenuItem, удалитьToolStripMenuItem, toolStripMenuItem1, закрытьToolStripMenuItem });
            отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            отчётToolStripMenuItem.Size = new Size(51, 20);
            отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // сформироватьToolStripMenuItem
            // 
            сформироватьToolStripMenuItem.Name = "сформироватьToolStripMenuItem";
            сформироватьToolStripMenuItem.Size = new Size(158, 22);
            сформироватьToolStripMenuItem.Text = "Сформировать";
            // 
            // подтвердитьToolStripMenuItem
            // 
            подтвердитьToolStripMenuItem.Name = "подтвердитьToolStripMenuItem";
            подтвердитьToolStripMenuItem.Size = new Size(158, 22);
            подтвердитьToolStripMenuItem.Text = "Подтвердить";
            // 
            // отправитьToolStripMenuItem
            // 
            отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            отправитьToolStripMenuItem.Size = new Size(158, 22);
            отправитьToolStripMenuItem.Text = "Отправить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(158, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(158, 22);
            закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 2, 1);
            tableLayoutPanel1.Controls.Add(reportTypesComboBox, 0, 1);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Controls.Add(deleteButton, 4, 1);
            tableLayoutPanel1.Controls.Add(reportGenereteButton, 3, 1);
            tableLayoutPanel1.Controls.Add(openReportsButton, 3, 0);
            tableLayoutPanel1.Controls.Add(changeStateButton, 5, 1);
            tableLayoutPanel1.Controls.Add(userComboBox, 6, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1322, 624);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Bottom;
            dateTimePicker2.Location = new Point(353, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(144, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // reportTypesComboBox
            // 
            reportTypesComboBox.Dock = DockStyle.Bottom;
            reportTypesComboBox.FormattingEnabled = true;
            reportTypesComboBox.Location = new Point(3, 34);
            reportTypesComboBox.Name = "reportTypesComboBox";
            reportTypesComboBox.Size = new Size(194, 23);
            reportTypesComboBox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Bottom;
            dateTimePicker1.Location = new Point(203, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 3;
            label1.Text = "Вид отчёта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(203, 15);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 4;
            label2.Text = "Период: начало";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(353, 15);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 5;
            label3.Text = "конец";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 9);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1316, 533);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Location = new Point(653, 33);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 24);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Удалить отчёт";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // reportGenereteButton
            // 
            reportGenereteButton.Location = new Point(503, 33);
            reportGenereteButton.Name = "reportGenereteButton";
            reportGenereteButton.Size = new Size(144, 23);
            reportGenereteButton.TabIndex = 6;
            reportGenereteButton.Text = "Сформировать";
            reportGenereteButton.UseVisualStyleBackColor = true;
            reportGenereteButton.Click += reportGenereteButton_Click;
            // 
            // openReportsButton
            // 
            openReportsButton.Location = new Point(503, 3);
            openReportsButton.Name = "openReportsButton";
            openReportsButton.Size = new Size(144, 23);
            openReportsButton.TabIndex = 9;
            openReportsButton.Text = "Просмотреть отчёты";
            openReportsButton.UseVisualStyleBackColor = true;
            openReportsButton.Click += openReportsButton_Click;
            // 
            // changeStateButton
            // 
            changeStateButton.Location = new Point(753, 33);
            changeStateButton.Name = "changeStateButton";
            changeStateButton.Size = new Size(94, 23);
            changeStateButton.TabIndex = 7;
            changeStateButton.Text = "Утвердить";
            changeStateButton.UseVisualStyleBackColor = true;
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(853, 33);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(94, 23);
            userComboBox.TabIndex = 14;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 648);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReportForm";
            Text = "Отчёт";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private ToolStripMenuItem сформироватьToolStripMenuItem;
        private ToolStripMenuItem подтвердитьToolStripMenuItem;
        private ToolStripMenuItem отправитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox reportTypesComboBox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button reportGenereteButton;
        private Button changeStateButton;
        private Button openReportsButton;
        private DataGridView dataGridView1;
        private Button deleteButton;
        private ComboBox userComboBox;
    }
}