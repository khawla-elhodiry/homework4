
namespace teacher_attendance_DB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label techer_nameLabel;
            System.Windows.Forms.Label cource_nameLabel;
            System.Windows.Forms.Label room_nameLabel;
            System.Windows.Forms.Label start_timeLabel;
            System.Windows.Forms.Label leave_timeLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new teacher_attendance_DB.dataset.DataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new teacher_attendance_DB.dataset.DataSet1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new teacher_attendance_DB.dataset.DataSet1TableAdapters.TableAdapterManager();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataTable1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techer_nameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacher_attendanceDataSet = new teacher_attendance_DB.teacher_attendanceDataSet();
            this.cource_nameComboBox = new System.Windows.Forms.ComboBox();
            this.courceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacher_attendanceDataSet1 = new teacher_attendance_DB.teacher_attendanceDataSet1();
            this.room_nameComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacher_attendanceDataSet2 = new teacher_attendance_DB.teacher_attendanceDataSet2();
            this.start_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leave_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teacherTableAdapter = new teacher_attendance_DB.teacher_attendanceDataSetTableAdapters.teacherTableAdapter();
            this.courceTableAdapter = new teacher_attendance_DB.teacher_attendanceDataSet1TableAdapters.courceTableAdapter();
            this.roomTableAdapter = new teacher_attendance_DB.teacher_attendanceDataSet2TableAdapters.roomTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new teacher_attendance_DB.dataset.DataSet1TableAdapters.attendanceTableAdapter();
            techer_nameLabel = new System.Windows.Forms.Label();
            cource_nameLabel = new System.Windows.Forms.Label();
            room_nameLabel = new System.Windows.Forms.Label();
            start_timeLabel = new System.Windows.Forms.Label();
            leave_timeLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // techer_nameLabel
            // 
            techer_nameLabel.AutoSize = true;
            techer_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            techer_nameLabel.Location = new System.Drawing.Point(62, 60);
            techer_nameLabel.Name = "techer_nameLabel";
            techer_nameLabel.Size = new System.Drawing.Size(152, 29);
            techer_nameLabel.TabIndex = 2;
            techer_nameLabel.Text = "techer name:";
            // 
            // cource_nameLabel
            // 
            cource_nameLabel.AutoSize = true;
            cource_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cource_nameLabel.Location = new System.Drawing.Point(64, 107);
            cource_nameLabel.Name = "cource_nameLabel";
            cource_nameLabel.Size = new System.Drawing.Size(158, 29);
            cource_nameLabel.TabIndex = 4;
            cource_nameLabel.Text = "cource name:";
            // 
            // room_nameLabel
            // 
            room_nameLabel.AutoSize = true;
            room_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            room_nameLabel.Location = new System.Drawing.Point(75, 159);
            room_nameLabel.Name = "room_nameLabel";
            room_nameLabel.Size = new System.Drawing.Size(141, 29);
            room_nameLabel.TabIndex = 6;
            room_nameLabel.Text = "room name:";
            // 
            // start_timeLabel
            // 
            start_timeLabel.AutoSize = true;
            start_timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_timeLabel.Location = new System.Drawing.Point(557, 50);
            start_timeLabel.Name = "start_timeLabel";
            start_timeLabel.Size = new System.Drawing.Size(116, 29);
            start_timeLabel.TabIndex = 8;
            start_timeLabel.Text = "start time:";
            // 
            // leave_timeLabel
            // 
            leave_timeLabel.AutoSize = true;
            leave_timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leave_timeLabel.Location = new System.Drawing.Point(557, 90);
            leave_timeLabel.Name = "leave_timeLabel";
            leave_timeLabel.Size = new System.Drawing.Size(129, 29);
            leave_timeLabel.TabIndex = 10;
            leave_timeLabel.Text = "leave time:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.Location = new System.Drawing.Point(386, 192);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(66, 29);
            noteLabel.TabIndex = 12;
            noteLabel.Text = "note:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(597, 135);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(66, 29);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "date:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = teacher_attendance_DB.dataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTable1BindingNavigator.BindingSource = this.dataTable1BindingSource;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTable1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataTable1BindingNavigatorSaveItem});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(948, 27);
            this.dataTable1BindingNavigator.TabIndex = 0;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataTable1BindingNavigatorSaveItem
            // 
            this.dataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTable1BindingNavigatorSaveItem.Enabled = false;
            this.dataTable1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTable1BindingNavigatorSaveItem.Image")));
            this.dataTable1BindingNavigatorSaveItem.Name = "dataTable1BindingNavigatorSaveItem";
            this.dataTable1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.dataTable1BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(12, 255);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowHeadersWidth = 51;
            this.dataTable1DataGridView.RowTemplate.Height = 24;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(893, 220);
            this.dataTable1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "techer_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "techer_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cource_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "cource_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "room_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "room_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "start_time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "leave_time";
            this.dataGridViewTextBoxColumn5.HeaderText = "leave_time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn6.HeaderText = "note";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn7.HeaderText = "date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // techer_nameComboBox
            // 
            this.techer_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "techer_name", true));
            this.techer_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "teacher_id", true));
            this.techer_nameComboBox.DataSource = this.teacherBindingSource;
            this.techer_nameComboBox.DisplayMember = "techer_name";
            this.techer_nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techer_nameComboBox.FormattingEnabled = true;
            this.techer_nameComboBox.Location = new System.Drawing.Point(220, 60);
            this.techer_nameComboBox.Name = "techer_nameComboBox";
            this.techer_nameComboBox.Size = new System.Drawing.Size(121, 37);
            this.techer_nameComboBox.TabIndex = 3;
            this.techer_nameComboBox.ValueMember = "teacher_id";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // teacher_attendanceDataSet
            // 
            this.teacher_attendanceDataSet.DataSetName = "teacher_attendanceDataSet";
            this.teacher_attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cource_nameComboBox
            // 
            this.cource_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "cource_name", true));
            this.cource_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courceBindingSource, "cource_id", true));
            this.cource_nameComboBox.DataSource = this.courceBindingSource;
            this.cource_nameComboBox.DisplayMember = "cource_name";
            this.cource_nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_nameComboBox.FormattingEnabled = true;
            this.cource_nameComboBox.Location = new System.Drawing.Point(220, 104);
            this.cource_nameComboBox.Name = "cource_nameComboBox";
            this.cource_nameComboBox.Size = new System.Drawing.Size(121, 37);
            this.cource_nameComboBox.TabIndex = 5;
            this.cource_nameComboBox.ValueMember = "cource_id";
            // 
            // courceBindingSource
            // 
            this.courceBindingSource.DataMember = "cource";
            this.courceBindingSource.DataSource = this.teacher_attendanceDataSet1;
            // 
            // teacher_attendanceDataSet1
            // 
            this.teacher_attendanceDataSet1.DataSetName = "teacher_attendanceDataSet1";
            this.teacher_attendanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room_nameComboBox
            // 
            this.room_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "room_name", true));
            this.room_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomBindingSource, "room_id", true));
            this.room_nameComboBox.DataSource = this.roomBindingSource;
            this.room_nameComboBox.DisplayMember = "room_name";
            this.room_nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_nameComboBox.FormattingEnabled = true;
            this.room_nameComboBox.Location = new System.Drawing.Point(220, 156);
            this.room_nameComboBox.Name = "room_nameComboBox";
            this.room_nameComboBox.Size = new System.Drawing.Size(121, 37);
            this.room_nameComboBox.TabIndex = 7;
            this.room_nameComboBox.ValueMember = "room_id";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.teacher_attendanceDataSet2;
            // 
            // teacher_attendanceDataSet2
            // 
            this.teacher_attendanceDataSet2.DataSetName = "teacher_attendanceDataSet2";
            this.teacher_attendanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // start_timeDateTimePicker
            // 
            this.start_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataTable1BindingSource, "start_time", true));
            this.start_timeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start_timeDateTimePicker.Location = new System.Drawing.Point(709, 50);
            this.start_timeDateTimePicker.Name = "start_timeDateTimePicker";
            this.start_timeDateTimePicker.Size = new System.Drawing.Size(144, 34);
            this.start_timeDateTimePicker.TabIndex = 9;
            // 
            // leave_timeDateTimePicker
            // 
            this.leave_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataTable1BindingSource, "leave_time", true));
            this.leave_timeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.leave_timeDateTimePicker.Location = new System.Drawing.Point(709, 90);
            this.leave_timeDateTimePicker.Name = "leave_timeDateTimePicker";
            this.leave_timeDateTimePicker.Size = new System.Drawing.Size(144, 34);
            this.leave_timeDateTimePicker.TabIndex = 11;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "note", true));
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(458, 192);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(424, 34);
            this.noteTextBox.TabIndex = 13;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataTable1BindingSource, "date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(709, 135);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(144, 34);
            this.dateDateTimePicker.TabIndex = 15;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // courceTableAdapter
            // 
            this.courceTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = this.dataSet1;
            this.attendanceBindingSource.Position = 0;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 516);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(leave_timeLabel);
            this.Controls.Add(this.leave_timeDateTimePicker);
            this.Controls.Add(start_timeLabel);
            this.Controls.Add(this.start_timeDateTimePicker);
            this.Controls.Add(room_nameLabel);
            this.Controls.Add(this.room_nameComboBox);
            this.Controls.Add(cource_nameLabel);
            this.Controls.Add(this.cource_nameComboBox);
            this.Controls.Add(techer_nameLabel);
            this.Controls.Add(this.techer_nameComboBox);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dataset.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataTable1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox techer_nameComboBox;
        private System.Windows.Forms.ComboBox cource_nameComboBox;
        private System.Windows.Forms.ComboBox room_nameComboBox;
        private System.Windows.Forms.DateTimePicker start_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker leave_timeDateTimePicker;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private teacher_attendanceDataSet teacher_attendanceDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private teacher_attendanceDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private teacher_attendanceDataSet1 teacher_attendanceDataSet1;
        private System.Windows.Forms.BindingSource courceBindingSource;
        private teacher_attendanceDataSet1TableAdapters.courceTableAdapter courceTableAdapter;
        private teacher_attendanceDataSet2 teacher_attendanceDataSet2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private teacher_attendanceDataSet2TableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private dataset.DataSet1TableAdapters.attendanceTableAdapter attendanceTableAdapter;
    }
}

