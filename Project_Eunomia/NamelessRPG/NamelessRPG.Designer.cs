namespace NamelessRPG
{
    partial class NamelessRPG
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IblHitPoints = new System.Windows.Forms.Label();
            this.IblGold = new System.Windows.Forms.Label();
            this.IblExperience = new System.Windows.Forms.Label();
            this.IblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // IblHitPoints
            // 
            this.IblHitPoints.AutoSize = true;
            this.IblHitPoints.Location = new System.Drawing.Point(67, 9);
            this.IblHitPoints.Name = "IblHitPoints";
            this.IblHitPoints.Size = new System.Drawing.Size(0, 13);
            this.IblHitPoints.TabIndex = 4;
            // 
            // IblGold
            // 
            this.IblGold.AutoSize = true;
            this.IblGold.Location = new System.Drawing.Point(48, 22);
            this.IblGold.Name = "IblGold";
            this.IblGold.Size = new System.Drawing.Size(0, 13);
            this.IblGold.TabIndex = 5;
            // 
            // IblExperience
            // 
            this.IblExperience.AutoSize = true;
            this.IblExperience.Location = new System.Drawing.Point(75, 35);
            this.IblExperience.Name = "IblExperience";
            this.IblExperience.Size = new System.Drawing.Size(0, 13);
            this.IblExperience.TabIndex = 6;
            // 
            // IblLevel
            // 
            this.IblLevel.AutoSize = true;
            this.IblLevel.Location = new System.Drawing.Point(50, 48);
            this.IblLevel.Name = "IblLevel";
            this.IblLevel.Size = new System.Drawing.Size(0, 13);
            this.IblLevel.TabIndex = 7;
            // 
            // NamelessRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 285);
            this.Controls.Add(this.IblLevel);
            this.Controls.Add(this.IblExperience);
            this.Controls.Add(this.IblGold);
            this.Controls.Add(this.IblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NamelessRPG";
            this.Text = "Space Blaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IblHitPoints;
        private System.Windows.Forms.Label IblGold;
        private System.Windows.Forms.Label IblExperience;
        private System.Windows.Forms.Label IblLevel;
    }
}

