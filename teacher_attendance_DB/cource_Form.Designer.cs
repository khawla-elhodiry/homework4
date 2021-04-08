
namespace teacher_attendance_DB
{
    partial class cource_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cource_Form));
            System.Windows.Forms.Label cource_nameLabel;
            this.teacher_attendanceDataSet1 = new teacher_attendance_DB.teacher_attendanceDataSet1();
            this.courceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courceTableAdapter = new teacher_attendance_DB.teacher_attendanceDataSet1TableAdapters.courceTableAdapter();
            this.tableAdapterManager = new teacher_attendance_DB.teacher_attendanceDataSet1TableAdapters.TableAdapterManager();
            this.courceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.courceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cource_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            cource_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingNavigator)).BeginInit();
            this.courceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_attendanceDataSet1
            // 
            this.teacher_attendanceDataSet1.DataSetName = "teacher_attendanceDataSet1";
            this.teacher_attendanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courceBindingSource
            // 
            this.courceBindingSource.DataMember = "cource";
            this.courceBindingSource.DataSource = this.teacher_attendanceDataSet1;
            // 
            // courceTableAdapter
            // 
            this.courceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courceTableAdapter = this.courceTableAdapter;
            this.tableAdapterManager.UpdateOrder = teacher_attendance_DB.teacher_attendanceDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courceBindingNavigator
            // 
            this.courceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courceBindingNavigator.BindingSource = this.courceBindingSource;
            this.courceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.courceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.courceBindingNavigatorSaveItem});
            this.courceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courceBindingNavigator.Name = "courceBindingNavigator";
            this.courceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courceBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.courceBindingNavigator.TabIndex = 0;
            this.courceBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // courceBindingNavigatorSaveItem
            // 
            this.courceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courceBindingNavigatorSaveItem.Image")));
            this.courceBindingNavigatorSaveItem.Name = "courceBindingNavigatorSaveItem";
            this.courceBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.courceBindingNavigatorSaveItem.Text = "Save Data";
            this.courceBindingNavigatorSaveItem.Click += new System.EventHandler(this.courceBindingNavigatorSaveItem_Click);
            // 
            // courceDataGridView
            // 
            this.courceDataGridView.AutoGenerateColumns = false;
            this.courceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.courceDataGridView.DataSource = this.courceBindingSource;
            this.courceDataGridView.Location = new System.Drawing.Point(267, 197);
            this.courceDataGridView.Name = "courceDataGridView";
            this.courceDataGridView.RowHeadersWidth = 51;
            this.courceDataGridView.RowTemplate.Height = 24;
            this.courceDataGridView.Size = new System.Drawing.Size(300, 220);
            this.courceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cource_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "cource_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // cource_nameLabel
            // 
            cource_nameLabel.AutoSize = true;
            cource_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cource_nameLabel.Location = new System.Drawing.Point(262, 121);
            cource_nameLabel.Name = "cource_nameLabel";
            cource_nameLabel.Size = new System.Drawing.Size(131, 25);
            cource_nameLabel.TabIndex = 2;
            cource_nameLabel.Text = "cource name:";
            // 
            // cource_nameTextBox
            // 
            this.cource_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courceBindingSource, "cource_name", true));
            this.cource_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_nameTextBox.Location = new System.Drawing.Point(399, 121);
            this.cource_nameTextBox.Name = "cource_nameTextBox";
            this.cource_nameTextBox.Size = new System.Drawing.Size(146, 30);
            this.cource_nameTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cource_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(cource_nameLabel);
            this.Controls.Add(this.cource_nameTextBox);
            this.Controls.Add(this.courceDataGridView);
            this.Controls.Add(this.courceBindingNavigator);
            this.Name = "cource_Form";
            this.Text = "cource_Form";
            this.Load += new System.EventHandler(this.cource_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingNavigator)).EndInit();
            this.courceBindingNavigator.ResumeLayout(false);
            this.courceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private teacher_attendanceDataSet1 teacher_attendanceDataSet1;
        private System.Windows.Forms.BindingSource courceBindingSource;
        private teacher_attendanceDataSet1TableAdapters.courceTableAdapter courceTableAdapter;
        private teacher_attendanceDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton courceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView courceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox cource_nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}