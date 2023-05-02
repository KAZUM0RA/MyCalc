namespace MyCalc
{
    partial class MainForm
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
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_MC = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_MS = new System.Windows.Forms.Button();
            this.button_MPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.panel_Results = new System.Windows.Forms.Panel();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(160, 19);
            this.toolStripStatusLabel_Info.Text = "Приложение загружено";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel_Info });
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(307, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.видToolStripMenuItem1, this.видToolStripMenuItem, this.правкаToolStripMenuItem, this.справкаToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem1
            // 
            this.видToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.инженерныйToolStripMenuItem, this.обычныйToolStripMenuItem });
            this.видToolStripMenuItem1.Name = "видToolStripMenuItem1";
            this.видToolStripMenuItem1.Size = new System.Drawing.Size(45, 23);
            this.видToolStripMenuItem1.Text = "Вид";
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Checked = true;
            this.обычныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.настройкиToolStripMenuItem });
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.видToolStripMenuItem.Text = "Окно";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оНасToolStripMenuItem });
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.оНасToolStripMenuItem.Text = "О нас";
            this.оНасToolStripMenuItem.Click += new System.EventHandler(this.оНасToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(314, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button_MC
            // 
            this.button_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MC.Location = new System.Drawing.Point(3, 73);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(55, 40);
            this.button_MC.TabIndex = 4;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            // 
            // button_MR
            // 
            this.button_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MR.Location = new System.Drawing.Point(64, 73);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(55, 40);
            this.button_MR.TabIndex = 4;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            // 
            // button_MS
            // 
            this.button_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MS.Location = new System.Drawing.Point(125, 73);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(55, 40);
            this.button_MS.TabIndex = 4;
            this.button_MS.Text = "MS";
            this.button_MS.UseVisualStyleBackColor = true;
            // 
            // button_MPlus
            // 
            this.button_MPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MPlus.Location = new System.Drawing.Point(186, 73);
            this.button_MPlus.Name = "button_MPlus";
            this.button_MPlus.Size = new System.Drawing.Size(55, 40);
            this.button_MPlus.TabIndex = 4;
            this.button_MPlus.Text = "M+";
            this.button_MPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(247, 73);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(55, 40);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "M-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // panel_Results
            // 
            this.panel_Results.Controls.Add(this.textBox_Result);
            this.panel_Results.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Results.Location = new System.Drawing.Point(0, 27);
            this.panel_Results.Name = "panel_Results";
            this.panel_Results.Size = new System.Drawing.Size(307, 40);
            this.panel_Results.TabIndex = 5;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.Location = new System.Drawing.Point(0, 0);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Result.Size = new System.Drawing.Size(307, 37);
            this.textBox_Result.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 459);
            this.Controls.Add(this.panel_Results);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button_MPlus);
            this.Controls.Add(this.button_MS);
            this.Controls.Add(this.button_MR);
            this.Controls.Add(this.button_MC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кулькулятор V1.0.1 beta";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Results.ResumeLayout(false);
            this.panel_Results.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;

        private System.Windows.Forms.TextBox textBox_Result;

        private System.Windows.Forms.Button button_MS;
        private System.Windows.Forms.Button button_MPlus;
        private System.Windows.Forms.Button buttonMinus;

        private System.Windows.Forms.Button button_MC;

        private System.Windows.Forms.Button button_MR;

        private System.Windows.Forms.Panel panel_Results;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;

        private System.Windows.Forms.StatusStrip statusStrip1;

        #endregion
    }
}