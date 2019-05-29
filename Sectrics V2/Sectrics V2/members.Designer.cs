namespace Sectrics_V2
{
    partial class members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(members));
            this.minimize = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.fromMemberTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toMemberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveMenu = new System.Windows.Forms.Panel();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.bridgeDrawing = new System.Windows.Forms.Panel();
            this.zoomInBar = new System.Windows.Forms.TrackBar();
            this.membersTable = new System.Windows.Forms.Button();
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
            // addMemberButton
            // 
            this.addMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberButton.BackColor = System.Drawing.Color.Transparent;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addMemberButton.FlatAppearance.BorderSize = 2;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(24, 434);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(540, 91);
            this.addMemberButton.TabIndex = 21;
            this.addMemberButton.TabStop = false;
            this.addMemberButton.Text = "ADD MEMBER";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // fromMemberTextbox
            // 
            this.fromMemberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromMemberTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromMemberTextbox.Location = new System.Drawing.Point(24, 239);
            this.fromMemberTextbox.Name = "fromMemberTextbox";
            this.fromMemberTextbox.Size = new System.Drawing.Size(417, 40);
            this.fromMemberTextbox.TabIndex = 0;
            this.fromMemberTextbox.Text = "Enter the from member here";
            this.fromMemberTextbox.TextChanged += new System.EventHandler(this.fromMemberTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "FROM MEMBER:";
            // 
            // toMemberTextbox
            // 
            this.toMemberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toMemberTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMemberTextbox.Location = new System.Drawing.Point(24, 363);
            this.toMemberTextbox.Name = "toMemberTextbox";
            this.toMemberTextbox.Size = new System.Drawing.Size(417, 40);
            this.toMemberTextbox.TabIndex = 1;
            this.toMemberTextbox.Text = "Enter the to member here";
            this.toMemberTextbox.TextChanged += new System.EventHandler(this.toMemberTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DIN Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "TO MEMBER:";
            // 
            // moveMenu
            // 
            this.moveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveMenu.BackColor = System.Drawing.Color.White;
            this.moveMenu.Location = new System.Drawing.Point(0, 0);
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(1920, 30);
            this.moveMenu.TabIndex = 26;
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
            this.BackToMainMenu.TabIndex = 27;
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
            this.bridgeDrawing.TabIndex = 29;
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
            this.zoomInBar.TabIndex = 28;
            this.zoomInBar.TabStop = false;
            this.zoomInBar.Value = 100;
            this.zoomInBar.Scroll += new System.EventHandler(this.zoomInBar_Scroll);
            // 
            // membersTable
            // 
            this.membersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.membersTable.BackColor = System.Drawing.Color.Transparent;
            this.membersTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.membersTable.FlatAppearance.BorderSize = 2;
            this.membersTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.membersTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersTable.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.membersTable.ForeColor = System.Drawing.Color.White;
            this.membersTable.Location = new System.Drawing.Point(584, 64);
            this.membersTable.Name = "membersTable";
            this.membersTable.Size = new System.Drawing.Size(540, 91);
            this.membersTable.TabIndex = 30;
            this.membersTable.TabStop = false;
            this.membersTable.Text = "TABLE";
            this.membersTable.UseVisualStyleBackColor = false;
            this.membersTable.Click += new System.EventHandler(this.membersTable_Click);
            // 
            // members
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.membersTable);
            this.Controls.Add(this.bridgeDrawing);
            this.Controls.Add(this.zoomInBar);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.fromMemberTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toMemberTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.BackToMainMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "members";
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
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TextBox fromMemberTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toMemberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel moveMenu;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel bridgeDrawing;
        private System.Windows.Forms.TrackBar zoomInBar;
        private System.Windows.Forms.Button membersTable;
    }
}