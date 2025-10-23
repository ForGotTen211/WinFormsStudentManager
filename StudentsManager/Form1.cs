using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;


namespace StudentsManager
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new();
        private Student? _selectedStudent = null;

        public Form1()
        {
            InitializeComponent();
            using var db = new AppDbContext();
            db.Students.Load();
            _bindingSource.DataSource = db.Students.Local.ToBindingList();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
                return;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            Student student = new()
            {
                Name = "misha",
                Age = 18,
                Group = 52,
                AverageScore = 1488,
                AdmissionDate = DateTime.Now,
            };
            db.Add(student);
            db.SaveChanges();
            _bindingSource.Add(student);
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(db.Students.First().Name);
            StudentChangeForm form2 = new();
            form2.OnStudentChanged += (student) =>
            {
                using var db = new AppDbContext();
                db.Students.Update(student);
                db.SaveChanges();
            };
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentChangeForm form2 = new();
            form2.OnStudentChanged += (student) =>
            {
                using var db = new AppDbContext();
                db.Students.Add(student);
                db.SaveChanges();
            };
            form2.ShowDialog();
        }
    }
}
