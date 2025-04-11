namespace AnimalShelter
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
            this.LblChipNumber = new System.Windows.Forms.Label();
            this.TxbChipNumber = new System.Windows.Forms.TextBox();
            this.BtnChipNumberGenerator = new System.Windows.Forms.Button();
            this.LblLastWalk = new System.Windows.Forms.Label();
            this.TxbSpecialField = new System.Windows.Forms.TextBox();
            this.GrbManage = new System.Windows.Forms.GroupBox();
            this.TxbDateOfBirth = new System.Windows.Forms.TextBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.BtnCalculateAge = new System.Windows.Forms.Button();
            this.BtnDeleteAnimal = new System.Windows.Forms.Button();
            this.LbxAnimalsReserved = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnReserveCancel = new System.Windows.Forms.Button();
            this.GrbManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbAnimalType
            // 
            this.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAnimalType.FormattingEnabled = true;
            this.CmbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.CmbAnimalType.Location = new System.Drawing.Point(17, 53);
            this.CmbAnimalType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAnimalType.Name = "CmbAnimalType";
            this.CmbAnimalType.Size = new System.Drawing.Size(180, 28);
            this.CmbAnimalType.TabIndex = 0;
            this.CmbAnimalType.SelectedValueChanged += new System.EventHandler(this.CmbAnimalType_SelectedValueChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(770, 51);
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
            this.showInfoButton.Location = new System.Drawing.Point(770, 94);
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
            this.LbxAnimalsNotReserved.Size = new System.Drawing.Size(452, 264);
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
            // LblChipNumber
            // 
            this.LblChipNumber.AutoSize = true;
            this.LblChipNumber.Location = new System.Drawing.Point(309, 28);
            this.LblChipNumber.Name = "LblChipNumber";
            this.LblChipNumber.Size = new System.Drawing.Size(95, 20);
            this.LblChipNumber.TabIndex = 7;
            this.LblChipNumber.Text = "Chipnumber";
            // 
            // TxbChipNumber
            // 
            this.TxbChipNumber.Location = new System.Drawing.Point(313, 51);
            this.TxbChipNumber.Name = "TxbChipNumber";
            this.TxbChipNumber.Size = new System.Drawing.Size(146, 26);
            this.TxbChipNumber.TabIndex = 8;
            // 
            // BtnChipNumberGenerator
            // 
            this.BtnChipNumberGenerator.Location = new System.Drawing.Point(313, 85);
            this.BtnChipNumberGenerator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnChipNumberGenerator.Name = "BtnChipNumberGenerator";
            this.BtnChipNumberGenerator.Size = new System.Drawing.Size(146, 68);
            this.BtnChipNumberGenerator.TabIndex = 9;
            this.BtnChipNumberGenerator.Text = "Generate Chipnumber";
            this.BtnChipNumberGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChipNumberGenerator.UseVisualStyleBackColor = true;
            this.BtnChipNumberGenerator.Click += new System.EventHandler(this.BtnChipNumberGenerator_Click);
            // 
            // LblLastWalk
            // 
            this.LblLastWalk.AutoSize = true;
            this.LblLastWalk.Location = new System.Drawing.Point(461, 28);
            this.LblLastWalk.Name = "LblLastWalk";
            this.LblLastWalk.Size = new System.Drawing.Size(104, 20);
            this.LblLastWalk.TabIndex = 10;
            this.LblLastWalk.Text = "Bad Behavior";
            // 
            // TxbSpecialField
            // 
            this.TxbSpecialField.Location = new System.Drawing.Point(465, 51);
            this.TxbSpecialField.Name = "TxbSpecialField";
            this.TxbSpecialField.Size = new System.Drawing.Size(146, 26);
            this.TxbSpecialField.TabIndex = 11;
            // 
            // GrbManage
            // 
            this.GrbManage.Controls.Add(this.TxbDateOfBirth);
            this.GrbManage.Controls.Add(this.LblDateOfBirth);
            this.GrbManage.Controls.Add(this.BtnCalculateAge);
            this.GrbManage.Controls.Add(this.BtnDeleteAnimal);
            this.GrbManage.Controls.Add(this.showInfoButton);
            this.GrbManage.Controls.Add(this.TxbSpecialField);
            this.GrbManage.Controls.Add(this.CmbAnimalType);
            this.GrbManage.Controls.Add(this.LblLastWalk);
            this.GrbManage.Controls.Add(this.createAnimalButton);
            this.GrbManage.Controls.Add(this.BtnChipNumberGenerator);
            this.GrbManage.Controls.Add(this.LblTypeAnimal);
            this.GrbManage.Controls.Add(this.TxbChipNumber);
            this.GrbManage.Controls.Add(this.LblAnimalName);
            this.GrbManage.Controls.Add(this.LblChipNumber);
            this.GrbManage.Controls.Add(this.TxbAnimalName);
            this.GrbManage.Location = new System.Drawing.Point(12, 12);
            this.GrbManage.Name = "GrbManage";
            this.GrbManage.Size = new System.Drawing.Size(1256, 273);
            this.GrbManage.TabIndex = 12;
            this.GrbManage.TabStop = false;
            this.GrbManage.Text = "Manage";
            // 
            // TxbDateOfBirth
            // 
            this.TxbDateOfBirth.Location = new System.Drawing.Point(617, 51);
            this.TxbDateOfBirth.Name = "TxbDateOfBirth";
            this.TxbDateOfBirth.Size = new System.Drawing.Size(146, 26);
            this.TxbDateOfBirth.TabIndex = 15;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(613, 28);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.LblDateOfBirth.TabIndex = 14;
            this.LblDateOfBirth.Text = "Date of birth*";
            this.LblDateOfBirth.MouseLeave += new System.EventHandler(this.LblDateOfBirth_MouseLeave);
            this.LblDateOfBirth.MouseHover += new System.EventHandler(this.LblDateOfBirth_MouseHover);
            // 
            // BtnCalculateAge
            // 
            this.BtnCalculateAge.Location = new System.Drawing.Point(770, 139);
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
            this.BtnDeleteAnimal.Location = new System.Drawing.Point(770, 184);
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
            this.LbxAnimalsReserved.Location = new System.Drawing.Point(477, 323);
            this.LbxAnimalsReserved.Name = "LbxAnimalsReserved";
            this.LbxAnimalsReserved.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbxAnimalsReserved.Size = new System.Drawing.Size(452, 264);
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
            this.label2.Location = new System.Drawing.Point(473, 300);
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
            this.BtnReserveCancel.Location = new System.Drawing.Point(477, 593);
            this.BtnReserveCancel.Name = "BtnReserveCancel";
            this.BtnReserveCancel.Size = new System.Drawing.Size(106, 32);
            this.BtnReserveCancel.TabIndex = 16;
            this.BtnReserveCancel.Text = "Cancel";
            this.BtnReserveCancel.UseVisualStyleBackColor = true;
            this.BtnReserveCancel.Click += new System.EventHandler(this.BtnReserveCancel_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 749);
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
        private System.Windows.Forms.Label LblChipNumber;
        private System.Windows.Forms.TextBox TxbChipNumber;
        private System.Windows.Forms.Button BtnChipNumberGenerator;
        private System.Windows.Forms.Label LblLastWalk;
        private System.Windows.Forms.TextBox TxbSpecialField;
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
    }
}

