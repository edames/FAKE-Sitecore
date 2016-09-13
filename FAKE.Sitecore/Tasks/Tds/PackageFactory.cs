using System;

namespace FAKE.Sitecore.Tasks.Tds
{
    public static class PackageFactory
    {
        public static IPackageInstaller Initialize()
        {
            return new ShipPackageInstaller();
        }
    }
}
