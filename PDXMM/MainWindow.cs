using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PDXMM
{
    public partial class MainWindow : Form
    {
        public BackgroundWorker URLWorker = new BackgroundWorker();

        private Button lastButton = null;

        public MainWindow()
        {
            InitializeComponent();
            GetFonts();
            Load += MainWindow_Load;
            General.URLWorker.WorkerSupportsCancellation = true;
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
        }

        private void GetFonts()
        {
            CustomFont.FontInt(36F);
            paradoxLabel.Font = CustomFont.myFont;

            CustomFont.FontInt(15.75F);
            stellarisBtn.Font = CustomFont.myFont;
            hoi4Btn.Font = CustomFont.myFont;
            eu4Btn.Font = CustomFont.myFont;
            ck2Btn.Font = CustomFont.myFont;
            settingsBtn.Font = CustomFont.myFont;
            closeBtn.Font = CustomFont.myFont;
        }

        public void MainWindow_Load(object s, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            stellarisBtn.PerformClick();
        }

        //Make the form draggble by clicking the redbar(which is actually all that is visible from the actual form)
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stellarisBtn_Click(object sender, EventArgs e)
        {
            Switch(sender);

            string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Stellaris\\settings.txt",
                    SteamModPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\steamapps\\workshop\\content\\281990",
                    SelectedGame = "\\steamapps\\workshop\\content\\281990",
                    InstalledModsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Stellaris\\",
                    GameID = "281990";

            MainPanel.Controls.Add(new ContentControl(FileLocation, SteamModPath, SelectedGame, InstalledModsPath, GameID, "Stellaris"));
        }

        private void hoi4Btn_Click(object sender, EventArgs e)
        {
            Switch(sender);

            string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Hearts of Iron IV\\settings.txt",
                    SteamModPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\steamapps\\workshop\\content\\394360",
                    SelectedGame = "\\steamapps\\workshop\\content\\394360",
                    InstalledModsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Hearts of Iron IV\\",
                    GameID = "394360";

            MainPanel.Controls.Add(new ContentControl(FileLocation, SteamModPath, SelectedGame, InstalledModsPath, GameID, "Hearts  of  Iron  IV"));
        }

        private void ck2Btn_Click(object sender, EventArgs e)
        {
            Switch(sender);

            string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Crusader Kings II\\settings.txt",
                    SteamModPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\steamapps\\workshop\\content\\203770",
                    SelectedGame = "\\steamapps\\workshop\\content\\203770",
                    InstalledModsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Crusader Kings II\\",
                    GameID = "203770";

            MainPanel.Controls.Add(new ContentControl(FileLocation, SteamModPath, SelectedGame, InstalledModsPath, GameID, "Crusader Kings II"));
        }

        private void eu4Btn_Click(object sender, EventArgs e)
        {
            Switch(sender);

            string FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Crusader Kings II\\settings.txt",
                    SteamModPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Steam\\steamapps\\workshop\\content\\203770",
                    SelectedGame = "\\steamapps\\workshop\\content\\203770",
                    InstalledModsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\Crusader Kings II\\",
                    GameID = "203770";

            MainPanel.Controls.Add(new ContentControl(FileLocation, SteamModPath, SelectedGame, InstalledModsPath, GameID, "Crusader Kings II"));
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Switch(sender);
            MainPanel.Controls.Add(new SettingsControl());
        }

        private void Switch(object sender)
        {
            ButtonSwitcher(sender);

            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
        }

        public void ButtonSwitcher(object sender)
        {
            Button current = (Button)sender;
            current.BackColor = Color.White;
            current.ForeColor = Color.FromArgb(41, 39, 40);
            current.FlatAppearance.BorderSize = 0;
            current.FlatAppearance.MouseDownBackColor = Color.White;
            current.FlatAppearance.MouseOverBackColor = Color.White;
            current.Enabled = false;

            if (lastButton != null)
            {
                lastButton.BackColor = Color.FromArgb(41, 39, 40);
                lastButton.ForeColor = Color.White;
                lastButton.FlatAppearance.BorderSize = 1;
                lastButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
                lastButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 8, 55);
                lastButton.Enabled = true;
            }

            lastButton = current;
        }
    }
}