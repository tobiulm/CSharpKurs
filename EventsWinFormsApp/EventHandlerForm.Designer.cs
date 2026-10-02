namespace EventsWinFormsApp
{
    partial class EventHandlerForm
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
            outputLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(21, 49);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 21);
            outputLabel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(23, 141);
            button1.Name = "button1";
            button1.Size = new Size(309, 52);
            button1.TabIndex = 1;
            button1.Text = "Zweiten EvenHandler anfügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(564, 141);
            button2.Name = "button2";
            button2.Size = new Size(345, 52);
            button2.TabIndex = 2;
            button2.Text = "Zweiten EventHandler wegnehmen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EventHandlerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 226);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(outputLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "EventHandlerForm";
            Text = "Benachrichtigungen";
            Load += EventHandlerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label outputLabel;
        private Button button1;
        private Button button2;
    }
}