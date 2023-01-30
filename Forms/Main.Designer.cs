namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.topBar = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneImageCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.themeCb = new Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscription = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.createDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.numUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numOnlineUsers = new Siticone.UI.WinForms.SiticoneLabel();
            this.numKeys = new Siticone.UI.WinForms.SiticoneLabel();
            this.version = new Siticone.UI.WinForms.SiticoneLabel();
            this.customerPanelLink = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscriptionDaysLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.appDetails = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.userGroup = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.siticoneElipse1 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.appDetails.SuspendLayout();
            this.userGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.topBar;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.siticoneImageCheckBox1);
            this.topBar.Controls.Add(this.siticoneCirclePictureBox1);
            this.topBar.Controls.Add(this.themeCb);
            this.topBar.Controls.Add(this.topLabel);
            this.topBar.Controls.Add(this.siticoneControlBox1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.FillColor = System.Drawing.Color.White;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.ShadowDecoration.Parent = this.topBar;
            this.topBar.Size = new System.Drawing.Size(443, 31);
            this.topBar.TabIndex = 56;
            this.topBar.UseTransparentBackground = true;
            // 
            // siticoneImageCheckBox1
            // 
            this.siticoneImageCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneImageCheckBox1.Checked = true;
            this.siticoneImageCheckBox1.CheckedState.Image = global::CSharpKeyAuth.Properties.Resources.question_free_icon_font;
            this.siticoneImageCheckBox1.CheckedState.Parent = this.siticoneImageCheckBox1;
            this.siticoneImageCheckBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneImageCheckBox1.HoverState.Parent = this.siticoneImageCheckBox1;
            this.siticoneImageCheckBox1.Image = global::CSharpKeyAuth.Properties.Resources.question_free_icon_font;
            this.siticoneImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageCheckBox1.ImageRotate = 0F;
            this.siticoneImageCheckBox1.Location = new System.Drawing.Point(342, 0);
            this.siticoneImageCheckBox1.Name = "siticoneImageCheckBox1";
            this.siticoneImageCheckBox1.PressedState.Image = global::CSharpKeyAuth.Properties.Resources.question_free_icon_font;
            this.siticoneImageCheckBox1.PressedState.Parent = this.siticoneImageCheckBox1;
            this.siticoneImageCheckBox1.ShadowDecoration.Parent = this.siticoneImageCheckBox1;
            this.siticoneImageCheckBox1.Size = new System.Drawing.Size(34, 31);
            this.siticoneImageCheckBox1.TabIndex = 55;
            this.siticoneImageCheckBox1.UseTransparentBackground = true;
            this.siticoneImageCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneImageCheckBox1_CheckedChanged);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox1.Image")));
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(35, 25);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 54;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.UseTransparentBackground = true;
            // 
            // themeCb
            // 
            this.themeCb.BackColor = System.Drawing.Color.Transparent;
            this.themeCb.Checked = true;
            this.themeCb.CheckedState.Image = global::CSharpKeyAuth.Properties.Resources.bulb_dark;
            this.themeCb.CheckedState.Parent = this.themeCb;
            this.themeCb.Dock = System.Windows.Forms.DockStyle.Right;
            this.themeCb.HoverState.Parent = this.themeCb;
            this.themeCb.Image = global::CSharpKeyAuth.Properties.Resources.bulb_white;
            this.themeCb.ImageOffset = new System.Drawing.Point(0, 0);
            this.themeCb.ImageRotate = 0F;
            this.themeCb.Location = new System.Drawing.Point(376, 0);
            this.themeCb.Name = "themeCb";
            this.themeCb.PressedState.Parent = this.themeCb;
            this.themeCb.ShadowDecoration.Parent = this.themeCb;
            this.themeCb.Size = new System.Drawing.Size(34, 31);
            this.themeCb.TabIndex = 0;
            this.themeCb.UseTransparentBackground = true;
            this.themeCb.CheckedChanged += new System.EventHandler(this.themeCb_CheckedChanged);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.Black;
            this.topLabel.Location = new System.Drawing.Point(34, 6);
            this.topLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(99, 18);
            this.topLabel.TabIndex = 27;
            this.topLabel.Text = "KeyAuth Panel";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.CustomIconSize = 14F;
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.Location = new System.Drawing.Point(410, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(33, 31);
            this.siticoneControlBox1.TabIndex = 28;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.Black;
            this.key.Location = new System.Drawing.Point(27, 32);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(71, 14);
            this.key.TabIndex = 37;
            this.key.Text = "usernameLabel";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.Color.Black;
            this.expiry.Location = new System.Drawing.Point(27, 50);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(56, 14);
            this.expiry.TabIndex = 38;
            this.expiry.Text = "expiryLabel";
            // 
            // subscription
            // 
            this.subscription.BackColor = System.Drawing.Color.Transparent;
            this.subscription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.Color.Black;
            this.subscription.Location = new System.Drawing.Point(27, 68);
            this.subscription.Margin = new System.Windows.Forms.Padding(2);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(84, 14);
            this.subscription.TabIndex = 39;
            this.subscription.Text = "subscriptionLabel";
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.Color.Black;
            this.ip.Location = new System.Drawing.Point(27, 86);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(36, 14);
            this.ip.TabIndex = 44;
            this.ip.Text = "ipLabel";
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.Color.Black;
            this.hwid.Location = new System.Drawing.Point(27, 104);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(50, 14);
            this.hwid.TabIndex = 45;
            this.hwid.Text = "hwidLabel";
            // 
            // createDate
            // 
            this.createDate.BackColor = System.Drawing.Color.Transparent;
            this.createDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDate.ForeColor = System.Drawing.Color.Black;
            this.createDate.Location = new System.Drawing.Point(189, 32);
            this.createDate.Margin = new System.Windows.Forms.Padding(2);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(76, 14);
            this.createDate.TabIndex = 46;
            this.createDate.Text = "createDateLabel";
            // 
            // lastLogin
            // 
            this.lastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lastLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogin.ForeColor = System.Drawing.Color.Black;
            this.lastLogin.Location = new System.Drawing.Point(189, 68);
            this.lastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(69, 14);
            this.lastLogin.TabIndex = 47;
            this.lastLogin.Text = "lastLoginLabel";
            // 
            // numUsers
            // 
            this.numUsers.BackColor = System.Drawing.Color.Transparent;
            this.numUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUsers.ForeColor = System.Drawing.Color.Black;
            this.numUsers.Location = new System.Drawing.Point(27, 32);
            this.numUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numUsers.Name = "numUsers";
            this.numUsers.Size = new System.Drawing.Size(72, 14);
            this.numUsers.TabIndex = 48;
            this.numUsers.Text = "numUsersLabel";
            // 
            // numOnlineUsers
            // 
            this.numOnlineUsers.BackColor = System.Drawing.Color.Transparent;
            this.numOnlineUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOnlineUsers.ForeColor = System.Drawing.Color.Black;
            this.numOnlineUsers.Location = new System.Drawing.Point(27, 68);
            this.numOnlineUsers.Margin = new System.Windows.Forms.Padding(2);
            this.numOnlineUsers.Name = "numOnlineUsers";
            this.numOnlineUsers.Size = new System.Drawing.Size(103, 14);
            this.numOnlineUsers.TabIndex = 49;
            this.numOnlineUsers.Text = "numOnlineUsersLabel";
            // 
            // numKeys
            // 
            this.numKeys.BackColor = System.Drawing.Color.Transparent;
            this.numKeys.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKeys.ForeColor = System.Drawing.Color.Black;
            this.numKeys.Location = new System.Drawing.Point(27, 86);
            this.numKeys.Margin = new System.Windows.Forms.Padding(2);
            this.numKeys.Name = "numKeys";
            this.numKeys.Size = new System.Drawing.Size(68, 14);
            this.numKeys.TabIndex = 50;
            this.numKeys.Text = "numKeysLabel";
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.Black;
            this.version.Location = new System.Drawing.Point(27, 50);
            this.version.Margin = new System.Windows.Forms.Padding(2);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(60, 14);
            this.version.TabIndex = 51;
            this.version.Text = "versionLabel";
            // 
            // customerPanelLink
            // 
            this.customerPanelLink.BackColor = System.Drawing.Color.Transparent;
            this.customerPanelLink.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPanelLink.ForeColor = System.Drawing.Color.Black;
            this.customerPanelLink.Location = new System.Drawing.Point(27, 104);
            this.customerPanelLink.Margin = new System.Windows.Forms.Padding(2);
            this.customerPanelLink.Name = "customerPanelLink";
            this.customerPanelLink.Size = new System.Drawing.Size(115, 14);
            this.customerPanelLink.TabIndex = 52;
            this.customerPanelLink.Text = "customerPanelLinkLabel";
            // 
            // subscriptionDaysLabel
            // 
            this.subscriptionDaysLabel.BackColor = System.Drawing.Color.Transparent;
            this.subscriptionDaysLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionDaysLabel.ForeColor = System.Drawing.Color.Black;
            this.subscriptionDaysLabel.Location = new System.Drawing.Point(189, 50);
            this.subscriptionDaysLabel.Margin = new System.Windows.Forms.Padding(2);
            this.subscriptionDaysLabel.Name = "subscriptionDaysLabel";
            this.subscriptionDaysLabel.Size = new System.Drawing.Size(105, 14);
            this.subscriptionDaysLabel.TabIndex = 53;
            this.subscriptionDaysLabel.Text = "subscriptionDaysLabel";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.AutoSize = false;
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Black;
            this.siticoneLabel1.Location = new System.Drawing.Point(12, 325);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(278, 18);
            this.siticoneLabel1.TabIndex = 53;
            this.siticoneLabel1.Text = "Current Session Valdiation Status: ";
            this.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // appDetails
            // 
            this.appDetails.BorderColor = System.Drawing.Color.White;
            this.appDetails.BorderRadius = 4;
            this.appDetails.Controls.Add(this.customerPanelLink);
            this.appDetails.Controls.Add(this.version);
            this.appDetails.Controls.Add(this.numKeys);
            this.appDetails.Controls.Add(this.numOnlineUsers);
            this.appDetails.Controls.Add(this.numUsers);
            this.appDetails.CustomBorderColor = System.Drawing.Color.White;
            this.appDetails.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.appDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.appDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appDetails.ForeColor = System.Drawing.Color.Black;
            this.appDetails.Location = new System.Drawing.Point(12, 38);
            this.appDetails.Name = "appDetails";
            this.appDetails.ShadowDecoration.Parent = this.appDetails;
            this.appDetails.Size = new System.Drawing.Size(419, 138);
            this.appDetails.TabIndex = 57;
            this.appDetails.Text = "Application Details";
            this.appDetails.TextOffset = new System.Drawing.Point(10, -10);
            // 
            // userGroup
            // 
            this.userGroup.BorderColor = System.Drawing.Color.White;
            this.userGroup.BorderRadius = 4;
            this.userGroup.Controls.Add(this.key);
            this.userGroup.Controls.Add(this.hwid);
            this.userGroup.Controls.Add(this.lastLogin);
            this.userGroup.Controls.Add(this.subscriptionDaysLabel);
            this.userGroup.Controls.Add(this.expiry);
            this.userGroup.Controls.Add(this.createDate);
            this.userGroup.Controls.Add(this.subscription);
            this.userGroup.Controls.Add(this.ip);
            this.userGroup.CustomBorderColor = System.Drawing.Color.White;
            this.userGroup.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.userGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.userGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userGroup.ForeColor = System.Drawing.Color.Black;
            this.userGroup.Location = new System.Drawing.Point(12, 182);
            this.userGroup.Name = "userGroup";
            this.userGroup.ShadowDecoration.Parent = this.userGroup;
            this.userGroup.Size = new System.Drawing.Size(419, 138);
            this.userGroup.TabIndex = 58;
            this.userGroup.Text = "User Details";
            this.userGroup.TextOffset = new System.Drawing.Point(10, -10);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 5;
            this.siticoneElipse1.TargetControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(443, 349);
            this.Controls.Add(this.userGroup);
            this.Controls.Add(this.appDetails);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.appDetails.ResumeLayout(false);
            this.appDetails.PerformLayout();
            this.userGroup.ResumeLayout(false);
            this.userGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000009 RID: 9

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel subscription;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel key;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel createDate;
        private Siticone.UI.WinForms.SiticoneLabel lastLogin;
        private Siticone.UI.WinForms.SiticoneLabel numUsers;
        private Siticone.UI.WinForms.SiticoneLabel numOnlineUsers;
        private Siticone.UI.WinForms.SiticoneLabel numKeys;
        private Siticone.UI.WinForms.SiticoneLabel customerPanelLink;
        private Siticone.UI.WinForms.SiticoneLabel version;
        private Siticone.UI.WinForms.SiticoneLabel subscriptionDaysLabel;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topBar;
        private Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox themeCb;
        private System.Windows.Forms.Label topLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox appDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox userGroup;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageCheckBox siticoneImageCheckBox1;
    }
}
