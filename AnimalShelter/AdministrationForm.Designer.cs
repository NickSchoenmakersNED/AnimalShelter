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
            this.SuspendLayout();
            // 
            // CmbAnimalType
            // 
            this.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAnimalType.FormattingEnabled = true;
            this.CmbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.CmbAnimalType.Location = new System.Drawing.Point(13, 34);
            this.CmbAnimalType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAnimalType.Name = "CmbAnimalType";
            this.CmbAnimalType.Size = new System.Drawing.Size(180, 28);
            this.CmbAnimalType.TabIndex = 0;
            this.CmbAnimalType.SelectedValueChanged += new System.EventHandler(this.CmbAnimalType_SelectedValueChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(614, 23);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(96, 35);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(718, 23);
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
            this.LblTypeAnimal.Location = new System.Drawing.Point(9, 9);
            this.LblTypeAnimal.Name = "LblTypeAnimal";
            this.LblTypeAnimal.Size = new System.Drawing.Size(43, 20);
            this.LblTypeAnimal.TabIndex = 4;
            this.LblTypeAnimal.Text = "Type";
            // 
            // LblAnimalName
            // 
            this.LblAnimalName.AutoSize = true;
            this.LblAnimalName.Location = new System.Drawing.Point(196, 11);
            this.LblAnimalName.Name = "LblAnimalName";
            this.LblAnimalName.Size = new System.Drawing.Size(51, 20);
            this.LblAnimalName.TabIndex = 5;
            this.LblAnimalName.Text = "Name";
            // 
            // TxbAnimalName
            // 
            this.TxbAnimalName.Location = new System.Drawing.Point(200, 34);
            this.TxbAnimalName.Name = "TxbAnimalName";
            this.TxbAnimalName.Size = new System.Drawing.Size(100, 26);
            this.TxbAnimalName.TabIndex = 6;
            // 
            // LblChipNumber
            // 
            this.LblChipNumber.AutoSize = true;
            this.LblChipNumber.Location = new System.Drawing.Point(305, 9);
            this.LblChipNumber.Name = "LblChipNumber";
            this.LblChipNumber.Size = new System.Drawing.Size(95, 20);
            this.LblChipNumber.TabIndex = 7;
            this.LblChipNumber.Text = "Chipnumber";
            // 
            // TxbChipNumber
            // 
            this.TxbChipNumber.Location = new System.Drawing.Point(309, 32);
            this.TxbChipNumber.Name = "TxbChipNumber";
            this.TxbChipNumber.Size = new System.Drawing.Size(146, 26);
            this.TxbChipNumber.TabIndex = 8;
            // 
            // BtnChipNumberGenerator
            // 
            this.BtnChipNumberGenerator.Location = new System.Drawing.Point(309, 66);
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
            this.LblLastWalk.Location = new System.Drawing.Point(457, 9);
            this.LblLastWalk.Name = "LblLastWalk";
            this.LblLastWalk.Size = new System.Drawing.Size(104, 20);
            this.LblLastWalk.TabIndex = 10;
            this.LblLastWalk.Text = "Bad Behavior";
            // 
            // TxbSpecialField
            // 
            this.TxbSpecialField.Location = new System.Drawing.Point(461, 32);
            this.TxbSpecialField.Name = "TxbSpecialField";
            this.TxbSpecialField.Size = new System.Drawing.Size(146, 26);
            this.TxbSpecialField.TabIndex = 11;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 503);
            this.Controls.Add(this.TxbSpecialField);
            this.Controls.Add(this.LblLastWalk);
            this.Controls.Add(this.BtnChipNumberGenerator);
            this.Controls.Add(this.TxbChipNumber);
            this.Controls.Add(this.LblChipNumber);
            this.Controls.Add(this.TxbAnimalName);
            this.Controls.Add(this.LblAnimalName);
            this.Controls.Add(this.LblTypeAnimal);
            this.Controls.Add(this.LbxAnimals);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.CmbAnimalType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

