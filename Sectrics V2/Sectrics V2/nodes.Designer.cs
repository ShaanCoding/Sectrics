namespace Sectrics_V2
{
    partial class nodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nodes));
            this.label1 = new System.Windows.Forms.Label();
            this.xAxisTextbox = new System.Windows.Forms.TextBox();
            this.yAxisTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.saveBridge = new System.Windows.Forms.Button();
            this.loadBridge = new System.Windows.Forms.Button();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.bridgeDrawing = new System.Windows.Forms.Panel();
            this.zoomInBar = new System.Windows.Forms.TrackBar();
            this.minimize = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.nodesTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "X AXIS COORDINATES:";
            // 
            // xAxisTextbox
            // 
            this.xAxisTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xAxisTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxisTextbox.Location = new System.Drawing.Point(17, 239);
            this.xAxisTextbox.Name = "xAxisTextbox";
            this.xAxisTextbox.Size = new System.Drawing.Size(425, 40);
            this.xAxisTextbox.TabIndex = 0;
            this.xAxisTextbox.Text = "Enter the x-axis coordinates here.";
            this.xAxisTextbox.TextChanged += new System.EventHandler(this.xAxisTextbox_TextChanged);
            // 
            // yAxisTextbox
            // 
            this.yAxisTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yAxisTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxisTextbox.Location = new System.Drawing.Point(17, 363);
            this.yAxisTextbox.Name = "yAxisTextbox";
            this.yAxisTextbox.Size = new System.Drawing.Size(425, 40);
            this.yAxisTextbox.TabIndex = 1;
            this.yAxisTextbox.Text = "Enter the y-axis coordinates here.";
            this.yAxisTextbox.TextChanged += new System.EventHandler(this.yAxisTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y AXIS COORDINATES:";
            // 
            // addNodeButton
            // 
            this.addNodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNodeButton.BackColor = System.Drawing.Color.Transparent;
            this.addNodeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addNodeButton.FlatAppearance.BorderSize = 2;
            this.addNodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.addNodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNodeButton.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.addNodeButton.ForeColor = System.Drawing.Color.White;
            this.addNodeButton.Location = new System.Drawing.Point(17, 434);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(540, 91);
            this.addNodeButton.TabIndex = 16;
            this.addNodeButton.TabStop = false;
            this.addNodeButton.Text = "ADD NODE";
            this.addNodeButton.UseVisualStyleBackColor = false;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
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
            this.saveBridge.Location = new System.Drawing.Point(1166, 64);
            this.saveBridge.Name = "saveBridge";
            this.saveBridge.Size = new System.Drawing.Size(540, 91);
            this.saveBridge.TabIndex = 20;
            this.saveBridge.TabStop = false;
            this.saveBridge.Text = "SAVE BRIDGE";
            this.saveBridge.UseVisualStyleBackColor = false;
            this.saveBridge.Click += new System.EventHandler(this.saveBridge_Click);
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
            this.loadBridge.Location = new System.Drawing.Point(604, 64);
            this.loadBridge.Name = "loadBridge";
            this.loadBridge.Size = new System.Drawing.Size(540, 91);
            this.loadBridge.TabIndex = 21;
            this.loadBridge.TabStop = false;
            this.loadBridge.Text = "LOAD BRIDGE";
            this.loadBridge.UseVisualStyleBackColor = false;
            this.loadBridge.Click += new System.EventHandler(this.loadBridge_Click);
            // 
            // moveMenu
            // 
            this.moveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveMenu.BackColor = System.Drawing.Color.White;
            this.moveMenu.ForeColor = System.Drawing.Color.Transparent;
            this.moveMenu.Location = new System.Drawing.Point(0, 0);
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(1920, 30);
            this.moveMenu.TabIndex = 22;
            this.moveMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.moveMenu_Paint);
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
            this.BackToMainMenu.TabIndex = 23;
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
            this.bridgeDrawing.TabIndex = 27;
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
            this.zoomInBar.TabIndex = 26;
            this.zoomInBar.TabStop = false;
            this.zoomInBar.Value = 100;
            this.zoomInBar.Scroll += new System.EventHandler(this.zoomInBar_Scroll);
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
            // nodesTable
            // 
            this.nodesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nodesTable.BackColor = System.Drawing.Color.Transparent;
            this.nodesTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nodesTable.FlatAppearance.BorderSize = 2;
            this.nodesTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.nodesTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nodesTable.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.nodesTable.ForeColor = System.Drawing.Color.White;
            this.nodesTable.Location = new System.Drawing.Point(17, 627);
            this.nodesTable.Name = "nodesTable";
            this.nodesTable.Size = new System.Drawing.Size(540, 91);
            this.nodesTable.TabIndex = 28;
            this.nodesTable.TabStop = false;
            this.nodesTable.Text = "TABLE";
            this.nodesTable.UseVisualStyleBackColor = false;
            this.nodesTable.Click += new System.EventHandler(this.nodesTable_Click);
            // 
            // nodes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.nodesTable);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.yAxisTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xAxisTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoomInBar);
            this.Controls.Add(this.bridgeDrawing);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.loadBridge);
            this.Controls.Add(this.saveBridge);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nodes";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xAxisTextbox;
        private System.Windows.Forms.TextBox yAxisTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.Button saveBridge;
        private System.Windows.Forms.Button loadBridge;
        private System.Windows.Forms.Panel moveMenu;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel bridgeDrawing;
        private System.Windows.Forms.TrackBar zoomInBar;
        private System.Windows.Forms.Button nodesTable;
    }
}