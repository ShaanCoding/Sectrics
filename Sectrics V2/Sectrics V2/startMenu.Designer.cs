namespace Sectrics_V2
{
    partial class startMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startMenu));
            this.exitApplication = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.startApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // exitApplication
            // 
            this.exitApplication.BackColor = System.Drawing.Color.Transparent;
            this.exitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitApplication.BackgroundImage")));
            this.exitApplication.FlatAppearance.BorderSize = 0;
            this.exitApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApplication.Location = new System.Drawing.Point(1794, 35);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(64, 64);
            this.exitApplication.TabIndex = 0;
            this.exitApplication.TabStop = false;
            this.exitApplication.UseVisualStyleBackColor = false;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(1724, 35);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(64, 64);
            this.minimize.TabIndex = 1;
            this.minimize.TabStop = false;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // startApplication
            // 
            this.startApplication.BackColor = System.Drawing.Color.Transparent;
            this.startApplication.FlatAppearance.BorderSize = 0;
            this.startApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.startApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startApplication.Image = ((System.Drawing.Image)(resources.GetObject("startApplication.Image")));
            this.startApplication.Location = new System.Drawing.Point(690, 576);
            this.startApplication.Name = "startApplication";
            this.startApplication.Size = new System.Drawing.Size(540, 91);
            this.startApplication.TabIndex = 0;
            this.startApplication.TabStop = false;
            this.startApplication.UseVisualStyleBackColor = false;
            this.startApplication.Click += new System.EventHandler(this.startApplication_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN Alternate", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(825, 835);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT EDITION";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.Location = new System.Drawing.Point(690, 697);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(540, 109);
            this.helpButton.TabIndex = 1;
            this.helpButton.TabStop = false;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // moveMenu
            // 
            this.moveMenu.Location = new System.Drawing.Point(0, 0);
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(1920, 30);
            this.moveMenu.TabIndex = 42;
            this.moveMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseDown);
            this.moveMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseMove);
            this.moveMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseUp);
            // 
            // startMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startApplication);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "startMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sectrics - Truss Analysis Program";
            this.Load += new System.EventHandler(this.startMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button startApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel moveMenu;
    }
}

