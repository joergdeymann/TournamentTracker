namespace TrackerUI
{
    partial class CreatePriceForm
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
            createPriceLabel = new Label();
            placeNumberTextBox = new TextBox();
            firstNameLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            priceAmountTextBox = new TextBox();
            priceAmountLabel = new Label();
            pricePercentageTextBox = new TextBox();
            pricePercentageLabel = new Label();
            orLabel = new Label();
            createPriceButton = new Button();
            SuspendLayout();
            // 
            // createPriceLabel
            // 
            createPriceLabel.AutoSize = true;
            createPriceLabel.BackColor = Color.Transparent;
            createPriceLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPriceLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPriceLabel.Location = new Point(14, 9);
            createPriceLabel.Margin = new Padding(5, 0, 5, 0);
            createPriceLabel.Name = "createPriceLabel";
            createPriceLabel.Size = new Size(312, 74);
            createPriceLabel.TabIndex = 3;
            createPriceLabel.Text = "Create Price";
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.Font = new Font("Segoe UI", 15F);
            placeNumberTextBox.Location = new Point(281, 100);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(475, 47);
            placeNumberTextBox.TabIndex = 16;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(14, 93);
            firstNameLabel.Margin = new Padding(5, 0, 5, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(259, 54);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "Place Number";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Font = new Font("Segoe UI", 15F);
            placeNameTextBox.Location = new Point(281, 176);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(475, 47);
            placeNameTextBox.TabIndex = 18;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.BackColor = Color.Transparent;
            placeNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(14, 169);
            placeNameLabel.Margin = new Padding(5, 0, 5, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(223, 54);
            placeNameLabel.TabIndex = 17;
            placeNameLabel.Text = "Place Name";
            // 
            // priceAmountTextBox
            // 
            priceAmountTextBox.Font = new Font("Segoe UI", 15F);
            priceAmountTextBox.Location = new Point(281, 250);
            priceAmountTextBox.Name = "priceAmountTextBox";
            priceAmountTextBox.Size = new Size(475, 47);
            priceAmountTextBox.TabIndex = 20;
            priceAmountTextBox.Text = "0";
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.BackColor = Color.Transparent;
            priceAmountLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            priceAmountLabel.Location = new Point(14, 243);
            priceAmountLabel.Margin = new Padding(5, 0, 5, 0);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(249, 54);
            priceAmountLabel.TabIndex = 19;
            priceAmountLabel.Text = "Price Amount";
            // 
            // pricePercentageTextBox
            // 
            pricePercentageTextBox.Font = new Font("Segoe UI", 15F);
            pricePercentageTextBox.Location = new Point(281, 389);
            pricePercentageTextBox.Name = "pricePercentageTextBox";
            pricePercentageTextBox.Size = new Size(475, 47);
            pricePercentageTextBox.TabIndex = 22;
            pricePercentageTextBox.Text = "0";
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.BackColor = Color.Transparent;
            pricePercentageLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pricePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            pricePercentageLabel.Location = new Point(14, 382);
            pricePercentageLabel.Margin = new Padding(5, 0, 5, 0);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(157, 54);
            pricePercentageLabel.TabIndex = 21;
            pricePercentageLabel.Text = "Price % ";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.BackColor = Color.Transparent;
            orLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(281, 310);
            orLabel.Margin = new Padding(5, 0, 5, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(112, 54);
            orLabel.TabIndex = 23;
            orLabel.Text = "- or -";
            // 
            // createPriceButton
            // 
            createPriceButton.BackColor = Color.Silver;
            createPriceButton.FlatAppearance.BorderColor = Color.Silver;
            createPriceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPriceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPriceButton.FlatStyle = FlatStyle.Flat;
            createPriceButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPriceButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPriceButton.Location = new Point(281, 496);
            createPriceButton.Name = "createPriceButton";
            createPriceButton.Size = new Size(281, 78);
            createPriceButton.TabIndex = 24;
            createPriceButton.Text = "Create Price";
            createPriceButton.UseMnemonic = false;
            createPriceButton.UseVisualStyleBackColor = false;
            createPriceButton.Click += CreatePriceButtonEvent;
            // 
            // CreatePriceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 633);
            Controls.Add(createPriceButton);
            Controls.Add(orLabel);
            Controls.Add(pricePercentageTextBox);
            Controls.Add(pricePercentageLabel);
            Controls.Add(priceAmountTextBox);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(createPriceLabel);
            Name = "CreatePriceForm";
            Text = "CreatePriceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPriceLabel;
        private TextBox placeNumberTextBox;
        private Label firstNameLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private TextBox priceAmountTextBox;
        private Label priceAmountLabel;
        private TextBox pricePercentageTextBox;
        private Label pricePercentageLabel;
        private Label orLabel;
        private Button createPriceButton;
    }
}