using MetroFramework.Components;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using static System.IO.Compression.ZipFile;
using System.IO.Compression;

namespace Updater
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        public async void EasyMethode(object sender, EventArgs e)
        {
            string url = "YOUR_SERVER";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        string[] lines = responseData.Split('\n');
                        try
                        {
                            versionLabel.Text = lines[0];
                            statusLabel.Text = lines[1];
                            developerLabel.Text = lines[2];
                            string haahah = "hvh_version.txt";

                            if (File.Exists(haahah))
                            {
                                string welcheversion = File.ReadAllText(haahah);

                                if (versionLabel.Text.Trim() == welcheversion.Trim())
                                {
                                    foundupdateLabel.Text = "No Updates";
                                }
                                else
                                {
                                    foundupdateLabel.Text = "Found Updates, click Download";

                                }
                            }
                            else
                            {
                                File.WriteAllText(haahah, versionLabel.Text.Trim());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Fehler beim Abrufen der Daten. Statuscode: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async void unpackHVH(string zipFilePath)
        {
            try
            {
                if (File.Exists(zipFilePath))
                {
                    string currentDirec = Directory.GetCurrentDirectory();
                    ZipFile.ExtractToDirectory(zipFilePath, currentDirec);

                    File.Delete(zipFilePath);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async void DownloadHvH(object sender, EventArgs e)
        {
            string url = "YOUR_SERVER";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        string[] lines = responseData.Split('\n');
                        try
                        {
                            versionLabel.Text = lines[0];
                            string haahah = "hvh_version.txt";

                            if (File.Exists(haahah))
                            {
                                string welcheversion = File.ReadAllText(haahah);

                                if (versionLabel.Text.Trim() == welcheversion.Trim())
                                {
                                    MessageBox.Show("No Updates!");
                                }
                                else
                                {
                                    foundupdateLabel.Text = "Update Found, installing now...";

                                    string dataurladr = "http://YOUR_SERVER/hvh_tool/" + versionLabel.Text.Trim() + ".zip";
                                    string downloadFilePath = versionLabel.Text.Trim() + ".zip";

                                    using (WebClient webClient = new WebClient())
                                    {
                                        await webClient.DownloadFileTaskAsync(new Uri(dataurladr), downloadFilePath);
                                    }

                                    foundupdateLabel.Text = "Download Successful";

                                    string zipFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, versionLabel.Text.Trim() + ".zip");

                                    unpackHVH(zipFilePath);
                                }
                            }
                            else
                            {
                                File.WriteAllText(haahah, versionLabel.Text.Trim());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Fehler beim Abrufen der Daten. Statuscode: {response.StatusCode}");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something isnt working well!");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            EasyMethode(sender, e);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            EasyMethode(sender, e);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            DownloadHvH(sender, e);
        }
    }
}
