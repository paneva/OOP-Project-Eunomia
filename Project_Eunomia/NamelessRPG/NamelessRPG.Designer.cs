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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.playfield = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // playfield
            // 
            this.playfield.BackgroundImage = global::NamelessRPG.Properties.Resources.sampleBckgrnd;
            this.playfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playfield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playfield.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playfield.Location = new System.Drawing.Point(12, 12);
            this.playfield.Margin = new System.Windows.Forms.Padding(1);
            this.playfield.Name = "playfield";
            this.playfield.Size = new System.Drawing.Size(860, 678);
            this.playfield.TabIndex = 0;
            // 
            // NamelessRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 702);
            this.Controls.Add(this.playfield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NamelessRPG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Blaster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel playfield;
    }
}

