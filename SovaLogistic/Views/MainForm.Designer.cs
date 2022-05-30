
namespace SovaLogistic.Views
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.orderLB = new System.Windows.Forms.Label();
            this.clientLB = new System.Windows.Forms.Label();
            this.transLB = new System.Windows.Forms.Label();
            this.userLB = new System.Windows.Forms.Label();
            this.pictureBoxClient = new System.Windows.Forms.PictureBox();
            this.pictureBoxTransport = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrder = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderBy = new System.Windows.Forms.CheckBox();
            this.sortingCB = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sortingCBtrans = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.addBT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Controls.Add(this.orderLB);
            this.panel1.Controls.Add(this.clientLB);
            this.panel1.Controls.Add(this.transLB);
            this.panel1.Controls.Add(this.userLB);
            this.panel1.Controls.Add(this.pictureBoxClient);
            this.panel1.Controls.Add(this.pictureBoxTransport);
            this.panel1.Controls.Add(this.pictureBoxOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 542);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.exitBT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 99);
            this.panel4.TabIndex = 45;
            // 
            // exitBT
            // 
            this.exitBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBT.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBT.Location = new System.Drawing.Point(22, 24);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(224, 52);
            this.exitBT.TabIndex = 21;
            this.exitBT.Text = "Выход";
            this.exitBT.UseVisualStyleBackColor = false;
            this.exitBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBT
            // 
            this.addBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addBT.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBT.Location = new System.Drawing.Point(22, 369);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(224, 52);
            this.addBT.TabIndex = 22;
            this.addBT.Text = "Добавить";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Visible = false;
            this.addBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 69);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Главное меню";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SovaLogistic.Properties.Resources._7;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::SovaLogistic.Properties.Resources._5;
            this.pictureBoxUser.Location = new System.Drawing.Point(18, 99);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(58, 52);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 44;
            this.pictureBoxUser.TabStop = false;
            // 
            // orderLB
            // 
            this.orderLB.AutoSize = true;
            this.orderLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLB.Location = new System.Drawing.Point(84, 225);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(96, 29);
            this.orderLB.TabIndex = 43;
            this.orderLB.Text = "Заказы";
            this.orderLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // clientLB
            // 
            this.clientLB.AutoSize = true;
            this.clientLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLB.Location = new System.Drawing.Point(84, 169);
            this.clientLB.Name = "clientLB";
            this.clientLB.Size = new System.Drawing.Size(117, 29);
            this.clientLB.TabIndex = 42;
            this.clientLB.Text = "Клиенты";
            this.clientLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // transLB
            // 
            this.transLB.AutoSize = true;
            this.transLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transLB.Location = new System.Drawing.Point(84, 285);
            this.transLB.Name = "transLB";
            this.transLB.Size = new System.Drawing.Size(138, 29);
            this.transLB.TabIndex = 41;
            this.transLB.Text = "Транспорт";
            this.transLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // userLB
            // 
            this.userLB.AutoSize = true;
            this.userLB.BackColor = System.Drawing.Color.White;
            this.userLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLB.Location = new System.Drawing.Point(82, 112);
            this.userLB.Name = "userLB";
            this.userLB.Size = new System.Drawing.Size(181, 29);
            this.userLB.TabIndex = 40;
            this.userLB.Text = "Пользователи";
            this.userLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxClient
            // 
            this.pictureBoxClient.Image = global::SovaLogistic.Properties.Resources._8;
            this.pictureBoxClient.Location = new System.Drawing.Point(18, 157);
            this.pictureBoxClient.Name = "pictureBoxClient";
            this.pictureBoxClient.Size = new System.Drawing.Size(60, 52);
            this.pictureBoxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClient.TabIndex = 39;
            this.pictureBoxClient.TabStop = false;
            // 
            // pictureBoxTransport
            // 
            this.pictureBoxTransport.Image = global::SovaLogistic.Properties.Resources._3;
            this.pictureBoxTransport.Location = new System.Drawing.Point(18, 273);
            this.pictureBoxTransport.Name = "pictureBoxTransport";
            this.pictureBoxTransport.Size = new System.Drawing.Size(60, 52);
            this.pictureBoxTransport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTransport.TabIndex = 38;
            this.pictureBoxTransport.TabStop = false;
            // 
            // pictureBoxOrder
            // 
            this.pictureBoxOrder.Image = global::SovaLogistic.Properties.Resources._6;
            this.pictureBoxOrder.Location = new System.Drawing.Point(18, 215);
            this.pictureBoxOrder.Name = "pictureBoxOrder";
            this.pictureBoxOrder.Size = new System.Drawing.Size(60, 52);
            this.pictureBoxOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrder.TabIndex = 37;
            this.pictureBoxOrder.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.sortingCBtrans);
            this.panel2.Controls.Add(this.orderBy);
            this.panel2.Controls.Add(this.sortingCB);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 69);
            this.panel2.TabIndex = 3;
            // 
            // orderBy
            // 
            this.orderBy.AutoSize = true;
            this.orderBy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBy.Location = new System.Drawing.Point(632, 14);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(137, 32);
            this.orderBy.TabIndex = 48;
            this.orderBy.Text = "По убыванию";
            this.orderBy.UseVisualStyleBackColor = true;
            this.orderBy.CheckedChanged += new System.EventHandler(this.orderBy_CheckedChanged);
            // 
            // sortingCB
            // 
            this.sortingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingCB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingCB.FormattingEnabled = true;
            this.sortingCB.Items.AddRange(new object[] {
            "ID пользователя",
            "ФИО",
            "Дата рождения"});
            this.sortingCB.Location = new System.Drawing.Point(391, 12);
            this.sortingCB.Name = "sortingCB";
            this.sortingCB.Size = new System.Drawing.Size(224, 36);
            this.sortingCB.TabIndex = 47;
            this.sortingCB.SelectedIndexChanged += new System.EventHandler(this.sortingCB_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(87, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(289, 36);
            this.searchTextBox.TabIndex = 46;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 473);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // sortingCBtrans
            // 
            this.sortingCBtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingCBtrans.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingCBtrans.FormattingEnabled = true;
            this.sortingCBtrans.Items.AddRange(new object[] {
            "ID пользователя",
            "ФИО",
            "Дата рождения"});
            this.sortingCBtrans.Location = new System.Drawing.Point(391, 12);
            this.sortingCBtrans.Name = "sortingCBtrans";
            this.sortingCBtrans.Size = new System.Drawing.Size(224, 36);
            this.sortingCBtrans.TabIndex = 49;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 542);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userLB;
        private System.Windows.Forms.PictureBox pictureBoxClient;
        private System.Windows.Forms.PictureBox pictureBoxTransport;
        private System.Windows.Forms.PictureBox pictureBoxOrder;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label orderLB;
        private System.Windows.Forms.Label clientLB;
        private System.Windows.Forms.Label transLB;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.ComboBox sortingCB;
        private System.Windows.Forms.CheckBox orderBy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortingCBtrans;
    }
}