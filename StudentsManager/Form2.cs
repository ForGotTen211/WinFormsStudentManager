using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager
{
    public partial class StudentChangeForm : Form
    {
        private Student _student;
        public event Action<Student> OnStudentChanged = s => {};

        public StudentChangeForm(Student? student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                _nameBox.Text = student.Name;
                _ageBox.Text = student.Age.ToString();
                _groupBox.Text = student.Group.ToString();
                _averageBox.Text = student.AverageScore.ToString();
                _addmissionDateBox.Text = student.AdmissionDate.ToString();
            }
            _student = student ?? new Student();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            
            _student.Name = _nameBox.Text;
            _student.Age = int.Parse(_ageBox.Text);
            _student.Group = int.Parse(_groupBox.Text);
            _student.AverageScore = int.Parse(_averageBox.Text);
            _student.AdmissionDate = DateTime.Parse(_addmissionDateBox.Text);

            OnStudentChanged(_student);
            Close();
        }
    }
}
