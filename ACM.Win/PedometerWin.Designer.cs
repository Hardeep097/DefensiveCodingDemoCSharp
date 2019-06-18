namespace ACM.Win
{
    partial class PedometerWin
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
            this.label2 = new System.Windows.Forms.Label();
            this.GoalTextbox = new System.Windows.Forms.TextBox();
            this.StepTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step goal for today:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of steps today:";
            // 
            // GoalTextbox
            // 
            this.GoalTextbox.Location = new System.Drawing.Point(216, 41);
            this.GoalTextbox.Name = "GoalTextbox";
            this.GoalTextbox.Size = new System.Drawing.Size(100, 20);
            this.GoalTextbox.TabIndex = 2;
            // 
            // StepTextbox
            // 
            this.StepTextbox.Location = new System.Drawing.Point(216, 71);
            this.StepTextbox.Name = "StepTextbox";
            this.StepTextbox.Size = new System.Drawing.Size(100, 20);
            this.StepTextbox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(343, 41);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(91, 52);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(182, 145);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 310);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.StepTextbox);
            this.Controls.Add(this.GoalTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PedometerWin";
            this.Text = "PedometerWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GoalTextbox;
        private System.Windows.Forms.TextBox StepTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}