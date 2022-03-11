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
using Newtonsoft.Json;
using System.IO;

namespace Session_07
{
    public partial class UniversityForm : Form
    {
        University _universityItem;
        private const string FILE_NAME = "storage.json";

        public UniversityForm()
        {
            InitializeComponent();
        }

        #region UI
        private void UniversityForm_Load(object sender, EventArgs e)
        {
            _universityItem = new University()
            {
                Students = new List<Student>(),
                Courses = new List<Course>(),
                Professors = new List<Professor>(),
                Grades = new List<Grade>(),
                ScheduledCourses = new List<Schedule>()
            };
            //LoadData();
        }


        private void barButtonStudentsEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new StudentsForm()
            {
                UniversityItem = _universityItem
            });
        }
        private void barButtonProfessorsEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new ProfessorForm()
            {
                UniversityItem = _universityItem
            });
        }
        private void UniversityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveData();
        }

        #endregion

        //private void LoadData()
        //{
        //    try
        //    {
        //        string f = File.ReadAllText(FILE_NAME);
        //        _universityItem = (University)JsonConvert.DeserializeObject(f);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("No file found to load.");
        //    }
        //}

        //private void SaveData()
        //{
        //    string json = JsonConvert.SerializeObject(_universityItem, Formatting.Indented);
        //    File.WriteAllText(FILE_NAME, json);
        //}


        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

    }
}
