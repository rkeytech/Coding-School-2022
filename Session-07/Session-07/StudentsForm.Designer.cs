namespace Session_07
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControlStudent = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.listBoxStudents = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlAge = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditRegNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlRegNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.listBoxCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labelControlCourses = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.buttonAddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonCancelForm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonSaveForm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonDeleteStudent = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spinEditAge = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStudent)).BeginInit();
            this.layoutControlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlRegNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlStudent
            // 
            this.layoutControlStudent.Controls.Add(this.buttonDeleteStudent);
            this.layoutControlStudent.Controls.Add(this.buttonSaveForm);
            this.layoutControlStudent.Controls.Add(this.buttonCancelForm);
            this.layoutControlStudent.Controls.Add(this.buttonAddStudent);
            this.layoutControlStudent.Controls.Add(this.labelControlCourses);
            this.layoutControlStudent.Controls.Add(this.listBoxCourses);
            this.layoutControlStudent.Controls.Add(this.textEditRegNumber);
            this.layoutControlStudent.Controls.Add(this.textEditName);
            this.layoutControlStudent.Controls.Add(this.listBoxStudents);
            this.layoutControlStudent.Controls.Add(this.spinEditAge);
            this.layoutControlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlStudent.Location = new System.Drawing.Point(0, 0);
            this.layoutControlStudent.Name = "layoutControlStudent";
            this.layoutControlStudent.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(156, 108, 650, 400);
            this.layoutControlStudent.Root = this.Root;
            this.layoutControlStudent.Size = new System.Drawing.Size(584, 361);
            this.layoutControlStudent.TabIndex = 0;
            this.layoutControlStudent.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.splitterItem1,
            this.layoutControlName,
            this.layoutControlAge,
            this.layoutControlRegNumber,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(584, 361);
            this.Root.TextVisible = false;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Location = new System.Drawing.Point(12, 12);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(162, 337);
            this.listBoxStudents.StyleController = this.layoutControlStudent;
            this.listBoxStudents.TabIndex = 4;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listBoxStudents;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(166, 341);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(166, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 341);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(339, 12);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(233, 20);
            this.textEditName.StyleController = this.layoutControlStudent;
            this.textEditName.TabIndex = 6;
            // 
            // layoutControlName
            // 
            this.layoutControlName.Control = this.textEditName;
            this.layoutControlName.Location = new System.Drawing.Point(176, 0);
            this.layoutControlName.Name = "layoutControlName";
            this.layoutControlName.Size = new System.Drawing.Size(388, 24);
            this.layoutControlName.Text = "Student Name";
            this.layoutControlName.TextSize = new System.Drawing.Size(139, 13);
            // 
            // layoutControlAge
            // 
            this.layoutControlAge.Control = this.spinEditAge;
            this.layoutControlAge.Location = new System.Drawing.Point(176, 24);
            this.layoutControlAge.Name = "layoutControlAge";
            this.layoutControlAge.Size = new System.Drawing.Size(388, 24);
            this.layoutControlAge.Text = "Student Age";
            this.layoutControlAge.TextSize = new System.Drawing.Size(139, 13);
            // 
            // textEditRegNumber
            // 
            this.textEditRegNumber.Location = new System.Drawing.Point(339, 60);
            this.textEditRegNumber.Name = "textEditRegNumber";
            this.textEditRegNumber.Size = new System.Drawing.Size(233, 20);
            this.textEditRegNumber.StyleController = this.layoutControlStudent;
            this.textEditRegNumber.TabIndex = 8;
            // 
            // layoutControlRegNumber
            // 
            this.layoutControlRegNumber.Control = this.textEditRegNumber;
            this.layoutControlRegNumber.Location = new System.Drawing.Point(176, 48);
            this.layoutControlRegNumber.Name = "layoutControlRegNumber";
            this.layoutControlRegNumber.Size = new System.Drawing.Size(388, 24);
            this.layoutControlRegNumber.Text = "Student Registration Number";
            this.layoutControlRegNumber.TextSize = new System.Drawing.Size(139, 13);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Location = new System.Drawing.Point(340, 84);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(232, 112);
            this.listBoxCourses.StyleController = this.layoutControlStudent;
            this.listBoxCourses.TabIndex = 9;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.listBoxCourses;
            this.layoutControlItem2.Location = new System.Drawing.Point(328, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(236, 116);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(176, 89);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(152, 99);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // labelControlCourses
            // 
            this.labelControlCourses.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlCourses.Location = new System.Drawing.Point(188, 84);
            this.labelControlCourses.Name = "labelControlCourses";
            this.labelControlCourses.Size = new System.Drawing.Size(148, 13);
            this.labelControlCourses.StyleController = this.layoutControlStudent;
            this.labelControlCourses.TabIndex = 10;
            this.labelControlCourses.Text = "Courses Attending";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControlCourses;
            this.layoutControlItem6.Location = new System.Drawing.Point(176, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(152, 17);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(176, 188);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(388, 127);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(188, 327);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(88, 22);
            this.buttonAddStudent.StyleController = this.layoutControlStudent;
            this.buttonAddStudent.TabIndex = 11;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.buttonAddStudent;
            this.layoutControlItem7.Location = new System.Drawing.Point(176, 315);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // buttonCancelForm
            // 
            this.buttonCancelForm.Location = new System.Drawing.Point(474, 327);
            this.buttonCancelForm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonCancelForm.Name = "buttonCancelForm";
            this.buttonCancelForm.Size = new System.Drawing.Size(98, 22);
            this.buttonCancelForm.StyleController = this.layoutControlStudent;
            this.buttonCancelForm.TabIndex = 12;
            this.buttonCancelForm.Text = "Cancel";
            this.buttonCancelForm.Click += new System.EventHandler(this.buttonCancelForm_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.buttonCancelForm;
            this.layoutControlItem8.Location = new System.Drawing.Point(462, 315);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // buttonSaveForm
            // 
            this.buttonSaveForm.Location = new System.Drawing.Point(381, 327);
            this.buttonSaveForm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonSaveForm.Name = "buttonSaveForm";
            this.buttonSaveForm.Size = new System.Drawing.Size(89, 22);
            this.buttonSaveForm.StyleController = this.layoutControlStudent;
            this.buttonSaveForm.TabIndex = 13;
            this.buttonSaveForm.Text = "Save";
            this.buttonSaveForm.Click += new System.EventHandler(this.buttonSaveForm_Click);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.buttonSaveForm;
            this.layoutControlItem9.Location = new System.Drawing.Point(369, 315);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(93, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(280, 327);
            this.buttonDeleteStudent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(97, 22);
            this.buttonDeleteStudent.StyleController = this.layoutControlStudent;
            this.buttonDeleteStudent.TabIndex = 14;
            this.buttonDeleteStudent.Text = "Delete Student";
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.buttonDeleteStudent;
            this.layoutControlItem10.Location = new System.Drawing.Point(268, 315);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(101, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // spinEditAge
            // 
            this.spinEditAge.Location = new System.Drawing.Point(339, 36);
            this.spinEditAge.Name = "spinEditAge";
            this.spinEditAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAge.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEditAge.Size = new System.Drawing.Size(233, 20);
            this.spinEditAge.StyleController = this.layoutControlStudent;
            this.spinEditAge.TabIndex = 7;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.layoutControlStudent);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlStudent)).EndInit();
            this.layoutControlStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlRegNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAge.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlStudent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControlCourses;
        private DevExpress.XtraEditors.ListBoxControl listBoxCourses;
        private DevExpress.XtraEditors.TextEdit textEditRegNumber;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.ListBoxControl listBoxStudents;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAge;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlRegNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteStudent;
        private DevExpress.XtraEditors.SimpleButton buttonSaveForm;
        private DevExpress.XtraEditors.SimpleButton buttonCancelForm;
        private DevExpress.XtraEditors.SimpleButton buttonAddStudent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SpinEdit spinEditAge;
    }
}