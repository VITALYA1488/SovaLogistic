
namespace SovaLogistic.Views
{
    partial class EditFormTransport
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label usersIDLabel;
            System.Windows.Forms.Label сarryingLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeBT = new System.Windows.Forms.Button();
            this.backBT = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.usersIDTextBox = new System.Windows.Forms.TextBox();
            this.сarryingTextBox = new System.Windows.Forms.TextBox();
            this.deleteBT = new System.Windows.Forms.Button();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            usersIDLabel = new System.Windows.Forms.Label();
            сarryingLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(57, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(204, 28);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Название транспорта:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(77, 113);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(184, 28);
            numberLabel.TabIndex = 7;
            numberLabel.Text = "Номер транспорта:";
            // 
            // usersIDLabel
            // 
            usersIDLabel.AutoSize = true;
            usersIDLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usersIDLabel.Location = new System.Drawing.Point(104, 207);
            usersIDLabel.Name = "usersIDLabel";
            usersIDLabel.Size = new System.Drawing.Size(157, 28);
            usersIDLabel.TabIndex = 11;
            usersIDLabel.Text = "ID пользователя:";
            // 
            // сarryingLabel
            // 
            сarryingLabel.AutoSize = true;
            сarryingLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сarryingLabel.Location = new System.Drawing.Point(87, 160);
            сarryingLabel.Name = "сarryingLabel";
            сarryingLabel.Size = new System.Drawing.Size(174, 28);
            сarryingLabel.TabIndex = 13;
            сarryingLabel.Text = "Грузоподьемность:";
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
            // changeBT
            // 
            this.changeBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeBT.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.changeBT.Location = new System.Drawing.Point(12, 18);
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
            this.backBT.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.backBT.Location = new System.Drawing.Point(377, 18);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(134, 34);
            this.backBT.TabIndex = 17;
            this.backBT.Text = "Назад";
            this.backBT.UseVisualStyleBackColor = false;
            this.backBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(267, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 36);
            this.nameTextBox.TabIndex = 6;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Number", true));
            this.numberTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(267, 110);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(143, 36);
            this.numberTextBox.TabIndex = 8;
            // 
            // usersIDTextBox
            // 
            this.usersIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "UsersID", true));
            this.usersIDTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersIDTextBox.Location = new System.Drawing.Point(267, 204);
            this.usersIDTextBox.Name = "usersIDTextBox";
            this.usersIDTextBox.Size = new System.Drawing.Size(143, 36);
            this.usersIDTextBox.TabIndex = 12;
            // 
            // сarryingTextBox
            // 
            this.сarryingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Сarrying", true));
            this.сarryingTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сarryingTextBox.Location = new System.Drawing.Point(267, 157);
            this.сarryingTextBox.Name = "сarryingTextBox";
            this.сarryingTextBox.Size = new System.Drawing.Size(143, 36);
            this.сarryingTextBox.TabIndex = 14;
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBT.Location = new System.Drawing.Point(198, 18);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(134, 34);
            this.deleteBT.TabIndex = 21;
            this.deleteBT.Text = "Удалить";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SovaLogistic.Models.Transport);
            // 
            // EditFormTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(usersIDLabel);
            this.Controls.Add(this.usersIDTextBox);
            this.Controls.Add(сarryingLabel);
            this.Controls.Add(this.сarryingTextBox);
            this.Controls.Add(this.panel2);
            this.Name = "EditFormTransport";
            this.Text = "Редактирование транспорта";
            this.Load += new System.EventHandler(this.AddFormTransport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.Button changeBT;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox usersIDTextBox;
        private System.Windows.Forms.TextBox сarryingTextBox;
        private System.Windows.Forms.Button deleteBT;
    }
}