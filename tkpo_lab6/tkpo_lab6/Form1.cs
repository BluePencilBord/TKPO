using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkpo_lab6
{
    public partial class Form1 : Form, IObserver
    {
        private readonly CourseModel _model;
        private readonly CourseController _controller;
        public List<int> Grades { get; private set; }
        public Form1()
        {
            InitializeComponent();
            Grades = new List<int>();
            _model = new CourseModel("Тестовый курс");
            _controller = new CourseController(_model);
            _model.AddObserver(this);
            this.labelCourseName.Text = _model.CourseName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _controller.AddStudent(this.textBoxStudentName.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _controller.RemoveStudent(this.listBoxInfo.SelectedIndex);
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddGrade(this.listBoxInfo.SelectedIndex, Convert.ToInt16(this.textBoxStudentName.Text));
            }
            catch
            {
                MessageBox.Show("Неверно введено число");
            }
        }

        public new void Update()
        {
            this.listBoxInfo.Items.Clear();
            Grades.Clear();
            foreach (Student student in _model.Students)
            {
                this.listBoxInfo.Items.Add(student.Name);
                Grades.Add(student.Grade);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.labelGrade.Text = Grades[this.listBoxInfo.SelectedIndex].ToString();
            }
            catch
            {

            }
        }
    }
}
