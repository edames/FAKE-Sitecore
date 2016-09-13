using System;

namespace FAKE.Sitecore.Tasks.Tds
{
    public interface IPackageInstaller
    {
        string HostUrl { get; set; }
        string PackagePath { get; set; }

        void Install();
    }
}
