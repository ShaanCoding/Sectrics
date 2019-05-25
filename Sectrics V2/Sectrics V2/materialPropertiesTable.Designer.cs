namespace Sectrics_V2
{
    partial class materialPropertiesTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(materialPropertiesTable));
            this.minimize = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.bridgeDrawing = new System.Windows.Forms.Panel();
            this.zoomInBar = new System.Windows.Forms.TrackBar();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.membersListView = new System.Windows.Forms.ListBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.materialsListView = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInBar)).BeginInit();
            this.SuspendLayout();
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
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.exitApplication.TabIndex = 2;
            this.exitApplication.UseVisualStyleBackColor = false;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
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
            this.BackToMainMenu.Location = new System.Drawing.Point(24, 64);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(540, 91);
            this.BackToMainMenu.TabIndex = 25;
            this.BackToMainMenu.TabStop = false;
            this.BackToMainMenu.Text = "BACK";
            this.BackToMainMenu.UseVisualStyleBackColor = false;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // bridgeDrawing
            // 
            this.bridgeDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bridgeDrawing.BackColor = System.Drawing.Color.White;
            this.bridgeDrawing.Location = new System.Drawing.Point(645, 328);
            this.bridgeDrawing.Name = "bridgeDrawing";
            this.bridgeDrawing.Size = new System.Drawing.Size(1237, 723);
            this.bridgeDrawing.TabIndex = 35;
            this.bridgeDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.bridgeDrawing_Paint);
            this.bridgeDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bridgeDrawing_MouseMove);
            // 
            // zoomInBar
            // 
            this.zoomInBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.zoomInBar.Location = new System.Drawing.Point(645, 232);
            this.zoomInBar.Maximum = 100;
            this.zoomInBar.Minimum = 1;
            this.zoomInBar.Name = "zoomInBar";
            this.zoomInBar.Size = new System.Drawing.Size(884, 90);
            this.zoomInBar.TabIndex = 34;
            this.zoomInBar.TabStop = false;
            this.zoomInBar.Value = 100;
            this.zoomInBar.Scroll += new System.EventHandler(this.zoomInBar_Scroll);
            // 
            // moveMenu
            // 
            this.moveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveMenu.BackColor = System.Drawing.Color.White;
            this.moveMenu.Location = new System.Drawing.Point(0, 0);
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(1920, 30);
            this.moveMenu.TabIndex = 36;
            this.moveMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseDown);
            this.moveMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseMove);
            this.moveMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveMenu_MouseUp);
            // 
            // membersListView
            // 
            this.membersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.membersListView.FormattingEnabled = true;
            this.membersListView.ItemHeight = 25;
            this.membersListView.Location = new System.Drawing.Point(24, 500);
            this.membersListView.Name = "membersListView";
            this.membersListView.Size = new System.Drawing.Size(594, 354);
            this.membersListView.TabIndex = 37;
            // 
            // clearAll
            // 
            this.clearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAll.BackColor = System.Drawing.Color.Transparent;
            this.clearAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearAll.FlatAppearance.BorderSize = 2;
            this.clearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(34, 960);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(540, 91);
            this.clearAll.TabIndex = 39;
            this.clearAll.TabStop = false;
            this.clearAll.Text = "CLEAR ALL";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // materialsListView
            // 
            this.materialsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsListView.FormattingEnabled = true;
            this.materialsListView.ItemHeight = 25;
            this.materialsListView.Location = new System.Drawing.Point(24, 187);
            this.materialsListView.Name = "materialsListView";
            this.materialsListView.Size = new System.Drawing.Size(594, 279);
            this.materialsListView.TabIndex = 38;
            this.materialsListView.SelectedIndexChanged += new System.EventHandler(this.materialsListView_SelectedIndexChanged);
            // 
            // materialPropertiesTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.membersListView);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.materialsListView);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.bridgeDrawing);
            this.Controls.Add(this.zoomInBar);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "materialPropertiesTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sectrics - Truss Analysis Program";
            this.Load += new System.EventHandler(this.nodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoomInBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel bridgeDrawing;
        private System.Windows.Forms.TrackBar zoomInBar;
        private System.Windows.Forms.Panel moveMenu;
        private System.Windows.Forms.ListBox membersListView;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.ListBox materialsListView;
    }
}