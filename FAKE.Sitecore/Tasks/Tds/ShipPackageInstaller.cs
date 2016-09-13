using FAKE.Sitecore.Tasks.Tds.Exceptions;
using System;
using System.IO;
using FAKE.Sitecore.Utilities;

namespace FAKE.Sitecore.Tasks.Tds
{
    internal class ShipPackageInstaller : IPackageInstaller
    {
        private readonly string _serviceUrl = "/services/package/install/fileupload";

        public string PackagePath { get; set; }

        public string HostUrl { get; set; }

        public int Timeout { get; set; }

        public void Install()
        {
            Console.WriteLine("Test");
            if (!File.Exists(PackagePath))
                throw new InstallException("Provide a path for a package that exists.");
            if (string.IsNullOrWhiteSpace(HostUrl))
                throw new InstallException("Provide a host url for the Sitecore instance to install the package.");

            WebClient client = new WebClient();
            client.Timeout = Timeout;
            client.UploadFileCompleted += client_UploadFileCompleted;
            client.UploadFileAsync(new Uri(HostUrl), "POST", PackagePath);
        }

        void client_UploadFileCompleted(object sender, System.Net.UploadFileCompletedEventArgs e)
        {
            Console.WriteLine("Test");
        }
    }
}
