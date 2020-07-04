namespace Cabinet_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenTeachers = new System.Windows.Forms.Button();
            this.buttonOpenSchoolSubjects = new System.Windows.Forms.Button();
            this.buttonOpenAdministrators = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenTeachers
            // 
            this.buttonOpenTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenTeachers.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonOpenTeachers.Location = new System.Drawing.Point(12, 159);
            this.buttonOpenTeachers.Name = "buttonOpenTeachers";
            this.buttonOpenTeachers.Size = new System.Drawing.Size(253, 48);
            this.buttonOpenTeachers.TabIndex = 0;
            this.buttonOpenTeachers.Text = "Учителя";
            this.buttonOpenTeachers.UseVisualStyleBackColor = false;
            this.buttonOpenTeachers.Click += new System.EventHandler(this.buttonOpenTeachers_Click);
            // 
            // buttonOpenSchoolSubjects
            // 
            this.buttonOpenSchoolSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenSchoolSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSchoolSubjects.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.buttonOpenSchoolSubjects.Location = new System.Drawing.Point(12, 213);
            this.buttonOpenSchoolSubjects.Name = "buttonOpenSchoolSubjects";
            this.buttonOpenSchoolSubjects.Size = new System.Drawing.Size(253, 48);
            this.buttonOpenSchoolSubjects.TabIndex = 1;
            this.buttonOpenSchoolSubjects.Text = "Предметы";
            this.buttonOpenSchoolSubjects.UseVisualStyleBackColor = false;
            this.buttonOpenSchoolSubjects.Click += new System.EventHandler(this.buttonOpenSchoolSubjects_Click);
            // 
            // buttonOpenAdministrators
            // 
            this.buttonOpenAdministrators.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonOpenAdministrators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAdministrators.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAdministrators.Location = new System.Drawing.Point(12, 267);
            this.buttonOpenAdministrators.Name = "buttonOpenAdministrators";
            this.buttonOpenAdministrators.Size = new System.Drawing.Size(253, 48);
            this.buttonOpenAdministrators.TabIndex = 2;
            this.buttonOpenAdministrators.Text = "Администраторы";
            this.buttonOpenAdministrators.UseVisualStyleBackColor = false;
            this.buttonOpenAdministrators.Click += new System.EventHandler(this.buttonOpenAdministrators_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.labelHello.Location = new System.Drawing.Point(12, 122);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(67, 23);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "Привет";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            this.Logo.Image = global::Cabinet_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(270, 107);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(277, 323);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenAdministrators);
            this.Controls.Add(this.buttonOpenSchoolSubjects);
            this.Controls.Add(this.buttonOpenTeachers);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenTeachers;
        private System.Windows.Forms.Button buttonOpenSchoolSubjects;
        private System.Windows.Forms.Button buttonOpenAdministrators;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox Logo;
    }
}

