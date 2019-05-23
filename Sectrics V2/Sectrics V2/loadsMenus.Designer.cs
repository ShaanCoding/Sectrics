﻿namespace Sectrics_V2
{
    partial class loadsMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadsMenus));
            this.minimize = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.addLoadButton = new System.Windows.Forms.Button();
            this.xForceTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yForceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nodeListView = new System.Windows.Forms.ListBox();
            this.loadsListView = new System.Windows.Forms.ListBox();
            this.removeLoad = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(1724, 35);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(64, 64);
            this.minimize.TabIndex = 3;
            this.minimize.TabStop = false;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitApplication.BackColor = System.Drawing.Color.Transparent;
            this.exitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitApplication.BackgroundImage")));
            this.exitApplication.FlatAppearance.BorderSize = 0;
            this.exitApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApplication.Location = new System.Drawing.Point(1794, 35);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(64, 64);
            this.exitApplication.TabIndex = 2;
            this.exitApplication.TabStop = false;
            this.exitApplication.UseVisualStyleBackColor = false;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // addLoadButton
            // 
            this.addLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addLoadButton.BackColor = System.Drawing.Color.Transparent;
            this.addLoadButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addLoadButton.FlatAppearance.BorderSize = 2;
            this.addLoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.addLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLoadButton.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.addLoadButton.ForeColor = System.Drawing.Color.White;
            this.addLoadButton.Location = new System.Drawing.Point(376, 406);
            this.addLoadButton.Name = "addLoadButton";
            this.addLoadButton.Size = new System.Drawing.Size(540, 91);
            this.addLoadButton.TabIndex = 31;
            this.addLoadButton.TabStop = false;
            this.addLoadButton.Text = "ADD LOADS";
            this.addLoadButton.UseVisualStyleBackColor = false;
            this.addLoadButton.Click += new System.EventHandler(this.addLoadButton_Click);
            // 
            // xForceTextbox
            // 
            this.xForceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xForceTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xForceTextbox.Location = new System.Drawing.Point(445, 260);
            this.xForceTextbox.Name = "xForceTextbox";
            this.xForceTextbox.Size = new System.Drawing.Size(471, 40);
            this.xForceTextbox.TabIndex = 1;
            this.xForceTextbox.Text = "Enter the X axis forces here";
            this.xForceTextbox.TextChanged += new System.EventHandler(this.xForceTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "X AXIS FORCES:";
            // 
            // nodeTextbox
            // 
            this.nodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeTextbox.Location = new System.Drawing.Point(445, 190);
            this.nodeTextbox.Name = "nodeTextbox";
            this.nodeTextbox.Size = new System.Drawing.Size(471, 40);
            this.nodeTextbox.TabIndex = 0;
            this.nodeTextbox.Text = "Enter the node here";
            this.nodeTextbox.TextChanged += new System.EventHandler(this.nodeTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "NODE:";
            // 
            // yForceTextbox
            // 
            this.yForceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yForceTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yForceTextbox.Location = new System.Drawing.Point(445, 334);
            this.yForceTextbox.Name = "yForceTextbox";
            this.yForceTextbox.Size = new System.Drawing.Size(471, 40);
            this.yForceTextbox.TabIndex = 2;
            this.yForceTextbox.Text = "Enter the Y axis forces here";
            this.yForceTextbox.TextChanged += new System.EventHandler(this.yForceTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "Y AXIS FORCES:";
            // 
            // nodeListView
            // 
            this.nodeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeListView.FormattingEnabled = true;
            this.nodeListView.ItemHeight = 25;
            this.nodeListView.Location = new System.Drawing.Point(1100, 307);
            this.nodeListView.Name = "nodeListView";
            this.nodeListView.Size = new System.Drawing.Size(456, 404);
            this.nodeListView.TabIndex = 33;
            this.nodeListView.SelectedIndexChanged += new System.EventHandler(this.nodeListView_SelectedIndexChanged);
            // 
            // loadsListView
            // 
            this.loadsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadsListView.FormattingEnabled = true;
            this.loadsListView.ItemHeight = 25;
            this.loadsListView.Location = new System.Drawing.Point(603, 585);
            this.loadsListView.Name = "loadsListView";
            this.loadsListView.Size = new System.Drawing.Size(420, 404);
            this.loadsListView.TabIndex = 34;
            this.loadsListView.SelectedIndexChanged += new System.EventHandler(this.loadsListView_SelectedIndexChanged);
            // 
            // removeLoad
            // 
            this.removeLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLoad.BackColor = System.Drawing.Color.Transparent;
            this.removeLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeLoad.FlatAppearance.BorderSize = 2;
            this.removeLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.removeLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLoad.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.removeLoad.ForeColor = System.Drawing.Color.White;
            this.removeLoad.Location = new System.Drawing.Point(39, 560);
            this.removeLoad.Name = "removeLoad";
            this.removeLoad.Size = new System.Drawing.Size(540, 91);
            this.removeLoad.TabIndex = 35;
            this.removeLoad.TabStop = false;
            this.removeLoad.Text = "REMOVE LOAD";
            this.removeLoad.UseVisualStyleBackColor = false;
            this.removeLoad.Click += new System.EventHandler(this.removeLoad_Click);
            // 
            // removeAll
            // 
            this.removeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAll.BackColor = System.Drawing.Color.Transparent;
            this.removeAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeAll.FlatAppearance.BorderSize = 2;
            this.removeAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.removeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAll.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.removeAll.ForeColor = System.Drawing.Color.White;
            this.removeAll.Location = new System.Drawing.Point(39, 675);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(540, 91);
            this.removeAll.TabIndex = 36;
            this.removeAll.TabStop = false;
            this.removeAll.Text = "CLEAR ALL";
            this.removeAll.UseVisualStyleBackColor = false;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // moveMenu
            // 
            this.moveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveMenu.BackColor = System.Drawing.Color.White;
            this.moveMenu.Location = new System.Drawing.Point(0, 0);
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(1920, 30);
            this.moveMenu.TabIndex = 37;
            this.moveMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseDown);
            this.moveMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseMove);
            this.moveMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseUp);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackToMainMenu.FlatAppearance.BorderSize = 2;
            this.BackToMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.BackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.BackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.BackToMainMenu.Location = new System.Drawing.Point(1224, 139);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(540, 91);
            this.BackToMainMenu.TabIndex = 38;
            this.BackToMainMenu.TabStop = false;
            this.BackToMainMenu.Text = "BACK";
            this.BackToMainMenu.UseVisualStyleBackColor = false;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // loadsMenus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.removeLoad);
            this.Controls.Add(this.loadsListView);
            this.Controls.Add(this.nodeListView);
            this.Controls.Add(this.yForceTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addLoadButton);
            this.Controls.Add(this.xForceTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nodeTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loadsMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sectrics - Truss Analysis Program";
            this.Load += new System.EventHandler(this.nodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.Button addLoadButton;
        private System.Windows.Forms.TextBox xForceTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nodeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yForceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox nodeListView;
        private System.Windows.Forms.ListBox loadsListView;
        private System.Windows.Forms.Button removeLoad;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Panel moveMenu;
        private System.Windows.Forms.Button BackToMainMenu;
    }
}