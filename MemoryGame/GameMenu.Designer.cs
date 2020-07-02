namespace MemoryGame
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(228, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE LEVEL";
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Transparent;
            this.level1.Cursor = System.Windows.Forms.Cursors.Default;
            this.level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level1.Location = new System.Drawing.Point(137, 434);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(143, 69);
            this.level1.TabIndex = 1;
            this.level1.Text = "LEVEL 1 (4x4)";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.button1_Click);
            // 
            // level2
            // 
            this.level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level2.Location = new System.Drawing.Point(350, 432);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(143, 72);
            this.level2.TabIndex = 2;
            this.level2.Text = "LEVEL 2 (4x6)";
            this.level2.UseVisualStyleBackColor = true;
            this.level2.Click += new System.EventHandler(this.button2_Click);
            // 
            // level3
            // 
            this.level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level3.Location = new System.Drawing.Point(541, 434);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(143, 69);
            this.level3.TabIndex = 3;
            this.level3.Text = "LEVEL 3 (6x6)";
            this.level3.UseVisualStyleBackColor = true;
            this.level3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkViolet;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(161, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 77);
            this.label2.TabIndex = 4;
            this.label2.Text = "MEMORY GAME";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "GameMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level3;
        private System.Windows.Forms.Label label2;
    }
}

