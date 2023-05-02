using System.ComponentModel;

namespace MyCalc.Properties
{
    partial class Tools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.s1 = new System.Windows.Forms.GroupBox();
            this.Red = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.s1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // s1
            // 
            this.s1.Controls.Add(this.Red);
            this.s1.Controls.Add(this.Green);
            this.s1.Controls.Add(this.Blue);
            this.s1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s1.Location = new System.Drawing.Point(0, 0);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(304, 459);
            this.s1.TabIndex = 0;
            this.s1.TabStop = false;
            this.s1.Text = "Цвет";
            // 
            // Red
            // 
            this.Red.AutoSize = false;
            this.Red.Dock = System.Windows.Forms.DockStyle.Top;
            this.Red.Location = new System.Drawing.Point(3, 116);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(298, 50);
            this.Red.TabIndex = 1;
            this.Red.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Green
            // 
            this.Green.AutoSize = false;
            this.Green.Dock = System.Windows.Forms.DockStyle.Top;
            this.Green.Location = new System.Drawing.Point(3, 66);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(298, 50);
            this.Green.TabIndex = 1;
            this.Green.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Blue
            // 
            this.Blue.AutoSize = false;
            this.Blue.Dock = System.Windows.Forms.DockStyle.Top;
            this.Blue.Location = new System.Drawing.Point(3, 16);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(298, 50);
            this.Blue.TabIndex = 1;
            this.Blue.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 459);
            this.Controls.Add(this.s1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Куркулятор Настройки";
            this.s1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TrackBar Green;
        private System.Windows.Forms.TrackBar Red;

        private System.Windows.Forms.TrackBar Blue;

        private System.Windows.Forms.GroupBox s1;

        #endregion
    }
}