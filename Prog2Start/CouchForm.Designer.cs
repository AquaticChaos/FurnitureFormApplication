namespace Prog3Start
{
    partial class CouchForm
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
            components = new System.ComponentModel.Container();
            createButton = new Button();
            cancelButton = new Button();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            catLabel = new Label();
            categoryTextBox = new TextBox();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            seatsLabel = new Label();
            seatsTextBox = new TextBox();
            legsLabel = new Label();
            legsTextBox = new TextBox();
            materialComboBox = new ComboBox();
            materialLabel = new Label();
            cushionGroupBox = new GroupBox();
            cusMatLabel = new Label();
            cusMatComboBox = new ComboBox();
            heightLabel = new Label();
            heightTextBox = new TextBox();
            widthLabel = new Label();
            widthTextBox = new TextBox();
            lengthLabel = new Label();
            lengthTextBox = new TextBox();
            inputErrorProvider = new ErrorProvider(components);
            cushionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(235, 247);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(131, 247);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(77, 44);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 2;
            priceTextBox.Validating += double_Validating;
            priceTextBox.Validated += double_Validated;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(33, 48);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(36, 15);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price:";
            // 
            // catLabel
            // 
            catLabel.AutoSize = true;
            catLabel.Location = new Point(11, 77);
            catLabel.Name = "catLabel";
            catLabel.Size = new Size(58, 15);
            catLabel.TabIndex = 5;
            catLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(77, 73);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(100, 23);
            categoryTextBox.TabIndex = 4;
            categoryTextBox.Validating += string_Validating;
            categoryTextBox.Validated += string_Validated;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(21, 106);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(48, 15);
            weightLabel.TabIndex = 7;
            weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(77, 102);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(100, 23);
            weightTextBox.TabIndex = 6;
            weightTextBox.Validating += double_Validating;
            weightTextBox.Validated += double_Validated;
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new Point(32, 135);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(37, 15);
            seatsLabel.TabIndex = 9;
            seatsLabel.Text = "Seats:";
            // 
            // seatsTextBox
            // 
            seatsTextBox.Location = new Point(77, 131);
            seatsTextBox.Name = "seatsTextBox";
            seatsTextBox.Size = new Size(100, 23);
            seatsTextBox.TabIndex = 8;
            seatsTextBox.Validating += int_Validating;
            seatsTextBox.Validated += int_Validated;
            // 
            // legsLabel
            // 
            legsLabel.AutoSize = true;
            legsLabel.Location = new Point(35, 164);
            legsLabel.Name = "legsLabel";
            legsLabel.Size = new Size(34, 15);
            legsLabel.TabIndex = 11;
            legsLabel.Text = "Legs:";
            // 
            // legsTextBox
            // 
            legsTextBox.Location = new Point(77, 160);
            legsTextBox.Name = "legsTextBox";
            legsTextBox.Size = new Size(100, 23);
            legsTextBox.TabIndex = 10;
            // 
            // materialComboBox
            // 
            materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox.FormattingEnabled = true;
            materialComboBox.Items.AddRange(new object[] { "Textile", "Leather" });
            materialComboBox.Location = new Point(77, 189);
            materialComboBox.Name = "materialComboBox";
            materialComboBox.Size = new Size(100, 23);
            materialComboBox.TabIndex = 12;
            materialComboBox.Validating += comboBox_Validating;
            materialComboBox.Validated += comboBox_Validated;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(16, 193);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(53, 15);
            materialLabel.TabIndex = 13;
            materialLabel.Text = "Material:";
            // 
            // cushionGroupBox
            // 
            cushionGroupBox.Controls.Add(cusMatLabel);
            cushionGroupBox.Controls.Add(cusMatComboBox);
            cushionGroupBox.Controls.Add(heightLabel);
            cushionGroupBox.Controls.Add(heightTextBox);
            cushionGroupBox.Controls.Add(widthLabel);
            cushionGroupBox.Controls.Add(widthTextBox);
            cushionGroupBox.Controls.Add(lengthLabel);
            cushionGroupBox.Controls.Add(lengthTextBox);
            cushionGroupBox.Location = new Point(204, 31);
            cushionGroupBox.Name = "cushionGroupBox";
            cushionGroupBox.Size = new Size(176, 135);
            cushionGroupBox.TabIndex = 14;
            cushionGroupBox.TabStop = false;
            cushionGroupBox.Text = "Cushion Information";
            // 
            // cusMatLabel
            // 
            cusMatLabel.AutoSize = true;
            cusMatLabel.Location = new Point(12, 108);
            cusMatLabel.Name = "cusMatLabel";
            cusMatLabel.Size = new Size(53, 15);
            cusMatLabel.TabIndex = 21;
            cusMatLabel.Text = "Material:";
            // 
            // cusMatComboBox
            // 
            cusMatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cusMatComboBox.FormattingEnabled = true;
            cusMatComboBox.Items.AddRange(new object[] { "Foam", "Stuffing" });
            cusMatComboBox.Location = new Point(70, 104);
            cusMatComboBox.Name = "cusMatComboBox";
            cusMatComboBox.Size = new Size(100, 23);
            cusMatComboBox.TabIndex = 20;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(19, 79);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(46, 15);
            heightLabel.TabIndex = 19;
            heightLabel.Text = "Height:";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(70, 75);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(100, 23);
            heightTextBox.TabIndex = 18;
            heightTextBox.Validating += double_Validating;
            heightTextBox.Validated += double_Validated;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(23, 50);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(42, 15);
            widthLabel.TabIndex = 17;
            widthLabel.Text = "Width:";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(70, 46);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(100, 23);
            widthTextBox.TabIndex = 16;
            widthTextBox.Validating += double_Validating;
            widthTextBox.Validated += double_Validated;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(18, 21);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(47, 15);
            lengthLabel.TabIndex = 15;
            lengthLabel.Text = "Length:";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(70, 17);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(100, 23);
            lengthTextBox.TabIndex = 14;
            lengthTextBox.Validating += double_Validating;
            lengthTextBox.Validated += double_Validated;
            // 
            // inputErrorProvider
            // 
            inputErrorProvider.ContainerControl = this;
            // 
            // CouchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 300);
            Controls.Add(cushionGroupBox);
            Controls.Add(materialLabel);
            Controls.Add(materialComboBox);
            Controls.Add(legsLabel);
            Controls.Add(legsTextBox);
            Controls.Add(seatsLabel);
            Controls.Add(seatsTextBox);
            Controls.Add(weightLabel);
            Controls.Add(weightTextBox);
            Controls.Add(catLabel);
            Controls.Add(categoryTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Name = "CouchForm";
            Text = "Create A Couch";
            cushionGroupBox.ResumeLayout(false);
            cushionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createButton;
        private Button cancelButton;
        private TextBox priceTextBox;
        private Label priceLabel;
        private Label catLabel;
        private TextBox categoryTextBox;
        private Label weightLabel;
        private TextBox weightTextBox;
        private Label seatsLabel;
        private TextBox seatsTextBox;
        private Label legsLabel;
        private TextBox legsTextBox;
        private ComboBox materialComboBox;
        private Label materialLabel;
        private GroupBox cushionGroupBox;
        private Label cusMatLabel;
        private ComboBox cusMatComboBox;
        private Label heightLabel;
        private TextBox heightTextBox;
        private Label widthLabel;
        private TextBox widthTextBox;
        private Label lengthLabel;
        private TextBox lengthTextBox;
        private ErrorProvider inputErrorProvider;
    }
}