namespace EventsWinFormsApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            departmentsComboBox = new ComboBox();
            button1 = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Vorname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Nachname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "Abteilung:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(172, 6);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(165, 29);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(172, 42);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(165, 29);
            lastNameTextBox.TabIndex = 4;
            // 
            // departmentsComboBox
            // 
            departmentsComboBox.FormattingEnabled = true;
            departmentsComboBox.Location = new Point(172, 81);
            departmentsComboBox.Name = "departmentsComboBox";
            departmentsComboBox.Size = new Size(165, 29);
            departmentsComboBox.TabIndex = 5;
            departmentsComboBox.SelectedIndexChanged += departmentsComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 131);
            button1.Name = "button1";
            button1.Size = new Size(325, 43);
            button1.TabIndex = 6;
            button1.Text = "Mitarbeiter anlegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(12, 187);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 21);
            outputLabel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 250);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(departmentsComboBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Ereignisse in .net basierend auf Delegates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private ComboBox departmentsComboBox;
        private Button button1;
        private Label outputLabel;
    }
}
