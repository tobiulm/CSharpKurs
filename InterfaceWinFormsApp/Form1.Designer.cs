namespace InterfaceWinFormsApp
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            greetButton = new Button();
            label3 = new Label();
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
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Nachname:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(145, 6);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(228, 29);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(145, 64);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(228, 29);
            lastNameTextBox.TabIndex = 3;
            // 
            // greetButton
            // 
            greetButton.Location = new Point(12, 124);
            greetButton.Name = "greetButton";
            greetButton.Size = new Size(361, 58);
            greetButton.TabIndex = 4;
            greetButton.Text = "Grüße";
            greetButton.UseVisualStyleBackColor = true;
            greetButton.Click += greetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 347);
            Controls.Add(label3);
            Controls.Add(greetButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Demonstration von Interfaces";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button greetButton;
        private Label label3;
    }
}
