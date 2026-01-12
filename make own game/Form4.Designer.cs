namespace make_own_game
{
    partial class Form4
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
            this.gButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.jButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gButton
            // 
            this.gButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gButton.Location = new System.Drawing.Point(329, 172);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(106, 49);
            this.gButton.TabIndex = 0;
            this.gButton.Text = "Germany";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.gButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which country is bigger, Japan or Germany?";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Maroon;
            this.outputLabel.Location = new System.Drawing.Point(183, 305);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(163, 46);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // jButton
            // 
            this.jButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton.Location = new System.Drawing.Point(112, 172);
            this.jButton.Name = "jButton";
            this.jButton.Size = new System.Drawing.Size(106, 49);
            this.jButton.TabIndex = 4;
            this.jButton.Text = "Japan";
            this.jButton.UseVisualStyleBackColor = true;
            this.jButton.Click += new System.EventHandler(this.jButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(479, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.jButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button jButton;
        private System.Windows.Forms.Label timeLabel;
    }
}