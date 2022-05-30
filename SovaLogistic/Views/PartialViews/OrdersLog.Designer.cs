
namespace SovaLogistic.Views.PartialViews
{
    partial class OrdersLog
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
            this.OrderIDLB = new System.Windows.Forms.Label();
            this.OrderNameLB = new System.Windows.Forms.Label();
            this.OrderDateRegistrLB = new System.Windows.Forms.Label();
            this.OrderPlaceDepartureLB = new System.Windows.Forms.Label();
            this.OrderDateArrivalLB = new System.Windows.Forms.Label();
            this.OrderPlaceArrivalLB = new System.Windows.Forms.Label();
            this.OrderUsersIDLB = new System.Windows.Forms.Label();
            this.OrderTransportIDLB = new System.Windows.Forms.Label();
            this.OrderClientIDLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderIDLB
            // 
            this.OrderIDLB.AutoSize = true;
            this.OrderIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderIDLB.Location = new System.Drawing.Point(13, 91);
            this.OrderIDLB.Name = "OrderIDLB";
            this.OrderIDLB.Size = new System.Drawing.Size(88, 28);
            this.OrderIDLB.TabIndex = 1;
            this.OrderIDLB.Text = "ID заказа";
            // 
            // OrderNameLB
            // 
            this.OrderNameLB.AutoSize = true;
            this.OrderNameLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNameLB.Location = new System.Drawing.Point(324, 10);
            this.OrderNameLB.Name = "OrderNameLB";
            this.OrderNameLB.Size = new System.Drawing.Size(119, 28);
            this.OrderNameLB.TabIndex = 2;
            this.OrderNameLB.Text = "Наименовние";
            // 
            // OrderDateRegistrLB
            // 
            this.OrderDateRegistrLB.AutoSize = true;
            this.OrderDateRegistrLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateRegistrLB.Location = new System.Drawing.Point(324, 91);
            this.OrderDateRegistrLB.Name = "OrderDateRegistrLB";
            this.OrderDateRegistrLB.Size = new System.Drawing.Size(233, 28);
            this.OrderDateRegistrLB.TabIndex = 3;
            this.OrderDateRegistrLB.Text = "Дата регистрации заказа";
            // 
            // OrderPlaceDepartureLB
            // 
            this.OrderPlaceDepartureLB.AutoSize = true;
            this.OrderPlaceDepartureLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPlaceDepartureLB.Location = new System.Drawing.Point(324, 50);
            this.OrderPlaceDepartureLB.Name = "OrderPlaceDepartureLB";
            this.OrderPlaceDepartureLB.Size = new System.Drawing.Size(155, 28);
            this.OrderPlaceDepartureLB.TabIndex = 4;
            this.OrderPlaceDepartureLB.Text = "Место отбытия";
            // 
            // OrderDateArrivalLB
            // 
            this.OrderDateArrivalLB.AutoSize = true;
            this.OrderDateArrivalLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateArrivalLB.Location = new System.Drawing.Point(324, 184);
            this.OrderDateArrivalLB.Name = "OrderDateArrivalLB";
            this.OrderDateArrivalLB.Size = new System.Drawing.Size(153, 28);
            this.OrderDateArrivalLB.TabIndex = 5;
            this.OrderDateArrivalLB.Text = "Дата прибытия";
            // 
            // OrderPlaceArrivalLB
            // 
            this.OrderPlaceArrivalLB.AutoSize = true;
            this.OrderPlaceArrivalLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPlaceArrivalLB.Location = new System.Drawing.Point(324, 137);
            this.OrderPlaceArrivalLB.Name = "OrderPlaceArrivalLB";
            this.OrderPlaceArrivalLB.Size = new System.Drawing.Size(161, 28);
            this.OrderPlaceArrivalLB.TabIndex = 6;
            this.OrderPlaceArrivalLB.Text = "Место прибытия";
            // 
            // OrderUsersIDLB
            // 
            this.OrderUsersIDLB.AutoSize = true;
            this.OrderUsersIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderUsersIDLB.Location = new System.Drawing.Point(137, 50);
            this.OrderUsersIDLB.Name = "OrderUsersIDLB";
            this.OrderUsersIDLB.Size = new System.Drawing.Size(135, 28);
            this.OrderUsersIDLB.TabIndex = 7;
            this.OrderUsersIDLB.Text = "ID перевозчика";
            // 
            // OrderTransportIDLB
            // 
            this.OrderTransportIDLB.AutoSize = true;
            this.OrderTransportIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderTransportIDLB.Location = new System.Drawing.Point(134, 137);
            this.OrderTransportIDLB.Name = "OrderTransportIDLB";
            this.OrderTransportIDLB.Size = new System.Drawing.Size(138, 28);
            this.OrderTransportIDLB.TabIndex = 8;
            this.OrderTransportIDLB.Text = "ID Транспорта";
            // 
            // OrderClientIDLB
            // 
            this.OrderClientIDLB.AutoSize = true;
            this.OrderClientIDLB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderClientIDLB.Location = new System.Drawing.Point(134, 91);
            this.OrderClientIDLB.Name = "OrderClientIDLB";
            this.OrderClientIDLB.Size = new System.Drawing.Size(107, 28);
            this.OrderClientIDLB.TabIndex = 9;
            this.OrderClientIDLB.Text = "ID клиента";
            // 
            // OrdersLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.OrderClientIDLB);
            this.Controls.Add(this.OrderTransportIDLB);
            this.Controls.Add(this.OrderUsersIDLB);
            this.Controls.Add(this.OrderPlaceArrivalLB);
            this.Controls.Add(this.OrderDateArrivalLB);
            this.Controls.Add(this.OrderPlaceDepartureLB);
            this.Controls.Add(this.OrderDateRegistrLB);
            this.Controls.Add(this.OrderNameLB);
            this.Controls.Add(this.OrderIDLB);
            this.Name = "OrdersLog";
            this.Size = new System.Drawing.Size(795, 237);
            this.Load += new System.EventHandler(this.OrdersLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OrderDateRegistrLB;
        private System.Windows.Forms.Label OrderPlaceDepartureLB;
        private System.Windows.Forms.Label OrderDateArrivalLB;
        private System.Windows.Forms.Label OrderUsersIDLB;
        private System.Windows.Forms.Label OrderTransportIDLB;
        private System.Windows.Forms.Label OrderClientIDLB;
        public System.Windows.Forms.Label OrderNameLB;
        public System.Windows.Forms.Label OrderPlaceArrivalLB;
        public System.Windows.Forms.Label OrderIDLB;
    }
}
