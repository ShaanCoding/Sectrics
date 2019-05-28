namespace Sectrics_V2
{
    partial class supportMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supportMenus));
            this.minimize = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.addSupportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.supportNodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supportType = new System.Windows.Forms.ListBox();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.bridgeDrawing = new System.Windows.Forms.Panel();
            this.zoomInBar = new System.Windows.Forms.TrackBar();
            this.supportMenuTable = new System.Windows.Forms.Button();
            this.newBridge = new System.Windows.Forms.Button();
            this.loadBridge = new System.Windows.Forms.Button();
            this.saveBridge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInBar)).BeginInit();
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
            // addSupportButton
            // 
            this.addSupportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSupportButton.BackColor = System.Drawing.Color.Transparent;
            this.addSupportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addSupportButton.FlatAppearance.BorderSize = 2;
            this.addSupportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.addSupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupportButton.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.addSupportButton.ForeColor = System.Drawing.Color.White;
            this.addSupportButton.Location = new System.Drawing.Point(24, 519);
            this.addSupportButton.Name = "addSupportButton";
            this.addSupportButton.Size = new System.Drawing.Size(540, 91);
            this.addSupportButton.TabIndex = 31;
            this.addSupportButton.TabStop = false;
            this.addSupportButton.Text = "ADD SUPPORT";
            this.addSupportButton.UseVisualStyleBackColor = false;
            this.addSupportButton.Click += new System.EventHandler(this.addSupportButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "SUPPORT TYPE:";
            // 
            // supportNodeTextbox
            // 
            this.supportNodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supportNodeTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportNodeTextbox.Location = new System.Drawing.Point(24, 239);
            this.supportNodeTextbox.Name = "supportNodeTextbox";
            this.supportNodeTextbox.Size = new System.Drawing.Size(471, 40);
            this.supportNodeTextbox.TabIndex = 0;
            this.supportNodeTextbox.Text = "Enter the support node here";
            this.supportNodeTextbox.TextChanged += new System.EventHandler(this.supportNodeTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "SUPPORT NODE:";
            // 
            // supportType
            // 
            this.supportType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supportType.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportType.FormattingEnabled = true;
            this.supportType.ItemHeight = 33;
            this.supportType.Items.AddRange(new object[] {
            "Vertical Fixed Support",
            "Horozontal Fixed Support",
            "Vertical Roller",
            "Horozontal Roller"});
            this.supportType.Location = new System.Drawing.Point(24, 363);
            this.supportType.Name = "supportType";
            this.supportType.Size = new System.Drawing.Size(471, 136);
            this.supportType.TabIndex = 1;
            this.supportType.SelectedIndexChanged += new System.EventHandler(this.supportType_SelectedIndexChanged);
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
            this.BackToMainMenu.TabIndex = 37;
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
            this.bridgeDrawing.TabIndex = 39;
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
            this.zoomInBar.TabIndex = 38;
            this.zoomInBar.TabStop = false;
            this.zoomInBar.Value = 100;
            this.zoomInBar.Scroll += new System.EventHandler(this.zoomInBar_Scroll);
            // 
            // supportMenuTable
            // 
            this.supportMenuTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supportMenuTable.BackColor = System.Drawing.Color.Transparent;
            this.supportMenuTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.supportMenuTable.FlatAppearance.BorderSize = 2;
            this.supportMenuTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.supportMenuTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportMenuTable.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.supportMenuTable.ForeColor = System.Drawing.Color.White;
            this.supportMenuTable.Location = new System.Drawing.Point(584, 64);
            this.supportMenuTable.Name = "supportMenuTable";
            this.supportMenuTable.Size = new System.Drawing.Size(540, 91);
            this.supportMenuTable.TabIndex = 40;
            this.supportMenuTable.TabStop = false;
            this.supportMenuTable.Text = "TABLE";
            this.supportMenuTable.UseVisualStyleBackColor = false;
            this.supportMenuTable.Click += new System.EventHandler(this.supportMenuTable_Click);
            // 
            // newBridge
            // 
            this.newBridge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newBridge.BackColor = System.Drawing.Color.Transparent;
            this.newBridge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newBridge.FlatAppearance.BorderSize = 2;
            this.newBridge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.newBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBridge.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBridge.ForeColor = System.Drawing.Color.White;
            this.newBridge.Location = new System.Drawing.Point(24, 851);
            this.newBridge.Name = "newBridge";
            this.newBridge.Size = new System.Drawing.Size(540, 91);
            this.newBridge.TabIndex = 43;
            this.newBridge.TabStop = false;
            this.newBridge.Text = "NEW BRIDGE";
            this.newBridge.UseVisualStyleBackColor = false;
            this.newBridge.Click += new System.EventHandler(this.newBridge_Click);
            // 
            // loadBridge
            // 
            this.loadBridge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBridge.BackColor = System.Drawing.Color.Transparent;
            this.loadBridge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadBridge.FlatAppearance.BorderSize = 2;
            this.loadBridge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.loadBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBridge.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBridge.ForeColor = System.Drawing.Color.White;
            this.loadBridge.Location = new System.Drawing.Point(24, 630);
            this.loadBridge.Name = "loadBridge";
            this.loadBridge.Size = new System.Drawing.Size(540, 91);
            this.loadBridge.TabIndex = 42;
            this.loadBridge.TabStop = false;
            this.loadBridge.Text = "LOAD BRIDGE";
            this.loadBridge.UseVisualStyleBackColor = false;
            this.loadBridge.Click += new System.EventHandler(this.loadBridge_Click);
            // 
            // saveBridge
            // 
            this.saveBridge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBridge.BackColor = System.Drawing.Color.Transparent;
            this.saveBridge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBridge.FlatAppearance.BorderSize = 2;
            this.saveBridge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.saveBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBridge.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.saveBridge.ForeColor = System.Drawing.Color.White;
            this.saveBridge.Location = new System.Drawing.Point(24, 741);
            this.saveBridge.Name = "saveBridge";
            this.saveBridge.Size = new System.Drawing.Size(540, 91);
            this.saveBridge.TabIndex = 41;
            this.saveBridge.TabStop = false;
            this.saveBridge.Text = "SAVE BRIDGE";
            this.saveBridge.UseVisualStyleBackColor = false;
            this.saveBridge.Click += new System.EventHandler(this.saveBridge_Click);
            // 
            // supportMenus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.newBridge);
            this.Controls.Add(this.loadBridge);
            this.Controls.Add(this.saveBridge);
            this.Controls.Add(this.supportMenuTable);
            this.Controls.Add(this.bridgeDrawing);
            this.Controls.Add(this.zoomInBar);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.supportType);
            this.Controls.Add(this.addSupportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supportNodeTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "supportMenus";
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
        private System.Windows.Forms.Button addSupportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supportNodeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox supportType;
        private System.Windows.Forms.Panel moveMenu;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel bridgeDrawing;
        private System.Windows.Forms.TrackBar zoomInBar;
        private System.Windows.Forms.Button supportMenuTable;
        private System.Windows.Forms.Button newBridge;
        private System.Windows.Forms.Button loadBridge;
        private System.Windows.Forms.Button saveBridge;
    }
}