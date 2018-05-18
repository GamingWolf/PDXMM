using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using WinFormAnimation;
using System.Drawing;

namespace PDXMM
{
    public partial class ContentControl : UserControl
    {
        BackgroundWorker UpdateWroker = new BackgroundWorker();

        delegate void SetProgressCallback(int current);
        delegate void UpdateUICallBack();

        public ContentControl(string FileLocation, string SteamModPath, string SelectedGame, string InstalledModsPath, string GameID, string Name)
        {
            InitializeComponent();
            GetFonts();
            nameLbl.Text = Name;

            if (File.Exists(FileLocation))
            {
                General.GotURLNames = false;

                General.SelectedGame = SelectedGame;
                General.GameID = GameID;
                General.FileLocation = FileLocation;
                General.InstalledModsPath = InstalledModsPath;
                General.SteamModPath = SteamModPath;

                GeneralInit();
                UWInit();
            }
            else
            {
                NotInstalled notInstalled = new NotInstalled();
                Controls.Add(notInstalled);
                notInstalled.BringToFront();
            }
        }

        private void GetFonts()
        {
            CustomFont.FontInt(39.075F);
            nameLbl.Font = CustomFont.myFont;

            CustomFont.FontInt(12F);
            presetBtn.Font = CustomFont.myFont;
            copyBtn.Font = CustomFont.myFont;
            applyBtn.Font = CustomFont.myFont;
            pasteBtn.Font = CustomFont.myFont;

            CustomFont.FontInt(45F);
            updateBar.Font = CustomFont.myFont;
            updateBar.Font = CustomFont.myFont;
        }

        public static void GeneralInit()
        {
            General.URLWorker.Abort();
            General.CheckSteamDirectory();
            General.GetActiveMods();
            General.GetInstalledMods();
            General.GetURLNames();
        }

        private void GenerateRows()
        {
            dataGridDisp.Rows.Clear();
            dataGridDisp.Refresh();
            foreach(var mod in General.URLNameList)
            {
                try
                {
                    if (General.Mods.Contains(mod.Key.ToString()))
                    {
                        dataGridDisp.Rows.Add(1, 1, mod.Value, mod.Key);
                    }
                    else
                    {
                        dataGridDisp.Rows.Add(0, 0, mod.Value, mod.Key);
                    }
                }
                catch { }
            }
        }

        private void dataGridDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                try
                {
                    DataGridViewLinkCell linkCell = (DataGridViewLinkCell)dataGridDisp.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    linkCell.LinkVisited = true;

                    System.Diagnostics.Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=" + dataGridDisp.Rows[e.RowIndex].Cells[3].Value);
                }
                catch { }
            }
            else if(e.ColumnIndex == 0)
            {
                try
                {
                    int checkValue = Convert.ToInt32(dataGridDisp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    int originValue = Convert.ToInt32(dataGridDisp.Rows[e.RowIndex].Cells[1].Value);
                    if (checkValue == 0)
                    {
                        dataGridDisp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                        if(checkValue == originValue)
                        {
                            dataGridDisp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
                        }
                        else
                        {
                            dataGridDisp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        dataGridDisp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        if (checkValue == originValue)
                        {
                            dataGridDisp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
                        }
                        else
                        {
                            dataGridDisp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
                catch { }
            }
        }

        private void UWInit()
        {
            UpdateWroker.WorkerReportsProgress = true;
            UpdateWroker.WorkerSupportsCancellation = true;
            UpdateWroker.DoWork += new DoWorkEventHandler(UpdateWroker_DoWork);

            UpdateWroker.CancelAsync();
            UpdateWroker.RunWorkerAsync();
        }

        private void UpdateWroker_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!General.GotURLNames)
            {
                UpdateProgress(General.urlProgressInt);
            }
            if (General.GotURLNames)
            {
                e.Cancel = true;
                UpdateUI();
            }
        }

        private void UpdateProgress(int current)
        {
            try
            {
                if (updateBar.InvokeRequired)
                {
                    SetProgressCallback d = new SetProgressCallback(UpdateProgress);
                    Invoke(d, new object[] { current });
                }
                else
                {
                    updateBar.Maximum = General.InstalledModsList.Count;
                    updateBar.Text = current.ToString() + "|" + General.InstalledModsList.Count.ToString();
                    updateBar.Value = current;
                }
            }
            catch { }
        }

        private void UpdateUI()
        {
            if(updateBar.InvokeRequired)
            {
                UpdateUICallBack e = new UpdateUICallBack(UpdateUI);
                Invoke(e);
            }
            else
            {
                updateBar.Dispose();
                GenerateRows();
            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if(General.Mods.Count != 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(string.Join("\n", General.Mods));
            }
        }

        public void pasteBtn_Click(object sender, EventArgs e)
        {
            General.Mods.Clear();
            General.Mods.TrimExcess();
            string s = Clipboard.GetText();
            string[] pasted = s.Split('\n');
            foreach (string mod in pasted)
            {
                General.Mods.Add(mod.Trim());
            }

            General.CheckInstalled();

            if (General.MissingMod)
            {
                Controls.Add(new MissingModControl());
                dataGridDisp.SendToBack();
                nameLbl.SendToBack();
                applyBtn.SendToBack();
                pasteBtn.SendToBack();
                presetBtn.SendToBack();
                copyBtn.SendToBack();
                General.MissingMod = false;
            }
            else
            {

            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
