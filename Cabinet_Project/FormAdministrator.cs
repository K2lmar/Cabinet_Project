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
    public partial class FormAdministrator : Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
            ShowAdministrator();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdministratorsSet administratorSet = new AdministratorsSet();
            administratorSet.Login = textBoxLogin.Text;
            administratorSet.Password = textBoxPassword.Text;
            administratorSet.FirstName = textBoxFirstName.Text;
            administratorSet.MiddleName = textBoxMiddleName.Text;
            administratorSet.LastName = textBoxLastName.Text;
            Program.wftDb.AdministratorsSet.Add(administratorSet);
            Program.wftDb.SaveChanges();
            ShowAdministrator();
        }
        void ShowAdministrator()
        {
            listViewAdministrator.Items.Clear();
            foreach (AdministratorsSet administratorSet in Program.wftDb.AdministratorsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  administratorSet.Id.ToString(), administratorSet.Login, administratorSet.Password,
                  administratorSet.FirstName, administratorSet.MiddleName, administratorSet.LastName
                });
                item.Tag = administratorSet;
                listViewAdministrator.Items.Add(item);
            }
            listViewAdministrator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAdministrator.SelectedItems.Count == 1)
            {
                AdministratorsSet administratorSet = listViewAdministrator.SelectedItems[0].Tag as AdministratorsSet;
                administratorSet.Login = textBoxLogin.Text;
                administratorSet.Password = textBoxPassword.Text;
                administratorSet.FirstName = textBoxFirstName.Text;
                administratorSet.MiddleName = textBoxMiddleName.Text;
                administratorSet.LastName = textBoxLastName.Text;
                Program.wftDb.SaveChanges();
                ShowAdministrator();
            }
        }

        private void listViewAdministrator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdministrator.SelectedItems.Count == 1)
            {
                AdministratorsSet administratorSet = listViewAdministrator.SelectedItems[0].Tag as AdministratorsSet;
                textBoxLogin.Text = administratorSet.Login;
                textBoxPassword.Text = administratorSet.Password;
                textBoxFirstName.Text = administratorSet.FirstName;
                textBoxMiddleName.Text = administratorSet.MiddleName;
                textBoxLastName.Text = administratorSet.LastName;
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAdministrator.SelectedItems.Count == 1)
                {
                    AdministratorsSet administratorSet = listViewAdministrator.SelectedItems[0].Tag as AdministratorsSet;
                    Program.wftDb.AdministratorsSet.Remove(administratorSet);
                    Program.wftDb.SaveChanges();
                    ShowAdministrator();
                }
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
