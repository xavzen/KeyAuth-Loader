using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {
        public Color backgroundcolor;
        public Color textboxcolor;
        public Color topbarcolor;
        public Color textcolor;
        public Color placeholdercolor;
        public Bitmap logo;

        /*
        * 
        * WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=RfDTdiBq4_o
        * 
        */

        /*
        Optional Functions:

        KeyAuthApp.webhook("lfvbBrbFhIr", "?sellerkey=CUqDqlCIgl&type=resethash");
        // send secure request to webhook which is impossible to crack into. the base link set on the website is https://keyauth.com/api/seller/, which nobody except you can see, so the final request is https://keyauth.com/api/seller/?sellerkey=CUqDqlCIgl&type=resethash

        // byte[] result = KeyAuthApp.download("902901"); // downloads application file
        // File.WriteAllBytes("C:\\Users\\mak\\Downloads\\KeyAuth-CSHARP-Example-main (5)\\KeyAuth-CSHARP-Example-main\\ConsoleExample\\bin\\Debug\\countkeys.txt", result);

        MessageBox.Show(KeyAuthApp.var("123456")); // retrieve application variable
        */

        // KeyAuthApp.register("username", "password", "key");
        //KeyAuthApp.login("username", "password"); 


        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.0"
        );

        public Login()
        {
            InitializeComponent();
        }

        // Actions to do on FormLoad
        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            // KeyAuthApp.check();
            //siticoneLabel1.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}";
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt"))
            {
                string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt");
                if(text == "dark")
                {
                    themeCb.Checked = false;
                    CSharpKeyAuth.Properties.Settings.Default.Theme = "Dark";
                    DarkTheme();
                    ChangeTheme();
                }
            }
        }

        // Color settings for dark theme
        private void DarkTheme()
        {
            backgroundcolor = Color.FromArgb(43, 45, 50);
            textboxcolor = Color.FromArgb(60, 63, 69);
            topbarcolor = Color.FromArgb(32, 34, 37);
            textcolor = Color.FromArgb(255, 255, 255);
            placeholdercolor = Color.FromArgb(204, 220, 206);
            logo = CSharpKeyAuth.Properties.Resources.logo_1_dark;
        }

        // Color settings for light theme
        private void LightTheme()   
        {
            backgroundcolor = Color.FromArgb(238, 238, 238);
            textboxcolor = Color.FromArgb(192, 192, 192);
            topbarcolor = Color.FromArgb(255, 255, 255);
            textcolor = Color.FromArgb(0, 0, 0);
            placeholdercolor = Color.FromArgb(0, 0, 0);
            logo = CSharpKeyAuth.Properties.Resources.logo_1_white;
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.upgrade(username.Text, key.Text); // success is set to false so people can't press upgrade then press login and skip logging in. it doesn't matter, since you shouldn't take any action on succesfull upgrade anyways. the only thing that needs to be done is the user needs to see the message from upgrade function
            //status.Text = "Status: " + KeyAuthApp.response.message;
            // don't login, because they haven't authenticated. this is just to extend expiry of user with new key.
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text,password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else;
                //status.Text = "Status: " + KeyAuthApp.response.message;
        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else;
                //status.Text = "Status: " + KeyAuthApp.response.message;
        }

        private void LicBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else;
                //status.Text = "Status: " + KeyAuthApp.response.message;
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
            // Username format
            username.FillColor = textboxcolor;
            username.ForeColor = textcolor;
            username.PlaceholderForeColor = placeholdercolor;

            // Password format
            password.FillColor = textboxcolor;
            password.ForeColor = textcolor;
            password.PlaceholderForeColor = placeholdercolor;

            // License format
            key.FillColor = textboxcolor;
            key.ForeColor = textcolor;
            key.PlaceholderForeColor = placeholdercolor;

            // Form format
            topBar.FillColor = topbarcolor;
            topLabel.ForeColor = textcolor;

            this.BackColor = backgroundcolor;
        }

        // Close application
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
