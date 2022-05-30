
namespace SovaLogistic.Views.PartialViews
{
    partial class TransportsLog
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
            this.CarryingLB = new System.Windows.Forms.Label();
            this.TransNumberLB = new System.Windows.Forms.Label();
            this.TransNameLB = new System.Windows.Forms.Label();
            this.TransportIDLB = new System.Windows.Forms.Label();
            this.UsersIDLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarryingLB
            // 
            this.CarryingLB.AutoSize = true;
            this.CarryingLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarryingLB.Location = new System.Drawing.Point(531, 98);
            this.CarryingLB.Name = "CarryingLB";
            this.CarryingLB.Size = new System.Drawing.Size(171, 28);
            this.CarryingLB.TabIndex = 7;
            this.CarryingLB.Text = "Грузоподъемность";
            // 
            // TransNumberLB
            // 
            this.TransNumberLB.AutoSize = true;
            this.TransNumberLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransNumberLB.Location = new System.Drawing.Point(212, 98);
            this.TransNumberLB.Name = "TransNumberLB";
            this.TransNumberLB.Size = new System.Drawing.Size(179, 28);
            this.TransNumberLB.TabIndex = 6;
            this.TransNumberLB.Text = "Номер транспорта";
            // 
            // TransNameLB
            // 
            this.TransNameLB.AutoSize = true;
            this.TransNameLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransNameLB.Location = new System.Drawing.Point(212, 57);
            this.TransNameLB.Name = "TransNameLB";
            this.TransNameLB.Size = new System.Drawing.Size(199, 28);
            this.TransNameLB.TabIndex = 5;
            this.TransNameLB.Text = "Название транспорта";
            // 
            // TransportIDLB
            // 
            this.TransportIDLB.AutoSize = true;
            this.TransportIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportIDLB.Location = new System.Drawing.Point(212, 18);
            this.TransportIDLB.Name = "TransportIDLB";
            this.TransportIDLB.Size = new System.Drawing.Size(138, 28);
            this.TransportIDLB.TabIndex = 4;
            this.TransportIDLB.Text = "ID Транспорта";
            // 
            // UsersIDLB
            // 
            this.UsersIDLB.AutoSize = true;
            this.UsersIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersIDLB.Location = new System.Drawing.Point(531, 18);
            this.UsersIDLB.Name = "UsersIDLB";
            this.UsersIDLB.Size = new System.Drawing.Size(135, 28);
            this.UsersIDLB.TabIndex = 8;
            this.UsersIDLB.Text = "ID перевозчика";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SovaLogistic.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TransportsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersIDLB);
            this.Controls.Add(this.CarryingLB);
            this.Controls.Add(this.TransNumberLB);
            this.Controls.Add(this.TransNameLB);
            this.Controls.Add(this.TransportIDLB);
            this.Name = "TransportsLog";
            this.Size = new System.Drawing.Size(795, 150);
            this.Load += new System.EventHandler(this.TransportsLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TransNumberLB;
        private System.Windows.Forms.Label TransNameLB;
        private System.Windows.Forms.Label UsersIDLB;
        public System.Windows.Forms.Label CarryingLB;
        public System.Windows.Forms.Label TransportIDLB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
