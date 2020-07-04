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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            ShowTeacher();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TeachersSet teachersSet = new TeachersSet();
            teachersSet.Login = textBoxLogin.Text;
            teachersSet.Password = textBoxPassword.Text;
            teachersSet.FirstName = textBoxFirstName.Text;
            teachersSet.MiddleName = textBoxMiddleName.Text;
            teachersSet.LastName = textBoxLastName.Text;
            teachersSet.Phone = textBoxPhone.Text;
            teachersSet.Email = textBoxEmail.Text;
            Program.wftDb.TeachersSet.Add(teachersSet);
            Program.wftDb.SaveChanges();
            ShowTeacher();
        }
        void ShowTeacher()
        {
            listViewTeacher.Items.Clear();
            foreach (TeachersSet teachersSet in Program.wftDb.TeachersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  teachersSet.Id.ToString(), teachersSet.Login, teachersSet.Password,
                  teachersSet.FirstName, teachersSet.MiddleName, teachersSet.LastName,
                  teachersSet.Phone, teachersSet.Email
                });
                item.Tag = teachersSet;
                listViewTeacher.Items.Add(item);
            }
            listViewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeacher.SelectedItems.Count == 1)
            {
                TeachersSet teachersSet = listViewTeacher.SelectedItems[0].Tag as TeachersSet;
                teachersSet.Login = textBoxLogin.Text;
                teachersSet.Password = textBoxPassword.Text;
                teachersSet.FirstName = textBoxFirstName.Text;
                teachersSet.MiddleName = textBoxMiddleName.Text;
                teachersSet.LastName = textBoxLastName.Text;
                teachersSet.Phone = textBoxPhone.Text;
                teachersSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowTeacher();
            }
        }

        private void listViewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeacher.SelectedItems.Count == 1)
            {
                TeachersSet teachersSet = listViewTeacher.SelectedItems[0].Tag as TeachersSet;
                textBoxLogin.Text = teachersSet.Login;
                textBoxPassword.Text = teachersSet.Password;
                textBoxFirstName.Text = teachersSet.FirstName;
                textBoxMiddleName.Text = teachersSet.MiddleName;
                textBoxLastName.Text = teachersSet.LastName;
                textBoxPhone.Text = teachersSet.Phone;
                textBoxEmail.Text = teachersSet.Email;
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = ""; 
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeacher.SelectedItems.Count == 1)
                {
                    TeachersSet teachersSet = listViewTeacher.SelectedItems[0].Tag as TeachersSet;
                    Program.wftDb.TeachersSet.Remove(teachersSet);
                    Program.wftDb.SaveChanges();
                    ShowTeacher();
                }
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
