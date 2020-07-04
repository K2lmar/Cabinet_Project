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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "teacher")
            {
                buttonOpenAdministrators.Enabled = false;
            }
            labelHello.Text = "Добро пожаловать, " + FormAuthorization.users.login;
        }

        private void buttonOpenTeachers_Click(object sender, EventArgs e)
        {
            Form formTeacher = new FormTeacher();
            formTeacher.Show();
        }

        private void buttonOpenSchoolSubjects_Click(object sender, EventArgs e)
        {
            Form formSchoolSubject = new FormSchoolSubject();
            formSchoolSubject.Show();
        }

        private void buttonOpenAdministrators_Click(object sender, EventArgs e)
        {
            Form formAdministrator = new FormAdministrator();
            formAdministrator.Show();
        }
    }
}
