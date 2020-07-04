namespace Cabinet_Project
{
    partial class FormSchoolSubject
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewSchoolSubject = new System.Windows.Forms.ListView();
            this.labelNameSubject = new System.Windows.Forms.Label();
            this.labelIdTeachers = new System.Windows.Forms.Label();
            this.comboBoxIdTeachers = new System.Windows.Forms.ComboBox();
            this.textBoxNameSubject = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonAdd.Location = new System.Drawing.Point(270, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonEdit.Location = new System.Drawing.Point(462, 317);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(124, 36);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonDel.Location = new System.Drawing.Point(638, 316);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(124, 36);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewSchoolSubject
            // 
            this.listViewSchoolSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSchoolSubject.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.listViewSchoolSubject.FullRowSelect = true;
            this.listViewSchoolSubject.GridLines = true;
            this.listViewSchoolSubject.HideSelection = false;
            this.listViewSchoolSubject.Location = new System.Drawing.Point(242, 1);
            this.listViewSchoolSubject.MultiSelect = false;
            this.listViewSchoolSubject.Name = "listViewSchoolSubject";
            this.listViewSchoolSubject.Size = new System.Drawing.Size(560, 309);
            this.listViewSchoolSubject.TabIndex = 3;
            this.listViewSchoolSubject.UseCompatibleStateImageBehavior = false;
            this.listViewSchoolSubject.View = System.Windows.Forms.View.Details;
            this.listViewSchoolSubject.SelectedIndexChanged += new System.EventHandler(this.listViewSchoolSubject_SelectedIndexChanged);
            // 
            // labelNameSubject
            // 
            this.labelNameSubject.AutoSize = true;
            this.labelNameSubject.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelNameSubject.Location = new System.Drawing.Point(12, 132);
            this.labelNameSubject.Name = "labelNameSubject";
            this.labelNameSubject.Size = new System.Drawing.Size(168, 23);
            this.labelNameSubject.TabIndex = 4;
            this.labelNameSubject.Text = "Название предмета";
            // 
            // labelIdTeachers
            // 
            this.labelIdTeachers.AutoSize = true;
            this.labelIdTeachers.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelIdTeachers.Location = new System.Drawing.Point(12, 200);
            this.labelIdTeachers.Name = "labelIdTeachers";
            this.labelIdTeachers.Size = new System.Drawing.Size(74, 23);
            this.labelIdTeachers.TabIndex = 5;
            this.labelIdTeachers.Text = "Учитель";
            // 
            // comboBoxIdTeachers
            // 
            this.comboBoxIdTeachers.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.comboBoxIdTeachers.FormattingEnabled = true;
            this.comboBoxIdTeachers.Location = new System.Drawing.Point(16, 226);
            this.comboBoxIdTeachers.Name = "comboBoxIdTeachers";
            this.comboBoxIdTeachers.Size = new System.Drawing.Size(185, 30);
            this.comboBoxIdTeachers.TabIndex = 6;
            // 
            // textBoxNameSubject
            // 
            this.textBoxNameSubject.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.textBoxNameSubject.Location = new System.Drawing.Point(16, 158);
            this.textBoxNameSubject.Name = "textBoxNameSubject";
            this.textBoxNameSubject.Size = new System.Drawing.Size(185, 29);
            this.textBoxNameSubject.TabIndex = 7;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название предмета";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id учителя";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Учитель";
            this.columnHeader4.Width = 145;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cabinet_Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormSchoolSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNameSubject);
            this.Controls.Add(this.comboBoxIdTeachers);
            this.Controls.Add(this.labelIdTeachers);
            this.Controls.Add(this.labelNameSubject);
            this.Controls.Add(this.listViewSchoolSubject);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSchoolSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewSchoolSubject;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelNameSubject;
        private System.Windows.Forms.Label labelIdTeachers;
        private System.Windows.Forms.ComboBox comboBoxIdTeachers;
        private System.Windows.Forms.TextBox textBoxNameSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}