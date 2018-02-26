using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace PDXMM
{
    public class General
    {
        public static string FileLocation, SteamModPath, InstalledModsPath, SelectedGame, GameID;
        public static string PresetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Paradox Interactive\\PDXMM\\";

        public static List<string> Mods = new List<string>(),
                                    InstalledModsList = new List<string>(),
                                    MissingNameList = new List<string>(),
                                    MissingMods = new List<string>();

        public static SortedDictionary<int, string> URLNameList = new SortedDictionary<int, string>();

        public static int urlWorkerProgress, urlProgressInt;

        public static bool MissingMod = false, ClearOverWrite = false, GotURLNames = false, MissingInstalledModName= false;

        public static IEnumerable<string> query;

        public static AbortableBackgroundWorker URLWorker = new AbortableBackgroundWorker();

        public static WebClient title;

        public static void CheckSteamDirectory()
        {
            if (!File.Exists(PresetPath + "Location\\location.txt"))
            {
                if (!Directory.Exists(SteamModPath))
                {
                    SteamModPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + SteamModPath;
                    if (!Directory.Exists(SteamModPath))
                    {
                        Directory.CreateDirectory(PresetPath + "Location\\");
                        FolderBrowserDialog steam = new FolderBrowserDialog
                        {
                            Description = "Steam not found. \n Please select your steam install directory (steam.exe is in this folder).",
                            ShowNewFolderButton = false
                        };
                        steam.ShowDialog();
                        SteamModPath = steam.SelectedPath;

                        var location = new StringBuilder();
                        location.Append(SteamModPath);

                        using (var file = new StreamWriter(File.Create(PresetPath + "Location\\location.txt")))
                        {
                            file.Write(location);
                        }
                    }
                }
            }
            else
            {
                SteamModPath = File.ReadLines(PresetPath + "Location\\location.txt").First() + SelectedGame;
            }
        }

        public static void GetActiveMods()
        {
            string temp;

            Mods.Clear();
            Mods.TrimExcess();

            query = File.ReadLines(FileLocation)
                            .SkipWhile(line => !line.Contains("last_mods={"))
                            .Skip(1)
                            .TakeWhile(line => !line.Contains("}"));

            foreach (string mod in query)
            {
                temp = mod.Replace("\"mod/ugc_", "");
                Mods.Add(temp.Replace(".mod\"","").Trim());
            }
        }

        public static void DeleteEmptyFolders(string startLocation)
        {
            foreach(var directory in Directory.GetDirectories(startLocation))
            {
                DeleteEmptyFolders(directory);
                if(Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                }
            }
        }

        public static void WriteInstalledRealNames()
        {
            if (!Directory.Exists(PresetPath + "InstalledNames\\"))
            {
                Directory.CreateDirectory(PresetPath + "InstalledNames\\");
                WriteInstalledRealNames();
            }
            else if (!File.Exists(PresetPath + "InstalledNames\\" + GameID + ".txt"))
            {
                using (StreamWriter sw = new StreamWriter(File.Create(PresetPath + "InstalledNames\\" + GameID + ".txt")))
                {
                    foreach(KeyValuePair<int, string> entry in URLNameList)
                    {
                        sw.WriteLine("{0}=//={1}", entry.Key, entry.Value);
                    }
                    sw.Close();
                }
            }
            else if (URLNameList.Count > 0 && MissingInstalledModName)
            {
                using (StreamReader passer2 = new StreamReader(PresetPath + "InstalledNames\\" + GameID + ".txt"))
                {
                    string[] sep = { "=//=" };
                    string line;
                    while ((line = passer2.ReadLine()) != null)
                    {
                        string[] parts = line.Split(sep, StringSplitOptions.None);
                        URLNameList.Add(Int32.Parse(parts[0]), parts[1]);
                    }
                    passer2.Close();
                }
                File.Delete(PresetPath + "InstalledNames\\" + GameID + ".txt");
                using (StreamWriter sw = new StreamWriter(File.Create(PresetPath + "InstalledNames\\" + GameID + ".txt")))
                {
                    foreach (KeyValuePair<int, string> entry in URLNameList)
                    {
                        sw.WriteLine("{0}=//={1}", entry.Key, entry.Value);
                    }
                    sw.Close();
                }
            }
            else
            {
                File.Delete(PresetPath + "InstalledNames\\" + GameID + ".txt");
                using (StreamWriter sw = new StreamWriter(File.Create(PresetPath + "InstalledNames\\" + GameID + ".txt")))
                {
                    foreach (KeyValuePair<int, string> entry in URLNameList)
                    {
                        sw.WriteLine("{0}=//={1}", entry.Key, entry.Value);
                    }
                    sw.Close();
                }
            }
        }

        public static void GetInstalledMods()
        {
            DeleteEmptyFolders(SteamModPath);
            InstalledModsList.Clear();
            InstalledModsList.TrimExcess();

            foreach(string directory in Directory.GetDirectories(SteamModPath))
            {
                InstalledModsList.Add(directory.Replace(SteamModPath + "\\", ""));
            }
        }

        public static void CheckInstalled()
        {
            MissingMods.Clear();
            MissingMods.TrimExcess();
            foreach(string mod in Mods)
            {
                if(!InstalledModsList.Contains(mod))
                {
                    MissingMods.Add(mod);
                    MissingMod = true;
                }
            }
        }

        public static void GetURLNames()
        {
            URLWorker = new AbortableBackgroundWorker();

            URLWorker.DoWork += new DoWorkEventHandler(URLWorker_DoWork);
            URLWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(URLWorker_RunWorkerCompleted);

            URLNameList.Clear();

            GotURLNames = false;


            if(URLWorker.IsBusy)
            {
                URLWorker.Abort();
                URLWorker.Dispose();
                GetURLNames();
            }
            URLWorker.RunWorkerAsync();
        }

        private static void URLWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string source;
            urlProgressInt = 0;

            if (File.Exists(PresetPath + "InstalledNames\\" + GameID + ".txt"))
            {
                string line;
                StreamReader passer = new StreamReader(PresetPath + "InstalledNames\\" + GameID + ".txt");

                MissingNameList.Clear();
                MissingNameList.TrimExcess();

                while ((line = passer.ReadLine()) != null)
                {
                    int index = line.LastIndexOf("=//=");
                    if (index > 0)
                    {
                        MissingNameList.Add(line.Substring(0, index));
                    }
                }
                passer.Close();

                if (MissingNameList.Count != InstalledModsList.Count)
                {
                    if (MissingNameList.Count < InstalledModsList.Count)
                    {
                        for (int i = 0; i < InstalledModsList.Count; i++)
                        {
                            if(!MissingNameList.Contains(InstalledModsList[i]))
                            {
                                title = new WebClient();
                                MissingInstalledModName = true;
                                source = title.DownloadString("http://steamcommunity.com/sharedfiles/filedetails/?id=" + InstalledModsList[i]);
                                URLNameList.Add(Int32.Parse(s: InstalledModsList[i]), Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Replace("Steam Workshop :: ", ""));
                            }
                        }
                    }
                    else
                    {
                        URLNameList.Clear();

                        string[] sep = { "=//=" };
                        StreamReader passer2 = new StreamReader(PresetPath + "InstalledNames\\" + GameID + ".txt");
                        while ((line = passer2.ReadLine()) != null)
                        {
                            string[] parts = line.Split(sep, StringSplitOptions.None);
                            URLNameList.Add(Int32.Parse(parts[0]), parts[1]);
                        }
                        passer2.Close();

                        for(int j = 0; j < MissingNameList.Count; j++)
                        {
                            if(!InstalledModsList.Contains(MissingNameList[j]))
                            {
                                URLNameList.Remove(Int32.Parse(MissingNameList[j]));
                            }
                        }
                    }
                }
                else
                {
                    URLNameList.Clear();

                    string[] sep = { "=//=" };
                    StreamReader passer2 = new StreamReader(PresetPath + "InstalledNames\\" + GameID + ".txt");
                    while ((line = passer2.ReadLine()) != null)
                    {
                        string[] parts = line.Split(sep, StringSplitOptions.None);
                        URLNameList.Add(Int32.Parse(parts[0]), parts[1]);
                    }
                    passer2.Close();
                }
            }
            else
            {
                URLNameList.Clear();

                foreach (string mod in InstalledModsList)
                {
                    if (URLWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        title = new WebClient();
                        source = title.DownloadString("http://steamcommunity.com/sharedfiles/filedetails/?id=" + InstalledModsList[urlProgressInt]);
                        URLNameList.Add(Convert.ToInt32(InstalledModsList[urlProgressInt]), Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value.Replace("Steam Workshop :: ", ""));
                        urlProgressInt++;
                    }
                }
            }
        }
        private static void URLWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!e.Cancelled)
            {
                WriteInstalledRealNames();
                GotURLNames = true;
            }
        }

        //private void ExecuteCopy()
        //{
        //    if (!MissingMod && (PastedMods.Count != 0 || ClearOverWrite))
        //    {
        //        var newMods = new StringBuilder();
        //        newMods.Append("last_mods={");
        //        newMods.Append("\n");
        //        foreach (var mod in PastedMods)
        //        {
        //            newMods.Append(mod);
        //            newMods.Append("\n");
        //        }

        //        string fileContents = File.ReadAllText(FileLocation);

        //        var startIndex = fileContents.IndexOf("last_mods");
        //        var stopIndex = fileContents.IndexOf("}", startIndex);

        //        var substring = fileContents.Substring(startIndex, stopIndex - startIndex);
        //        var newContents = fileContents.Replace(substring, newMods.ToString());

        //        using (var file = new StreamWriter(File.Create(FileLocation)))
        //        {
        //            file.Write(newContents);
        //        }

        //        if (ClearOverWrite)
        //        {
        //            ClearOverWrite = false;
        //        }
        //    }
        //    else if (MissingMod)
        //    {
        //        MissingModDialog MissForm = new MissingModDialog();

        //        MissForm.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("You cannot commit an empty list. \n Use the clear button to clear all mods.");
        //    }
        //}
    }
}
