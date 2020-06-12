using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace AutoUpdater
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly var clientName = "nanoclient";
        private readonly var clientExtension = ".exe";
        private readonly var apiURL = "https://www.notlyze.de/api.php?call=";

        private string clientPath;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Logo mit progress_bar bei Download.
            Init();

            Process.Start(clientPath);
            Shutdown();
        }

        private void Init()
        {
            var dataFolder = Path.GetTempPath();

            clientPath = dataFolder + clientName + clientExtension;

            if (Directory.Exists(dataFolder))
            {
                if (File.Exists(clientPath))
                    CheckClient(clientPath);
                else
                    // Not yet downloaded.
                    DownloadClient();
            }
            else
                Directory.CreateDirectory(dataFolder);
        }

        private void DownloadClient()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(apiURL + "download", clientPath);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong at downloading files.", "Launcher", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
                return;
            }
        }

        private void CheckClient(string clientPath)
        {
            var clientHash = Helper.ConvertToHex(Helper.FileHash(clientPath));

            var latestHash;
            using (WebClient client = new WebClient())
            {
                try
                {
                    latestHash = client.DownloadString(apiURL + "hash");
                }
                catch
                {
                    MessageBox.Show("Something went wrong at fetching data.", "Launcher", MessageBoxButton.OK, MessageBoxImage.Error);
                    Environment.Exit(1);
                    return;
                }
            }

            if (!clientHash == latestHash)
                // Update!
                DownloadClient();
        }
    }
}
