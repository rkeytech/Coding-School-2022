using LogicProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class StudentsForm : Form
    {
        public University UniversityItem { get; set; }
        private Student _selectedStudent;
        private StudentHandler _studentHandler;

        public StudentsForm()
        {
            InitializeComponent();
            _studentHandler = new StudentHandler();
        }


        #region UI Controls
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudent();

            DisplayStudent();
        }

        private void buttonCancelForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSaveForm_Click(object sender, EventArgs e)
        {
            SaveStudent();

            ShowList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student student = NewStudent();
            ShowList();
            listBoxStudents.SelectedIndex = UniversityItem.Students.IndexOf(student);

        }
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent();

            ShowList();
        }

        #endregion

        private void ShowList()
        {
            listBoxStudents.Items.Clear();
            if ( UniversityItem.Students.Count > 0 )
            {
                foreach (Student item in UniversityItem.Students)
                {
                    listBoxStudents.Items.Add(item.Name);
                }
            }
        }

        private void DisplayStudent()
        {
            if (_selectedStudent != null)
            {
                textEditName.Text = _selectedStudent.Name;
                spinEditAge.Text = _selectedStudent.Age.ToString();
                textEditRegNumber.Text = _selectedStudent.RegistrationNumber.ToString();

                listBoxCourses.Items.Clear();
                if (_selectedStudent.Courses != null)
                {
                    foreach (Course item in _selectedStudent.Courses)
                    {
                        listBoxCourses.Items.Add(item.Code);
                    }
                }
            }
            else
            {
                textEditName.Text = string.Empty;
                spinEditAge.Text = "0";
                textEditRegNumber.Text = "0";
                listBoxCourses.Items.Clear();
            }
        }

        private void SaveStudent()
        {
            if (_selectedStudent != null)
            {
                _selectedStudent.Name = textEditName.Text;
                _selectedStudent.Age = Convert.ToInt32(spinEditAge.Text);
                _selectedStudent.RegistrationNumber = Convert.ToInt32(textEditRegNumber.Text);
            }
        }

        private Student NewStudent()
        {
            return _studentHandler.CreateObject(UniversityItem.Students, "Insert Name");
        }

        private void SelectStudent()
        {
            if (UniversityItem.Students.Count > 0)
            {
                if (listBoxStudents.SelectedIndex != -1)
                {
                    _selectedStudent = UniversityItem.Students[listBoxStudents.SelectedIndex];
                }
                else
                {
                    _selectedStudent = UniversityItem.Students[0];
                }
            }
        }

        private void DeleteStudent()
        {
            _studentHandler.DeleteObject(_selectedStudent, UniversityItem.Students);
            _selectedStudent = null;

        }

    }
}
