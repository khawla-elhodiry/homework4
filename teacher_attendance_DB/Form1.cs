using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher_attendance_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.dataSet1.attendance);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet2.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.teacher_attendanceDataSet2.room);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet1.cource' table. You can move, or remove it, as needed.
            this.courceTableAdapter.Fill(this.teacher_attendanceDataSet1.cource);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.teacher_attendanceDataSet.teacher);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacher_Form2 f1 = new teacher_Form2();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cource_Form f1 = new cource_Form();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            room_Form f1 = new room_Form();
            f1.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int tea_id = Convert.ToInt32(techer_nameComboBox.SelectedValue);
            int cource_id = Convert.ToInt32(cource_nameComboBox.SelectedValue);
            int room_id = Convert.ToInt32(room_nameComboBox.SelectedValue);

            this.attendanceTableAdapter.Insert(tea_id, cource_id, room_id, this.start_timeDateTimePicker.Value.TimeOfDay, leave_timeDateTimePicker.Value.TimeOfDay, noteTextBox.Text, dateDateTimePicker.Value);
            this.attendanceTableAdapter.Fill(this.dataSet1.attendance);
            
        }
    }
}
