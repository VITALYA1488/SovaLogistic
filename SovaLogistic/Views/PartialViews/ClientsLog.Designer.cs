
namespace SovaLogistic.Views.PartialViews
{
    partial class ClientsLog
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
            this.ClientPhoneLB = new System.Windows.Forms.Label();
            this.ClientBirthdayLB = new System.Windows.Forms.Label();
            this.ClientFioLB = new System.Windows.Forms.Label();
            this.ClientIDLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPhoneLB
            // 
            this.ClientPhoneLB.AutoSize = true;
            this.ClientPhoneLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPhoneLB.Location = new System.Drawing.Point(452, 17);
            this.ClientPhoneLB.Name = "ClientPhoneLB";
            this.ClientPhoneLB.Size = new System.Drawing.Size(81, 28);
            this.ClientPhoneLB.TabIndex = 7;
            this.ClientPhoneLB.Text = "Телефон";
            // 
            // ClientBirthdayLB
            // 
            this.ClientBirthdayLB.AutoSize = true;
            this.ClientBirthdayLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientBirthdayLB.Location = new System.Drawing.Point(212, 97);
            this.ClientBirthdayLB.Name = "ClientBirthdayLB";
            this.ClientBirthdayLB.Size = new System.Drawing.Size(144, 28);
            this.ClientBirthdayLB.TabIndex = 6;
            this.ClientBirthdayLB.Text = "Дата рождения";
            // 
            // ClientFioLB
            // 
            this.ClientFioLB.AutoSize = true;
            this.ClientFioLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientFioLB.Location = new System.Drawing.Point(212, 58);
            this.ClientFioLB.Name = "ClientFioLB";
            this.ClientFioLB.Size = new System.Drawing.Size(56, 28);
            this.ClientFioLB.TabIndex = 5;
            this.ClientFioLB.Text = "ФИО";
            // 
            // ClientIDLB
            // 
            this.ClientIDLB.AutoSize = true;
            this.ClientIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientIDLB.Location = new System.Drawing.Point(212, 17);
            this.ClientIDLB.Name = "ClientIDLB";
            this.ClientIDLB.Size = new System.Drawing.Size(113, 28);
            this.ClientIDLB.TabIndex = 4;
            this.ClientIDLB.Text = "ID Клиента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SovaLogistic.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ClientsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientPhoneLB);
            this.Controls.Add(this.ClientBirthdayLB);
            this.Controls.Add(this.ClientFioLB);
            this.Controls.Add(this.ClientIDLB);
            this.Name = "ClientsLog";
            this.Size = new System.Drawing.Size(795, 150);
            this.Load += new System.EventHandler(this.ClientsLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClientBirthdayLB;
        private System.Windows.Forms.Label ClientFioLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ClientPhoneLB;
        public System.Windows.Forms.Label ClientIDLB;
    }
}
