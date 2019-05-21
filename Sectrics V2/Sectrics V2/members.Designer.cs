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
            this.nodesMenu = new System.Windows.Forms.Button();
            this.membersMenu = new System.Windows.Forms.Button();
            this.supportsMenu = new System.Windows.Forms.Button();
            this.loadsMenu = new System.Windows.Forms.Button();
            this.solveMenu = new System.Windows.Forms.Button();
            this.aboutMenu = new System.Windows.Forms.Button();
            this.exitMenu = new System.Windows.Forms.Button();
            this.materialPropertiesMenu = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.fromMemberTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toMemberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.membersListView = new System.Windows.Forms.ListBox();
            this.removeMember = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.nodeListView = new System.Windows.Forms.ListBox();
            this.moveMenu = new System.Windows.Forms.Panel();
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
            // nodesMenu
            // 
            this.nodesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nodesMenu.BackColor = System.Drawing.Color.Transparent;
            this.nodesMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nodesMenu.FlatAppearance.BorderSize = 2;
            this.nodesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.nodesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nodesMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.nodesMenu.ForeColor = System.Drawing.Color.White;
            this.nodesMenu.Location = new System.Drawing.Point(30, 193);
            this.nodesMenu.Name = "nodesMenu";
            this.nodesMenu.Size = new System.Drawing.Size(537, 91);
            this.nodesMenu.TabIndex = 4;
            this.nodesMenu.TabStop = false;
            this.nodesMenu.Text = "NODES";
            this.nodesMenu.UseVisualStyleBackColor = false;
            this.nodesMenu.Click += new System.EventHandler(this.nodesMenu_Click);
            // 
            // membersMenu
            // 
            this.membersMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.membersMenu.BackColor = System.Drawing.Color.Transparent;
            this.membersMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.membersMenu.FlatAppearance.BorderSize = 2;
            this.membersMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.membersMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.membersMenu.ForeColor = System.Drawing.Color.White;
            this.membersMenu.Location = new System.Drawing.Point(30, 301);
            this.membersMenu.Name = "membersMenu";
            this.membersMenu.Size = new System.Drawing.Size(537, 91);
            this.membersMenu.TabIndex = 5;
            this.membersMenu.TabStop = false;
            this.membersMenu.Text = "MEMBERS";
            this.membersMenu.UseVisualStyleBackColor = false;
            this.membersMenu.Click += new System.EventHandler(this.membersMenu_Click);
            // 
            // supportsMenu
            // 
            this.supportsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supportsMenu.BackColor = System.Drawing.Color.Transparent;
            this.supportsMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.supportsMenu.FlatAppearance.BorderSize = 2;
            this.supportsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.supportsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportsMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.supportsMenu.ForeColor = System.Drawing.Color.White;
            this.supportsMenu.Location = new System.Drawing.Point(30, 517);
            this.supportsMenu.Name = "supportsMenu";
            this.supportsMenu.Size = new System.Drawing.Size(537, 91);
            this.supportsMenu.TabIndex = 6;
            this.supportsMenu.TabStop = false;
            this.supportsMenu.Text = "SUPPORTS";
            this.supportsMenu.UseVisualStyleBackColor = false;
            this.supportsMenu.Click += new System.EventHandler(this.supportsMenu_Click);
            // 
            // loadsMenu
            // 
            this.loadsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadsMenu.BackColor = System.Drawing.Color.Transparent;
            this.loadsMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadsMenu.FlatAppearance.BorderSize = 2;
            this.loadsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.loadsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadsMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.loadsMenu.ForeColor = System.Drawing.Color.White;
            this.loadsMenu.Location = new System.Drawing.Point(30, 625);
            this.loadsMenu.Name = "loadsMenu";
            this.loadsMenu.Size = new System.Drawing.Size(537, 91);
            this.loadsMenu.TabIndex = 7;
            this.loadsMenu.TabStop = false;
            this.loadsMenu.Text = "LOADS";
            this.loadsMenu.UseVisualStyleBackColor = false;
            this.loadsMenu.Click += new System.EventHandler(this.loadsMenu_Click);
            // 
            // solveMenu
            // 
            this.solveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.solveMenu.BackColor = System.Drawing.Color.Transparent;
            this.solveMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.solveMenu.FlatAppearance.BorderSize = 2;
            this.solveMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.solveMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.solveMenu.ForeColor = System.Drawing.Color.White;
            this.solveMenu.Location = new System.Drawing.Point(30, 733);
            this.solveMenu.Name = "solveMenu";
            this.solveMenu.Size = new System.Drawing.Size(537, 91);
            this.solveMenu.TabIndex = 8;
            this.solveMenu.TabStop = false;
            this.solveMenu.Text = "SOLVE";
            this.solveMenu.UseVisualStyleBackColor = false;
            this.solveMenu.Click += new System.EventHandler(this.solveMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutMenu.BackColor = System.Drawing.Color.Transparent;
            this.aboutMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aboutMenu.FlatAppearance.BorderSize = 2;
            this.aboutMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.aboutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.aboutMenu.ForeColor = System.Drawing.Color.White;
            this.aboutMenu.Location = new System.Drawing.Point(30, 841);
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(537, 91);
            this.aboutMenu.TabIndex = 9;
            this.aboutMenu.TabStop = false;
            this.aboutMenu.Text = "ABOUT";
            this.aboutMenu.UseVisualStyleBackColor = false;
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMenu.BackColor = System.Drawing.Color.Transparent;
            this.exitMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitMenu.FlatAppearance.BorderSize = 2;
            this.exitMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.exitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.exitMenu.ForeColor = System.Drawing.Color.White;
            this.exitMenu.Location = new System.Drawing.Point(30, 949);
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(537, 91);
            this.exitMenu.TabIndex = 10;
            this.exitMenu.TabStop = false;
            this.exitMenu.Text = "EXIT";
            this.exitMenu.UseVisualStyleBackColor = false;
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // materialPropertiesMenu
            // 
            this.materialPropertiesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPropertiesMenu.BackColor = System.Drawing.Color.Transparent;
            this.materialPropertiesMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.materialPropertiesMenu.FlatAppearance.BorderSize = 2;
            this.materialPropertiesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.materialPropertiesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialPropertiesMenu.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.materialPropertiesMenu.ForeColor = System.Drawing.Color.White;
            this.materialPropertiesMenu.Location = new System.Drawing.Point(30, 409);
            this.materialPropertiesMenu.Name = "materialPropertiesMenu";
            this.materialPropertiesMenu.Size = new System.Drawing.Size(537, 91);
            this.materialPropertiesMenu.TabIndex = 11;
            this.materialPropertiesMenu.TabStop = false;
            this.materialPropertiesMenu.Text = "MATERIAL PROPERTIES";
            this.materialPropertiesMenu.UseVisualStyleBackColor = false;
            this.materialPropertiesMenu.Click += new System.EventHandler(this.materialPropertiesMenu_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberButton.BackColor = System.Drawing.Color.Transparent;
            this.addMemberButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addMemberButton.BackgroundImage")));
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addMemberButton.FlatAppearance.BorderSize = 2;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(809, 326);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(540, 91);
            this.addMemberButton.TabIndex = 21;
            this.addMemberButton.TabStop = false;
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // fromMemberTextbox
            // 
            this.fromMemberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromMemberTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromMemberTextbox.Location = new System.Drawing.Point(932, 127);
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
            this.label2.Location = new System.Drawing.Point(673, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "FROM MEMBER:";
            // 
            // toMemberTextbox
            // 
            this.toMemberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toMemberTextbox.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMemberTextbox.Location = new System.Drawing.Point(932, 195);
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
            this.label1.Location = new System.Drawing.Point(673, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "TO MEMBER:";
            // 
            // membersListView
            // 
            this.membersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.membersListView.FormattingEnabled = true;
            this.membersListView.ItemHeight = 25;
            this.membersListView.Location = new System.Drawing.Point(1259, 517);
            this.membersListView.Name = "membersListView";
            this.membersListView.Size = new System.Drawing.Size(529, 404);
            this.membersListView.TabIndex = 22;
            this.membersListView.SelectedIndexChanged += new System.EventHandler(this.membersListView_SelectedIndexChanged);
            // 
            // removeMember
            // 
            this.removeMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMember.BackColor = System.Drawing.Color.Transparent;
            this.removeMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeMember.FlatAppearance.BorderSize = 2;
            this.removeMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(81)))));
            this.removeMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMember.Font = new System.Drawing.Font("DIN Alternate", 10.125F, System.Drawing.FontStyle.Bold);
            this.removeMember.ForeColor = System.Drawing.Color.White;
            this.removeMember.Location = new System.Drawing.Point(660, 517);
            this.removeMember.Name = "removeMember";
            this.removeMember.Size = new System.Drawing.Size(540, 91);
            this.removeMember.TabIndex = 23;
            this.removeMember.TabStop = false;
            this.removeMember.Text = "REMOVE MEMBER";
            this.removeMember.UseVisualStyleBackColor = false;
            this.removeMember.Click += new System.EventHandler(this.removeMember_Click);
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
            this.clearAll.Location = new System.Drawing.Point(660, 625);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(540, 91);
            this.clearAll.TabIndex = 24;
            this.clearAll.TabStop = false;
            this.clearAll.Text = "CLEAR ALL";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // nodeListView
            // 
            this.nodeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeListView.FormattingEnabled = true;
            this.nodeListView.ItemHeight = 25;
            this.nodeListView.Location = new System.Drawing.Point(1375, 113);
            this.nodeListView.Name = "nodeListView";
            this.nodeListView.Size = new System.Drawing.Size(462, 354);
            this.nodeListView.TabIndex = 25;
            this.nodeListView.SelectedIndexChanged += new System.EventHandler(this.nodeListView_SelectedIndexChanged);
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
            // members
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.moveMenu);
            this.Controls.Add(this.nodeListView);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.removeMember);
            this.Controls.Add(this.membersListView);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.fromMemberTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toMemberTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialPropertiesMenu);
            this.Controls.Add(this.exitMenu);
            this.Controls.Add(this.aboutMenu);
            this.Controls.Add(this.solveMenu);
            this.Controls.Add(this.loadsMenu);
            this.Controls.Add(this.supportsMenu);
            this.Controls.Add(this.membersMenu);
            this.Controls.Add(this.nodesMenu);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exitApplication);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sectrics - Truss Analysis Program";
            this.Load += new System.EventHandler(this.nodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.Button nodesMenu;
        private System.Windows.Forms.Button membersMenu;
        private System.Windows.Forms.Button supportsMenu;
        private System.Windows.Forms.Button loadsMenu;
        private System.Windows.Forms.Button solveMenu;
        private System.Windows.Forms.Button aboutMenu;
        private System.Windows.Forms.Button exitMenu;
        private System.Windows.Forms.Button materialPropertiesMenu;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TextBox fromMemberTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toMemberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox membersListView;
        private System.Windows.Forms.Button removeMember;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.ListBox nodeListView;
        private System.Windows.Forms.Panel moveMenu;
    }
}