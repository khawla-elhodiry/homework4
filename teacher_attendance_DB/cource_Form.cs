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
    public partial class cource_Form : Form
    {
        public cource_Form()
        {
            InitializeComponent();
        }

        private void courceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet1);

        }

        private void cource_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet1.cource' table. You can move, or remove it, as needed.
            this.courceTableAdapter.Fill(this.teacher_attendanceDataSet1.cource);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courceBindingSource.EndEdit();
            this.courceTableAdapter.Update(teacher_attendanceDataSet1.cource);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courceTableAdapter.Insert(cource_nameTextBox.Text);
            this.courceTableAdapter.Fill(this.teacher_attendanceDataSet1.cource);
        }
    }
}
