namespace make_own_game
{
    partial class Form3
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
            this.answerButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(199, 268);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(107, 45);
            this.answerButton.TabIndex = 0;
            this.answerButton.Text = "answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel.Location = new System.Drawing.Point(206, 385);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(116, 42);
            this.outputLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "What is the fourth most populous country in the world?";
            // 
            // ansTextBox
            // 
            this.ansTextBox.Location = new System.Drawing.Point(206, 168);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(100, 22);
            this.ansTextBox.TabIndex = 3;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(564, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 464);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.answerButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Label timeLabel;
    }
}