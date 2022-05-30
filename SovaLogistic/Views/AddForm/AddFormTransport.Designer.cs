
namespace SovaLogistic.Views.AddForm
{
    partial class AddFormTransport
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
            System.Windows.Forms.Label transortIDLabel;
            System.Windows.Forms.Label usersIDLabel;
            System.Windows.Forms.Label сarryingLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.addBT = new System.Windows.Forms.Button();
            this.backBT = new System.Windows.Forms.Button();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.transortIDTextBox = new System.Windows.Forms.TextBox();
            this.usersIDTextBox = new System.Windows.Forms.TextBox();
            this.сarryingTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            transortIDLabel = new System.Windows.Forms.Label();
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
            nameLabel.Location = new System.Drawing.Point(66, 99);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(204, 28);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Название транспорта:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(86, 141);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(184, 28);
            numberLabel.TabIndex = 8;
            numberLabel.Text = "Номер транспорта:";
            // 
            // transortIDLabel
            // 
            transortIDLabel.AutoSize = true;
            transortIDLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            transortIDLabel.Location = new System.Drawing.Point(122, 57);
            transortIDLabel.Name = "transortIDLabel";
            transortIDLabel.Size = new System.Drawing.Size(148, 28);
            transortIDLabel.TabIndex = 10;
            transortIDLabel.Text = "ID транспорта:";
            // 
            // usersIDLabel
            // 
            usersIDLabel.AutoSize = true;
            usersIDLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usersIDLabel.Location = new System.Drawing.Point(130, 225);
            usersIDLabel.Name = "usersIDLabel";
            usersIDLabel.Size = new System.Drawing.Size(140, 28);
            usersIDLabel.TabIndex = 12;
            usersIDLabel.Text = "ID перевозчика:";
            // 
            // сarryingLabel
            // 
            сarryingLabel.AutoSize = true;
            сarryingLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сarryingLabel.Location = new System.Drawing.Point(94, 183);
            сarryingLabel.Name = "сarryingLabel";
            сarryingLabel.Size = new System.Drawing.Size(176, 28);
            сarryingLabel.TabIndex = 14;
            сarryingLabel.Text = "Груозподъемность:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.addBT);
            this.panel2.Controls.Add(this.backBT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 73);
            this.panel2.TabIndex = 5;
            // 
            // addBT
            // 
            this.addBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBT.Location = new System.Drawing.Point(23, 20);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(134, 34);
            this.addBT.TabIndex = 19;
            this.addBT.Text = "Добавить";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // backBT
            // 
            this.backBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backBT.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBT.Location = new System.Drawing.Point(367, 20);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(134, 34);
            this.backBT.TabIndex = 17;
            this.backBT.Text = "Назад";
            this.backBT.UseVisualStyleBackColor = false;
            this.backBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SovaLogistic.Models.Transport);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(276, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(131, 36);
            this.nameTextBox.TabIndex = 7;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Number", true));
            this.numberTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(276, 138);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(131, 36);
            this.numberTextBox.TabIndex = 9;
            // 
            // transortIDTextBox
            // 
            this.transortIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "TransortID", true));
            this.transortIDTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transortIDTextBox.Location = new System.Drawing.Point(276, 54);
            this.transortIDTextBox.Name = "transortIDTextBox";
            this.transortIDTextBox.Size = new System.Drawing.Size(131, 36);
            this.transortIDTextBox.TabIndex = 11;
            // 
            // usersIDTextBox
            // 
            this.usersIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "UsersID", true));
            this.usersIDTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersIDTextBox.Location = new System.Drawing.Point(276, 222);
            this.usersIDTextBox.Name = "usersIDTextBox";
            this.usersIDTextBox.Size = new System.Drawing.Size(131, 36);
            this.usersIDTextBox.TabIndex = 13;
            // 
            // сarryingTextBox
            // 
            this.сarryingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportBindingSource, "Сarrying", true));
            this.сarryingTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сarryingTextBox.Location = new System.Drawing.Point(276, 180);
            this.сarryingTextBox.Name = "сarryingTextBox";
            this.сarryingTextBox.Size = new System.Drawing.Size(131, 36);
            this.сarryingTextBox.TabIndex = 15;
            // 
            // AddFormTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(transortIDLabel);
            this.Controls.Add(this.transortIDTextBox);
            this.Controls.Add(usersIDLabel);
            this.Controls.Add(this.usersIDTextBox);
            this.Controls.Add(сarryingLabel);
            this.Controls.Add(this.сarryingTextBox);
            this.Controls.Add(this.panel2);
            this.Name = "AddFormTransport";
            this.Text = "Добавление транспорта";
            this.Load += new System.EventHandler(this.AddFormTransport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox transortIDTextBox;
        private System.Windows.Forms.TextBox usersIDTextBox;
        private System.Windows.Forms.TextBox сarryingTextBox;
    }
}