using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranscript
{
    public partial class Form1 : Form
    {
        List<Course> year1Sem1;
        List<Course> year1Sem2;
        List<Course> year2Sem1;
        List<Course> year2Sem2;
        List<Course> year3Sem1;
        List<Course> year3Sem2;
        List<Course> year4Sem1;
        List<Course> year4Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();

            year2Sem1 = new List<Course>();
            year2Sem2 = new List<Course>();

            year3Sem1 = new List<Course>();
            year3Sem2 = new List<Course>();

            year4Sem1 = new List<Course>();
            year4Sem2 = new List<Course>();
        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBoxCourseID.Text;
            newCourse.CourseName = textBoxCourseName.Text;
            newCourse.CourseCredit = textBoxCourseID.Text;
            newCourse.Grade = textBoxGrade.Text;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridViewY1S1.DataSource = null;
                    year1Sem1.Add(newCourse);
                    dataGridViewY1S1.DataSource = year1Sem1;
                    break;
                case 1:
                    dataGridViewY1S2.DataSource = null;
                    year1Sem2.Add(newCourse);
                    dataGridViewY1S2.DataSource = year1Sem2;
                    break;
                case 2:
                    dataGridViewY2S1.DataSource = null;
                    year2Sem1.Add(newCourse);
                    dataGridViewY2S1.DataSource = year2Sem1;
                    break;
                case 3:
                    dataGridViewY2S2.DataSource = null;
                    year2Sem2.Add(newCourse);
                    dataGridViewY2S2.DataSource = year2Sem2;
                    break;
                case 4:
                    dataGridViewY3S1.DataSource = null;
                    year3Sem1.Add(newCourse);
                    dataGridViewY3S1.DataSource = year3Sem1;
                    break;
                case 5:
                    dataGridViewY3S2.DataSource = null;
                    year3Sem2.Add(newCourse);
                    dataGridViewY3S2.DataSource = year3Sem2;
                    break;
                case 6:
                    dataGridViewY4S1.DataSource = null;
                    year4Sem1.Add(newCourse);
                    dataGridViewY4S1.DataSource = year4Sem1;
                    break;
                case 7:
                    dataGridViewY4S2.DataSource = null;
                    year4Sem2.Add(newCourse);
                    dataGridViewY4S2.DataSource = year4Sem2;
                    break;
            }
        }
    }
    class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
        public string Grade { get; set; }
    }
}
