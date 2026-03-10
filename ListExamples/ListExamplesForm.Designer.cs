namespace ListExamples
{
    partial class ListExamplesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            InfoGroupBox = new GroupBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            LastNamelabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            ListGroupBox = new GroupBox();
            ListBox = new ListBox();
            ComboBox = new ComboBox();
            InfoGroupBox.SuspendLayout();
            ListGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(634, 369);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 69);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(529, 369);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(99, 69);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(425, 369);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(98, 69);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(CompanyLabel);
            InfoGroupBox.Controls.Add(CompanyTextBox);
            InfoGroupBox.Controls.Add(LastNamelabel);
            InfoGroupBox.Controls.Add(LastNameTextBox);
            InfoGroupBox.Controls.Add(FirstNameLabel);
            InfoGroupBox.Controls.Add(FirstNameTextBox);
            InfoGroupBox.Location = new Point(12, 12);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(291, 426);
            InfoGroupBox.TabIndex = 0;
            InfoGroupBox.TabStop = false;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(8, 130);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(89, 25);
            CompanyLabel.TabIndex = 5;
            CompanyLabel.Text = "Company";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(103, 124);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(150, 31);
            CompanyTextBox.TabIndex = 4;
            CompanyTextBox.TextChanged += CompanyTextBox_TextChanged;
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(8, 82);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(43, 25);
            LastNamelabel.TabIndex = 3;
            LastNamelabel.Text = "Last";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(57, 79);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(196, 31);
            LastNameTextBox.TabIndex = 2;
            LastNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 35);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(45, 25);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(57, 32);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(196, 31);
            FirstNameTextBox.TabIndex = 0;
            // 
            // ListGroupBox
            // 
            ListGroupBox.Controls.Add(ListBox);
            ListGroupBox.Controls.Add(ComboBox);
            ListGroupBox.Location = new Point(309, 12);
            ListGroupBox.Name = "ListGroupBox";
            ListGroupBox.Size = new Size(466, 351);
            ListGroupBox.TabIndex = 4;
            ListGroupBox.TabStop = false;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(6, 54);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(454, 279);
            ListBox.TabIndex = 1;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(6, 15);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(182, 33);
            ComboBox.TabIndex = 0;
            // 
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListGroupBox);
            Controls.Add(InfoGroupBox);
            Controls.Add(SubmitButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesForm";
            Text = "Form1";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            ListGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private GroupBox InfoGroupBox;
        private Label LastNamelabel;
        private TextBox LastNameTextBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private Label CompanyLabel;
        private TextBox CompanyTextBox;
        private GroupBox ListGroupBox;
        private ListBox ListBox;
        private ComboBox ComboBox;
    }
}
