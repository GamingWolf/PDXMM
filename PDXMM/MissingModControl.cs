using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PDXMM
{
    public partial class MissingModControl : UserControl
    {
        AbortableBackgroundWorker nameWorker = new AbortableBackgroundWorker();

        List<string> nameList = new List<string>();

        delegate void SetProgressCallback(int current);

        public static bool done = false;

        public static WebClient title;

        public MissingModControl()
        {
            InitializeComponent();
            missingDataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            CustomFont.FontInt(45F);
            updateBar.Font = CustomFont.myFont;
            updateBar.Maximum = General.MissingMods.Count;
            NWInt();
        }

        private void NWInt()
        {
            nameWorker.WorkerSupportsCancellation = true;
            nameWorker.WorkerReportsProgress = true;
            nameWorker.DoWork += new DoWorkEventHandler(nameWorker_DoWork);
            nameWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(nameWorker_RunWorkerCompleted);

            nameWorker.CancelAsync();
            nameWorker.RunWorkerAsync();
        }

        private void GenerateRows()
        {
            updateBar.Dispose();
            doneBtn.Visible = true;
            for(int i = 0;i < General.MissingMods.Count; i++)
            {
                missingDataGrid.Rows.Add(nameList[i], General.MissingMods[i]);
            }
        }

        private void missingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DataGridViewLinkCell linkCell = (DataGridViewLinkCell)missingDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                linkCell.LinkVisited = true;
                System.Diagnostics.Process.Start("http://steamcommunity.com/sharedfiles/filedetails/?id=" + missingDataGrid.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            General.GetInstalledMods();
            General.CheckInstalled();
            if (General.MissingMod)
            {
                Refresh();
                General.MissingMod = false;
                Visible = true;
            }
        }

        private void nameWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string source;
            if(!done)
            {
                for (int i = 0; i < General.MissingMods.Count; i++)
                {
                    title = new WebClient();
                    source = title.DownloadString("http://steamcommunity.com/sharedfiles/filedetails/?id=" + General.MissingMods[i]);
                    nameList.Add(Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Replace("Steam Workshop :: ", ""));
                    UpdateProgress(i + 1);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void nameWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GenerateRows();
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
                    updateBar.Maximum = General.MissingMods.Count;
                    updateBar.Text = current.ToString() + "|" + General.MissingMods.Count.ToString();
                    updateBar.Value = current;
                }
            }
            catch { }
        }
    }
}
