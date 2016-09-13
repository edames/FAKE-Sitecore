# FAKE Sitecore

Custom tasks with FAKE for Sitecore.

## Getting Started


Create `build.fsx` for defining targets and workflow.

```
#r "tools/FAKE/tools/FakeLib.dll" // include Fake lib
#r "tools/FAKE.Sitecore/FAKE.Sitecore.dll"

open Fake 
open FAKE.Sitecore.Tasks.Tds

Target "Build" (fun _ ->
  trace "Build Tds packages..."
)

Target "Deploy" (fun _ ->
  let installer = PackageFactory.Initialize()
  installer.HostUrl = "http://habitat.local"
  installer.PackagePath = "C:\Projects\Habitat\Habitat.TDS.Master\bin\Package_CreateUpdatePackages\Habitat.update"
  installer.Install()
)

Target "Default" (fun _ ->
  trace "Starting build..."
)

Build
  ==> Deploy
  ==> Default

Run Default 
```  