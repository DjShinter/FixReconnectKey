using System;
using System.Reflection;

using System.Runtime.InteropServices;
using MelonLoader;
using FixReconnectKey;

[assembly: AssemblyTitle(ModBuildInfo.Name)]
[assembly: AssemblyDescription(ModBuildInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(ModBuildInfo.Name)]
[assembly: AssemblyCopyright("Copyright © 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion(ModBuildInfo.Version)]
[assembly: AssemblyFileVersion(ModBuildInfo.Version)]
[assembly: MelonInfo(typeof(FixReconnectKeyMod), ModBuildInfo.Name, ModBuildInfo.Version, ModBuildInfo.Author, ModBuildInfo.DownloadLink)]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly: MelonColor(ConsoleColor.DarkMagenta)]
[assembly: MelonPriority(0)]