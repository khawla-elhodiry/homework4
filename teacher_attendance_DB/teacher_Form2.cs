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
    public partial class teacher_Form2 : Form
    {
        public teacher_Form2()
        {
            InitializeComponent();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet);

        }

        private void teacher_Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.teacher_attendanceDataSet.teacher);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherTableAdapter.Insert(techer_nameTextBox.Text);
            this.teacherTableAdapter.Fill(this.teacher_attendanceDataSet.teacher);
        }
    }
}
