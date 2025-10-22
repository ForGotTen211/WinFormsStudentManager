using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;


namespace StudentsManager
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new();
        public Form1()
        {
            InitializeComponent();
            var db = new AppDbContext();
            db.Students.Load();
            _bindingSource.DataSource = db.Students.Local.ToBindingList();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(db.Students.First().Name);
            Form2 form2 = new();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
