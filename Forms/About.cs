using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Loader.Forms
{
    public partial class About : Form
    {
        public Color backgroundcolor;
        public Color textboxcolor;
        public Color topbarcolor;
        public Color textcolor;
        public Bitmap logo;

        public About()
        {
            InitializeComponent();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/JW7hPggJUq");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/JW7hPggJUq");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://keyauth.cc/");
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Color settings for dark theme
        private void DarkTheme()
        {
            backgroundcolor = Color.FromArgb(43, 45, 50);
            textboxcolor = Color.FromArgb(60, 63, 69);
            topbarcolor = Color.FromArgb(32, 34, 37);
            textcolor = Color.FromArgb(255, 255, 255);
            logo = CSharpKeyAuth.Properties.Resources.logo_1_dark;
        }

        // Change theme function
        private void ChangeTheme()
        {
            label1.ForeColor = Color.White;

            // Form format
            topBar.FillColor = topbarcolor;
            topLabel.ForeColor = textcolor;

            this.BackColor = backgroundcolor;
        }

        private void About_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt"))
            {
                string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\keyauth-panel.txt");
                if (text == "dark")
                {
                    CSharpKeyAuth.Properties.Settings.Default.Theme = "Dark";
                    DarkTheme();
                    ChangeTheme();
                }
            }
        }
    }
}
