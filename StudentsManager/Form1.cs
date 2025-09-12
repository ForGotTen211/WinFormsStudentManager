using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;


namespace StudentsManager
{
    public partial class Form1 : Form
    {
        private AppDbContext _db = new();
        private BindingSource _bindingSource = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db.Students.Load();
            _bindingSource.DataSource = _db.Students.Local;
            dataGridView1.DataSource = _bindingSource;
        }
    }
}
