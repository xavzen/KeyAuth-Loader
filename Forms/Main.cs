using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Color backgroundcolor;
        public Color textboxcolor;
        public Color topbarcolor;
        public Color textcolor;

        public Main()
        {
            InitializeComponent();
        }

        //string chatchannel = "testing"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            siticoneLabel1.Text = $"Current Session Validation Status: {Login.KeyAuthApp.response.success}";
            key.Text = "<b>Username:</b> " + Login.KeyAuthApp.user_data.username;
            expiry.Text = "<b>Expiry:</b> " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            subscription.Text = "<b>Subscription:</b> " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            ip.Text = "<b>IP Address:</b> " + Login.KeyAuthApp.user_data.ip;
            hwid.Text = "<b>HWID:</b> " + Login.KeyAuthApp.user_data.hwid;
            createDate.Text = "<b>Creation date:</b> " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "<b>Last login:</b> " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
            subscriptionDaysLabel.Text = "<b>Expiry in Days:</b> " + expirydaysleft();
            numUsers.Text = "<b>Number of users:</b> " + Login.KeyAuthApp.app_data.numUsers;
            numOnlineUsers.Text = "<b>Number of online users:</b> " + Login.KeyAuthApp.app_data.numOnlineUsers;
            numKeys.Text = "<b>Number of licenses:</b> " + Login.KeyAuthApp.app_data.numKeys;
            version.Text = "<b>Current version:</b> " + Login.KeyAuthApp.app_data.version;
            customerPanelLink.Text = "<b>Customer panel:</b> " + Login.KeyAuthApp.app_data.customerPanelLink;

            // var onlineUsers = Login.KeyAuthApp.fetchOnline();
            // foreach (var user in onlineUsers)
            // {
                   //onlineUsersBox.Items.Add(user.credential);
            // }
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt"))
            {
                string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt");
                if (text == "dark")
                {
                    themeCb.Checked = false;
                    CSharpKeyAuth.Properties.Settings.Default.Theme = "Dark";
                    DarkTheme();
                    ChangeTheme();
                }
            }
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }

        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        // Color settings for dark theme
        private void DarkTheme()
        {
            backgroundcolor = Color.FromArgb(43, 45, 50);
            textboxcolor = Color.FromArgb(60, 63, 69);
            topbarcolor = Color.FromArgb(32, 34, 37);
            textcolor = Color.FromArgb(255, 255, 255);
        }

        // Color settings for light theme
        private void LightTheme()
        {
            backgroundcolor = Color.FromArgb(238, 238, 238);
            textboxcolor = Color.FromArgb(192, 192, 192);
            topbarcolor = Color.FromArgb(255, 255, 255);
            textcolor = Color.FromArgb(0, 0, 0);
        }

        // Change theme radioButton
        private void themeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (themeCb.Checked)
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt", "light");
                CSharpKeyAuth.Properties.Settings.Default.Theme = "Light";
                LightTheme();
                ChangeTheme();
            }
            else
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt", "dark");
                CSharpKeyAuth.Properties.Settings.Default.Theme = "Dark";
                DarkTheme();
                ChangeTheme();
            }
        }

        // Change theme function
        private void ChangeTheme()
        {
            key.ForeColor = textcolor;
            expiry.ForeColor = textcolor;
            subscription.ForeColor = textcolor;
            ip.ForeColor = textcolor;
            hwid.ForeColor = textcolor;
            createDate.ForeColor = textcolor;
            lastLogin.ForeColor = textcolor;
            subscriptionDaysLabel.ForeColor = textcolor;
            numUsers.ForeColor = textcolor;
            numOnlineUsers.ForeColor = textcolor;
            numKeys.ForeColor = textcolor;
            version.ForeColor = textcolor;
            customerPanelLink.ForeColor = textcolor;
            this.BackColor = backgroundcolor;
            topBar.FillColor = topbarcolor;
            siticoneLabel1.ForeColor = textcolor;
            topLabel.ForeColor = textcolor;
            appDetails.FillColor = backgroundcolor;
            appDetails.CustomBorderColor = topbarcolor;
            appDetails.ForeColor = textcolor;
            appDetails.BorderColor = topbarcolor;
            userGroup.CustomBorderColor = topbarcolor;
            userGroup.FillColor = backgroundcolor;
            userGroup.ForeColor = textcolor;
            userGroup.BorderColor = topbarcolor;
        }

        // Close application
        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Loader.Forms.About about = new Loader.Forms.About();
            about.ShowDialog();
        }
    }
}
