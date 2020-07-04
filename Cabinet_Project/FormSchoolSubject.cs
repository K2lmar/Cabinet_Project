using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Project
{
    public partial class FormSchoolSubject : Form
    {
        public FormSchoolSubject()
        {
            InitializeComponent();
            ShowTeacher();
            ShowSchoolSubject();
        }

        void ShowTeacher()
        {
            comboBoxIdTeachers.Items.Clear();
            foreach (TeachersSet teachersSet in Program.wftDb.TeachersSet)
            {
                string[] item = {teachersSet.Id.ToString() + ".", teachersSet.FirstName, 
                  teachersSet.MiddleName, teachersSet.LastName,
                  teachersSet.Phone, teachersSet.Email};
                comboBoxIdTeachers.Items.Add(string.Join("", item));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxIdTeachers.SelectedItem != null && textBoxNameSubject.Text != "")
            {
                SchoolSubjectsSet schoolSubjectsSet = new SchoolSubjectsSet();
                schoolSubjectsSet.NameSubject = textBoxNameSubject.Text;
                schoolSubjectsSet.IdTeachers = Convert.ToInt32(comboBoxIdTeachers.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SchoolSubjectsSet.Add(schoolSubjectsSet);
                Program.wftDb.SaveChanges();
                ShowSchoolSubject();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowSchoolSubject()
        {
            listViewSchoolSubject.Items.Clear();
            foreach (SchoolSubjectsSet schoolSubjectsSet in Program.wftDb.SchoolSubjectsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    schoolSubjectsSet.Id.ToString() + ".",
                    schoolSubjectsSet.NameSubject.ToString(),
                    schoolSubjectsSet.IdTeachers.ToString(),
                    schoolSubjectsSet.TeachersSet.FirstName+" "+schoolSubjectsSet.TeachersSet.MiddleName+" "+schoolSubjectsSet.TeachersSet.LastName
                });
                item.Tag = schoolSubjectsSet;
                listViewSchoolSubject.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSchoolSubject.SelectedItems.Count == 1)
            {
                SchoolSubjectsSet schoolSubjectsSet = listViewSchoolSubject.SelectedItems[0].Tag as SchoolSubjectsSet;
                schoolSubjectsSet.NameSubject = textBoxNameSubject.Text;
                schoolSubjectsSet.IdTeachers = Convert.ToInt32(comboBoxIdTeachers.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowSchoolSubject();
            }
        }

        private void listViewSchoolSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSchoolSubject.SelectedItems.Count == 1)
            {
                SchoolSubjectsSet schoolSubjectsSet = listViewSchoolSubject.SelectedItems[0].Tag as SchoolSubjectsSet;
                textBoxNameSubject.Text = schoolSubjectsSet.NameSubject;
                comboBoxIdTeachers.SelectedIndex = comboBoxIdTeachers.FindString(schoolSubjectsSet.IdTeachers.ToString());
            }
            else
            {
                textBoxNameSubject.Text = "";
                comboBoxIdTeachers.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSchoolSubject.SelectedItems.Count == 1)
                {
                    SchoolSubjectsSet schoolSubjectsSet = listViewSchoolSubject.SelectedItems[0].Tag as SchoolSubjectsSet;
                    Program.wftDb.SchoolSubjectsSet.Remove(schoolSubjectsSet);
                    Program.wftDb.SaveChanges();
                    ShowSchoolSubject();
                }
                textBoxNameSubject.Text = "";
                comboBoxIdTeachers.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
