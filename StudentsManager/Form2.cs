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
    public partial class Form2 : Form
    {
        private Student _student;

        public Form2(Student? student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                textBox1.Text = student.Name;
                textBox2.Text = student.Age.ToString();
                textBox3.Text = student.Group.ToString();
                textBox4.Text = student.AverageScore.ToString();
                textBox5.Text = student.AdmissionDate.ToString();
            }
            else
            {
                _student = new Student();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            _student.Name = textBox1.Text;
            _student.Name = textBox1.Text;
            _student.Name = textBox1.Text;
            _student.Name = textBox1.Text;
            _student.Name = textBox1.Text;

            db.Students.Add(_student);
            db.SaveChanges();
        }
    }
}
