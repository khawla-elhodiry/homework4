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
    public partial class room_Form : Form
    {
        public room_Form()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet2);

        }

        private void room_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet2.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.teacher_attendanceDataSet2.room);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            roomTableAdapter.Insert(room_nameTextBox.Text);
            this.roomTableAdapter.Fill(this.teacher_attendanceDataSet2.room);
           
        }
    }
}
