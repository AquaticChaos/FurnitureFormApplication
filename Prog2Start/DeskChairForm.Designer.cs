namespace Prog3Start
{
    partial class DeskChairForm
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
            spinComboBox = new ComboBox();
            spinLabel = new Label();
            inputErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(118, 243);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(14, 243);
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
            // spinComboBox
            // 
            spinComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            spinComboBox.FormattingEnabled = true;
            spinComboBox.Items.AddRange(new object[] { "Yes", "No" });
            spinComboBox.Location = new Point(77, 189);
            spinComboBox.Name = "spinComboBox";
            spinComboBox.Size = new Size(100, 23);
            spinComboBox.TabIndex = 12;
            spinComboBox.Validating += comboBox_Validating;
            spinComboBox.Validated += comboBox_Validated;
            // 
            // spinLabel
            // 
            spinLabel.AutoSize = true;
            spinLabel.Location = new Point(35, 193);
            spinLabel.Name = "spinLabel";
            spinLabel.Size = new Size(33, 15);
            spinLabel.TabIndex = 13;
            spinLabel.Text = "Spin:";
            // 
            // inputErrorProvider
            // 
            inputErrorProvider.ContainerControl = this;
            // 
            // DeskChairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 300);
            Controls.Add(spinLabel);
            Controls.Add(spinComboBox);
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
            Name = "DeskChairForm";
            Text = "Create A Desk Chair";
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
        private ComboBox spinComboBox;
        private Label spinLabel;
        private ErrorProvider inputErrorProvider;
    }
}