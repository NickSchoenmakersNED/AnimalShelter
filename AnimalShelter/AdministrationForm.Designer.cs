﻿namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.CmbAnimalType = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.LbxAnimalsNotReserved = new System.Windows.Forms.ListBox();
            this.LblTypeAnimal = new System.Windows.Forms.Label();
            this.LblAnimalName = new System.Windows.Forms.Label();
            this.TxbAnimalName = new System.Windows.Forms.TextBox();
            this.LblSpecialField1 = new System.Windows.Forms.Label();
            this.TxbSpecialField1 = new System.Windows.Forms.TextBox();
            this.GrbManage = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbDateOfBirth = new System.Windows.Forms.TextBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.BtnCalculateAge = new System.Windows.Forms.Button();
            this.BtnDeleteAnimal = new System.Windows.Forms.Button();
            this.LbxAnimalsReserved = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnReserveCancel = new System.Windows.Forms.Button();
            this.LblRoom = new System.Windows.Forms.Label();
            this.LbxLocations = new System.Windows.Forms.ListBox();
            this.TxbLocation = new System.Windows.Forms.TextBox();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.BtnChangeLocation = new System.Windows.Forms.Button();
            this.BtnDeleteLocation = new System.Windows.Forms.Button();
            this.BtnLocationAnimals = new System.Windows.Forms.Button();
            this.BtnShowAllAnimals = new System.Windows.Forms.Button();
            this.CmdSpecialField1 = new System.Windows.Forms.ComboBox();
            this.LblSpecialField2 = new System.Windows.Forms.Label();
            this.TxbSpecialField2 = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.GrbManage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbAnimalType
            // 
            this.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAnimalType.FormattingEnabled = true;
            this.CmbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Horse",
            "Parrot",
            "Lizard"});
            this.CmbAnimalType.Location = new System.Drawing.Point(17, 53);
            this.CmbAnimalType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAnimalType.Name = "CmbAnimalType";
            this.CmbAnimalType.Size = new System.Drawing.Size(180, 28);
            this.CmbAnimalType.TabIndex = 0;
            this.CmbAnimalType.SelectedValueChanged += new System.EventHandler(this.CmbAnimalType_SelectedValueChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(465, 53);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(191, 35);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(465, 96);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(191, 35);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // LbxAnimalsNotReserved
            // 
            this.LbxAnimalsNotReserved.BackColor = System.Drawing.SystemColors.Window;
            this.LbxAnimalsNotReserved.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbxAnimalsNotReserved.FormattingEnabled = true;
            this.LbxAnimalsNotReserved.ItemHeight = 20;
            this.LbxAnimalsNotReserved.Location = new System.Drawing.Point(12, 323);
            this.LbxAnimalsNotReserved.Name = "LbxAnimalsNotReserved";
            this.LbxAnimalsNotReserved.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbxAnimalsNotReserved.Size = new System.Drawing.Size(495, 264);
            this.LbxAnimalsNotReserved.TabIndex = 3;
            this.LbxAnimalsNotReserved.SelectedValueChanged += new System.EventHandler(this.LbxAnimalsNotReserved_SelectedValueChanged);
            // 
            // LblTypeAnimal
            // 
            this.LblTypeAnimal.AutoSize = true;
            this.LblTypeAnimal.Location = new System.Drawing.Point(13, 28);
            this.LblTypeAnimal.Name = "LblTypeAnimal";
            this.LblTypeAnimal.Size = new System.Drawing.Size(43, 20);
            this.LblTypeAnimal.TabIndex = 4;
            this.LblTypeAnimal.Text = "Type";
            // 
            // LblAnimalName
            // 
            this.LblAnimalName.AutoSize = true;
            this.LblAnimalName.Location = new System.Drawing.Point(200, 30);
            this.LblAnimalName.Name = "LblAnimalName";
            this.LblAnimalName.Size = new System.Drawing.Size(51, 20);
            this.LblAnimalName.TabIndex = 5;
            this.LblAnimalName.Text = "Name";
            // 
            // TxbAnimalName
            // 
            this.TxbAnimalName.Location = new System.Drawing.Point(204, 53);
            this.TxbAnimalName.Name = "TxbAnimalName";
            this.TxbAnimalName.Size = new System.Drawing.Size(100, 26);
            this.TxbAnimalName.TabIndex = 6;
            // 
            // LblSpecialField1
            // 
            this.LblSpecialField1.AutoSize = true;
            this.LblSpecialField1.Location = new System.Drawing.Point(6, 22);
            this.LblSpecialField1.Name = "LblSpecialField1";
            this.LblSpecialField1.Size = new System.Drawing.Size(125, 20);
            this.LblSpecialField1.TabIndex = 10;
            this.LblSpecialField1.Text = "LblSpecialField1";
            // 
            // TxbSpecialField1
            // 
            this.TxbSpecialField1.Location = new System.Drawing.Point(6, 47);
            this.TxbSpecialField1.Name = "TxbSpecialField1";
            this.TxbSpecialField1.Size = new System.Drawing.Size(146, 26);
            this.TxbSpecialField1.TabIndex = 11;
            // 
            // GrbManage
            // 
            this.GrbManage.Controls.Add(this.BtnClear);
            this.GrbManage.Controls.Add(this.groupBox1);
            this.GrbManage.Controls.Add(this.TxbDateOfBirth);
            this.GrbManage.Controls.Add(this.LblDateOfBirth);
            this.GrbManage.Controls.Add(this.BtnCalculateAge);
            this.GrbManage.Controls.Add(this.BtnDeleteAnimal);
            this.GrbManage.Controls.Add(this.showInfoButton);
            this.GrbManage.Controls.Add(this.CmbAnimalType);
            this.GrbManage.Controls.Add(this.createAnimalButton);
            this.GrbManage.Controls.Add(this.LblTypeAnimal);
            this.GrbManage.Controls.Add(this.LblAnimalName);
            this.GrbManage.Controls.Add(this.TxbAnimalName);
            this.GrbManage.Location = new System.Drawing.Point(12, 12);
            this.GrbManage.Name = "GrbManage";
            this.GrbManage.Size = new System.Drawing.Size(1431, 273);
            this.GrbManage.TabIndex = 12;
            this.GrbManage.TabStop = false;
            this.GrbManage.Text = "Manage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxbSpecialField2);
            this.groupBox1.Controls.Add(this.LblSpecialField2);
            this.groupBox1.Controls.Add(this.CmdSpecialField1);
            this.groupBox1.Controls.Add(this.LblSpecialField1);
            this.groupBox1.Controls.Add(this.TxbSpecialField1);
            this.groupBox1.Location = new System.Drawing.Point(663, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 206);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special fields";
            // 
            // TxbDateOfBirth
            // 
            this.TxbDateOfBirth.Location = new System.Drawing.Point(312, 53);
            this.TxbDateOfBirth.Name = "TxbDateOfBirth";
            this.TxbDateOfBirth.Size = new System.Drawing.Size(146, 26);
            this.TxbDateOfBirth.TabIndex = 15;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(308, 30);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.LblDateOfBirth.TabIndex = 14;
            this.LblDateOfBirth.Text = "Date of birth*";
            this.LblDateOfBirth.MouseLeave += new System.EventHandler(this.LblDateOfBirth_MouseLeave);
            this.LblDateOfBirth.MouseHover += new System.EventHandler(this.LblDateOfBirth_MouseHover);
            // 
            // BtnCalculateAge
            // 
            this.BtnCalculateAge.Location = new System.Drawing.Point(465, 141);
            this.BtnCalculateAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalculateAge.Name = "BtnCalculateAge";
            this.BtnCalculateAge.Size = new System.Drawing.Size(191, 35);
            this.BtnCalculateAge.TabIndex = 13;
            this.BtnCalculateAge.Text = "Calculate Age (Days)";
            this.BtnCalculateAge.UseVisualStyleBackColor = true;
            this.BtnCalculateAge.Click += new System.EventHandler(this.BtnCalculateAge_Click);
            // 
            // BtnDeleteAnimal
            // 
            this.BtnDeleteAnimal.Location = new System.Drawing.Point(465, 186);
            this.BtnDeleteAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteAnimal.Name = "BtnDeleteAnimal";
            this.BtnDeleteAnimal.Size = new System.Drawing.Size(191, 35);
            this.BtnDeleteAnimal.TabIndex = 12;
            this.BtnDeleteAnimal.Text = "Delete";
            this.BtnDeleteAnimal.UseVisualStyleBackColor = true;
            this.BtnDeleteAnimal.Click += new System.EventHandler(this.BtnDeleteAnimal_Click);
            // 
            // LbxAnimalsReserved
            // 
            this.LbxAnimalsReserved.FormattingEnabled = true;
            this.LbxAnimalsReserved.ItemHeight = 20;
            this.LbxAnimalsReserved.Location = new System.Drawing.Point(513, 323);
            this.LbxAnimalsReserved.Name = "LbxAnimalsReserved";
            this.LbxAnimalsReserved.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbxAnimalsReserved.Size = new System.Drawing.Size(424, 264);
            this.LbxAnimalsReserved.TabIndex = 13;
            this.LbxAnimalsReserved.SelectedValueChanged += new System.EventHandler(this.LbxAnimalsReserved_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Not Reserved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reserved";
            // 
            // BtnReserve
            // 
            this.BtnReserve.Location = new System.Drawing.Point(12, 593);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(106, 32);
            this.BtnReserve.TabIndex = 15;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // BtnReserveCancel
            // 
            this.BtnReserveCancel.Location = new System.Drawing.Point(513, 593);
            this.BtnReserveCancel.Name = "BtnReserveCancel";
            this.BtnReserveCancel.Size = new System.Drawing.Size(106, 32);
            this.BtnReserveCancel.TabIndex = 16;
            this.BtnReserveCancel.Text = "Cancel";
            this.BtnReserveCancel.UseVisualStyleBackColor = true;
            this.BtnReserveCancel.Click += new System.EventHandler(this.BtnReserveCancel_Click);
            // 
            // LblRoom
            // 
            this.LblRoom.AutoSize = true;
            this.LblRoom.Location = new System.Drawing.Point(939, 300);
            this.LblRoom.Name = "LblRoom";
            this.LblRoom.Size = new System.Drawing.Size(78, 20);
            this.LblRoom.TabIndex = 18;
            this.LblRoom.Text = "Locations";
            // 
            // LbxLocations
            // 
            this.LbxLocations.FormattingEnabled = true;
            this.LbxLocations.ItemHeight = 20;
            this.LbxLocations.Location = new System.Drawing.Point(943, 323);
            this.LbxLocations.Name = "LbxLocations";
            this.LbxLocations.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbxLocations.Size = new System.Drawing.Size(500, 264);
            this.LbxLocations.TabIndex = 17;
            // 
            // TxbLocation
            // 
            this.TxbLocation.Location = new System.Drawing.Point(943, 603);
            this.TxbLocation.Name = "TxbLocation";
            this.TxbLocation.Size = new System.Drawing.Size(146, 26);
            this.TxbLocation.TabIndex = 18;
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.Location = new System.Drawing.Point(943, 639);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(146, 34);
            this.BtnAddLocation.TabIndex = 19;
            this.BtnAddLocation.Text = "Add location";
            this.BtnAddLocation.UseVisualStyleBackColor = true;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // BtnChangeLocation
            // 
            this.BtnChangeLocation.Location = new System.Drawing.Point(1095, 639);
            this.BtnChangeLocation.Name = "BtnChangeLocation";
            this.BtnChangeLocation.Size = new System.Drawing.Size(146, 34);
            this.BtnChangeLocation.TabIndex = 20;
            this.BtnChangeLocation.Text = "Add to location";
            this.BtnChangeLocation.UseVisualStyleBackColor = true;
            this.BtnChangeLocation.Click += new System.EventHandler(this.BtnChangeLocation_Click);
            // 
            // BtnDeleteLocation
            // 
            this.BtnDeleteLocation.Location = new System.Drawing.Point(1095, 599);
            this.BtnDeleteLocation.Name = "BtnDeleteLocation";
            this.BtnDeleteLocation.Size = new System.Drawing.Size(146, 34);
            this.BtnDeleteLocation.TabIndex = 21;
            this.BtnDeleteLocation.Text = "Delete location";
            this.BtnDeleteLocation.UseVisualStyleBackColor = true;
            this.BtnDeleteLocation.Click += new System.EventHandler(this.BtnDeleteLocation_Click);
            // 
            // BtnLocationAnimals
            // 
            this.BtnLocationAnimals.Location = new System.Drawing.Point(1247, 599);
            this.BtnLocationAnimals.Name = "BtnLocationAnimals";
            this.BtnLocationAnimals.Size = new System.Drawing.Size(196, 34);
            this.BtnLocationAnimals.TabIndex = 22;
            this.BtnLocationAnimals.Text = "Show animals in location";
            this.BtnLocationAnimals.UseVisualStyleBackColor = true;
            this.BtnLocationAnimals.Click += new System.EventHandler(this.BtnLocationAnimals_Click);
            // 
            // BtnShowAllAnimals
            // 
            this.BtnShowAllAnimals.Location = new System.Drawing.Point(1247, 639);
            this.BtnShowAllAnimals.Name = "BtnShowAllAnimals";
            this.BtnShowAllAnimals.Size = new System.Drawing.Size(196, 34);
            this.BtnShowAllAnimals.TabIndex = 23;
            this.BtnShowAllAnimals.Text = "Show all animals";
            this.BtnShowAllAnimals.UseVisualStyleBackColor = true;
            this.BtnShowAllAnimals.Click += new System.EventHandler(this.BtnShowAllAnimals_Click);
            // 
            // CmdSpecialField1
            // 
            this.CmdSpecialField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmdSpecialField1.FormattingEnabled = true;
            this.CmdSpecialField1.Location = new System.Drawing.Point(6, 47);
            this.CmdSpecialField1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdSpecialField1.Name = "CmdSpecialField1";
            this.CmdSpecialField1.Size = new System.Drawing.Size(145, 28);
            this.CmdSpecialField1.TabIndex = 17;
            // 
            // LblSpecialField2
            // 
            this.LblSpecialField2.AutoSize = true;
            this.LblSpecialField2.Location = new System.Drawing.Point(154, 22);
            this.LblSpecialField2.Name = "LblSpecialField2";
            this.LblSpecialField2.Size = new System.Drawing.Size(125, 20);
            this.LblSpecialField2.TabIndex = 18;
            this.LblSpecialField2.Text = "LblSpecialField2";
            // 
            // TxbSpecialField2
            // 
            this.TxbSpecialField2.Location = new System.Drawing.Point(158, 45);
            this.TxbSpecialField2.Name = "TxbSpecialField2";
            this.TxbSpecialField2.Size = new System.Drawing.Size(146, 26);
            this.TxbSpecialField2.TabIndex = 19;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(465, 230);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(191, 35);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 749);
            this.Controls.Add(this.BtnShowAllAnimals);
            this.Controls.Add(this.BtnLocationAnimals);
            this.Controls.Add(this.BtnDeleteLocation);
            this.Controls.Add(this.BtnChangeLocation);
            this.Controls.Add(this.BtnAddLocation);
            this.Controls.Add(this.TxbLocation);
            this.Controls.Add(this.LblRoom);
            this.Controls.Add(this.LbxLocations);
            this.Controls.Add(this.BtnReserveCancel);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbxAnimalsReserved);
            this.Controls.Add(this.GrbManage);
            this.Controls.Add(this.LbxAnimalsNotReserved);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.GrbManage.ResumeLayout(false);
            this.GrbManage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbAnimalType;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.ListBox LbxAnimalsNotReserved;
        private System.Windows.Forms.Label LblTypeAnimal;
        private System.Windows.Forms.Label LblAnimalName;
        private System.Windows.Forms.TextBox TxbAnimalName;
        private System.Windows.Forms.Label LblSpecialField1;
        private System.Windows.Forms.TextBox TxbSpecialField1;
        private System.Windows.Forms.GroupBox GrbManage;
        private System.Windows.Forms.Button BtnDeleteAnimal;
        private System.Windows.Forms.ListBox LbxAnimalsReserved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnReserve;
        private System.Windows.Forms.Button BtnReserveCancel;
        private System.Windows.Forms.Button BtnCalculateAge;
        private System.Windows.Forms.TextBox TxbDateOfBirth;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblRoom;
        private System.Windows.Forms.ListBox LbxLocations;
        private System.Windows.Forms.TextBox TxbLocation;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.Button BtnChangeLocation;
        private System.Windows.Forms.Button BtnDeleteLocation;
        private System.Windows.Forms.Button BtnLocationAnimals;
        private System.Windows.Forms.Button BtnShowAllAnimals;
        private System.Windows.Forms.ComboBox CmdSpecialField1;
        private System.Windows.Forms.Label LblSpecialField2;
        private System.Windows.Forms.TextBox TxbSpecialField2;
        private System.Windows.Forms.Button BtnClear;
    }
}

