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
            this.LbxAnimals = new System.Windows.Forms.ListBox();
            this.LblTypeAnimal = new System.Windows.Forms.Label();
            this.LblAnimalName = new System.Windows.Forms.Label();
            this.TxbAnimalName = new System.Windows.Forms.TextBox();
            this.LblChipNumber = new System.Windows.Forms.Label();
            this.TxbChipNumber = new System.Windows.Forms.TextBox();
            this.BtnChipNumberGenerator = new System.Windows.Forms.Button();
            this.LblLastWalk = new System.Windows.Forms.Label();
            this.TxbSpecialField = new System.Windows.Forms.TextBox();
            this.GrbManage = new System.Windows.Forms.GroupBox();
            this.BtnDeleteAnimal = new System.Windows.Forms.Button();
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
            this.createAnimalButton.Location = new System.Drawing.Point(618, 42);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(112, 35);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(618, 85);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(112, 35);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // LbxAnimals
            // 
            this.LbxAnimals.FormattingEnabled = true;
            this.LbxAnimals.ItemHeight = 20;
            this.LbxAnimals.Location = new System.Drawing.Point(837, 23);
            this.LbxAnimals.Name = "LbxAnimals";
            this.LbxAnimals.Size = new System.Drawing.Size(452, 464);
            this.LbxAnimals.TabIndex = 3;
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
            this.GrbManage.Size = new System.Drawing.Size(819, 175);
            this.GrbManage.TabIndex = 12;
            this.GrbManage.TabStop = false;
            this.GrbManage.Text = "Manage";
            // 
            // BtnDeleteAnimal
            // 
            this.BtnDeleteAnimal.Location = new System.Drawing.Point(618, 130);
            this.BtnDeleteAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteAnimal.Name = "BtnDeleteAnimal";
            this.BtnDeleteAnimal.Size = new System.Drawing.Size(112, 35);
            this.BtnDeleteAnimal.TabIndex = 12;
            this.BtnDeleteAnimal.Text = "Delete";
            this.BtnDeleteAnimal.UseVisualStyleBackColor = true;
            this.BtnDeleteAnimal.Click += new System.EventHandler(this.BtnDeleteAnimal_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 503);
            this.Controls.Add(this.GrbManage);
            this.Controls.Add(this.LbxAnimals);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.GrbManage.ResumeLayout(false);
            this.GrbManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbAnimalType;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.ListBox LbxAnimals;
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
    }
}

