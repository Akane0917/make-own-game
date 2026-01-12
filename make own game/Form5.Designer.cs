namespace make_own_game
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.ansButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the capital of Canada?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel.Location = new System.Drawing.Point(156, 363);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(175, 53);
            this.outputLabel.TabIndex = 1;
            // 
            // ansTextBox
            // 
            this.ansTextBox.Location = new System.Drawing.Point(178, 180);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(100, 22);
            this.ansTextBox.TabIndex = 2;
            // 
            // ansButton
            // 
            this.ansButton.Location = new System.Drawing.Point(178, 266);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(104, 41);
            this.ansButton.TabIndex = 3;
            this.ansButton.Text = "answer";
            this.ansButton.UseVisualStyleBackColor = true;
            this.ansButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(418, 21);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 453);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Button ansButton;
        private System.Windows.Forms.Label timeLabel;
    }
}