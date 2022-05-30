
namespace SovaLogistic.Views
{
    partial class EditFormUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label roleLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBT = new System.Windows.Forms.Button();
            this.changeBT = new System.Windows.Forms.Button();
            this.backBT = new System.Windows.Forms.Button();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthdayLabel.Location = new System.Drawing.Point(49, 161);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(141, 28);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "День рождения:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(129, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 28);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "ФИО:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(104, 203);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(86, 28);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Телефон:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roleLabel.Location = new System.Drawing.Point(140, 116);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(56, 28);
            roleLabel.TabIndex = 11;
            roleLabel.Text = "Роль:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.deleteBT);
            this.panel2.Controls.Add(this.changeBT);
            this.panel2.Controls.Add(this.backBT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 73);
            this.panel2.TabIndex = 4;
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBT.Location = new System.Drawing.Point(196, 20);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(134, 34);
            this.deleteBT.TabIndex = 20;
            this.deleteBT.Text = "Удалить";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // changeBT
            // 
            this.changeBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBT.Location = new System.Drawing.Point(12, 20);
            this.changeBT.Name = "changeBT";
            this.changeBT.Size = new System.Drawing.Size(134, 34);
            this.changeBT.TabIndex = 19;
            this.changeBT.Text = "Изменить";
            this.changeBT.UseVisualStyleBackColor = false;
            this.changeBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBT
            // 
            this.backBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBT.Location = new System.Drawing.Point(377, 20);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(134, 34);
            this.backBT.TabIndex = 17;
            this.backBT.Text = "Назад";
            this.backBT.UseVisualStyleBackColor = false;
            this.backBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(196, 155);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 36);
            this.birthdayDateTimePicker.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(196, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 36);
            this.nameTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(196, 200);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 36);
            this.phoneTextBox.TabIndex = 10;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.roleTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleTextBox.Location = new System.Drawing.Point(196, 113);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(200, 36);
            this.roleTextBox.TabIndex = 12;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(SovaLogistic.Models.Users);
            // 
            // EditFormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.panel2);
            this.Name = "EditFormUsers";
            this.Text = "Редактирование пользователей";
            this.Load += new System.EventHandler(this.AddFormUsers_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.Button changeBT;
        private System.Windows.Forms.BindingSource usersBindingSource;
        public System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Button deleteBT;
    }
}