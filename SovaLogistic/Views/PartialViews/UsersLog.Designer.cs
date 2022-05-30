
namespace SovaLogistic.Views.PartialViews
{
    partial class UsersLog
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoleLB = new System.Windows.Forms.Label();
            this.FioLB = new System.Windows.Forms.Label();
            this.BirthdayLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.UsersIDLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleLB
            // 
            this.RoleLB.AutoSize = true;
            this.RoleLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLB.Location = new System.Drawing.Point(219, 98);
            this.RoleLB.Name = "RoleLB";
            this.RoleLB.Size = new System.Drawing.Size(51, 28);
            this.RoleLB.TabIndex = 0;
            this.RoleLB.Text = "Роль";
            // 
            // FioLB
            // 
            this.FioLB.AutoSize = true;
            this.FioLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioLB.Location = new System.Drawing.Point(219, 60);
            this.FioLB.Name = "FioLB";
            this.FioLB.Size = new System.Drawing.Size(56, 28);
            this.FioLB.TabIndex = 1;
            this.FioLB.Text = "ФИО";
            // 
            // BirthdayLB
            // 
            this.BirthdayLB.AutoSize = true;
            this.BirthdayLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLB.Location = new System.Drawing.Point(454, 98);
            this.BirthdayLB.Name = "BirthdayLB";
            this.BirthdayLB.Size = new System.Drawing.Size(144, 28);
            this.BirthdayLB.TabIndex = 2;
            this.BirthdayLB.Text = "Дата рождения";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLB.Location = new System.Drawing.Point(454, 18);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(81, 28);
            this.phoneLB.TabIndex = 3;
            this.phoneLB.Text = "Телефон";
            this.phoneLB.Click += new System.EventHandler(this.PhoneLB_Click);
            // 
            // UsersIDLB
            // 
            this.UsersIDLB.AutoSize = true;
            this.UsersIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersIDLB.Location = new System.Drawing.Point(212, 18);
            this.UsersIDLB.Name = "UsersIDLB";
            this.UsersIDLB.Size = new System.Drawing.Size(152, 28);
            this.UsersIDLB.TabIndex = 4;
            this.UsersIDLB.Text = "ID пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SovaLogistic.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UsersLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersIDLB);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.BirthdayLB);
            this.Controls.Add(this.FioLB);
            this.Controls.Add(this.RoleLB);
            this.Name = "UsersLog";
            this.Size = new System.Drawing.Size(795, 150);
            this.Load += new System.EventHandler(this.UsersLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleLB;
        private System.Windows.Forms.Label FioLB;
        private System.Windows.Forms.Label BirthdayLB;
        public System.Windows.Forms.Label phoneLB;
        public System.Windows.Forms.Label UsersIDLB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
